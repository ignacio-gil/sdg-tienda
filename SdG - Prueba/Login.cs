using MySql.Data.MySqlClient;
using SdG___Prueba.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SdG___Prueba
{
    public partial class Login : Form
    {
        private Personal personalIngresado;
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUsuario.Text;
                string password = txtPassword.Text;

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM personal WHERE dni=@user AND claveAcceso=@password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@password", password);

                        MySqlDataReader reader = command.ExecuteReader();

                        if (!reader.Read())
                        {
                            MessageBox.Show("Nombre de usuario y/o contraseña incorrecto.");
                        }
                        else
                        {
                            personalIngresado = new(
                                reader.GetInt32("idPersonal"), 
                                reader.GetString("nombre"),
                                reader.GetString("apellido"), 
                                reader.GetInt32("idRol")
                            );

                            iniciarFormulario();
                            txtUsuario.Clear();
                            txtPassword.Clear();
                            this.Visible = false;
                            reader.GetString("nombreRol");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void iniciarFormulario()
        {
            FormPrincipal form = new(personalIngresado);
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
