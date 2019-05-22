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
    public partial class Letterofattorney : Form
    {
        Word._Application oWord;
        string pathtofile;

        public Letterofattorney(string pathtofile)
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
        
        // Замена закладки SECONDNAME на данные введенные в textBox
        private void SetTemplate(Word._Document oDoc)
        {
            oDoc.Bookmarks["Name"].Range.Text = textBox1.Text;
            oDoc.Bookmarks["Pass_series"].Range.Text = textBox2.Text;
            oDoc.Bookmarks["Pass_number"].Range.Text = textBox3.Text;
            oDoc.Bookmarks["issue"].Range.Text = textBox4.Text;
            oDoc.Bookmarks["adress"].Range.Text = textBox5.Text;
            oDoc.Bookmarks["to_do_list"].Range.Text = richTextBox1.Text;
            oDoc.Bookmarks["Name2"].Range.Text = textBox1.Text;
            oDoc.Bookmarks["time"].Range.Text = textBox6.Text;

            // если нужно заменять другие закладки, тогда копируем верхнюю строку изменяя на нужные параметры 

        }
        private void button1_Click(object sender, EventArgs e)
        {
            oWord = new Word.Application();
            Word._Document oDoc = GetDoc(@"C:\Users\boris\Desktop\Folderfortricks\template1.dotx");
            
            oDoc.SaveAs(FileName: pathtofile);

            //oWord.Visible = true;
            oDoc.Close();
            this.Close();
        }
    }
}
