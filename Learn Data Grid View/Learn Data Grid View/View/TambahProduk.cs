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
    public partial class TambahProduk : Form
    {
        public TambahProduk()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            ProductModel produk = new ProductModel
            {
                nama_produk = textNamaProduk.Text,
                harga = int.Parse(textHargaProduk.Text),
                deskripsi = textDeskripsi.Text
            };

            bool success;

            success = Controller.ProductController.Insert(produk);
            MessageBox.Show(success ? "Produk berhasil ditambahkan." : "Gagal menambahkan produk.");


            if (success)
            {
                new Produk().Show();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Produk produk = new Produk();
            produk.Show();
            this.Hide();
        }
    }
}
