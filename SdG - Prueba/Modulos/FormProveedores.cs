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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SdG___Prueba.Modulos
{
    public partial class FormProveedores : Form
    {
        private string codProvSel = "";
        private int opcionElegida = 0;
        private DataGridView dtvProveedores2;
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void activarCajas(bool activar)
        {
            groupBox1.Visible = activar;
            dtvProveedores.Enabled = !activar;

            //txtCod.Enabled = activar;
            txtRazonSocial.Enabled = activar;
            txtMail.Enabled = activar;
            txtTelefono.Enabled = activar;
            txtCuil.Enabled = activar;
            txtDireccion.Enabled = activar;
            txtPagWeb.Enabled = activar;

            btnAceptar.Visible = activar;
            btnCerrarInfo.Visible = activar;
            btnAgregar.Enabled = !activar;
        }

        private void limpiarCajas()
        {
            txtCod.Clear();
            txtRazonSocial.Clear();
            txtMail.Clear();
            txtTelefono.Clear();
            txtCuil.Clear();
            txtDireccion.Clear();
            txtLocalidad.Clear();
            cbxProvincias.SelectedIndex = -1;
            txtPagWeb.Clear();
            txtBuscar.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Nuevo proveedor";
            dtvProveedores.ClearSelection();
            limpiarCajas();
            activarCajas(true);
            opcionElegida = 1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (opcionElegida == 1)
            {
                agregarProveedor();
            }
            else if (opcionElegida == 2)
            {
                if (!modificarProveedor())
                {
                    MessageBox.Show("No se pudo modificar el producto");
                }
            }

            activarCajas(false);
            limpiarCajas();
            dtvProveedores.Rows.Clear();
            cargarDtvProveedores();
            opcionElegida = 0;
        }

        private void agregarProveedor()
        {
            try
            {
                Proveedor proveedor = new(
                    txtCod.Text,
                    txtRazonSocial.Text,
                    txtMail.Text,
                    txtTelefono.Text,
                    txtCuil.Text,
                    txtDireccion.Text,
                    txtLocalidad.Text,
                    buscarProvincia(cbxProvincias.Text),
                    txtPagWeb.Text
                );

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO proveedor " +
                        "(razonSocial, cuil, mail, telefono, paginaWeb, direccion, localidad, idProvincia)" +
                        " VALUES (@razonSocial, @cuil, @mail, @telefono, @pagWeb, @direccion, @localidad, @idProv)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@razonSocial", proveedor.RazonSocial);
                        command.Parameters.AddWithValue("@cuil", proveedor.Cuil);
                        command.Parameters.AddWithValue("@mail", proveedor.Mail);
                        command.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                        command.Parameters.AddWithValue("@pagWeb", proveedor.PagWeb);
                        command.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                        command.Parameters.AddWithValue("@localidad", proveedor.Localidad);
                        command.Parameters.AddWithValue("@idProv", proveedor.IdProvincia);

                        if (command.ExecuteNonQuery() == -1)
                        {
                            MessageBox.Show("No se pudo ingresar el producto");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargarDtvProveedores()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM proveedor";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        dtvProveedores2.Rows.Clear();

                        while (reader.Read())
                        {
                            string[] row = {
                                reader.GetInt32("idProveedor").ToString(),
                                reader.GetString("razonSocial"),
                                reader.GetString("mail"),
                                reader.GetString("telefono"),
                                reader.GetString("cuil")
                            };

                            dtvProveedores.Rows.Add(row);
                            dtvProveedores2.Rows.Add(row);
                        }

                        dtvProveedores.ClearSelection();
                        limpiarCajas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            crearDtvCopia();
            cargarDtvProveedores();
        }

        private void crearDtvCopia()
        {
            dtvProveedores2 = new DataGridView();

            dtvProveedores2.AllowUserToAddRows = dtvProveedores.AllowUserToAddRows;
            dtvProveedores2.AllowUserToDeleteRows = dtvProveedores.AllowUserToDeleteRows;

            foreach (DataGridViewColumn columna in dtvProveedores.Columns)
            {
                dtvProveedores2.Columns.Add(columna.Clone() as DataGridViewColumn);
            }
        }

        private void dtvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            /*
            if (dtvProveedores.SelectedRows.Count > 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow filaSeleccionada = dtvProveedores.SelectedRows[0];
                codProvSel = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Proveedor proveedor = buscarProveedor(codProvSel);

                txtCod.Text = proveedor.id;
                txtRazonSocial.Text = proveedor.razonSocial;
                txtMail.Text = proveedor.mail;
                txtTelefono.Text = proveedor.telefono;
                txtCuil.Text = proveedor.cuil;
                txtDireccion.Text = proveedor.direccion;
                txtPagWeb.Text = proveedor.pagWeb;
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            */
        }

        private Proveedor buscarProveedor(string idProveedor)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM proveedor WHERE idProveedor=@idProv";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idProv", idProveedor);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            MessageBox.Show("No se pudo encontrar el producto");
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

        private bool modificarProveedor()
        {
            try
            {
                Proveedor proveedor = new(
                    txtCod.Text,
                    txtRazonSocial.Text,
                    txtMail.Text,
                    txtTelefono.Text,
                    txtCuil.Text,
                    txtDireccion.Text,
                    txtLocalidad.Text,
                    buscarProvincia(cbxProvincias.Text),
                    txtPagWeb.Text
                );

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE proveedor " +
                        "SET razonSocial=@razonSocial, mail=@mail, " +
                        "telefono=@telefono, cuil=@cuil, direccion=@direccion, localidad=@localidad, idProvincia=@idProv, paginaWeb=@paginaWeb " +
                        "WHERE idProveedor=@idProveedor";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@razonSocial", proveedor.RazonSocial);
                        command.Parameters.AddWithValue("@mail", proveedor.Mail);
                        command.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                        command.Parameters.AddWithValue("@cuil", proveedor.Cuil);
                        command.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                        command.Parameters.AddWithValue("@localidad", proveedor.Localidad);
                        command.Parameters.AddWithValue("@idProv", proveedor.IdProvincia);
                        command.Parameters.AddWithValue("@paginaWeb", proveedor.PagWeb);
                        command.Parameters.AddWithValue("@idProveedor", codProvSel);

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtvProveedores.Rows.Clear();
            cargarDtvProveedores();
            txtBuscar.Clear();
        }

        private void buscarEnDtv(string texto)
        {
            if (texto.Equals(""))
            {
                dtvProveedores.Rows.Clear();
                cargarDtvProveedores();
            }
            else
            {
                List<DataGridViewRow> filas = [];

                for (int i = 0; i < dtvProveedores2.RowCount; i++)
                {
                    DataGridViewRow fila = dtvProveedores2.Rows[i];
                    if (fila.Cells["RazonSocial"].Value.ToString().Contains(texto))
                    {
                        filas.Add(fila);
                    }
                }

                dtvProveedores.Rows.Clear();

                foreach (DataGridViewRow item in filas)
                {
                    string[] row = {
                                item.Cells["Codigo"].Value.ToString(),
                                item.Cells["RazonSocial"].Value.ToString(),
                                item.Cells["Mail"].Value.ToString(),
                                item.Cells["NroTelefono"].Value.ToString(),
                                item.Cells["Cuil"].Value.ToString()
                    };

                    dtvProveedores.Rows.Add(row);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarEnDtv(txtBuscar.Text);
        }

        private void dtvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                //BtnModificar
                activarCajas(true);
                opcionElegida = 2;

                DataGridViewRow filaSeleccionada = dtvProveedores.CurrentRow;
                codProvSel = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Proveedor proveedor = buscarProveedor(codProvSel);

                groupBox1.Text = "Modificar proveedor";
                txtCod.Text = proveedor.Id;
                txtRazonSocial.Text = proveedor.RazonSocial;
                txtMail.Text = proveedor.Mail;
                txtTelefono.Text = proveedor.Telefono;
                txtCuil.Text = proveedor.Cuil;
                txtDireccion.Text = proveedor.Direccion;
                txtLocalidad.Text = proveedor.Localidad;
                cbxProvincias.Text = buscarProvinciaPorId(proveedor.IdProvincia);
                txtPagWeb.Text = proveedor.PagWeb;
            }
            else if (e.ColumnIndex == 7)
            {
                //BtnBorrar
                DataGridViewRow filaSeleccionada = dtvProveedores.CurrentRow;
                codProvSel = filaSeleccionada.Cells["Codigo"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    "Esta acción eliminará el proveedor seleccionado.\n\n¿Está seguro?",
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

                            string query = "DELETE FROM proveedor WHERE idProveedor=@idProv";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@idProv", codProvSel);

                                if (command.ExecuteNonQuery() != -1)
                                {
                                    dtvProveedores.Rows.Clear();
                                    cargarDtvProveedores();
                                    codProvSel = "";
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
            else if (e.ColumnIndex == 5)
            {
                activarCajas(true);

                btnAceptar.Visible = false;
                btnCerrarInfo.Visible = true;

                txtRazonSocial.ReadOnly = true;
                txtMail.ReadOnly = true;
                txtTelefono.ReadOnly = true;
                txtCuil.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtLocalidad.ReadOnly = true;
                cbxProvincias.Enabled = false;
                txtPagWeb.ReadOnly = true;

                DataGridViewRow filaSeleccionada = dtvProveedores.CurrentRow;
                codProvSel = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Proveedor proveedor = buscarProveedor(codProvSel);

                groupBox1.Text = "Más info";
                txtCod.Text = proveedor.Id;
                txtRazonSocial.Text = proveedor.RazonSocial;
                txtMail.Text = proveedor.Mail;
                txtTelefono.Text = proveedor.Telefono;
                txtCuil.Text = proveedor.Cuil;
                txtDireccion.Text = proveedor.Direccion;
                txtLocalidad.Text = proveedor.Localidad;
                cbxProvincias.Text = buscarProvinciaPorId(proveedor.IdProvincia);
                txtPagWeb.Text = proveedor.PagWeb;
            }
        }

        private void btnCerrarInfo_Click(object sender, EventArgs e)
        {
            if(opcionElegida == 1 || opcionElegida == 2)
            {
                activarCajas(false);
                limpiarCajas();
                dtvProveedores.ClearSelection();
            } else
            {
                btnCerrarInfo.Visible = false;
                activarCajas(false);
                txtRazonSocial.ReadOnly = false;
                txtMail.ReadOnly = false;
                txtTelefono.ReadOnly = false;
                txtCuil.ReadOnly = false;
                txtDireccion.ReadOnly = false;
                txtLocalidad.ReadOnly = false;
                cbxProvincias.Enabled = true;
                txtPagWeb.ReadOnly = false;
            }
            opcionElegida = 0;
        }

        private int buscarProvincia(string provinciaElegida)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM provincia WHERE nombre=@nombreProv";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreProv", provinciaElegida);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return -1;
                        }
                        else
                        {
                            return reader.GetInt32("idProvincia");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1;
            }
        }

        private string buscarProvinciaPorId(int idProvincia)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM provincia WHERE idProvincia=@idProvincia";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idProvincia", idProvincia);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return "";
                        }
                        else
                        {
                            return reader.GetString("nombre");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "";
            }
        }
    }


}
