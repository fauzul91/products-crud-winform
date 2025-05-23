using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_Data_Grid_View.Model;
using Npgsql;

namespace Learn_Data_Grid_View.Controller
{
    class ProductController
    {
        public static List<ProductModel> GetAllProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM products";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductModel produk = new ProductModel
                            {
                                id_produk = reader.GetInt32(0),
                                nama_produk = reader.GetString(1),
                                harga = reader.GetInt32(2),
                                deskripsi = reader.GetString(3)
                            };
                            products.Add(produk);
                        }
                    }
                }
                Database.CloseConnection();
            }
            return products;
        }

        public static bool Insert(ProductModel produk)
        {
            string query = "INSERT INTO products(nama_produk, harga, deskripsi) VALUES (@name, @harga, @deskripsi)";
            
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", produk.nama_produk);
                        cmd.Parameters.AddWithValue("@harga", produk.harga);
                        cmd.Parameters.AddWithValue("@deskripsi", produk.deskripsi);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }

        public static bool Update(ProductModel produk)
        {
            string query = "UPDATE products SET nama_produk=@name, harga=@harga, deskripsi=@deskripsi WHERE id_produk=@id_produk";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", produk.nama_produk);
                        cmd.Parameters.AddWithValue("@harga", produk.harga);
                        cmd.Parameters.AddWithValue("@deskripsi", produk.deskripsi);
                        cmd.Parameters.AddWithValue("@id_produk", produk.id_produk);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;                
            }
            finally
            {
                Database.CloseConnection();
            }
        }

        public static bool DeleteProduk(int id_produk)
        {
            string query = "DELETE FROM products WHERE id_produk = @id_produk";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_produk", id_produk);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }
    }
}
