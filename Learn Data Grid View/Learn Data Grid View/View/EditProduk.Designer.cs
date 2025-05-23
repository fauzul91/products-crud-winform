namespace Learn_Data_Grid_View.View
{
    partial class EditProduk
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
            btnBack = new Button();
            btnEdit = new Button();
            textDeskripsi = new TextBox();
            label4 = new Label();
            textHargaProduk = new TextBox();
            label3 = new Label();
            textNamaProduk = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(69, 62);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 17;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(82, 709);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(508, 52);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit Produk";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // textDeskripsi
            // 
            textDeskripsi.Location = new Point(85, 500);
            textDeskripsi.Multiline = true;
            textDeskripsi.Name = "textDeskripsi";
            textDeskripsi.Size = new Size(505, 160);
            textDeskripsi.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 458);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 14;
            label4.Text = "Deskripsi";
            // 
            // textHargaProduk
            // 
            textHargaProduk.Location = new Point(79, 385);
            textHargaProduk.Name = "textHargaProduk";
            textHargaProduk.Size = new Size(505, 31);
            textHargaProduk.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 343);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 12;
            label3.Text = "Harga Produk";
            // 
            // textNamaProduk
            // 
            textNamaProduk.Location = new Point(79, 272);
            textNamaProduk.Name = "textNamaProduk";
            textNamaProduk.Size = new Size(505, 31);
            textNamaProduk.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 230);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 10;
            label2.Text = "Nama Produk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 122);
            label1.Name = "label1";
            label1.Size = new Size(217, 48);
            label1.TabIndex = 9;
            label1.Text = "Edit Produk";
            // 
            // EditProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 823);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(textDeskripsi);
            Controls.Add(label4);
            Controls.Add(textHargaProduk);
            Controls.Add(label3);
            Controls.Add(textNamaProduk);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "EditProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnEdit;
        private TextBox textDeskripsi;
        private Label label4;
        private TextBox textHargaProduk;
        private Label label3;
        private TextBox textNamaProduk;
        private Label label2;
        private Label label1;
    }
}