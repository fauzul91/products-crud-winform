using Learn_Data_Grid_View.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_Data_Grid_View.View
{
    public partial class EditProduk : Form
    {
        private ProductModel currentProduct = null;

        public EditProduk(ProductModel produk)
        {
            InitializeComponent();
            currentProduct = produk;
            textNamaProduk.Text = produk.nama_produk;
            textHargaProduk.Text = produk.harga.ToString();
            textDeskripsi.Text = produk.deskripsi;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductModel produk = new ProductModel
            {
                id_produk = currentProduct.id_produk,
                nama_produk = textNamaProduk.Text,
                harga = int.Parse(textHargaProduk.Text),
                deskripsi = textDeskripsi.Text
            };

            if (currentProduct == null)
            {
                MessageBox.Show("Produk tidak ditemukan.");
            }

            if (string.IsNullOrEmpty(produk.nama_produk) || string.IsNullOrEmpty(produk.deskripsi))
            {
                MessageBox.Show("Nama produk dan deskripsi tidak boleh kosong.");
                return;
            }

            if (produk.harga <= 0)
            {
                MessageBox.Show("Harga produk harus lebih dari 0.");
                return;
            }

            bool success = Controller.ProductController.Update(produk);
            MessageBox.Show(success ? "Produk berhasil diperbarui." : "Gagal memperbarui produk.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Produk produk = new Produk();
            produk.Show();
            this.Hide();
        }
    }
}
