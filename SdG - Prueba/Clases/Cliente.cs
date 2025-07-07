using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Cliente : Persona
    {
        public Cliente(int idCliente, string nombre,
                          string apellido, string dni,
                          DateTime fechaNacimiento, string nroTelefono,
                          string mail, string direccion, string localidad, int idProvincia)
                        :
                        base(idCliente, nombre, apellido, dni, fechaNacimiento,
                            nroTelefono, mail, direccion, localidad, idProvincia)
        {
        }

        public static Cliente buscarClientePorId(int id)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM cliente WHERE idCliente=@id";

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
                            return new Cliente(
                                reader.GetInt32("idCliente"),
                                reader.GetString("nombre"),
                                reader.GetString("apellido"),
                                reader.GetString("dni"),
                                reader.GetDateTime("fechaNacimiento"),
                                reader.GetString("nroTelefono"),
                                reader.GetString("email"),
                                reader.GetString("direccion"),
                                reader.GetString("localidad"),
                                reader.GetInt32("idProvincia")
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
