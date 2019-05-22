using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Filemanager
{
    public partial class DetailsForm : Form
    {
        private MiddleForm form2;
        private BeginingForm form1;
        File file;
        Word.Document WordDoc;
        Word.Application WordApp;
        object miss = Type.Missing;
        byte[] compl;
        bool see = false;

        public DetailsForm(BeginingForm form1, MiddleForm form2, File file)
        {
            InitializeComponent();
            this.form1 = form1;
            this.form2 = form2;
            this.file = file;
            this.Text = "Properties of " + "\"" + this.file.name + "\"";
            if (file.State=="Completed")
            {
                Controlfunc.Makeitinvisible(Finalizedocument, EditFile);
                Seefile.Visible = true;
            }
            else
            {
                if (form2.current.accesslevel != 0 && form2.current.name!=file.touser)
                {
                    Finalizedocument.Visible = false;
                }
            }
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Add("Document name", file.name);
            dataGridView.Rows.Add("Signature validity", "Signature valid");
            dataGridView.Rows.Add("Last edit date", file.date);
            dataGridView.Rows.Add("Last editor", file.fromuser);
            dataGridView.Rows.Add("Document state", file.State);
            if (file.State!="Completed")
            {
                dataGridView.Rows.Add("Directed to", file.touser);
            }
            else
            {
                dataGridView.Rows.Add("Directed to", "-");
            }
            dataGridView.Rows.Add("Notice from last editor", file.note);
            dataGridView.Rows.Add("Document path", file.pathtofile);
            
            if (form2.current.accesslevel==0 || file.State=="Completed")
            {
                Deletefile.Visible = true;
            }

            foreach (User u in form1.userbase)
            {
                Chosenuser.Items.Add(u.name);
            }
        }

        private void Finalizedocument_Click(object sender, EventArgs e)
        {
            file.State = "Completed";
            file.fromuser = form2.current.name;
            file.note = NoteBox.Text;
            if (WordApp != null)
            {
                WordDoc.Close(ref miss, ref miss, ref miss);
                WordApp.Quit(ref miss, ref miss, ref miss);
            }
            EndWork();
        }

        private void EndWork()
        {
            System.IO.File.WriteAllBytes(file.pathtofile, Cryptfunc.AESEncrypt(System.IO.File.ReadAllBytes(file.pathtofile)));
            Cryptfunc.Loging(file);
            Cryptfunc.Signing(file);

            MessageBox.Show("Changes accepted");
            this.Close();
        }
        
        private void SeeLogs_Click(object sender, EventArgs e)
        {
            new DocHistory(file.logs, file.name).ShowDialog();
        }

        private void EndwithoutSave_Click(object sender, EventArgs e)
        {
            if (Chosenuser.SelectedIndex >= 0)
            {
                if (ActionSelectionBox.SelectedIndex>=0)
                {
                    file.fromuser = form2.current.name;
                    file.touser = Chosenuser.Text;
                    file.note = NoteBox.Text;
                    file.State = ActionSelectionBox.Text;
                    WordDoc.Close(ref miss, ref miss, ref miss);
                    WordApp.Quit(ref miss, ref miss, ref miss);

                    EndWork();
                }
                else
                {
                    MessageBox.Show("Choose action at first");
                }
            }
            else
            {
                MessageBox.Show("Choose next user at first");
            }
        }

        private void EndwithSave_Click(object sender, EventArgs e)
        {
            if (Chosenuser.SelectedIndex >= 0)
            {
                if (ActionSelectionBox.SelectedIndex >= 0)
                {
                    object path = file.pathtofile;
                    WordDoc.SaveAs2(ref path);

                    file.fromuser = form2.current.name;
                    file.touser = Chosenuser.Text;
                    file.note = NoteBox.Text;
                    file.State = ActionSelectionBox.Text;
                    WordDoc.Close(ref miss, ref miss, ref miss);
                    WordApp.Quit(ref miss, ref miss, ref miss);

                    EndWork();
                }
                else
                {
                    MessageBox.Show("Choose action at first");
                }
            }
            else
            {
                MessageBox.Show("Choose next user at first");
            }
        }

        private void EditFile_Click(object sender, EventArgs e)
        {
            WordApp = new Word.Application()
            {
                Visible = true
            };
            System.IO.File.WriteAllBytes(file.pathtofile, Cryptfunc.AESDecrypt(System.IO.File.ReadAllBytes(file.pathtofile)));
            object readOnly = false;
            object path = file.pathtofile;
            WordDoc = WordApp.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
            WordDoc.Activate();

            Controlfunc.Makeitinvisible(EditFile, SeeLogs, Deletefile);
            Controlfunc.Makeitvisible(Chooseuserlabel, Chosenuser, ActionSelectionBox, Actionselectionlabel, NoteBox, Notelabel1, Notelabel2, EndwithoutSave, EndwithSave);

        }

        private void Seefile_Click(object sender, EventArgs e)
        {
            WordApp = new Word.Application()
            {
                Visible = true
            };

            compl = Cryptfunc.AESDecrypt(System.IO.File.ReadAllBytes(file.pathtofile));
            System.IO.File.WriteAllBytes(file.pathtofile, compl);
            object readOnly = false;
            object path = file.pathtofile;
            WordDoc = WordApp.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
            WordDoc.Activate();

            Controlfunc.Makeitinvisible(Seefile, Deletefile);
            see = true;
        }

        private void Deletefile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure???", "Confirmation window", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                System.IO.File.Delete(file.pathtofile);
                System.IO.File.Delete(file.pathtolog);
                System.IO.File.Delete(file.pathtosign);
                this.Close();
            }
        }

        private void DetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (see)
            {
                WordDoc.Close(ref miss, ref miss, ref miss);
                WordApp.Quit(ref miss, ref miss, ref miss);

                System.IO.File.WriteAllBytes(file.pathtofile, Cryptfunc.AESEncrypt(compl));
            }
            form2.UpdateGrid();
        }
    }
}