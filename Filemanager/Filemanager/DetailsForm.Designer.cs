namespace Filemanager
{
    partial class DetailsForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Propertytype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Properties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalizedocument = new System.Windows.Forms.Button();
            this.Chosenuser = new System.Windows.Forms.ComboBox();
            this.Chooseuserlabel = new System.Windows.Forms.Label();
            this.Notelabel1 = new System.Windows.Forms.Label();
            this.Notelabel2 = new System.Windows.Forms.Label();
            this.EndwithoutSave = new System.Windows.Forms.Button();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.SeeLogs = new System.Windows.Forms.Button();
            this.ActionSelectionBox = new System.Windows.Forms.ComboBox();
            this.Actionselectionlabel = new System.Windows.Forms.Label();
            this.EndwithSave = new System.Windows.Forms.Button();
            this.EditFile = new System.Windows.Forms.Button();
            this.Seefile = new System.Windows.Forms.Button();
            this.Deletefile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Propertytype,
            this.Properties});
            this.dataGridView.Location = new System.Drawing.Point(27, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(303, 200);
            this.dataGridView.TabIndex = 0;
            // 
            // Propertytype
            // 
            this.Propertytype.HeaderText = "Type of property";
            this.Propertytype.Name = "Propertytype";
            this.Propertytype.ReadOnly = true;
            this.Propertytype.Width = 120;
            // 
            // Properties
            // 
            this.Properties.HeaderText = "Properties";
            this.Properties.Name = "Properties";
            this.Properties.ReadOnly = true;
            this.Properties.Width = 180;
            // 
            // Finalizedocument
            // 
            this.Finalizedocument.Location = new System.Drawing.Point(27, 303);
            this.Finalizedocument.Name = "Finalizedocument";
            this.Finalizedocument.Size = new System.Drawing.Size(99, 46);
            this.Finalizedocument.TabIndex = 2;
            this.Finalizedocument.Text = "Mark document version as final";
            this.Finalizedocument.UseVisualStyleBackColor = true;
            this.Finalizedocument.Click += new System.EventHandler(this.Finalizedocument_Click);
            // 
            // Chosenuser
            // 
            this.Chosenuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Chosenuser.FormattingEnabled = true;
            this.Chosenuser.Location = new System.Drawing.Point(349, 30);
            this.Chosenuser.Name = "Chosenuser";
            this.Chosenuser.Size = new System.Drawing.Size(123, 21);
            this.Chosenuser.TabIndex = 4;
            this.Chosenuser.Tag = "";
            this.Chosenuser.Visible = false;
            // 
            // Chooseuserlabel
            // 
            this.Chooseuserlabel.AutoSize = true;
            this.Chooseuserlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chooseuserlabel.Location = new System.Drawing.Point(359, 14);
            this.Chooseuserlabel.Name = "Chooseuserlabel";
            this.Chooseuserlabel.Size = new System.Drawing.Size(100, 15);
            this.Chooseuserlabel.TabIndex = 5;
            this.Chooseuserlabel.Text = "Select user to send";
            this.Chooseuserlabel.Visible = false;
            // 
            // Notelabel1
            // 
            this.Notelabel1.AutoSize = true;
            this.Notelabel1.Location = new System.Drawing.Point(340, 94);
            this.Notelabel1.Name = "Notelabel1";
            this.Notelabel1.Size = new System.Drawing.Size(138, 13);
            this.Notelabel1.TabIndex = 6;
            this.Notelabel1.Text = "Attache notice to document";
            this.Notelabel1.Visible = false;
            // 
            // Notelabel2
            // 
            this.Notelabel2.AutoSize = true;
            this.Notelabel2.Location = new System.Drawing.Point(370, 107);
            this.Notelabel2.Name = "Notelabel2";
            this.Notelabel2.Size = new System.Drawing.Size(75, 13);
            this.Notelabel2.TabIndex = 8;
            this.Notelabel2.Text = "(Unnecessary)";
            this.Notelabel2.Visible = false;
            // 
            // EndwithoutSave
            // 
            this.EndwithoutSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EndwithoutSave.Location = new System.Drawing.Point(339, 242);
            this.EndwithoutSave.Name = "EndwithoutSave";
            this.EndwithoutSave.Size = new System.Drawing.Size(139, 55);
            this.EndwithoutSave.TabIndex = 9;
            this.EndwithoutSave.Text = "End work with file without saving changes in document";
            this.EndwithoutSave.UseVisualStyleBackColor = false;
            this.EndwithoutSave.Visible = false;
            this.EndwithoutSave.Click += new System.EventHandler(this.EndwithoutSave_Click);
            // 
            // NoteBox
            // 
            this.NoteBox.Location = new System.Drawing.Point(339, 123);
            this.NoteBox.Multiline = true;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(133, 107);
            this.NoteBox.TabIndex = 10;
            this.NoteBox.Visible = false;
            // 
            // SeeLogs
            // 
            this.SeeLogs.Location = new System.Drawing.Point(27, 242);
            this.SeeLogs.Name = "SeeLogs";
            this.SeeLogs.Size = new System.Drawing.Size(99, 46);
            this.SeeLogs.TabIndex = 11;
            this.SeeLogs.Text = "See document history (logs)";
            this.SeeLogs.UseVisualStyleBackColor = true;
            this.SeeLogs.Click += new System.EventHandler(this.SeeLogs_Click);
            // 
            // ActionSelectionBox
            // 
            this.ActionSelectionBox.BackColor = System.Drawing.SystemColors.Window;
            this.ActionSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionSelectionBox.FormattingEnabled = true;
            this.ActionSelectionBox.Items.AddRange(new object[] {
            "In work",
            "To rework",
            "To verify"});
            this.ActionSelectionBox.Location = new System.Drawing.Point(351, 70);
            this.ActionSelectionBox.Name = "ActionSelectionBox";
            this.ActionSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.ActionSelectionBox.TabIndex = 12;
            this.ActionSelectionBox.Visible = false;
            // 
            // Actionselectionlabel
            // 
            this.Actionselectionlabel.AutoSize = true;
            this.Actionselectionlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Actionselectionlabel.Location = new System.Drawing.Point(359, 54);
            this.Actionselectionlabel.Name = "Actionselectionlabel";
            this.Actionselectionlabel.Size = new System.Drawing.Size(99, 15);
            this.Actionselectionlabel.TabIndex = 13;
            this.Actionselectionlabel.Text = "Select action to file";
            this.Actionselectionlabel.Visible = false;
            // 
            // EndwithSave
            // 
            this.EndwithSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EndwithSave.Location = new System.Drawing.Point(339, 303);
            this.EndwithSave.Name = "EndwithSave";
            this.EndwithSave.Size = new System.Drawing.Size(139, 51);
            this.EndwithSave.TabIndex = 14;
            this.EndwithSave.Text = "End work with file with saving changes in document";
            this.EndwithSave.UseVisualStyleBackColor = false;
            this.EndwithSave.Visible = false;
            this.EndwithSave.Click += new System.EventHandler(this.EndwithSave_Click);
            // 
            // EditFile
            // 
            this.EditFile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EditFile.Location = new System.Drawing.Point(154, 242);
            this.EditFile.Name = "EditFile";
            this.EditFile.Size = new System.Drawing.Size(93, 46);
            this.EditFile.TabIndex = 15;
            this.EditFile.Text = "Edit document";
            this.EditFile.UseVisualStyleBackColor = false;
            this.EditFile.Click += new System.EventHandler(this.EditFile_Click);
            // 
            // Seefile
            // 
            this.Seefile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Seefile.Location = new System.Drawing.Point(154, 303);
            this.Seefile.Name = "Seefile";
            this.Seefile.Size = new System.Drawing.Size(93, 46);
            this.Seefile.TabIndex = 16;
            this.Seefile.Text = "See document";
            this.Seefile.UseVisualStyleBackColor = false;
            this.Seefile.Visible = false;
            this.Seefile.Click += new System.EventHandler(this.Seefile_Click);
            // 
            // Deletefile
            // 
            this.Deletefile.BackColor = System.Drawing.Color.LightCoral;
            this.Deletefile.Location = new System.Drawing.Point(255, 242);
            this.Deletefile.Name = "Deletefile";
            this.Deletefile.Size = new System.Drawing.Size(75, 46);
            this.Deletefile.TabIndex = 17;
            this.Deletefile.Text = "Delete document";
            this.Deletefile.UseVisualStyleBackColor = false;
            this.Deletefile.Visible = false;
            this.Deletefile.Click += new System.EventHandler(this.Deletefile_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Deletefile);
            this.Controls.Add(this.Seefile);
            this.Controls.Add(this.EditFile);
            this.Controls.Add(this.EndwithSave);
            this.Controls.Add(this.Actionselectionlabel);
            this.Controls.Add(this.ActionSelectionBox);
            this.Controls.Add(this.SeeLogs);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.EndwithoutSave);
            this.Controls.Add(this.Notelabel2);
            this.Controls.Add(this.Notelabel1);
            this.Controls.Add(this.Chooseuserlabel);
            this.Controls.Add(this.Chosenuser);
            this.Controls.Add(this.Finalizedocument);
            this.Controls.Add(this.dataGridView);
            this.Name = "DetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailsForm_FormClosing);
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propertytype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Properties;
        private System.Windows.Forms.Button Finalizedocument;
        private System.Windows.Forms.ComboBox Chosenuser;
        private System.Windows.Forms.Label Chooseuserlabel;
        private System.Windows.Forms.Label Notelabel1;
        private System.Windows.Forms.Label Notelabel2;
        private System.Windows.Forms.Button EndwithoutSave;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.Button SeeLogs;
        private System.Windows.Forms.ComboBox ActionSelectionBox;
        private System.Windows.Forms.Label Actionselectionlabel;
        private System.Windows.Forms.Button EndwithSave;
        private System.Windows.Forms.Button EditFile;
        private System.Windows.Forms.Button Seefile;
        private System.Windows.Forms.Button Deletefile;
    }
}