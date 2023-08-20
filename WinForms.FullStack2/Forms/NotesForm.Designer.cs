namespace WinForms.FullStack2.Forms
{
    partial class NotesForm
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
            lblTest = new Label();
            lblUser = new Label();
            label1 = new Label();
            txtDescription = new RichTextBox();
            btnEdit = new Button();
            btnClear = new Button();
            btnAdded = new Button();
            listNote = new ListBox();
            SuspendLayout();
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTest.Location = new Point(825, 440);
            lblTest.Margin = new Padding(5, 0, 5, 0);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(70, 22);
            lblTest.TabIndex = 22;
            lblTest.Text = "label2";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(825, 396);
            lblUser.Margin = new Padding(5, 0, 5, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 22);
            lblUser.TabIndex = 23;
            lblUser.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(479, 396);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 21;
            label1.Text = "Giriş Yapan Kullanıcı:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(482, 13);
            txtDescription.Margin = new Padding(5, 4, 5, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(617, 161);
            txtDescription.TabIndex = 20;
            txtDescription.Text = "";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(482, 254);
            btnEdit.Margin = new Padding(5, 4, 5, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(619, 65);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "GÜNCELLE";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(482, 327);
            btnClear.Margin = new Padding(5, 4, 5, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(619, 65);
            btnClear.TabIndex = 17;
            btnClear.Text = "TEMİZLE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdded
            // 
            btnAdded.Location = new Point(482, 182);
            btnAdded.Margin = new Padding(5, 4, 5, 4);
            btnAdded.Name = "btnAdded";
            btnAdded.Size = new Size(619, 65);
            btnAdded.TabIndex = 19;
            btnAdded.Text = "EKLE";
            btnAdded.UseVisualStyleBackColor = true;
            btnAdded.Click += btnAdded_Click;
            // 
            // listNote
            // 
            listNote.FormattingEnabled = true;
            listNote.ItemHeight = 27;
            listNote.Location = new Point(14, 13);
            listNote.Margin = new Padding(5, 4, 5, 4);
            listNote.Name = "listNote";
            listNote.Size = new Size(458, 463);
            listNote.TabIndex = 15;
            listNote.SelectedIndexChanged += listNote_SelectedIndexChanged;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 480);
            Controls.Add(lblTest);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(btnEdit);
            Controls.Add(btnClear);
            Controls.Add(btnAdded);
            Controls.Add(listNote);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "NotesForm";
            Text = "NotesForm";
            FormClosed += NotesForm_FormClosed;
            Load += NotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTest;
        private Label lblUser;
        private Label label1;
        private RichTextBox txtDescription;
        private Button btnEdit;
        private Button btnClear;
        private Button btnAdded;
        private ListBox listNote;
    }
}