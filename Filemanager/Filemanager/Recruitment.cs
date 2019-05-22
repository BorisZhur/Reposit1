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
    public partial class Recruitment : Form
    {
        Word._Application oWord;
        string pathtofile;
        public Recruitment(string pathtofile)
        {
            InitializeComponent();
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
            oDoc.Bookmarks["name"].Range.Text = textBox1.Text;
            oDoc.Bookmarks["place"].Range.Text = textBox2.Text;
            oDoc.Bookmarks["rank"].Range.Text = textBox3.Text;
            oDoc.Bookmarks["conditions"].Range.Text = textBox4.Text;
            oDoc.Bookmarks["money1"].Range.Text = textBox12.Text;
            oDoc.Bookmarks["money2"].Range.Text = textBox13.Text;
            oDoc.Bookmarks["money3"].Range.Text = textBox15.Text;
            oDoc.Bookmarks["money4"].Range.Text = textBox14.Text;
            oDoc.Bookmarks["test"].Range.Text = textBox16.Text;
            oDoc.Bookmarks["number"].Range.Text = textBox7.Text;
            oDoc.Bookmarks["ddt"].Range.Text = textBox8.Text;
            oDoc.Bookmarks["mmt"].Range.Text = textBox9.Text;
            oDoc.Bookmarks["yyt"].Range.Text = textBox10.Text;
            oDoc.Bookmarks["nt"].Range.Text = textBox11.Text;
            oDoc.Bookmarks["date0"].Range.Text = DateTime.Today.ToShortDateString();
            oDoc.Bookmarks["date1"].Range.Text = textBox5.Text;
            oDoc.Bookmarks["date2"].Range.Text = textBox6.Text;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            oWord = new Word.Application();
            Word._Document oDoc = GetDoc(@"C:\Users\boris\Desktop\Folderfortricks\template2.dotx");

            oDoc.SaveAs(FileName: pathtofile);
            //oWord.Visible = true;
            oDoc.Close();
            this.Close();
        }

    }
}
