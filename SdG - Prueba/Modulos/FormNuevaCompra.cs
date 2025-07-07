using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class FormNuevaCompra : Form
    {
        private string codProdSel = "";
        private Personal personal;
        private Proveedor proveedor;
        private decimal totalPagado = 0;
        public FormNuevaCompra()
        {
            InitializeComponent();
        }

        private void FormNuevaCompra_Load(object sender, EventArgs e)
        {
            cbxBuscarPor.SelectedIndex = 0;

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
                        "INNER JOIN categoria AS c ON p.idCategoria = c.idCategoria";

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
                                reader.GetDecimal("precioCompra").ToString()
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
                for (int i = 0; i < dtvCompra.Rows.Count; i++)
                {
                    DataGridViewRow row = dtvCompra.Rows[i];
                    if (row.Cells[0].Value.ToString() == fila[0])
                    {
                        existe = true;
                    }
                }

                if (!existe) { dtvCompra.Rows.Add(fila); actualizarTotalPagar(); }
            }
        }

        //Lista de la compra
        private void dtvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && dtvCompra.Rows.Count > 0)
            {
                panelEditar.Enabled = true;
                dtvCompra.Enabled = false;

                gbxListaProductos.Enabled = false;
                tableLayoutPanel9.Enabled = false;

                DataGridViewRow filaSeleccionada = dtvCompra.CurrentRow;
                txtProductoPedido.Text = filaSeleccionada.Cells[1].Value.ToString();
                numCantidadProducto.Value = Convert.ToInt32(filaSeleccionada.Cells[2].Value.ToString());
                numPrecioCompra.Value = decimal.Parse(filaSeleccionada.Cells[3].Value.ToString());

                codProdSel = filaSeleccionada.Cells[0].Value.ToString();

                
            }
            else if (e.ColumnIndex == 6 && dtvCompra.Rows.Count > 0)
            {
                //BtnBorrar
                dtvCompra.Rows.RemoveAt(e.RowIndex);
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
            dtvCompra.Enabled = true;
            dtvCompra.ClearSelection();

            txtProductoPedido.Clear();
            numCantidadProducto.Value = 0;

            codProdSel = "";
            numPrecioCompra.Value = 0;
            numCantidadProducto.Maximum = 1000;

            gbxListaProductos.Enabled = true;
            tableLayoutPanel9.Enabled = true;
        }
        private void btnCambiarCantidad_Click(object sender, EventArgs e)
        {
            int cantidadNueva = Convert.ToInt32(numCantidadProducto.Value);
            decimal precioCompraNuevo = numPrecioCompra.Value;

            dtvCompra.CurrentRow.Cells[2].Value = cantidadNueva;
            dtvCompra.CurrentRow.Cells[3].Value = precioCompraNuevo;

            decimal subtotalNuevo = cantidadNueva * precioCompraNuevo;
            dtvCompra.CurrentRow.Cells[4].Value = subtotalNuevo;
            actualizarTotalPagar();
            btnCancelarCambio_Click(this, new EventArgs());
        }

        //Datos del Proveedor
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            proveedor = Proveedor.buscarProveedorPorCuil(txtCuilProveedor.Text);

            if (proveedor != null)
            {
                txtCuilProveedor.ReadOnly = true;
                btnBuscarProveedor.Enabled = false;
                btnCancelarProveedor.Enabled = true;

                txtRazonSocial.Text = proveedor.RazonSocial;
                txtProveedorDireccion.Text = proveedor.Direccion + ", " + proveedor.Localidad;
                txtProveedorMail.Text = proveedor.Mail;
            }
            else
            {
                MessageBox.Show("No existe un proveedor con ese CUIL.");
            }
        }
        private void btnCancelarProveedor_Click(object sender, EventArgs e)
        {
            txtCuilProveedor.ReadOnly = false;
            btnBuscarProveedor.Enabled = true;
            btnCancelarProveedor.Enabled = false;

            txtRazonSocial.Clear();
            txtProveedorDireccion.Clear();
            txtProveedorMail.Clear();

            proveedor = null;
        }

        //Datos de la Compra
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
            totalPagado = 0;
            for (int i = 0; i < dtvCompra.Rows.Count; i++)
            {
                DataGridViewRow row = dtvCompra.Rows[i];
                string valorCelda = row.Cells[4].Value.ToString();
                decimal valorSubtotal = decimal.Parse(valorCelda);
                totalPagado += valorSubtotal;
            }

            lblTotalPagar.Text = "TOTAL PAGADO: $" + totalPagado;

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

            dtvCompra.Rows.Clear();
            btnCancelarCambio_Click(this, new EventArgs());
            btnActualizar_Click(this, new EventArgs());
            btnCancelarProveedor_Click(this, new EventArgs());
            txtCuilProveedor.Clear();
            actualizarTotalPagar();

        }

        //Registrar Compra
        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            int idCaja = buscarCaja(cbxCajas.SelectedItem.ToString());
            if (validarCampos(idCaja))
            {
                DateOnly dateOnly = new();
                TimeOnly timeOnly = new();
                Compra nuevaCompra = new(
                    0,
                    dateOnly,
                    timeOnly,
                    totalPagado,
                    personal.Id,
                    Convert.ToInt32(proveedor.Id),
                    idCaja
                );

                int idRegistro = registrarCompra(nuevaCompra);
                if (idRegistro != -1)
                {
                    MessageBox.Show("Compra registrada");

                    //Registrar detalles compra
                    registrarCompraProductos(idRegistro);
                    actualizarSaldoCaja(nuevaCompra.IdCaja, nuevaCompra.ImporteTotal);

                    btnLimpiarTodo_Click(this, new EventArgs());
                }

            }
        }
        private bool validarCampos(int idCaja)
        {
            decimal saldoCaja = decimal.Parse(Caja.consultarSaldo(idCaja).ToString());
            if(saldoCaja < totalPagado) { MessageBox.Show("Saldo de Caja insuficiente."); return false; }
            if(txtIdPersonal.Text.Equals("") || txtRazonSocial.Text.Equals("")) { MessageBox.Show("Hay campos sin completar."); return false; }
            if(dtvCompra.Rows.Count == 0) { MessageBox.Show("No hay productos cargados."); return false; }
            
            return  true;
        }
        private int registrarCompra(Compra nuevaCompra)
        {
            try
            {
                int idRegistro = -1;

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {


                    connection.Open();

                    string query = "INSERT INTO compra (fechaCompra, horaCompra, importeTotal, " +
                                   "idPersonal, idProveedor, idCaja) VALUES (CURRENT_DATE(), CURRENT_TIME(), " +
                                   "@importeTotal, @idPersonal, @idProveedor, @idCaja); " +
                                   "SELECT LAST_INSERT_ID() AS ID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@importeTotal", nuevaCompra.ImporteTotal);
                        command.Parameters.AddWithValue("@idPersonal", nuevaCompra.IdPersonal);
                        command.Parameters.AddWithValue("@idProveedor", nuevaCompra.IdProveedor);
                        command.Parameters.AddWithValue("@idCaja", nuevaCompra.IdCaja);


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
        private bool registrarDetalleCompra(Detalle detalle)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO detallecompra (cantidad, precioCompra, total, descripcion, idCompra, idProducto) " +
                        "VALUES (@cantidad, @precioCompra, @total, @descripcion, @idCompra, @idProducto)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        command.Parameters.AddWithValue("@precioCompra", detalle.Precio);
                        command.Parameters.AddWithValue("@total", detalle.Total);
                        command.Parameters.AddWithValue("@descripcion", detalle.Descripcion);
                        command.Parameters.AddWithValue("@idCompra", detalle.IdCompraVenta);
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

                    string query = "UPDATE producto SET cantidadStock = cantidadStock + @cantidad WHERE idProducto=@idProducto";

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
        private bool registrarCompraProductos(int idCompra)
        {
            Detalle detalle;
            for (int i = 0; i < dtvCompra.Rows.Count; i++)
            {
                DataGridViewRow row = dtvCompra.Rows[i];

                detalle = new(
                    0,
                    Convert.ToInt32(row.Cells[2].Value.ToString()),
                    decimal.Parse(row.Cells[3].Value.ToString()),
                    decimal.Parse(row.Cells[4].Value.ToString()),
                    row.Cells[1].Value.ToString(),
                    buscarIdProducto(row.Cells[0].Value.ToString()),
                    idCompra
                );

                if (!registrarDetalleCompra(detalle)) { return false; }

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

                    string query = "UPDATE caja SET efectivo = efectivo - @pago WHERE idCaja=@idCaja";

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
