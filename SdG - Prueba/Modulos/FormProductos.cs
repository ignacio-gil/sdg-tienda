using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using SdG___Prueba.Clases;
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
        DataGridView dtvProductos2;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dtvProductos.ClearSelection();
            limpiarCajas();
            activarCajas(true);
            opcionElegida = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            activarCajas(false);
            limpiarCajas();
            dtvProductos.ClearSelection();
        }

        private void agregarProducto()
        {
            try
            {
                string codigo = txtCod.Text;
                int idMarca = cbxMarca.SelectedIndex;
                string modelo = txtModelo.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                float precio = float.Parse(txtPrecio.Text);
                int idCategoria = cbxCategoria.SelectedIndex;

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO producto " +
                        "(codProducto, idMarca, modelo, cantidadStock, precioUnitario, idCategoria)" +
                        " VALUES (@cod, @idMarca, @modelo, @cantidadStock, @precioUnitario, @idCat)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod", codigo);
                        command.Parameters.AddWithValue("@idMarca", idMarca);
                        command.Parameters.AddWithValue("@modelo", modelo);
                        command.Parameters.AddWithValue("@cantidadStock", cantidad);
                        command.Parameters.AddWithValue("@precioUnitario", precio);
                        command.Parameters.AddWithValue("@idCat", idCategoria);

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

                        while (reader.Read())
                        {
                            cbxMarca.Items.Add(reader.GetString("nombreMarca"));
                        }
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

                        while (reader.Read())
                        {
                            cbxCategoria.Items.Add(reader.GetString("nombreCat"));
                        }
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
            crearDtvCopiar();
            cargarMarcas();
            cargarCategorias();
            cargarDtvProductos();
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
            dtvProductos.Enabled = !activar;

            txtCod.Enabled = activar;
            cbxMarca.Enabled = activar;
            txtModelo.Enabled = activar;
            cbxCategoria.Enabled = activar;
            txtCantidad.Enabled = activar;
            txtPrecio.Enabled = activar;

            btnAceptar.Visible = activar;
            btnCancelar.Visible = activar;

            btnAgregar.Enabled = !activar;
            //btnModificar.Enabled = !activar;
            //btnEliminar.Enabled = !activar;
        }

        private void limpiarCajas()
        {
            txtCod.Clear();
            cbxMarca.SelectedIndex = -1;
            txtModelo.Clear();
            cbxCategoria.SelectedIndex = -1;
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void cargarDtvProductos()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM producto";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        dtvProductos2.Rows.Clear();

                        while (reader.Read())
                        {

                            string[] row = {
                                reader.GetString("codProducto"),
                                reader.GetInt32("idMarca").ToString(),
                                reader.GetString("modelo"),
                                reader.GetInt32("cantidadStock").ToString(),
                                reader.GetFloat("precioUnitario").ToString()
                            };

                            dtvProductos.Rows.Add(row);
                            dtvProductos2.Rows.Add(row);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dtvProductos.SelectedRows.Count > 0)
            {
                activarCajas(true);
                opcionElegida = 2;
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista por favor.");
            }

        }

        private bool modificarProducto()
        {
            try
            {
                Producto producto = new(
                    txtCod.Text,
                    cbxMarca.SelectedIndex,
                    txtModelo.Text,
                    Convert.ToInt32(txtCantidad.Text),
                    float.Parse(txtPrecio.Text),
                    cbxCategoria.SelectedIndex
                );

                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE producto " +
                        "SET codProducto=@codNew, idMarca=@idMarca, modelo=@modelo, " +
                        "cantidadStock=@cantidadStock, precioUnitario=@precioUnitario, idCategoria=@idCat " +
                        "WHERE codProducto=@codOld";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codNew", producto.Codigo);
                        command.Parameters.AddWithValue("@idMarca", producto.IdMarca);
                        command.Parameters.AddWithValue("@modelo", producto.Modelo);
                        command.Parameters.AddWithValue("@cantidadStock", producto.Cantidad);
                        command.Parameters.AddWithValue("@precioUnitario", producto.Precio);
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
                                reader.GetFloat("precioUnitario"),
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtvProductos.SelectedRows[0];
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
            else
            {
                MessageBox.Show("Seleccione un producto de la lista por favor.");
            }
        }

        private void buscarEnDtv(string texto)
        {
            if (texto.Equals(""))
            {
                dtvProductos.Rows.Clear();
                cargarDtvProductos();
            }
            else
            {
                List<DataGridViewRow> filas = [];

                for (int i = 0; i < dtvProductos2.RowCount; i++)
                {
                    DataGridViewRow fila = dtvProductos2.Rows[i];
                    if (fila.Cells["Codigo"].Value.ToString().Contains(texto))
                    {
                        filas.Add(fila);
                    }
                }

                dtvProductos.Rows.Clear();

                foreach (DataGridViewRow item in filas)
                {
                    string[] row = {
                                item.Cells["Codigo"].Value.ToString(),
                                item.Cells["Marca"].Value.ToString(),
                                item.Cells["Modelo"].Value.ToString(),
                                item.Cells["Cantidad"].Value.ToString(),
                                item.Cells["Precio_unitario"].Value.ToString()
                    };

                    dtvProductos.Rows.Add(row);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarEnDtv(txtBuscar.Text);
        }

        private void crearDtvCopiar()
        {
            dtvProductos2 = new DataGridView();

            dtvProductos2.AllowUserToAddRows = dtvProductos.AllowUserToAddRows;
            dtvProductos2.AllowUserToDeleteRows = dtvProductos.AllowUserToDeleteRows;

            foreach (DataGridViewColumn columna in dtvProductos.Columns)
            {
                dtvProductos2.Columns.Add(columna.Clone() as DataGridViewColumn);
            }
        }

        private void dtvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtvProductos.SelectedRows.Count>0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow filaSeleccionada = dtvProductos.SelectedRows[0];
                codProductoSel = filaSeleccionada.Cells["Codigo"].Value.ToString();
                Producto producto = buscarProducto(codProductoSel);

                txtCod.Text = producto.Codigo;
                cbxMarca.SelectedIndex = producto.IdMarca;
                txtModelo.Text = producto.Modelo;
                cbxCategoria.SelectedIndex = producto.IdCat;
                txtCantidad.Text = producto.Cantidad.ToString();
                txtPrecio.Text = producto.Precio.ToString();
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
    }
}
