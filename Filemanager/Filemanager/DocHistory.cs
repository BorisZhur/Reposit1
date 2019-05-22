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
    public partial class DocHistory : Form
    {
        List<Logline> loglines;

        public DocHistory(List<Logline> loglines, string docname)
        {
            InitializeComponent();
            this.loglines = loglines;
            this.Text = "History of document \"" + docname + "\"";
            if (loglines.Count<13)
            {
                int extra = 20 * (13 - loglines.Count);
                dataGridView.Size = new Size(dataGridView.Width, dataGridView.Height - extra);
                this.Size = new Size(this.Width, this.Height - extra);
            }
        }

        private void LogHistory_Load(object sender, EventArgs e)
        {
            foreach (Logline log in loglines)
            {
                dataGridView.Rows.Add(log.State, log.fromuser, log.State=="Completed" ? "-" : log.touser, log.date, log.note);
            }
        }
    }
}
