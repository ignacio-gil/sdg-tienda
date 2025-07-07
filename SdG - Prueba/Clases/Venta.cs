using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SdG___Prueba.Clases
{
    public class Venta(int id, DateOnly fecha, TimeOnly hora, decimal importeTotal, decimal importePagado, 
                       decimal importeCambio, int idPersonal, int idCliente, int idCaja)
    {
        public int Id { set; get; } = id;
        public DateOnly Fecha { set; get; } = fecha;
        public TimeOnly Hora { set; get; } = hora;
        public decimal ImporteTotal { set; get; } = importeTotal;
        public decimal ImportePagado { set; get; } = importePagado;
        public decimal ImporteCambio { set; get; } = importeCambio;
        public int IdPersonal { set; get; } = idPersonal;
        public int IdCliente { set; get; } = idCliente;
        public int IdCaja { set; get; } = idCaja;

        public static Venta buscarVentaPorId(int id)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM venta WHERE idVenta=@id";

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
                            return new Venta(
                                reader.GetInt32("idVenta"),
                                DateOnly.FromDateTime(reader.GetDateTime("fechaVenta")),
                                TimeOnly.FromTimeSpan(reader.GetTimeSpan("horaVenta")),
                                reader.GetDecimal("importeTotal"),
                                reader.GetDecimal("importePagado"),
                                reader.GetDecimal("importeCambio"),
                                reader.GetInt32("idPersonal"),
                                reader.GetInt32("idCliente"),
                                reader.GetInt32("idCaja")
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
    }

    


}
