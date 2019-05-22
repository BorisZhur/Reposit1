namespace Filemanager
{
    partial class MiddleForm
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
            this.Logout = new System.Windows.Forms.Button();
            this.Changefolder = new System.Windows.Forms.Button();
            this.Warninglabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.Filterbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditUserBase = new System.Windows.Forms.Button();
            this.NewDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(720, 10);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(60, 25);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Changefolder
            // 
            this.Changefolder.Location = new System.Drawing.Point(685, 52);
            this.Changefolder.Margin = new System.Windows.Forms.Padding(2);
            this.Changefolder.Name = "Changefolder";
            this.Changefolder.Size = new System.Drawing.Size(95, 51);
            this.Changefolder.TabIndex = 1;
            this.Changefolder.Text = "Change browse folder";
            this.Changefolder.UseVisualStyleBackColor = true;
            this.Changefolder.Click += new System.EventHandler(this.Changefolder_Click);
            // 
            // Warninglabel
            // 
            this.Warninglabel.AutoSize = true;
            this.Warninglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Warninglabel.Location = new System.Drawing.Point(58, 337);
            this.Warninglabel.Name = "Warninglabel";
            this.Warninglabel.Size = new System.Drawing.Size(671, 15);
            this.Warninglabel.TabIndex = 2;
            this.Warninglabel.Text = "Attention! You need to have file and it\'s signature in selected folder for the be" +
    "st application performance";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(12, 10);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(70, 13);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "Current user: ";
            // 
            // Searchbox
            // 
            this.Searchbox.Location = new System.Drawing.Point(480, 8);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(200, 20);
            this.Searchbox.TabIndex = 8;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Location = new System.Drawing.Point(409, 11);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(65, 13);
            this.Searchlabel.TabIndex = 9;
            this.Searchlabel.Text = "Search files:";
            // 
            // Filterbox
            // 
            this.Filterbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filterbox.FormattingEnabled = true;
            this.Filterbox.Items.AddRange(new object[] {
            "All files",
            "Files sent to me",
            "Uncompleted files",
            "Completed files",
            "Files without valid ES"});
            this.Filterbox.Location = new System.Drawing.Point(12, 52);
            this.Filterbox.Name = "Filterbox";
            this.Filterbox.Size = new System.Drawing.Size(110, 21);
            this.Filterbox.TabIndex = 10;
            this.Filterbox.SelectedIndexChanged += new System.EventHandler(this.Filterbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filter the file list";
            // 
            // EditUserBase
            // 
            this.EditUserBase.Location = new System.Drawing.Point(12, 311);
            this.EditUserBase.Name = "EditUserBase";
            this.EditUserBase.Size = new System.Drawing.Size(110, 23);
            this.EditUserBase.TabIndex = 12;
            this.EditUserBase.Text = "Edit user base";
            this.EditUserBase.UseVisualStyleBackColor = true;
            this.EditUserBase.Click += new System.EventHandler(this.EditUserBase_Click);
            // 
            // NewDocument
            // 
            this.NewDocument.Location = new System.Drawing.Point(12, 90);
            this.NewDocument.Name = "NewDocument";
            this.NewDocument.Size = new System.Drawing.Size(110, 37);
            this.NewDocument.TabIndex = 13;
            this.NewDocument.Text = "Create new document";
            this.NewDocument.UseVisualStyleBackColor = true;
            this.NewDocument.Click += new System.EventHandler(this.NewDocument_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.NewDocument);
            this.Controls.Add(this.EditUserBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filterbox);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.Warninglabel);
            this.Controls.Add(this.Changefolder);
            this.Controls.Add(this.Logout);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic document management system version 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiddleForm_FormClosed);
            this.Load += new System.EventHandler(this.MiddleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Changefolder;
        private System.Windows.Forms.Label Warninglabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.ComboBox Filterbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditUserBase;
        private System.Windows.Forms.Button NewDocument;
    }
}