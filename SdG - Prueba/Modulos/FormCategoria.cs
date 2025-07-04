using MySql.Data.MySqlClient;
using SdG___Prueba.Modulos.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SdG___Prueba.Modulos
{

    public partial class FormCategoria : Form
    {
        private string catElegida = "";
        private int opcionElegida = 0;
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM categoria";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        lstCategorias.Items.Clear();

                        while (reader.Read())
                        {
                            lstCategorias.Items.Add(reader.GetString("nombreCat"));
                        }

                        lstCategorias.ClearSelected();
                        txtNombre.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void agregarCategoria()
        {
            if (buscarCategoria(txtNombre.Text))
            {
                try
                {

                    string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO categoria (nombreCat) VALUES (@nombreCat)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nombreCat", txtNombre.Text);

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
                MessageBox.Show("Categoría ya existente");
            }
        }

        private bool buscarCategoria(string nuevaCat)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM categoria WHERE nombreCat=@nuevaMarca";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nuevaMarca", nuevaCat);
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

        private bool modificarCategoria()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE categoria " +
                        "SET nombreCat=@nuevoNombre WHERE nombreCat=@nombreCat";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nuevoNombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@nombreCat", catElegida);

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            lstCategorias.Enabled = false;
            lstCategorias.ClearSelected();
            panelMod.Visible = true;
            opcionElegida = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            catElegida = lstCategorias.SelectedItem.ToString();
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            lstCategorias.Enabled = false;
            lstCategorias.ClearSelected();
            panelMod.Visible = true;
            opcionElegida = 2;
            txtNombre.Text = catElegida;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            catElegida = lstCategorias.SelectedItem.ToString();

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

                        string query = "DELETE FROM categoria WHERE nombreCat=@nombreCat";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nombreCat", catElegida);

                            if (command.ExecuteNonQuery() != -1)
                            {
                                cargarCategorias();
                                btnEditar.Enabled = false;
                                btnBorrar.Enabled = false;
                                catElegida = "";
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

        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedIndex > -1)
            {
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            panelMod.Visible = false;
            opcionElegida = 0;
            catElegida = "";
            btnAgregar.Enabled = true;
            lstCategorias.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")) { return; }
            if (opcionElegida == 1)
            {
                agregarCategoria();
            }
            else if (opcionElegida == 2)
            {
                modificarCategoria();
            }

            txtNombre.Clear();
            panelMod.Visible = false;
            opcionElegida = 0;
            catElegida = "";
            btnAgregar.Enabled = true;
            lstCategorias.Enabled = true;
            cargarCategorias();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
