namespace Learn_Data_Grid_View
{
    partial class Produk
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAddProduct = new Button();
            ProductTitle = new Label();
            dataProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataProducts).BeginInit();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(1054, 74);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(124, 35);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Tambah";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // ProductTitle
            // 
            ProductTitle.AutoSize = true;
            ProductTitle.Font = new Font("Poppins SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductTitle.Location = new Point(45, 54);
            ProductTitle.Name = "ProductTitle";
            ProductTitle.Size = new Size(266, 70);
            ProductTitle.TabIndex = 2;
            ProductTitle.Text = "Product List";
            // 
            // dataProducts
            // 
            dataProducts.AllowUserToOrderColumns = true;
            dataProducts.AllowUserToResizeColumns = false;
            dataProducts.AllowUserToResizeRows = false;
            dataProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProducts.BackgroundColor = Color.White;
            dataProducts.BorderStyle = BorderStyle.None;
            dataProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataProducts.ColumnHeadersHeight = 75;
            dataProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataProducts.EnableHeadersVisualStyles = false;
            dataProducts.GridColor = Color.White;
            dataProducts.Location = new Point(57, 127);
            dataProducts.Name = "dataProducts";
            dataProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Gilroy-Regular", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataProducts.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Gilroy-Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 145, 83);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataProducts.RowTemplate.Height = 50;
            dataProducts.ScrollBars = ScrollBars.Vertical;
            dataProducts.Size = new Size(1121, 647);
            dataProducts.TabIndex = 3;
            dataProducts.CellContentClick += dataProducts_CellContentClick;
            // 
            // Produk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 804);
            Controls.Add(dataProducts);
            Controls.Add(ProductTitle);
            Controls.Add(btnAddProduct);
            Name = "Produk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)dataProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddProduct;
        private Label ProductTitle;
        private DataGridView dataProducts;
    }
}