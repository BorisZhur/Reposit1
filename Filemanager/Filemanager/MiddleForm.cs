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
    public partial class MiddleForm : Form
    {
        string folderpath = @"C:\Users\boris\Desktop\Folderfortricks";
        public bool fileinwork = false;
        private BeginingForm form1;
        public User current;
        public List<File> files = new List<File>();
        DataGridView dataGridView;

        public MiddleForm(BeginingForm form1, User current)
        {
            InitializeComponent();
            this.current = current;
            this.form1 = form1;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void MiddleForm_FormClosed(object sender, FormClosedEventArgs e) => form1.Visible = true;
        
        private void MiddleForm_Load(object sender, EventArgs e)
        {
            UserLabel.Text += current.name;
            dataGridView = new System.Windows.Forms.DataGridView()
            {
                Name = "dataGridView",
                Location = new System.Drawing.Point(127, 30),
                AllowUserToAddRows = false,
                AllowUserToOrderColumns = false,
                AllowUserToDeleteRows = false,
                AllowDrop = false,
                Size = new System.Drawing.Size(553, 250)

            };
            this.Controls.Add(dataGridView);
            var column1 = new System.Windows.Forms.DataGridViewColumn
            {
                Name = "Name",
                HeaderText = "Document Name",
                Width = 100,
                ReadOnly = true,
                Frozen = true,
                CellTemplate = new System.Windows.Forms.DataGridViewTextBoxCell()
            };
            dataGridView.Columns.Add(column1);
            var column2 = new System.Windows.Forms.DataGridViewColumn
            {
                Name = "User",
                HeaderText = "Last editor",
                Width = 63,
                ReadOnly = true,
                Frozen = true,
                CellTemplate = new System.Windows.Forms.DataGridViewTextBoxCell()
            };
            dataGridView.Columns.Add(column2);
            var column3 = new System.Windows.Forms.DataGridViewColumn
            {
                Name = "Time",
                HeaderText = "Last change time",
                Width = 107,
                ReadOnly = true,
                Frozen = true,
                CellTemplate = new System.Windows.Forms.DataGridViewTextBoxCell()
            };
            dataGridView.Columns.Add(column3);
            var column4 = new System.Windows.Forms.DataGridViewColumn
            {
                Name = "State",
                HeaderText = "State",
                Width = 100,
                ReadOnly = true,
                Frozen = true,
                CellTemplate = new System.Windows.Forms.DataGridViewTextBoxCell()
            };
            dataGridView.Columns.Add(column4);
            var column5 = new System.Windows.Forms.DataGridViewColumn
            {
                Name = "Validity",
                HeaderText = "Validity of ES",
                Width = 80,
                ReadOnly = true,
                Frozen = true,
                CellTemplate = new System.Windows.Forms.DataGridViewTextBoxCell()
            };
            dataGridView.Columns.Add(column5);
            var column6 = new System.Windows.Forms.DataGridViewButtonColumn()
            {
                Name = "Details",
                Width = 100,
                ReadOnly = true,
                HeaderText = "",
                UseColumnTextForButtonValue = false
            };
            dataGridView.Columns.Add(column6);
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.CellClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
            Filterbox.SelectedItem = "All files";
            if (current.accesslevel > 0)
            {
                EditUserBase.Visible = false;
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0 || e.ColumnIndex!=dataGridView.Columns["Details"].Index)
            {
                return;
            }

            string name = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            int ind = 0;
            for (ind = 0; ind < files.Count; ind++)
            {
                if (files[ind].name == name)
                {
                    if (files[ind].IsFileValid())
                    {
                        DetailsForm form3 = new DetailsForm(form1, this, files[ind]);
                        form3.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("ES non valid or file logs non valid!!! Can't show properties for such type of documents");
                    }
                    break;
                }
            }
        }

        private void Changefolder_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK && fbd.SelectedPath != null) 
            {
                folderpath = fbd.SelectedPath;
                UpdateGrid();
            }
        }

        public void UpdateGrid()
        {
            int filter = 0;
            switch(Filterbox.SelectedItem.ToString())
            {
                case "All files":
                    filter = 0;
                    break;
                case "Files sent to me":
                    filter = 1;
                    break;
                case "Uncompleted files":
                    filter = 2;
                    break;
                case "Completed files":
                    filter = 3;
                    break;
                case "Files without valid ES":
                    filter = 4;
                    break;
            }

            if (dataGridView.Rows.Count>0)
            {
                dataGridView.Rows.Clear();
            }
            try
            {
                string[] names = System.IO.Directory.GetFiles(folderpath, '*' + Searchbox.Text + "*.docx");
                files = new List<File>();

                for (int i = 0; i < names.Length; i++)
                {
                    files.Add(new File(names[i]));

                    if (Userhaveacess(files[i]))
                    {
                        switch (filter)
                        {
                            case 1:
                                if (files[i].touser == current.name && files[i].State != "Completed")
                                {
                                    dataGridView.Rows.Add(files[i].name, files[i].goodfile ? files[i].fromuser : "-", files[i].goodfile ? files[i].date.ToString() : "-", files[i].goodfile ? files[i].State : "Bad file", files[i].IsFileValid() ? "Valid" : "Non valid", "Details...");
                                }
                                break;
                            case 2:
                                if (files[i].goodfile && files[i].State != "Completed")
                                {
                                    dataGridView.Rows.Add(files[i].name, files[i].goodfile ? files[i].fromuser : "-", files[i].goodfile ? files[i].date.ToString() : "-", files[i].goodfile ? files[i].State : "Bad file", files[i].IsFileValid() ? "Valid" : "Non valid", "Details...");
                                }
                                break;
                            case 3:
                                if (files[i].State == "Completed")
                                {
                                    dataGridView.Rows.Add(files[i].name, files[i].goodfile ? files[i].fromuser : "-", files[i].goodfile ? files[i].date.ToString() : "-", files[i].goodfile ? files[i].State : "Bad file", files[i].IsFileValid() ? "Valid" : "Non valid", "Details...");
                                }
                                break;
                            case 4:
                                if (!files[i].goodfile)
                                {
                                    dataGridView.Rows.Add(files[i].name, "-", "-", "Bad file", "Non valid", "Details...");
                                }
                                break;
                            default:
                                dataGridView.Rows.Add(files[i].name, files[i].goodfile ? files[i].fromuser : "-", files[i].goodfile ? files[i].date.ToString() : "-", files[i].goodfile ? files[i].State : "Bad file", files[i].IsFileValid() ? "Valid" : "Non valid", "Details...");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uncorrect expression, got " + ex.ToString());
            }
        }

        public bool Userhaveacess(File f)
        {
            if (current.name == f.touser  || !f.goodfile || f.State == "Completed" && current.name == f.logs[f.logs.Count - 2].fromuser)
            {
                return true;
            }
            else
            {
                int fileaccess = 2;
                foreach (User u in form1.userbase)
                {
                    if (u.name == f.fromuser)
                    {
                        fileaccess = u.accesslevel;
                        break;
                    }
                }
                return current.accesslevel <= fileaccess;
            }
        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void Filterbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void EditUserBase_Click(object sender, EventArgs e)
        {
            new Userbasework(form1).ShowDialog();
        }

        private void NewDocument_Click(object sender, EventArgs e)
        {
            new CreatingDoc(this, form1).ShowDialog();
        }
    }
}