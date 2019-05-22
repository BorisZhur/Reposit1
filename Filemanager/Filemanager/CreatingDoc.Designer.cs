namespace Filemanager
{
    partial class CreatingDoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFolder = new System.Windows.Forms.Button();
            this.NewBlank = new System.Windows.Forms.Button();
            this.DocumentName = new System.Windows.Forms.TextBox();
            this.Labelforname = new System.Windows.Forms.Label();
            this.Endofwork = new System.Windows.Forms.Button();
            this.Attentionlabel = new System.Windows.Forms.Label();
            this.Pathtofile = new System.Windows.Forms.Label();
            this.Createlabel2 = new System.Windows.Forms.Label();
            this.Createlabel3 = new System.Windows.Forms.Label();
            this.TemplateselectionBox = new System.Windows.Forms.ComboBox();
            this.Templateredir = new System.Windows.Forms.Button();
            this.Finishlabel1 = new System.Windows.Forms.Label();
            this.Finishlabel2 = new System.Windows.Forms.Label();
            this.ActionSelectionBox = new System.Windows.Forms.ComboBox();
            this.Createlabel1 = new System.Windows.Forms.Label();
            this.NextuserselectionBox = new System.Windows.Forms.ComboBox();
            this.Nextuserlabel = new System.Windows.Forms.Label();
            this.Actionlabel = new System.Windows.Forms.Label();
            this.Finishlabel3 = new System.Windows.Forms.Label();
            this.NoticeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(32, 25);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(121, 24);
            this.SelectFolder.TabIndex = 0;
            this.SelectFolder.Text = "Select folder to save";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // NewBlank
            // 
            this.NewBlank.Location = new System.Drawing.Point(15, 89);
            this.NewBlank.Name = "NewBlank";
            this.NewBlank.Size = new System.Drawing.Size(102, 38);
            this.NewBlank.TabIndex = 1;
            this.NewBlank.Text = "Create new blank";
            this.NewBlank.UseVisualStyleBackColor = true;
            this.NewBlank.Visible = false;
            this.NewBlank.Click += new System.EventHandler(this.NewBlank_Click);
            // 
            // DocumentName
            // 
            this.DocumentName.Location = new System.Drawing.Point(288, 28);
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.Size = new System.Drawing.Size(100, 20);
            this.DocumentName.TabIndex = 2;
            this.DocumentName.TextChanged += new System.EventHandler(this.DocumentName_TextChanged);
            // 
            // Labelforname
            // 
            this.Labelforname.AutoSize = true;
            this.Labelforname.Location = new System.Drawing.Point(159, 31);
            this.Labelforname.Name = "Labelforname";
            this.Labelforname.Size = new System.Drawing.Size(123, 13);
            this.Labelforname.TabIndex = 3;
            this.Labelforname.Text = "Enter name of document";
            // 
            // Endofwork
            // 
            this.Endofwork.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Endofwork.Location = new System.Drawing.Point(162, 89);
            this.Endofwork.Name = "Endofwork";
            this.Endofwork.Size = new System.Drawing.Size(106, 38);
            this.Endofwork.TabIndex = 4;
            this.Endofwork.Text = "End work with file";
            this.Endofwork.UseVisualStyleBackColor = false;
            this.Endofwork.Visible = false;
            this.Endofwork.Click += new System.EventHandler(this.Endofwork_Click);
            // 
            // Attentionlabel
            // 
            this.Attentionlabel.AutoSize = true;
            this.Attentionlabel.BackColor = System.Drawing.SystemColors.Control;
            this.Attentionlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Attentionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attentionlabel.Location = new System.Drawing.Point(12, 7);
            this.Attentionlabel.Name = "Attentionlabel";
            this.Attentionlabel.Size = new System.Drawing.Size(381, 15);
            this.Attentionlabel.TabIndex = 5;
            this.Attentionlabel.Text = "Attention!!! Choose folder and name of document before adding new document";
            // 
            // Pathtofile
            // 
            this.Pathtofile.AutoSize = true;
            this.Pathtofile.Location = new System.Drawing.Point(12, 52);
            this.Pathtofile.Name = "Pathtofile";
            this.Pathtofile.Size = new System.Drawing.Size(86, 13);
            this.Pathtofile.TabIndex = 6;
            this.Pathtofile.Text = "Path to new file: ";
            // 
            // Createlabel2
            // 
            this.Createlabel2.AutoSize = true;
            this.Createlabel2.BackColor = System.Drawing.Color.Azure;
            this.Createlabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Createlabel2.Location = new System.Drawing.Point(12, 130);
            this.Createlabel2.Name = "Createlabel2";
            this.Createlabel2.Size = new System.Drawing.Size(286, 15);
            this.Createlabel2.TabIndex = 7;
            this.Createlabel2.Text = "Or you can create document by using one of this templates";
            this.Createlabel2.Visible = false;
            // 
            // Createlabel3
            // 
            this.Createlabel3.AutoSize = true;
            this.Createlabel3.Location = new System.Drawing.Point(12, 153);
            this.Createlabel3.Name = "Createlabel3";
            this.Createlabel3.Size = new System.Drawing.Size(80, 13);
            this.Createlabel3.TabIndex = 8;
            this.Createlabel3.Text = "Select template";
            this.Createlabel3.Visible = false;
            // 
            // TemplateselectionBox
            // 
            this.TemplateselectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TemplateselectionBox.FormattingEnabled = true;
            this.TemplateselectionBox.Items.AddRange(new object[] {
            "Доверенность",
            "Приказ о приеме на работу",
            "Заявление на отпуск"});
            this.TemplateselectionBox.Location = new System.Drawing.Point(98, 150);
            this.TemplateselectionBox.Name = "TemplateselectionBox";
            this.TemplateselectionBox.Size = new System.Drawing.Size(121, 21);
            this.TemplateselectionBox.TabIndex = 9;
            this.TemplateselectionBox.Visible = false;
            this.TemplateselectionBox.SelectedIndexChanged += new System.EventHandler(this.TemplateselectionBox_SelectedIndexChanged);
            // 
            // Templateredir
            // 
            this.Templateredir.Location = new System.Drawing.Point(225, 148);
            this.Templateredir.Name = "Templateredir";
            this.Templateredir.Size = new System.Drawing.Size(184, 23);
            this.Templateredir.TabIndex = 10;
            this.Templateredir.Text = "Create by using selected template";
            this.Templateredir.UseVisualStyleBackColor = true;
            this.Templateredir.Visible = false;
            this.Templateredir.Click += new System.EventHandler(this.Templateredir_Click);
            // 
            // Finishlabel1
            // 
            this.Finishlabel1.AutoSize = true;
            this.Finishlabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Finishlabel1.Location = new System.Drawing.Point(12, 175);
            this.Finishlabel1.Name = "Finishlabel1";
            this.Finishlabel1.Size = new System.Drawing.Size(293, 15);
            this.Finishlabel1.TabIndex = 11;
            this.Finishlabel1.Text = "When you finish work with document, choose it\'s destination";
            this.Finishlabel1.Visible = false;
            // 
            // Finishlabel2
            // 
            this.Finishlabel2.AutoSize = true;
            this.Finishlabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Finishlabel2.Location = new System.Drawing.Point(12, 190);
            this.Finishlabel2.Name = "Finishlabel2";
            this.Finishlabel2.Size = new System.Drawing.Size(334, 15);
            this.Finishlabel2.TabIndex = 12;
            this.Finishlabel2.Text = "and, then press button \"End work with file\", without exiting document";
            this.Finishlabel2.Visible = false;
            // 
            // ActionSelectionBox
            // 
            this.ActionSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionSelectionBox.FormattingEnabled = true;
            this.ActionSelectionBox.Items.AddRange(new object[] {
            "In work",
            "To verify"});
            this.ActionSelectionBox.Location = new System.Drawing.Point(115, 208);
            this.ActionSelectionBox.Name = "ActionSelectionBox";
            this.ActionSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.ActionSelectionBox.TabIndex = 13;
            this.ActionSelectionBox.Visible = false;
            // 
            // Createlabel1
            // 
            this.Createlabel1.AutoSize = true;
            this.Createlabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Createlabel1.Location = new System.Drawing.Point(12, 73);
            this.Createlabel1.Name = "Createlabel1";
            this.Createlabel1.Size = new System.Drawing.Size(163, 15);
            this.Createlabel1.TabIndex = 14;
            this.Createlabel1.Text = "You can create empty document";
            this.Createlabel1.Visible = false;
            // 
            // NextuserselectionBox
            // 
            this.NextuserselectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NextuserselectionBox.FormattingEnabled = true;
            this.NextuserselectionBox.Location = new System.Drawing.Point(300, 208);
            this.NextuserselectionBox.Name = "NextuserselectionBox";
            this.NextuserselectionBox.Size = new System.Drawing.Size(109, 21);
            this.NextuserselectionBox.TabIndex = 15;
            this.NextuserselectionBox.Visible = false;
            // 
            // Nextuserlabel
            // 
            this.Nextuserlabel.AutoSize = true;
            this.Nextuserlabel.Location = new System.Drawing.Point(242, 211);
            this.Nextuserlabel.Name = "Nextuserlabel";
            this.Nextuserlabel.Size = new System.Drawing.Size(52, 13);
            this.Nextuserlabel.TabIndex = 16;
            this.Nextuserlabel.Text = "Next user";
            this.Nextuserlabel.Visible = false;
            // 
            // Actionlabel
            // 
            this.Actionlabel.AutoSize = true;
            this.Actionlabel.Location = new System.Drawing.Point(12, 211);
            this.Actionlabel.Name = "Actionlabel";
            this.Actionlabel.Size = new System.Drawing.Size(97, 13);
            this.Actionlabel.TabIndex = 17;
            this.Actionlabel.Text = "Select action to file";
            this.Actionlabel.Visible = false;
            // 
            // Finishlabel3
            // 
            this.Finishlabel3.AutoSize = true;
            this.Finishlabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Finishlabel3.Location = new System.Drawing.Point(12, 232);
            this.Finishlabel3.Name = "Finishlabel3";
            this.Finishlabel3.Size = new System.Drawing.Size(229, 15);
            this.Finishlabel3.TabIndex = 18;
            this.Finishlabel3.Text = "You can attache some note to file for next user";
            this.Finishlabel3.Visible = false;
            // 
            // NoticeBox
            // 
            this.NoticeBox.Location = new System.Drawing.Point(12, 250);
            this.NoticeBox.Multiline = true;
            this.NoticeBox.Name = "NoticeBox";
            this.NoticeBox.Size = new System.Drawing.Size(397, 76);
            this.NoticeBox.TabIndex = 19;
            this.NoticeBox.Visible = false;
            // 
            // CreatingDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 338);
            this.Controls.Add(this.NoticeBox);
            this.Controls.Add(this.Finishlabel3);
            this.Controls.Add(this.Actionlabel);
            this.Controls.Add(this.Nextuserlabel);
            this.Controls.Add(this.NextuserselectionBox);
            this.Controls.Add(this.Createlabel1);
            this.Controls.Add(this.ActionSelectionBox);
            this.Controls.Add(this.Finishlabel2);
            this.Controls.Add(this.Finishlabel1);
            this.Controls.Add(this.Templateredir);
            this.Controls.Add(this.TemplateselectionBox);
            this.Controls.Add(this.Createlabel3);
            this.Controls.Add(this.Createlabel2);
            this.Controls.Add(this.Pathtofile);
            this.Controls.Add(this.Attentionlabel);
            this.Controls.Add(this.Endofwork);
            this.Controls.Add(this.Labelforname);
            this.Controls.Add(this.DocumentName);
            this.Controls.Add(this.NewBlank);
            this.Controls.Add(this.SelectFolder);
            this.Name = "CreatingDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatingDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Button NewBlank;
        private System.Windows.Forms.TextBox DocumentName;
        private System.Windows.Forms.Label Labelforname;
        private System.Windows.Forms.Button Endofwork;
        private System.Windows.Forms.Label Attentionlabel;
        private System.Windows.Forms.Label Pathtofile;
        private System.Windows.Forms.Label Createlabel2;
        private System.Windows.Forms.Label Createlabel3;
        private System.Windows.Forms.ComboBox TemplateselectionBox;
        private System.Windows.Forms.Button Templateredir;
        private System.Windows.Forms.Label Finishlabel1;
        private System.Windows.Forms.Label Finishlabel2;
        private System.Windows.Forms.ComboBox ActionSelectionBox;
        private System.Windows.Forms.Label Createlabel1;
        private System.Windows.Forms.ComboBox NextuserselectionBox;
        private System.Windows.Forms.Label Nextuserlabel;
        private System.Windows.Forms.Label Actionlabel;
        private System.Windows.Forms.Label Finishlabel3;
        private System.Windows.Forms.TextBox NoticeBox;
    }
}