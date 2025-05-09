using Learn_Data_Grid_View.Controller;
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
using System.Xml.Linq;

namespace Learn_Data_Grid_View
{
    public partial class FormProduk : Form
    {
        private bool isEdit = false;
        private ProductModel currentProduct = null;
        public FormProduk()
        {
            InitializeComponent();            
        }

        public FormProduk(ProductModel produk) : this()
        {
            isEdit = true;
            currentProduct = produk;

            textNamaProduk.Text = produk.nama_produk;
            textHargaProduk.Text = produk.harga.ToString();
            textDeskripsi.Text = produk.deskripsi;

            btnSubmit.Text = "Update Produk";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Produk produk = new Produk();
            produk.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductModel produk = new ProductModel
            {
                nama_produk = textNamaProduk.Text,
                harga = int.Parse(textHargaProduk.Text),
                deskripsi = textDeskripsi.Text
            };

            bool success;

            if (isEdit && currentProduct != null)
            {
                produk.id_produk = currentProduct.id_produk;
                success = Controller.ProductController.Update(produk);
                MessageBox.Show(success ? "Produk berhasil diperbarui." : "Gagal memperbarui produk.");
            }
            else
            {
                success = Controller.ProductController.Insert(produk);
                MessageBox.Show(success ? "Produk berhasil ditambahkan." : "Gagal menambahkan produk.");
            }

            if (success)
            {
                new Produk().Show();
                this.Close();
            }
        }
        private void ClearInput()
        {
            textNamaProduk.Clear();
            textHargaProduk.Clear();
            textDeskripsi.Clear();
        }
    }
}
