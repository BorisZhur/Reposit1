namespace Filemanager
{
    partial class BeginingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Log_in = new System.Windows.Forms.Button();
            this.loglabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Log_in
            // 
            this.Log_in.Location = new System.Drawing.Point(373, 226);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(75, 23);
            this.Log_in.TabIndex = 0;
            this.Log_in.Text = "Login";
            this.Log_in.UseVisualStyleBackColor = true;
            this.Log_in.Click += new System.EventHandler(this.Login_Click);
            // 
            // loglabel
            // 
            this.loglabel.AutoSize = true;
            this.loglabel.Location = new System.Drawing.Point(258, 162);
            this.loglabel.Name = "loglabel";
            this.loglabel.Size = new System.Drawing.Size(33, 13);
            this.loglabel.TabIndex = 1;
            this.loglabel.Text = "Login";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Location = new System.Drawing.Point(258, 190);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(53, 13);
            this.passlabel.TabIndex = 2;
            this.passlabel.Text = "Password";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(324, 162);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(171, 20);
            this.Login.TabIndex = 3;
            this.Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(324, 187);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(171, 20);
            this.Password.TabIndex = 4;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.loglabel);
            this.Controls.Add(this.Log_in);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic document management system version 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Log_in;
        private System.Windows.Forms.Label loglabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
    }
}

