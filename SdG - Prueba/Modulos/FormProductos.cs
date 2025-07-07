using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using SdG___Prueba.Clases;
using SdG___Prueba.Modulos.Productos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SdG___Prueba.Modulos
{
    public partial class FormProductos : Form
    {
        private string codProductoSel = "";
        private int opcionElegida = 0;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Nuevo producto";
            dtvProductos.ClearSelection();
            limpiarCajas();
            activarCajas(true);
            opcionElegida = 1;
        }

        private void agregarProducto()
        {
            try
            {
                Producto nuevoProducto = new(
                    txtCod.Text,
                    buscarMarca(cbxMarca.SelectedItem.ToString()),
                    txtModelo.Text,
                    Convert.ToInt32(numCantidad.Value),
                    numPrecioCompra.Value,
                    numPrecioVenta.Value,
                    buscarCategoria(cbxCategoria.SelectedItem.ToString())
                );

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO producto " +
                        "(codProducto, idMarca, modelo, cantidadStock, precioCompra, precioVenta, idCategoria)" +
                        " VALUES (@cod, @idMarca, @modelo, @cantidadStock, @precioCompra, @precioVenta, @idCat)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod", nuevoProducto.Codigo);
                        command.Parameters.AddWithValue("@idMarca", nuevoProducto.IdMarca);
                        command.Parameters.AddWithValue("@modelo", nuevoProducto.Modelo);
                        command.Parameters.AddWithValue("@cantidadStock", nuevoProducto.Cantidad);
                        command.Parameters.AddWithValue("@precioCompra", nuevoProducto.PrecioCompra);
                        command.Parameters.AddWithValue("@precioVenta", nuevoProducto.PrecioVenta);
                        command.Parameters.AddWithValue("@idCat", nuevoProducto.IdCat);

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

                        string itemSelected = (cbxMarca.SelectedItem == null) ? "" : cbxMarca.SelectedItem.ToString();
                        cbxMarca.Items.Clear();

                        while (reader.Read())
                        {
                            cbxMarca.Items.Add(reader.GetString("nombreMarca"));
                        }

                        cbxMarca.SelectedItem = itemSelected;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

                        string itemSelected = (cbxCategoria.SelectedItem == null) ? "" : cbxCategoria.SelectedItem.ToString();
                        cbxCategoria.Items.Clear();

                        while (reader.Read())
                        {
                            cbxCategoria.Items.Add(reader.GetString("nombreCat"));
                        }

                        cbxMarca.SelectedItem = itemSelected;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            cargarMarcas();
            cargarCategorias();
            cargarDtvProductos();
            cbxBuscarPor.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (opcionElegida == 1)
            {
                agregarProducto();
            }
            else if (opcionElegida == 2)
            {
                if (!modificarProducto())
                {
                    MessageBox.Show("No se pudo modificar el producto");
                }

            }

            activarCajas(false);
            limpiarCajas();
            dtvProductos.Rows.Clear();
            cargarDtvProductos();
            opcionElegida = 0;

        }

        private void activarCajas(bool activar)
        {
            groupBox1.Visible = activar;
            dtvProductos.Enabled = !activar;

            txtCod.Enabled = activar;
            cbxMarca.Enabled = activar;
            txtModelo.Enabled = activar;
            cbxCategoria.Enabled = activar;
            numCantidad.Enabled = activar;
            numPrecioCompra.Enabled = activar;
            numPrecioVenta.Enabled = activar;

            btnAceptar.Visible = activar;

            btnAgregar.Enabled = !activar;
            btnCerrarInfo.Visible = activar;
        }

        private void limpiarCajas()
        {
            txtCod.Clear();
            cbxMarca.SelectedIndex = -1;
            txtModelo.Clear();
            cbxCategoria.SelectedIndex = -1;
            numCantidad.Value = 0;
            numPrecioCompra.Value = 0;
            numPrecioVenta.Value = 0;
        }

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

                        while (reader.Read())
                        {

                            string[] row = {
                                reader.GetString("codProducto"),
                                reader.GetString("nombreMarca") + " " + reader.GetString("modelo"),
                                reader.GetString("nombreCat"),
                                reader.GetInt32("cantidadStock").ToString(),
                                reader.GetDecimal("precioCompra").ToString(),
                                reader.GetDecimal("precioVenta").ToString()
                            };

                            dtvProductos.Rows.Add(row);
                        }

                        dtvProductos.ClearSelection();
                        limpiarCajas();
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
            dtvProductos.Rows.Clear();
            cargarDtvProductos();
        }

        private bool modificarProducto()
        {
            try
            {
                Producto producto = new(
                    txtCod.Text,
                    buscarMarca(cbxMarca.SelectedItem.ToString()),
                    txtModelo.Text,
                    Convert.ToInt32(numCantidad.Value),
                    numPrecioCompra.Value,
                    numPrecioVenta.Value,
                    buscarCategoria(cbxCategoria.SelectedItem.ToString())
                );

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE producto " +
                        "SET codProducto=@codNew, idMarca=@idMarca, modelo=@modelo, " +
                        "cantidadStock=@cantidadStock, precioCompra=@precioCompra, precioVenta=@precioVenta, idCategoria=@idCat " +
                        "WHERE codProducto=@codOld";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codNew", producto.Codigo);
                        command.Parameters.AddWithValue("@idMarca", producto.IdMarca);
                        command.Parameters.AddWithValue("@modelo", producto.Modelo);
                        command.Parameters.AddWithValue("@cantidadStock", producto.Cantidad);
                        command.Parameters.AddWithValue("@precioCompra", producto.PrecioCompra);
                        command.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                        command.Parameters.AddWithValue("@idCat", producto.IdCat);
                        command.Parameters.AddWithValue("@codOld", codProductoSel);

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

        private Producto buscarProducto(String productoSeleccionado)
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
                        command.Parameters.AddWithValue("@cod", productoSeleccionado);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            MessageBox.Show("No se pudo encontrar el producto");
                            return null;
                        }
                        else
                        {
                            return new Producto(
                                reader.GetString("codProducto"),
                                reader.GetInt32("idMarca"),
                                reader.GetString("modelo"),
                                reader.GetInt32("cantidadStock"),
                                reader.GetDecimal("precioCompra"),
                                reader.GetDecimal("precioVenta"),
                                reader.GetInt32("idCategoria")
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string columnaABuscar = "";
            
            switch (cbxBuscarPor.SelectedIndex)
            {
                case 0: columnaABuscar = "codProducto"; break;
                case 1: columnaABuscar = "nombreCat"; break;
                case 2: columnaABuscar = "nombreMarca"; break;
                case 3: columnaABuscar = "modelo"; break;
                default: break;
            }
            buscarPor(txtBuscar.Text, columnaABuscar);
        }

        private void dtvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                //BtnModificar
                activarCajas(true);
                opcionElegida = 2;

                DataGridViewRow filaSeleccionada = dtvProductos.CurrentRow;
                codProductoSel = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Producto producto = buscarProducto(codProductoSel);

                groupBox1.Text = "Modificar producto";
                rellenarDatosCajas(producto);
            }
            else if (e.ColumnIndex == 8)
            {
                //BtnBorrar
                DataGridViewRow filaSeleccionada = dtvProductos.CurrentRow;
                codProductoSel = filaSeleccionada.Cells["Codigo"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    "Esta acción eliminará el producto seleccionado.\n\n¿Está seguro?",
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

                            string query = "DELETE FROM producto WHERE codProducto=@cod";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@cod", codProductoSel);

                                if (command.ExecuteNonQuery() != -1)
                                {
                                    dtvProductos.Rows.Clear();
                                    cargarDtvProductos();
                                    codProductoSel = "";
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
            else if (e.ColumnIndex == 6)
            {
                //BtnMasInfo
                activarCajas(true);
                btnAceptar.Visible = false;
                btnConfigMarca.Visible = false;
                btnConfigCategorias.Visible = false;

                txtCod.ReadOnly = true;
                cbxMarca.Enabled = false;
                txtModelo.ReadOnly = true;
                cbxCategoria.Enabled = false;
                numCantidad.ReadOnly = true;
                numPrecioCompra.ReadOnly = true;
                numPrecioVenta.ReadOnly = true;
                numCantidad.Increment = 0;
                numPrecioCompra.Increment = 0;
                numPrecioVenta.Increment = 0;

                DataGridViewRow filaSeleccionada = dtvProductos.CurrentRow;
                codProductoSel = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Producto producto = buscarProducto(codProductoSel);

                groupBox1.Text = "Más info";
                rellenarDatosCajas(producto);
            }
        }

        private void btnCerrarInfo_Click(object sender, EventArgs e)
        {
            if (opcionElegida == 1 || opcionElegida == 2)
            {
                activarCajas(false);
                limpiarCajas();
                dtvProductos.ClearSelection();
            }
            else
            {
                btnConfigMarca.Visible = true;
                btnConfigCategorias.Visible = true;
                btnCerrarInfo.Visible = false;
                btnConfigMarca.Visible = true;
                activarCajas(false);

                txtCod.ReadOnly = false;
                cbxMarca.Enabled = true;
                txtModelo.ReadOnly = false;
                cbxCategoria.Enabled = true;
                numCantidad.ReadOnly = false;
                numPrecioCompra.ReadOnly = false;
                numPrecioVenta.ReadOnly = false;
                numCantidad.Increment = 1000;
                numPrecioCompra.Increment = 1000;
                numPrecioVenta.Increment = 1000;
            }

            opcionElegida = 0;
        }

        private void btnConfigMarcas_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new();
            formMarca.ShowDialog();
            cargarMarcas();
        }

        private void btnConfigCategorias_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new();
            formCategoria.ShowDialog();
            cargarCategorias();
        }

        private int buscarMarca(string marcaElegida)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM marca WHERE nombreMarca=@nombreMarca";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreMarca", marcaElegida);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return -1;
                        }
                        else
                        {
                            return reader.GetInt32("idMarca");
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

        private int buscarCategoria(string categoriaElegida)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM categoria WHERE nombreCat=@nombreCat";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreCat", categoriaElegida);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return -1;
                        }
                        else
                        {
                            return reader.GetInt32("idCategoria");
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

        private string buscarMarcaPorId(int idMarca)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM marca WHERE idMarca=@idMarca";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idMarca", idMarca);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return "";
                        }
                        else
                        {
                            return reader.GetString("nombreMarca");
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

        private string buscarCategoriaPorId(int idCat)
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM categoria WHERE idCategoria=@idCategoria";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idCategoria", idCat);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            return "";
                        }
                        else
                        {
                            return reader.GetString("nombreCat");
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

        private void buscarPor(string texto, string item)
        {
            if (texto.Equals(""))
            {
                dtvProductos.Rows.Clear();
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
                            "WHERE " + item + " like @texto";

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
                                    reader.GetString("nombreCat"),
                                    reader.GetInt32("cantidadStock").ToString(),
                                    reader.GetFloat("precioCompra").ToString(),
                                    reader.GetFloat("precioVenta").ToString()
                                };

                                dtvProductos.Rows.Add(row);
                            }

                            dtvProductos.ClearSelection();
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

        private void rellenarDatosCajas(Producto producto)
        {
            txtCod.Text = producto.Codigo;
            cbxMarca.SelectedItem = buscarMarcaPorId(producto.IdMarca);
            txtModelo.Text = producto.Modelo;
            numCantidad.Value = producto.Cantidad;
            numPrecioCompra.Value = decimal.Parse(producto.PrecioCompra.ToString());
            numPrecioVenta.Value = decimal.Parse(producto.PrecioVenta.ToString());
            cbxCategoria.SelectedItem = buscarCategoriaPorId(producto.IdCat);
        }

    }
}
