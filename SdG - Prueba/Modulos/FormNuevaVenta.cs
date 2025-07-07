using MySql.Data.MySqlClient;
using SdG___Prueba.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SdG___Prueba.Modulos
{
    public partial class FormNuevaVenta : Form
    {
        private string codProdSel = "";
        private Personal personal;
        private Cliente cliente;
        private decimal totalPagar = 0;
        public FormNuevaVenta()
        {
            InitializeComponent();
        }

        private void FormNuevaVenta_Load(object sender, EventArgs e)
        {
            cbxBuscarPor.SelectedIndex = 0;
            numTotalPagado.Minimum = 0;

            rellenarDatosPersonal();
            cargarDtvProductos();
            cargarFecha();
            cargarCajas();
        }

        //Datos del Personal
        private void rellenarDatosPersonal()
        {
            personal = ((FormPrincipal)this.MdiParent).personal;
            txtIdPersonal.Text = personal.Id.ToString();
            txtPersonalNombre.Text = personal.Apellido + ", " + personal.Nombre;
            txtRol.Text = buscarRolPorId(personal.IdRol);
        }
        private string buscarRolPorId(int idRol)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM rol WHERE idRol=@idRol";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idRol", idRol);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return "";
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
                return "";
            }
        }

        //Productos en Stock
        private void cargarDtvProductos()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT p.codProducto, m.nombreMarca,  p.modelo, c.nombreCat, p.cantidadStock, p.precioCompra, p.precioVenta " +
                        "FROM producto AS p INNER JOIN marca AS m ON p.idMarca = m.idMarca " +
                        "INNER JOIN categoria AS c ON p.idCategoria = c.idCategoria WHERE p.cantidadStock>0";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        dtvProductos.Rows.Clear();

                        while (reader.Read())
                        {

                            string[] row = {
                                reader.GetString("codProducto"),
                                reader.GetString("nombreMarca") + " " + reader.GetString("modelo"),
                                reader.GetInt32("cantidadStock").ToString(),
                                reader.GetDecimal("precioVenta").ToString()
                            };

                            dtvProductos.Rows.Add(row);
                        }

                        dtvProductos.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDtvProductos();
            txtBuscar.Clear();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columnaABuscar = "";

            switch (cbxBuscarPor.SelectedIndex)
            {
                case 0: columnaABuscar = "codProducto"; break;
                case 1: columnaABuscar = "nombreMarca"; break;
                case 2: columnaABuscar = "modelo"; break;
                default: break;
            }
            buscarPor(txtBuscar.Text, columnaABuscar);
        }
        private void buscarPor(string texto, string item)
        {
            if (texto.Equals(""))
            {
                cargarDtvProductos();
            }
            else
            {
                try
                {
                    string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT p.codProducto, m.nombreMarca,  p.modelo, c.nombreCat, p.cantidadStock, p.precioCompra, p.precioVenta " +
                            "FROM producto AS p INNER JOIN marca AS m ON p.idMarca = m.idMarca " +
                            "INNER JOIN categoria AS c ON p.idCategoria = c.idCategoria " +
                            "WHERE " + item + " like @texto AND p.cantidadStock>0";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@texto", "%" + texto + "%");
                            MySqlDataReader reader = command.ExecuteReader();

                            dtvProductos.Rows.Clear();

                            while (reader.Read())
                            {

                                string[] row = {
                                    reader.GetString("codProducto"),
                                    reader.GetString("nombreMarca") + " " + reader.GetString("modelo"),
                                    reader.GetInt32("cantidadStock").ToString(),
                                    reader.GetDecimal("precioVenta").ToString()
                                };

                                dtvProductos.Rows.Add(row);
                            }

                            dtvProductos.ClearSelection();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dtvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow filaSeleccionada = dtvProductos.CurrentRow;

                string[] fila = {
                                filaSeleccionada.Cells["Codigo"].Value.ToString(),
                                filaSeleccionada.Cells["Descripcion"].Value.ToString(),
                                "1",
                                filaSeleccionada.Cells["Precio"].Value.ToString(),
                                filaSeleccionada.Cells["Precio"].Value.ToString()
                };

                //Controlar que no exista
                bool existe = false;
                for (int i = 0; i < dtvPedido.Rows.Count; i++)
                {
                    DataGridViewRow row = dtvPedido.Rows[i];
                    if (row.Cells[0].Value.ToString() == fila[0])
                    {
                        existe = true;
                    }
                }

                if (!existe) { dtvPedido.Rows.Add(fila); actualizarTotalPagar(); }
            }
        }

        //Lista del Pedido
        private void dtvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && dtvPedido.Rows.Count > 0)
            {
                panelEditar.Enabled = true;
                dtvPedido.Enabled = false;

                DataGridViewRow filaSeleccionada = dtvPedido.CurrentRow;
                txtProductoPedido.Text = filaSeleccionada.Cells[1].Value.ToString();
                numCantidadProducto.Value = Convert.ToInt32(filaSeleccionada.Cells[2].Value.ToString());

                codProdSel = filaSeleccionada.Cells[0].Value.ToString();

                int cantidadProd = cantidadDisponible();
                lblCantidadStock.Text = cantidadProd.ToString();
                numCantidadProducto.Maximum = cantidadProd;
            }
            else if (e.ColumnIndex == 6 && dtvPedido.Rows.Count > 0)
            {
                //BtnBorrar
                dtvPedido.Rows.RemoveAt(e.RowIndex);
                actualizarTotalPagar();
            }
        }
        private int cantidadDisponible()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM producto WHERE codProducto=@cod";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod", codProdSel);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            MessageBox.Show("No se pudo encontrar el producto");
                            return 0;
                        }
                        else
                        {
                            return reader.GetInt32("cantidadStock");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
        }
        private void btnCancelarCambio_Click(object sender, EventArgs e)
        {
            panelEditar.Enabled = false;
            dtvPedido.Enabled = true;
            dtvPedido.ClearSelection();

            txtProductoPedido.Clear();
            numCantidadProducto.Value = 0;

            codProdSel = "";
            lblCantidadStock.Text = "0";
            numCantidadProducto.Maximum = 1000;
        }
        private void btnCambiarCantidad_Click(object sender, EventArgs e)
        {
            dtvPedido.CurrentRow.Cells[2].Value = numCantidadProducto.Value.ToString();

            decimal subtotalActual = decimal.Parse(dtvPedido.CurrentRow.Cells[3].Value.ToString());
            dtvPedido.CurrentRow.Cells[4].Value = subtotalActual * numCantidadProducto.Value;
            actualizarTotalPagar();
            btnCancelarCambio_Click(this, new EventArgs());
        }

        //Datos del Cliente
        private Cliente buscarCliente(string dniClienteABuscar)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM cliente WHERE dni=@dni";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dni", dniClienteABuscar);
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
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            cliente = buscarCliente(txtClienteDni.Text);

            if (cliente != null)
            {
                txtClienteDni.ReadOnly = true;
                btnBuscarCliente.Enabled = false;
                btnCancelarCliente.Enabled = true;

                txtClienteNombre.Text = cliente.Apellido + ", " + cliente.Nombre;
                txtClienteDireccion.Text = cliente.Direccion + ", " + cliente.Localidad;
                txtClienteMail.Text = cliente.Mail;
            }
            else
            {
                MessageBox.Show("No existe un cliente con ese DNI.");
            }
        }
        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            txtClienteDni.ReadOnly = false;
            btnBuscarCliente.Enabled = true;
            btnCancelarCliente.Enabled = false;

            txtClienteNombre.Clear();
            txtClienteDireccion.Clear();
            txtClienteMail.Clear();

            cliente = null;
        }

        //Datos de la Venta
        private void cargarFecha()
        {
            txtFecha.Text = DateTime.Today.ToShortDateString();
        }
        private void cargarCajas()
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

                        cbxCajas.Items.Clear();

                        while (reader.Read())
                        {
                            cbxCajas.Items.Add(reader.GetString("nombre"));
                        }

                        cbxCajas.SelectedIndex = (cbxCajas.Items.Count > 0) ? 0 : -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void actualizarTotalPagar()
        {
            totalPagar = 0;
            for (int i = 0; i < dtvPedido.Rows.Count; i++)
            {
                DataGridViewRow row = dtvPedido.Rows[i];
                string valorCelda = row.Cells[4].Value.ToString();
                decimal valorSubtotal = decimal.Parse(valorCelda);
                totalPagar += valorSubtotal;
            }

            numTotalPagado.Minimum = totalPagar;
            numTotalPagado.Value = totalPagar;
            lblTotalPagar.Text = "TOTAL A PAGAR: $" + totalPagar;

        }
        private void numTotalPagado_ValueChanged(object sender, EventArgs e)
        {
            if (numTotalPagado.Value >= totalPagar)
            {
                numCambioDevuelto.Value = numTotalPagado.Value - totalPagar;
            }
        }
        private int buscarCaja(string nombre)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM caja WHERE nombre=@nombre";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return -1;
                        }
                        else
                        {
                            return reader.GetInt32("idCaja");
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

        //Limpiar todo
        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {

            dtvPedido.Rows.Clear();
            btnCancelarCambio_Click(this, new EventArgs());
            btnActualizar_Click(this, new EventArgs());
            btnCancelarCliente_Click(this, new EventArgs());
            txtClienteDni.Clear();
            actualizarTotalPagar();

        }


        //Registrar venta
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DateOnly dateOnly = new();
                TimeOnly timeOnly = new();
                Venta nuevaVenta = new(
                    0,
                    dateOnly,
                    timeOnly,
                    totalPagar,
                    numTotalPagado.Value,
                    numCambioDevuelto.Value,
                    personal.Id,
                    cliente.Id,
                    buscarCaja(cbxCajas.SelectedItem.ToString())
                );

                int idRegistro = registrarVenta(nuevaVenta);
                if (idRegistro != -1)
                {
                    MessageBox.Show("Venta registrada");

                    //Registrar detalles venta
                    registrarVentaProductos(idRegistro);
                    actualizarSaldoCaja(nuevaVenta.IdCaja, nuevaVenta.ImporteTotal);

                    btnLimpiarTodo_Click(this, new EventArgs());
                }

            }
            else
            {
                MessageBox.Show("Hay campos sin completar.");
            }
        }
        private bool validarCampos()
        {
            return (!txtIdPersonal.Text.Equals("")) && !(dtvPedido.Rows.Count == 0) && (!txtClienteNombre.Text.Equals(""));
        }
        private int registrarVenta(Venta nuevaVenta)
        {
            try
            {
                int idRegistro = -1;

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    

                    connection.Open();

                    string query = "INSERT INTO venta (fechaVenta, horaVenta, importeTotal, importePagado, " +
                                   "importeCambio, idPersonal, idCliente, idCaja) VALUES (CURRENT_DATE(), CURRENT_TIME(), " +
                                   "@importeTotal, @importePagado, @importeCambio, @idPersonal, @idCliente,@idCaja); " +
                                   "SELECT LAST_INSERT_ID() AS ID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@importeTotal", nuevaVenta.ImporteTotal);
                        command.Parameters.AddWithValue("@importePagado", nuevaVenta.ImportePagado);
                        command.Parameters.AddWithValue("@importeCambio", nuevaVenta.ImporteCambio);
                        command.Parameters.AddWithValue("@idPersonal", nuevaVenta.IdPersonal);
                        command.Parameters.AddWithValue("@idCliente", nuevaVenta.IdCliente);
                        command.Parameters.AddWithValue("@idCaja", nuevaVenta.IdCaja);


                        idRegistro = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

                return idRegistro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1;
            }

        }
        private bool registrarDetalleVenta(Detalle detalle)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query1 = "INSERT INTO venta (fechaVenta, horaVenta, importeTotal, importePagado, " +
                                   "importeCambio, idPersonal, idCliente, idCaja) VALUES (CURRENT_DATE(), CURRENT_TIME(), " +
                                   "@importeTotal, @importePagado, @importeCambio, @idPersonal, @idCliente,@idCaja)";

                    string query = "INSERT INTO detalleventa (cantidad, precioVenta, total, descripcion, idVenta, idProducto) " +
                        "VALUES (@cantidad, @precioVenta, @total, @descripcion, @idVenta, @idProducto)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        command.Parameters.AddWithValue("@precioVenta", detalle.Precio);
                        command.Parameters.AddWithValue("@total", detalle.Total);
                        command.Parameters.AddWithValue("@descripcion", detalle.Descripcion);
                        command.Parameters.AddWithValue("@idVenta", detalle.IdCompraVenta);
                        command.Parameters.AddWithValue("@idProducto", detalle.IdProducto);

                        if (command.ExecuteNonQuery() == -1)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        private bool actualizarCantidadProducto(Detalle detalle)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE producto SET cantidadStock = cantidadStock - @cantidad WHERE idProducto=@idProducto";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        command.Parameters.AddWithValue("@idProducto", detalle.IdProducto);

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
        private bool registrarVentaProductos(int idVenta)
        {
            Detalle detalle;
            for (int i = 0; i < dtvPedido.Rows.Count; i++)
            {
                DataGridViewRow row = dtvPedido.Rows[i];

                detalle = new(
                    0,
                    Convert.ToInt32(row.Cells[2].Value.ToString()),
                    decimal.Parse(row.Cells[3].Value.ToString()),
                    decimal.Parse(row.Cells[4].Value.ToString()),
                    row.Cells[1].Value.ToString(),
                    buscarIdProducto(row.Cells[0].Value.ToString()),
                    idVenta
                );

                if (!registrarDetalleVenta(detalle)) { return false; }

                actualizarCantidadProducto(detalle);
            }
            return true;
        }
        private int buscarIdProducto(string codProducto)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM producto WHERE codProducto=@codProducto";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codProducto", codProducto);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return -1;
                        }
                        else
                        {
                            return reader.GetInt32("idProducto");
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
        private bool actualizarSaldoCaja(int idCaja, decimal totalPago)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE caja SET efectivo = efectivo + @pago WHERE idCaja=@idCaja";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pago", totalPago);
                        command.Parameters.AddWithValue("@idCaja", idCaja);

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
