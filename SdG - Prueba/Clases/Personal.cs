using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Personal : Persona
    {
        public int IdRol { get; set; }
        public string ClaveAcceso { get; set; }

        public Personal(int idPersonal, string nombre,
                          string apellido, string dni,
                          DateTime fechaNacimiento, string nroTelefono,
                          string mail, string direccion, string localidad,
                          int idProvincia, int idRol, string claveAcceso)
                            : 
                          base(idPersonal, nombre, apellido, dni,
                          fechaNacimiento, nroTelefono,
                          mail, direccion, localidad, idProvincia)
        {
            IdRol = idRol;
            ClaveAcceso = claveAcceso;
        }

        public Personal(int idPersonal, string nombre, string apellido, int idRol)
                : base(idPersonal, nombre, apellido)
        {
            IdRol = idRol;
        }

        public static Personal buscarPersonalPorId(int id)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM personal WHERE idPersonal=@id";

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
                            return new Personal(
                                reader.GetInt32("idPersonal"),
                                reader.GetString("nombre"),
                                reader.GetString("apellido"),
                                reader.GetInt32("idRol")
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

        public static string buscarNombreRol(int id)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM rol WHERE idRol=@id";

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
                            return reader.GetString("nombreRol");
                                
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
