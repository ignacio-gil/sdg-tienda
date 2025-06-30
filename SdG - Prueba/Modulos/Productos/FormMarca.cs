using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SdG___Prueba.Modulos.Productos
{
    public partial class FormMarca : Form
    {
        private string marcaElegida = "";
        private int opcionElegida = 0;
        public FormMarca()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void cargarMarcas()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM marca";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        lstMarcas.Items.Clear();

                        while (reader.Read())
                        {
                            lstMarcas.Items.Add(reader.GetString("nombreMarca"));
                        }

                        lstMarcas.ClearSelected();
                        txtNombre.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarcas.SelectedIndex > -1)
            {
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            lstMarcas.Enabled = false;
            lstMarcas.ClearSelected();
            panelMod.Visible = true;
            opcionElegida = 1;
        }

        private void agregarMarca()
        {
            if (buscarMarca(txtNombre.Text))
            {
                try
                {

                    string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO marca (nombreMarca) VALUES (@nombreMarca)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nombreMarca", txtNombre.Text);

                            if (command.ExecuteNonQuery() == -1)
                            {
                                MessageBox.Show("No se pudo ingresar la marca");
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Marca ya existente");
            }
        }

        private bool buscarMarca(string nuevaMarca)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM marca WHERE nombreMarca=@nuevaMarca";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nuevaMarca", nuevaMarca);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            panelMod.Visible = false;
            opcionElegida = 0;
            marcaElegida = "";
            btnAgregar.Enabled = true;
            lstMarcas.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")) { return; }
            if (opcionElegida == 1)
            {
                agregarMarca();
            }
            else if (opcionElegida == 2)
            {
                modificarMarca();
            }

            txtNombre.Clear();
            panelMod.Visible = false;
            opcionElegida = 0;
            marcaElegida = "";
            btnAgregar.Enabled = true;
            lstMarcas.Enabled = true;
            cargarMarcas();
        }

        private bool modificarMarca()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE marca " +
                        "SET nombreMarca=@nuevoNombre WHERE nombreMarca=@nombreMarca";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nuevoNombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@nombreMarca", marcaElegida);

                        if (command.ExecuteNonQuery() == -1)
                        {
                            return false;
                        }
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            marcaElegida = lstMarcas.SelectedItem.ToString();
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            lstMarcas.Enabled = false;
            lstMarcas.ClearSelected();
            panelMod.Visible = true;
            opcionElegida = 2;
            txtNombre.Text = marcaElegida;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            marcaElegida = marcaElegida = lstMarcas.SelectedItem.ToString();

            DialogResult resultado = MessageBox.Show(
                "Esta acción eliminará la marca seleccionada.\n\n¿Está seguro?",
                "Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
             );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM marca WHERE nombreMarca=@nombreMarca";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nombreMarca", marcaElegida);

                            if (command.ExecuteNonQuery() != -1)
                            {
                                cargarMarcas();
                                btnEditar.Enabled = false;
                                btnBorrar.Enabled = false;
                                marcaElegida = "";
                            }
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
}
