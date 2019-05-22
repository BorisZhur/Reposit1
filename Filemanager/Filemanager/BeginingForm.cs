using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Filemanager
{
    public partial class BeginingForm : Form
    {
        private MiddleForm form2;
        public List<User> userbase = new List<User>();
        public string pathtobase = @"C:\Users\boris\Desktop\Folderfortricks\userbase.txt";

        public BeginingForm()
        {
            InitializeComponent();
            Initializeuserbase();
        }

        void Initializeuserbase()
        {
            string[] ch = { "\r\n" };
            string[] s = System.Text.Encoding.UTF8.GetString(Cryptfunc.AESDecrypt(System.IO.File.ReadAllBytes(pathtobase))).Split(ch, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in s)
            {
                string uname = "", upass = "";
                int uaccess;
                int i = 0;
                while (str[i]!=' ') { uname += str[i++];}
                i++;
                uaccess = int.Parse(str[i].ToString());
                i += 2;
                while (i<str.Length) { upass += str[i++]; }
                userbase.Add(new User(uname, uaccess, upass));
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Loginnig();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password.Select();
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loginnig();
            }
        }

        private void Loginnig()
        {
            if (Login.Text != "" && Password.Text != "")
            {
                bool found = false;
                int i = 0;
                for (i = 0; i < userbase.Count; i++)
                {
                    if (Login.Text == userbase[i].name)
                    {
                        found = true;
                        break;
                    }
                }
                if (found == false || (found == true && Password.Text != userbase[i].pass))
                {
                    MessageBox.Show("Wrong login or password");
                    Login.Text = "";
                    Password.Text = "";
                }
                else
                {
                    this.Visible = false;
                    form2 = new MiddleForm(this, userbase[i]) { Visible = true };
                    Login.Text = "";
                    Password.Text = "";
                }
            }
        }
    }
}
