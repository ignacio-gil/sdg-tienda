using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Proveedor(string id, string razonSocial, string mail, string telefono, string cuil, string direccion, string localidad, int idProvincia, string pagWeb)
    {
        public string Id { get; set; } = id;
        public string RazonSocial { get; set; } = razonSocial;
        public string Mail { get; set; } = mail;
        public string Telefono { get; set; } = telefono;
        public string Cuil { get; set; } = cuil;
        public string Direccion { get; set; } = direccion;
        public string Localidad { get; set; } = localidad;
        public int IdProvincia { get; set; } = idProvincia;
        public string PagWeb { get; set; } = pagWeb;

        public static Proveedor buscarProveedorPorCuil(string cuilProveedorABuscar)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM proveedor WHERE cuil=@cuil";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cuil", cuilProveedorABuscar);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return null;
                        }
                        else
                        {
                            return new Proveedor(
                                reader.GetInt32("idProveedor").ToString(),
                                reader.GetString("razonSocial"),
                                reader.GetString("mail"),
                                reader.GetString("telefono"),
                                reader.GetString("cuil"),
                                reader.GetString("direccion"),
                                reader.GetString("localidad"),
                                reader.GetInt32("idProvincia"),
                                reader.GetString("paginaWeb")
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
