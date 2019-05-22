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
    public partial class CreatingDoc : Form
    {
        string pathf, fullpath;
        Word.Application WordApp;
        Word.Document WordDoc;
        object miss = Type.Missing;
        object newTemplate = false;
        object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
        MiddleForm form2;
        BeginingForm form1;
        public bool templateok = false;
        
        public CreatingDoc(MiddleForm form2, BeginingForm form1)
        {
            InitializeComponent();
            this.form2 = form2;
            this.form1 = form1;

            foreach (User user in form1.userbase)
            {
                NextuserselectionBox.Items.Add(user.name);
            }
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) 
            {
                pathf = fbd.SelectedPath;
            }
            if (DocumentName.Text != "" && pathf != null)
            {
                Controlfunc.Makeitvisible(NewBlank, TemplateselectionBox, Createlabel1, Createlabel2, Createlabel3);
            }
            else
            {
                Controlfunc.Makeitinvisible(NewBlank, TemplateselectionBox, Createlabel1, Createlabel2, Createlabel3);
            }
            fullpath = pathf + "\\" + DocumentName.Text + ".docx";
            Pathtofile.Text = "Path to new file: " + fullpath;
        }

        private void NewBlank_Click(object sender, EventArgs e)
        {
            WordApp = new Word.Application
            {
                Visible = true
            };
            
            object visible = true;
            WordDoc = WordApp.Documents.Add(ref miss, ref newTemplate, ref documentType, ref visible);
            WordDoc.Activate();
            Controlfunc.Makeitvisible(Endofwork, Finishlabel1, Finishlabel2, Actionlabel, Nextuserlabel, ActionSelectionBox, NextuserselectionBox, Finishlabel3, NoticeBox);
            Controlfunc.Makeitinvisible(SelectFolder, Labelforname, DocumentName, Attentionlabel, Createlabel1, Createlabel2, Createlabel3, TemplateselectionBox, Templateredir, NewBlank);
        }

        private void Endofwork_Click(object sender, EventArgs e)
        {
            if (ActionSelectionBox.SelectedIndex >= 0)
            {
                if (NextuserselectionBox.SelectedIndex >= 0)
                {
                    if (!templateok)
                    {
                        object path = fullpath;
                        WordDoc.SaveAs2(ref path);
                        WordDoc.Close(ref miss, ref miss, ref miss);
                        WordApp.Quit(ref miss, ref miss, ref miss);
                    }

                    File file = new File(pathf, DocumentName.Text, NextuserselectionBox.Text, ActionSelectionBox.Text, form2.current.name, NoticeBox.Text);
                    System.IO.File.WriteAllBytes(file.pathtofile, Cryptfunc.AESEncrypt(System.IO.File.ReadAllBytes(file.pathtofile)));
                    Cryptfunc.Loging(file);
                    Cryptfunc.Signing(file);

                    this.Close();
                    form2.UpdateGrid();
                }
                else
                {
                    MessageBox.Show("Choose next user at first!");
                }
            }
            else
            {
                MessageBox.Show("Choose action at first!");
            }
        }

        private void TemplateselectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TemplateselectionBox.SelectedIndex>=0)
            {
                Templateredir.Visible = true;
            }
            else
            {
                Templateredir.Visible = false;
            }
        }

        private void Templateredir_Click(object sender, EventArgs e)
        {
            if (TemplateselectionBox.SelectedIndex>=0)
            {
                switch(TemplateselectionBox.SelectedIndex)
                {
                    case 0:
                        new Letterofattorney(fullpath).ShowDialog();
                        break;
                    case 1:
                        new Recruitment(fullpath).ShowDialog();
                        break;
                    case 2:
                        new Vacation(fullpath).ShowDialog();
                        break;
                    default:
                        break;
                }
                if (System.IO.File.Exists(fullpath))
                {
                    Controlfunc.Makeitvisible(Endofwork, Finishlabel1, Finishlabel2, Actionlabel, Nextuserlabel, ActionSelectionBox, NextuserselectionBox, Finishlabel3, NoticeBox);
                    Controlfunc.Makeitinvisible(SelectFolder, Labelforname, DocumentName, Attentionlabel, Createlabel1, Createlabel2, Createlabel3, TemplateselectionBox, Templateredir, NewBlank);
                    templateok = true;
                }
            }
            else
            {
                MessageBox.Show("Select template at first");
            }
        }

        private void DocumentName_TextChanged(object sender, EventArgs e)
        {
            if (DocumentName.Text != "" && pathf != null)
            {
                Controlfunc.Makeitvisible(NewBlank, TemplateselectionBox, Createlabel1, Createlabel2, Createlabel3);
            }
            else
            {
                Controlfunc.Makeitinvisible(NewBlank, TemplateselectionBox, Createlabel1, Createlabel2, Createlabel3);
            }
            fullpath = pathf + "\\" + DocumentName.Text + ".docx";
            Pathtofile.Text = "Path to new file: " + fullpath;
        }
    }
}