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
    public partial class Userbasework : Form
    {
        BeginingForm form1;

        public Userbasework(BeginingForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
            foreach (User u in form1.userbase)
            {
                dataGridView.Rows.Add(u.name, null, u.pass);
            }

            for (int i=0; i<form1.userbase.Count; i++)
            {
                dataGridView.Rows[i].Cells[1].Value = form1.userbase[i].Accesslevel;
            }
        }

        private void ConfirmChanges_Click(object sender, EventArgs e)
        {
            List<User> ul = new List<User>();
            int leadercounter = 0;
            for (int i=0; i<dataGridView.RowCount-1; i++)
            {
                try
                {
                    string un = "", ua = "", up = "";
                    un = dataGridView.Rows[i].Cells[0].Value.ToString();
                    ua = dataGridView.Rows[i].Cells[1].Value.ToString();
                    if (ua=="Leadership") { leadercounter++; }
                    up = dataGridView.Rows[i].Cells[2].Value.ToString();

                    ul.Add(new User(un, up));
                    ul[i].Accesslevel = ua;
                }
                catch(Exception) { }
            }
            if (leadercounter!=0)
            {
                string strout = "";
                foreach (User u in ul)
                {
                    strout += u.name + ' ' + u.accesslevel + ' ' + u.pass + "\r\n";
                }
                System.IO.File.WriteAllBytes(form1.pathtobase, Cryptfunc.AESEncrypt(System.Text.Encoding.UTF8.GetBytes(strout)));
                form1.userbase = ul;
                this.Close();
            }
            else
            {
                MessageBox.Show("Company need one leader at least!!!");
            }
        }
    }
}
