namespace Learn_Data_Grid_View.View
{
    partial class TambahProduk
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
            btnTambah = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 106);
            label1.Name = "label1";
            label1.Size = new Size(285, 48);
            label1.TabIndex = 0;
            label1.Text = "Tambah Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 196);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama Produk";
            // 
            // textNamaProduk
            // 
            textNamaProduk.Location = new Point(71, 238);
            textNamaProduk.Name = "textNamaProduk";
            textNamaProduk.Size = new Size(505, 31);
            textNamaProduk.TabIndex = 2;
            // 
            // textHargaProduk
            // 
            textHargaProduk.Location = new Point(71, 351);
            textHargaProduk.Name = "textHargaProduk";
            textHargaProduk.Size = new Size(505, 31);
            textHargaProduk.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 309);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 3;
            label3.Text = "Harga Produk";
            // 
            // textDeskripsi
            // 
            textDeskripsi.Location = new Point(77, 466);
            textDeskripsi.Multiline = true;
            textDeskripsi.Name = "textDeskripsi";
            textDeskripsi.Size = new Size(505, 160);
            textDeskripsi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 424);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 5;
            label4.Text = "Deskripsi";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(74, 675);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(508, 52);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah Produk";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(61, 28);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 8;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // TambahProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 819);
            Controls.Add(btnBack);
            Controls.Add(btnTambah);
            Controls.Add(textDeskripsi);
            Controls.Add(label4);
            Controls.Add(textHargaProduk);
            Controls.Add(label3);
            Controls.Add(textNamaProduk);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "TambahProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TambahProduk";
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
        private Button btnTambah;
        private Button btnBack;
    }
}