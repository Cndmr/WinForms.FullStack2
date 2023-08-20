namespace WinForms.FullStack2.Forms
{
    partial class ProductsForm
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
            txtStock = new TextBox();
            lblUser = new Label();
            label1 = new Label();
            txtProductName = new RichTextBox();
            btnEdit = new Button();
            btnRemoved = new Button();
            btnAdded = new Button();
            listProduct = new ListBox();
            lblTest = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(673, 216);
            txtStock.Margin = new Padding(5, 4, 5, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(617, 34);
            txtStock.TabIndex = 14;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(1016, 545);
            lblUser.Margin = new Padding(5, 0, 5, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 22);
            lblUser.TabIndex = 13;
            lblUser.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(670, 545);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 12;
            label1.Text = "Giriş Yapan Kullanıcı:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(673, 31);
            txtProductName.Margin = new Padding(5, 4, 5, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(617, 161);
            txtProductName.TabIndex = 11;
            txtProductName.Text = "";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(673, 330);
            btnEdit.Margin = new Padding(5, 4, 5, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(619, 65);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "GÜNCELLE";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemoved
            // 
            btnRemoved.Location = new Point(673, 403);
            btnRemoved.Margin = new Padding(5, 4, 5, 4);
            btnRemoved.Name = "btnRemoved";
            btnRemoved.Size = new Size(619, 65);
            btnRemoved.TabIndex = 9;
            btnRemoved.Text = "SİL";
            btnRemoved.UseVisualStyleBackColor = true;
            btnRemoved.Click += btnRemoved_Click;
            // 
            // btnAdded
            // 
            btnAdded.Location = new Point(673, 258);
            btnAdded.Margin = new Padding(5, 4, 5, 4);
            btnAdded.Name = "btnAdded";
            btnAdded.Size = new Size(619, 65);
            btnAdded.TabIndex = 10;
            btnAdded.Text = "EKLE";
            btnAdded.UseVisualStyleBackColor = true;
            btnAdded.Click += btnAdded_Click;
            // 
            // listProduct
            // 
            listProduct.FormattingEnabled = true;
            listProduct.ItemHeight = 27;
            listProduct.Location = new Point(8, 31);
            listProduct.Margin = new Padding(5, 4, 5, 4);
            listProduct.Name = "listProduct";
            listProduct.Size = new Size(652, 571);
            listProduct.TabIndex = 7;
            listProduct.SelectedIndexChanged += listNote_SelectedIndexChanged_1;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTest.Location = new Point(1016, 579);
            lblTest.Margin = new Padding(5, 0, 5, 0);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(70, 22);
            lblTest.TabIndex = 13;
            lblTest.Text = "label2";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(667, 476);
            btnClear.Margin = new Padding(5, 4, 5, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(619, 65);
            btnClear.TabIndex = 9;
            btnClear.Text = "TEMİZLE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 608);
            Controls.Add(txtStock);
            Controls.Add(lblTest);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Controls.Add(btnEdit);
            Controls.Add(btnClear);
            Controls.Add(btnRemoved);
            Controls.Add(btnAdded);
            Controls.Add(listProduct);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ProductsForm";
            Text = "ProductsForm";
            FormClosed += ProductsForm_FormClosed;
            Load += ProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStock;
        private Label lblUser;
        private Label label1;
        private RichTextBox txtProductName;
        private Button btnEdit;
        private Button btnRemoved;
        private Button btnAdded;
        private ListBox listProduct;
        private Label lblTest;
        private Button btnClear;
    }
}