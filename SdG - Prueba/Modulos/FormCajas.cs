using MySql.Data.MySqlClient;
using SdG___Prueba.Clases;
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
    public partial class FormCajas : Form
    {
        private int opcionElegida = 0;
        private string idCajaSel = "";
        public FormCajas()
        {
            InitializeComponent();
        }

        private void FormCajas_Load(object sender, EventArgs e)
        {
            cargarDtvCajas();
        }


        private void cargarDtvCajas()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM caja";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string[] row = {
                                reader.GetInt32("idCaja").ToString(),
                                reader.GetString("nombre"),
                                "$ " + reader.GetFloat("efectivo").ToString()
                            };

                            dtvCajas.Rows.Add(row);
                        }

                        dtvCajas.ClearSelection();
                        limpiarCajas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void limpiarCajas()
        {
            txtIdCaja.Clear();
            txtNombre.Clear();
            numEfectivo.Value = 0;
        }

        private void activarCajas(bool activar)
        {
            groupBox1.Visible = activar;
            dtvCajas.Enabled = !activar;

            btnAceptar.Visible = activar;
            tableLayoutBuscarPor.Enabled = !activar;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtvCajas.Rows.Clear();
            cargarDtvCajas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Nueva caja";
            dtvCajas.ClearSelection();
            limpiarCajas();
            activarCajas(true);
            opcionElegida = 1;
        }

        private void agregarCaja()
        {
            string nombre = txtNombre.Text;
            float efectivoInicial = float.Parse(numEfectivo.Value.ToString());

            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO caja (nombre, efectivo) VALUES (@nombre, @efectivo)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@efectivo", efectivoInicial);


                        if (command.ExecuteNonQuery() == -1)
                        {
                            MessageBox.Show("No se pudo ingresar la nueva caja");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (opcionElegida == 1)
            {
                agregarCaja();
            }
            else if (opcionElegida == 2)
            {
                if (!modificarCaja())
                {
                    MessageBox.Show("No se pudo modificar el producto");
                }
            }

            activarCajas(false);
            limpiarCajas();
            dtvCajas.Rows.Clear();
            cargarDtvCajas();
            opcionElegida = 0;
        }

        private void btnCerrarInfo_Click(object sender, EventArgs e)
        {
            activarCajas(false);
            limpiarCajas();
            dtvCajas.ClearSelection();
            opcionElegida = 0;
        }

        private void dtvCajas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                //BtnModificar
                activarCajas(true);
                opcionElegida = 2;

                DataGridViewRow filaSeleccionada = dtvCajas.CurrentRow;
                idCajaSel = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Caja cajaAMod = buscarCaja(idCajaSel);

                groupBox1.Text = "Modificar caja";
                txtIdCaja.Text = cajaAMod.Id.ToString();
                txtNombre.Text = cajaAMod.Nombre;
                numEfectivo.Value = decimal.Parse(cajaAMod.Efectivo.ToString());
            }
            else if (e.ColumnIndex == 4)
            {
                //BtnBorrar
                DataGridViewRow filaSeleccionada = dtvCajas.CurrentRow;
                idCajaSel = filaSeleccionada.Cells["Codigo"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    "Esta acción eliminará la caja seleccionada.\n\n¿Está seguro?",
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

                            string query = "DELETE FROM caja WHERE idCaja=@idCaja";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@idCaja", idCajaSel);

                                if (command.ExecuteNonQuery() != -1)
                                {
                                    dtvCajas.Rows.Clear();
                                    cargarDtvCajas();
                                    idCajaSel = "";
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

        private Caja buscarCaja(string idCaja)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM caja WHERE idCaja=@id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idCaja);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            MessageBox.Show("No se pudo encontrar la caja");
                            return null;
                        }
                        else
                        {
                            return new Caja(
                                reader.GetInt32("idCaja"),
                                reader.GetString("nombre"),
                                reader.GetFloat("efectivo")
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

        private bool modificarCaja()
        {
            try
            {
                string nombre = txtNombre.Text;
                decimal efectivo = numEfectivo.Value;

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE caja SET nombre=@nombre, efectivo=@efectivo WHERE idCaja=@idCaja";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@efectivo", efectivo);
                        command.Parameters.AddWithValue("@idCaja", idCajaSel);

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
    }
}
