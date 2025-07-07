using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Detalle(int id, int cantidad, decimal precio, decimal total, 
                         string descripcion, int idProducto, int idCompraVenta)
    {
        public int Id { set; get; } = id;
        public int Cantidad { set; get; } = cantidad;
        public decimal Precio { set; get; } = precio;
        public decimal Total { set; get; } = total;
        public string Descripcion { set; get; } = descripcion;
        public int IdProducto { set; get; } = idProducto;
        public int IdCompraVenta { set; get; } = idCompraVenta;

        public static Detalle buscarDetalleVentaPorId(int idVenta)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM detalleventa WHERE idVenta=@id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idVenta);

                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return null;
                        }
                        else
                        {
                            return new Detalle(
                                reader.GetInt32("idDetalleVenta"),
                                reader.GetInt32("cantidad"),
                                reader.GetDecimal("precioVenta"),
                                reader.GetDecimal("total"),
                                reader.GetString("descripcion"),
                                reader.GetInt32("idVenta"),
                                reader.GetInt32("idProducto")
                            );
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

        public static void cargarDetallesVentaPorId(DataGridView dtv, int idVenta)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM detalleventa WHERE idVenta = @idVenta";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idVenta", idVenta);

                        MySqlDataReader reader = command.ExecuteReader();

                        dtv.Rows.Clear();

                        while (reader.Read())
                        {

                            string[] row = {
                                Producto.buscarCodigoPorID(reader.GetInt32("idProducto")),
                                reader.GetString("descripcion"),
                                reader.GetInt32("cantidad").ToString(),
                                reader.GetDecimal("precioVenta").ToString(),
                                reader.GetDecimal("total").ToString()
                            };

                            dtv.Rows.Add(row);
                        }

                        dtv.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

    
}
