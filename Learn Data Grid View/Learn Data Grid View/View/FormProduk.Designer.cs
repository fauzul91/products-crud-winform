namespace Learn_Data_Grid_View
{
    partial class FormProduk
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
            label1 = new Label();
            label2 = new Label();
            textNamaProduk = new TextBox();
            textHargaProduk = new TextBox();
            label3 = new Label();
            textDeskripsi = new TextBox();
            label4 = new Label();
            btnBack = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 74);
            label1.Name = "label1";
            label1.Size = new Size(295, 70);
            label1.TabIndex = 0;
            label1.Text = "Form Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 204);
            label2.Name = "label2";
            label2.Size = new Size(179, 42);
            label2.TabIndex = 1;
            label2.Text = "Nama Produk";
            // 
            // textNamaProduk
            // 
            textNamaProduk.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNamaProduk.Location = new Point(129, 259);
            textNamaProduk.Name = "textNamaProduk";
            textNamaProduk.Size = new Size(571, 43);
            textNamaProduk.TabIndex = 2;
            // 
            // textHargaProduk
            // 
            textHargaProduk.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textHargaProduk.Location = new Point(129, 391);
            textHargaProduk.Name = "textHargaProduk";
            textHargaProduk.Size = new Size(578, 43);
            textHargaProduk.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 346);
            label3.Name = "label3";
            label3.Size = new Size(179, 42);
            label3.TabIndex = 3;
            label3.Text = "Harga Produk";
            // 
            // textDeskripsi
            // 
            textDeskripsi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDeskripsi.Location = new Point(129, 509);
            textDeskripsi.Multiline = true;
            textDeskripsi.Name = "textDeskripsi";
            textDeskripsi.Size = new Size(578, 160);
            textDeskripsi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(120, 464);
            label4.Name = "label4";
            label4.Size = new Size(125, 42);
            label4.TabIndex = 5;
            label4.Text = "Deskripsi";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(31, 46);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(129, 714);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(578, 47);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Tambah Produk";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FormProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 802);
            Controls.Add(btnSubmit);
            Controls.Add(btnBack);
            Controls.Add(textDeskripsi);
            Controls.Add(label4);
            Controls.Add(textHargaProduk);
            Controls.Add(label3);
            Controls.Add(textNamaProduk);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Produk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textNamaProduk;
        private TextBox textHargaProduk;
        private Label label3;
        private TextBox textDeskripsi;
        private Label label4;
        private Button btnBack;
        private Button btnSubmit;
    }
}