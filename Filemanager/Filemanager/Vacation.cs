using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Filemanager
{
    public partial class Vacation : Form
    {
        Word._Application oWord;
        string pathtofile;
        public Vacation(string pathtofile)
        {
            InitializeComponent();
            label10.Text = DateTime.Today.ToShortDateString();
            this.pathtofile = pathtofile;
        }
        
        private Word._Document GetDoc(string path)
        {
            Word._Document oDoc = oWord.Documents.Add(path);
            SetTemplate(oDoc);
            return oDoc;
        }



        // Замена закладки на данные введенные в textBox
        private void SetTemplate(Word._Document oDoc)
        {
            oDoc.Bookmarks["rank"].Range.Text = textBox1.Text;
            oDoc.Bookmarks["name"].Range.Text = textBox2.Text;
            oDoc.Bookmarks["date"].Range.Text = textBox3.Text;
            oDoc.Bookmarks["len"].Range.Text = textBox4.Text;
            oDoc.Bookmarks["date2"].Range.Text = label10.Text;
            oDoc.Bookmarks["name2"].Range.Text = textBox5.Text;
            if (checkBox1.Checked == true)
            {
                oDoc.Bookmarks["fire"].Range.Text = " с последующим увольнением по собственному желанию.";
            }
            else
            {
                oDoc.Bookmarks["fire"].Range.Text = ".";
            }
            oDoc.Bookmarks["type"].Range.Text = comboBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            oWord = new Word.Application();
            Word._Document oDoc = GetDoc(@"C:\Users\boris\Desktop\Folderfortricks\template3.dotx");

            oDoc.SaveAs(FileName:pathtofile);
            //oWord.Visible = true;
            oDoc.Close();
        }
    }
}
