namespace WinForms.FullStack2
{
    partial class UserLoginForm
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            btnGiris = new Button();
            label2 = new Label();
            lblPassword = new Label();
            txtPass = new TextBox();
            btnClose = new Button();
            label4 = new Label();
            txtRegister = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(102, 91);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(186, 23);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Kullanıcı Adınız";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(27, 130);
            txtUserName.Margin = new Padding(4, 3, 4, 3);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(366, 38);
            txtUserName.TabIndex = 1;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(27, 261);
            btnGiris.Margin = new Padding(4, 3, 4, 3);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(134, 65);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(134, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 55);
            label2.TabIndex = 0;
            label2.Text = "LOGIN";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(166, 181);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(65, 23);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Şifre";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(27, 217);
            txtPass.Margin = new Padding(4, 3, 4, 3);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(366, 38);
            txtPass.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(311, 261);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 65);
            btnClose.TabIndex = 4;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 382);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(373, 23);
            label4.TabIndex = 0;
            label4.Text = "D-Soft - Not Defteri Sürüm 1.0001";
            // 
            // txtRegister
            // 
            txtRegister.Location = new Point(169, 261);
            txtRegister.Margin = new Padding(4, 3, 4, 3);
            txtRegister.Name = "txtRegister";
            txtRegister.Size = new Size(134, 65);
            txtRegister.TabIndex = 3;
            txtRegister.Text = "Kayıt Ol";
            txtRegister.UseVisualStyleBackColor = true;
            txtRegister.Click += txtRegister_Click;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 461);
            Controls.Add(btnClose);
            Controls.Add(txtRegister);
            Controls.Add(btnGiris);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(lblPassword);
            Controls.Add(label2);
            Controls.Add(lblUserName);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserLoginForm";
            Text = "User";
            FormClosed += UserLoginForm_FormClosed;
            Load += UserLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Button btnGiris;
        private Label label2;
        private Label lblPassword;
        private TextBox txtPass;
        private Button btnClose;
        private Label label4;
        private Button txtRegister;
    }
}