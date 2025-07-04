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

    public partial class FormClientes : Form
    {
        private int opcionElegida = 0;
        private string codClienteSel = "";
        public FormClientes()
        {
            InitializeComponent();
        }

        private void limpiarCajas()
        {
            txtCod.Clear();
            txtDni.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            dateFechaNacimiento.Refresh();
            txtTelefono.Clear();
            txtMail.Clear();
            txtDireccion.Clear();
            txtLocalidad.Clear();
            cbxProvincias.SelectedIndex = -1;
        }

        private void activarCajas(bool activar)
        {
            groupBox1.Visible = activar;
            dtvClientes.Enabled = !activar;

            btnAceptar.Visible = activar;
            tableLayoutBuscarPor.Enabled = !activar;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            cargarDtvClientes();
            cbxBuscarPor.SelectedIndex = 0;
        }

        private void cargarDtvClientes()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM cliente";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string[] row = {
                                reader.GetInt32("idCliente").ToString(),
                                reader.GetString("apellido") + ", " +reader.GetString("nombre"),
                                reader.GetString("dni"),
                                reader.GetString("nroTelefono"),
                                reader.GetString("direccion") + ", " + reader.GetString("localidad")
                            };

                            dtvClientes.Rows.Add(row);
                        }

                        dtvClientes.ClearSelection();
                        limpiarCajas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Nuevo cliente";
            dtvClientes.ClearSelection();
            limpiarCajas();
            activarCajas(true);
            opcionElegida = 1;
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

        private void agregarCliente()
        {
            Cliente cliente = new(
                    0,
                    txtNombre.Text,
                    txtApellidos.Text,
                    txtDni.Text,
                    dateFechaNacimiento.Value,
                    txtTelefono.Text,
                    txtMail.Text,
                    txtDireccion.Text,
                    txtLocalidad.Text,
                    buscarProvincia(cbxProvincias.Text)
            );

            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO cliente " +
                        "(nombre, apellido, dni, fechaNacimiento, nroTelefono, email, direccion, localidad, idProvincia)" +
                        " VALUES (@nombre, @apellido, @dni, @fechaNacimiento, @nroTelefono, @email, @direccion, @localidad, @idProv)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                        command.Parameters.AddWithValue("@dni", cliente.Dni);
                        command.Parameters.AddWithValue("@fechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@nroTelefono", cliente.NroTelefono);
                        command.Parameters.AddWithValue("@email", cliente.Mail);
                        command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                        command.Parameters.AddWithValue("@localidad", cliente.Localidad);
                        command.Parameters.AddWithValue("@idProv", cliente.IdProvincia);

                        if (command.ExecuteNonQuery() == -1)
                        {
                            MessageBox.Show("No se pudo ingresar el cliente");
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
                agregarCliente();
            }
            else if (opcionElegida == 2)
            {

                if (!modificarCliente())
                {
                    MessageBox.Show("No se pudo modificar el producto");
                }

            }

            activarCajas(false);
            limpiarCajas();
            dtvClientes.Rows.Clear();
            cargarDtvClientes();
            opcionElegida = 0;
        }

        private void btnCerrarInfo_Click(object sender, EventArgs e)
        {
            activarCajas(false);
            if (opcionElegida == 1 || opcionElegida == 2)
            {
                limpiarCajas();
                dtvClientes.ClearSelection();
            }
            else
            {
                dateFechaNacimiento.Enabled = true;
                txtDni.ReadOnly = false;
                txtNombre.ReadOnly = false;
                txtApellidos.ReadOnly = false;
                dateFechaNacimiento.Enabled = true;
                txtTelefono.ReadOnly = false;
                txtMail.ReadOnly = false;
                txtDireccion.ReadOnly = false;
                txtLocalidad.ReadOnly = false;
                cbxProvincias.Enabled = true;
                btnAceptar.Visible = true;
            }
            opcionElegida = 0;
        }

        private void dtvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                //BtnModificar
                activarCajas(true);
                opcionElegida = 2;

                DataGridViewRow filaSeleccionada = dtvClientes.CurrentRow;
                codClienteSel = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Cliente clienteAMod = buscarCliente(codClienteSel);

                groupBox1.Text = "Modificar cliente";
                rellenarDatosCajas(clienteAMod);
            }
            else if (e.ColumnIndex == 7)
            {
                //BtnBorrar
                DataGridViewRow filaSeleccionada = dtvClientes.CurrentRow;
                codClienteSel = filaSeleccionada.Cells["Codigo"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    "Esta acción eliminará el cliente seleccionado.\n\n¿Está seguro?",
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

                            string query = "DELETE FROM cliente WHERE idCliente=@idCliente";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@idCliente", codClienteSel);

                                if (command.ExecuteNonQuery() != -1)
                                {
                                    dtvClientes.Rows.Clear();
                                    cargarDtvClientes();
                                    codClienteSel = "";
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
                //BtnMasInfo
                activarCajas(true);

                txtDni.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtApellidos.ReadOnly = true;
                dateFechaNacimiento.Enabled = false;
                txtTelefono.ReadOnly = true;
                txtMail.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtLocalidad.ReadOnly = true;
                cbxProvincias.Enabled = false;
                btnAceptar.Visible = false;

                DataGridViewRow filaSeleccionada = dtvClientes.CurrentRow;
                codClienteSel = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Cliente clienteInfo = buscarCliente(codClienteSel);

                groupBox1.Text = "Más info";
                rellenarDatosCajas(clienteInfo);
            }

        }

        private Cliente buscarCliente(string clienteABuscar)
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
                        command.Parameters.AddWithValue("@id", clienteABuscar);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            MessageBox.Show("No se pudo encontrar el cliente");
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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtvClientes.Rows.Clear();
            cargarDtvClientes();
        }

        private bool modificarCliente()
        {
            try
            {
                Cliente cliente = new(
                    0,
                    txtNombre.Text,
                    txtApellidos.Text,
                    txtDni.Text,
                    dateFechaNacimiento.Value,
                    txtTelefono.Text,
                    txtMail.Text,
                    txtDireccion.Text,
                    txtLocalidad.Text,
                    buscarProvincia(cbxProvincias.Text)
                );

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE cliente " +
                        "SET nombre=@nombre, apellido=@apellido, dni=@dni, " +
                        "fechaNacimiento=@fechaNacimiento, nroTelefono=@nroTelefono, email=@email, " +
                        "direccion=@direccion, localidad=@localidad, idProvincia=@idProvincia " +
                        "WHERE idCliente=@idCliente";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                        command.Parameters.AddWithValue("@dni", cliente.Dni);
                        command.Parameters.AddWithValue("@fechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@nroTelefono", cliente.NroTelefono);
                        command.Parameters.AddWithValue("@email", cliente.Mail);
                        command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                        command.Parameters.AddWithValue("@localidad", cliente.Localidad);
                        command.Parameters.AddWithValue("@idProvincia", cliente.IdProvincia);
                        command.Parameters.AddWithValue("@idCliente", codClienteSel);

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

        private void rellenarDatosCajas(Cliente cliente)
        {
            txtCod.Text = cliente.Id.ToString();
            txtDni.Text = cliente.Dni;
            txtNombre.Text = cliente.Nombre;
            txtApellidos.Text = cliente.Apellido;
            dateFechaNacimiento.Value = cliente.FechaNacimiento;
            txtTelefono.Text = cliente.NroTelefono;
            txtMail.Text = cliente.Mail;
            txtDireccion.Text = cliente.Direccion;
            txtLocalidad.Text = cliente.Localidad;
            cbxProvincias.Text = buscarProvinciaPorId(cliente.IdProvincia);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columnaABuscar = "";

            switch (cbxBuscarPor.SelectedIndex)
            {
                case 0: columnaABuscar = "IdCliente"; break;
                case 1: columnaABuscar = "dni"; break;
                case 2: columnaABuscar = "nombre"; break;
                case 3: columnaABuscar = "apellido"; break;
                default: break;
            }
            buscarPor(txtBuscar.Text, columnaABuscar);
        }

        private void buscarPor(string texto, string item)
        {
            if (texto.Equals(""))
            {
                dtvClientes.Rows.Clear();
                cargarDtvClientes();
            }
            else
            {
                try
                {
                    string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT * FROM cliente WHERE "+item+" like @texto";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@item", item);
                            command.Parameters.AddWithValue("@texto", "%" + texto + "%");
                            MySqlDataReader reader = command.ExecuteReader();

                            dtvClientes.Rows.Clear();

                            while (reader.Read())
                            {
                                string[] row = {
                                    reader.GetInt32("idCliente").ToString(),
                                    reader.GetString("apellido") + ", " +reader.GetString("nombre"),
                                    reader.GetString("dni"),
                                    reader.GetString("nroTelefono"),
                                    reader.GetString("direccion") + ", " + reader.GetString("localidad")
                                };
                                

                                dtvClientes.Rows.Add(row);
                            }

                            dtvClientes.ClearSelection();
                            limpiarCajas();
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
