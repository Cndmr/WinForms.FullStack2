namespace WinForms.FullStack2.Forms
{
    partial class RegisterForm
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
            txtName = new TextBox();
            txtNickName = new TextBox();
            txtPass = new TextBox();
            txtRegister = new Button();
            btnBack = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(23, 82);
            txtName.Margin = new Padding(5, 4, 5, 4);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ad Soyad";
            txtName.Size = new Size(293, 39);
            txtName.TabIndex = 1;
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(23, 129);
            txtNickName.Margin = new Padding(5, 4, 5, 4);
            txtNickName.Multiline = true;
            txtNickName.Name = "txtNickName";
            txtNickName.PlaceholderText = "Kullanıcı Adı";
            txtNickName.Size = new Size(293, 39);
            txtNickName.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(23, 176);
            txtPass.Margin = new Padding(5, 4, 5, 4);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Şifre";
            txtPass.Size = new Size(293, 39);
            txtPass.TabIndex = 3;
            // 
            // txtRegister
            // 
            txtRegister.Location = new Point(23, 223);
            txtRegister.Margin = new Padding(5, 4, 5, 4);
            txtRegister.Name = "txtRegister";
            txtRegister.Size = new Size(131, 39);
            txtRegister.TabIndex = 4;
            txtRegister.Text = "Kayıt ol";
            txtRegister.UseVisualStyleBackColor = true;
            txtRegister.Click += txtRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(164, 223);
            btnBack.Margin = new Padding(5, 4, 5, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(152, 39);
            btnBack.TabIndex = 5;
            btnBack.Text = "Geri dön";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 43);
            label1.TabIndex = 2;
            label1.Text = "KAYIT FORMU";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 303);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(txtRegister);
            Controls.Add(txtPass);
            Controls.Add(txtNickName);
            Controls.Add(txtName);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            FormClosed += RegisterForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtNickName;
        private TextBox txtPass;
        private Button txtRegister;
        private Button btnBack;
        private Label label1;
    }
}