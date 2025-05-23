using Learn_Data_Grid_View.Model;
using Learn_Data_Grid_View.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_Data_Grid_View
{
    public partial class Produk : Form
    {
        public Produk()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataProducts.DataSource = Controller.ProductController.GetAllProducts();
            if (!dataProducts.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Edit";
                btnEdit.Name = "Edit";
                btnEdit.Text = "Edit";
                btnEdit.UseColumnTextForButtonValue = true;
                dataProducts.Columns.Add(btnEdit);
            }

            if (!dataProducts.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.HeaderText = "Delete";
                btnDelete.Name = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;
                dataProducts.Columns.Add(btnDelete);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            TambahProduk tambahProduk = new TambahProduk();
            tambahProduk.Show();
            this.Hide();
        }

        private void dataProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataProducts.Rows[e.RowIndex];
                int id_produk = Convert.ToInt32(selectedRow.Cells["id_produk"].Value);
                string nama_produk = selectedRow.Cells["nama_produk"].Value.ToString();
                int harga = Convert.ToInt32(selectedRow.Cells["harga"].Value);
                string deskripsi = selectedRow.Cells["deskripsi"].Value.ToString();

                ProductModel produk = new ProductModel
                {
                    id_produk = id_produk,
                    nama_produk = nama_produk,
                    harga = harga,
                    deskripsi = deskripsi
                };

                if (dataProducts.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    EditProduk formEdit = new EditProduk(produk);
                    formEdit.Show();
                    this.Hide();
                }
                else if (dataProducts.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    var confirm = MessageBox.Show("Yakin ingin menghapus produk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        bool success = Controller.ProductController.DeleteProduk(id_produk);
                        MessageBox.Show(success ? "Produk berhasil dihapus." : "Gagal menghapus produk.");
                        LoadData();
                    }
                }
            }
        }
    }
}
