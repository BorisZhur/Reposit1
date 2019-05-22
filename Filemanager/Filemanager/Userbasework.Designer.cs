namespace Filemanager
{
    partial class Userbasework
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
            this.Uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uaccess = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Upass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmchanges = new System.Windows.Forms.Button();
            this.Attentionlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uname,
            this.Uaccess,
            this.Upass});
            this.dataGridView.Location = new System.Drawing.Point(25, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(355, 199);
            this.dataGridView.TabIndex = 0;
            // 
            // Uname
            // 
            this.Uname.HeaderText = "User name";
            this.Uname.Name = "Uname";
            // 
            // Uaccess
            // 
            this.Uaccess.HeaderText = "Level access";
            this.Uaccess.Items.AddRange(new object[] {
            "Leadership",
            "Middle level worker",
            "Low level worker"});
            this.Uaccess.Name = "Uaccess";
            this.Uaccess.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uaccess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Uaccess.Width = 150;
            // 
            // Upass
            // 
            this.Upass.HeaderText = "Password";
            this.Upass.Name = "Upass";
            // 
            // Confirmchanges
            // 
            this.Confirmchanges.Location = new System.Drawing.Point(280, 225);
            this.Confirmchanges.Name = "Confirmchanges";
            this.Confirmchanges.Size = new System.Drawing.Size(100, 44);
            this.Confirmchanges.TabIndex = 2;
            this.Confirmchanges.Text = "Confirm changes in the table";
            this.Confirmchanges.UseVisualStyleBackColor = true;
            this.Confirmchanges.Click += new System.EventHandler(this.ConfirmChanges_Click);
            // 
            // Attentionlabel
            // 
            this.Attentionlabel.AutoSize = true;
            this.Attentionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attentionlabel.Location = new System.Drawing.Point(12, 287);
            this.Attentionlabel.Name = "Attentionlabel";
            this.Attentionlabel.Size = new System.Drawing.Size(373, 15);
            this.Attentionlabel.TabIndex = 3;
            this.Attentionlabel.Text = "Attention! To save the changes, press confirmation button";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "To delete user just clear his name or password cell";
            // 
            // Userbasework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Attentionlabel);
            this.Controls.Add(this.Confirmchanges);
            this.Controls.Add(this.dataGridView);
            this.Name = "Userbasework";
            this.Text = "Edit user base";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Confirmchanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uname;
        private System.Windows.Forms.DataGridViewComboBoxColumn Uaccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Upass;
        private System.Windows.Forms.Label Attentionlabel;
        private System.Windows.Forms.Label label1;
    }
}