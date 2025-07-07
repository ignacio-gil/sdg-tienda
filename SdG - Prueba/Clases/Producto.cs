using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Producto(string codigo, int idMarca, string modelo, int cantidad, decimal precioCompra, decimal precioVenta, int idCat)
    {
        public string Codigo { get; set; } = codigo;
        public int IdMarca { get; set; } = idMarca;
        public string Modelo { get; set; } = modelo;
        public int Cantidad { get; set; } = cantidad;
        public decimal PrecioCompra { get; set; } = precioCompra;
        public decimal PrecioVenta { get; set; } = precioVenta;
        public int IdCat { get; set; } = idCat;

        public static string buscarCodigoPorID(int id)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM producto WHERE idProducto=@id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return null;
                        }
                        else
                        {
                            return reader.GetString("codProducto");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
}
