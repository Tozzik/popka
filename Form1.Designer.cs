namespace popka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuest = new Button();
            btnVxod = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(269, 315);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(75, 38);
            btnGuest.TabIndex = 0;
            btnGuest.Text = "Гость";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnVxod
            // 
            btnVxod.Location = new Point(185, 315);
            btnVxod.Name = "btnVxod";
            btnVxod.Size = new Size(75, 38);
            btnVxod.TabIndex = 1;
            btnVxod.Text = "Вход";
            btnVxod.UseVisualStyleBackColor = true;
            btnVxod.Click += btnVxod_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(185, 201);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Size = new Size(159, 23);
            txtLogin.TabIndex = 2;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(185, 242);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(159, 23);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 83);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(226, 370);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "Выход";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnVxod);
            Controls.Add(btnGuest);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuest;
        private Button btnVxod;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label label1;
        private Button btnClose;
    }
}
