namespace WinForms.FullStack2.Forms
{
    partial class NavigationForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnProduct = new Button();
            btnNote = new Button();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(12, 12);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(427, 91);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "ÜRÜN BİLGİSİ";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnNote
            // 
            btnNote.Location = new Point(12, 109);
            btnNote.Name = "btnNote";
            btnNote.Size = new Size(427, 91);
            btnNote.TabIndex = 0;
            btnNote.Text = "ÖZLÜ SÖZLER";
            btnNote.UseVisualStyleBackColor = true;
            btnNote.Click += btnNote_Click;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 214);
            Controls.Add(btnNote);
            Controls.Add(btnProduct);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "NavigationForm";
            Text = "NavigationForm";
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnProduct;
        private Button btnNote;
    }
}