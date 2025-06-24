using MySql.Data.MySqlClient;
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

                //Usuario nuevaUsuario = new Usuario(nombre,clave);

                string connectionString = "Server=localhost;Database=pruebitalogin;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT nombre, clave FROM usuario WHERE nombre = @user AND clave = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@password", password);

                        if (command.ExecuteScalar() == null)
                        {
                            MessageBox.Show("Nombre de usuario y/o contraseña incorrecto.");

                        }
                        else
                        {
                            iniciarFormulario();
                            txtUsuario.Clear();
                            txtPassword.Clear();
                            this.Visible = false;
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
            //FormAdmin formAdmin = new FormAdmin(this);
            //FormPrincipal form = new FormPrincipal(this);
            //formAdmin.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
