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
    public partial class FormListaDeVentas : Form
    {
        public FormListaDeVentas()
        {
            InitializeComponent();
        }

        private void FormListaDeVentas_Load(object sender, EventArgs e)
        {
            cargarDtvVentas();
        }

        //Lista de ventas
        private void cargarDtvVentas()
        {
            try
            {
                string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT v.idVenta, CONCAT(v.fechaVenta, ' '), CONCAT(v.horaVenta, ' '), v.importeTotal, v.importePagado, " +
                                   "v.importeCambio, c.nombre " +
                                   "FROM venta AS v INNER JOIN caja AS c ON v.idCaja = c.idCaja " +
                                   "ORDER BY v.fechaVenta DESC, v.horaVenta DESC";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        dtvVentas.Rows.Clear();

                        while (reader.Read())
                        {

                            string[] row = {
                                reader.GetString("CONCAT(v.fechaVenta, ' ')"),
                                reader.GetString("CONCAT(v.horaVenta, ' ')"),
                                reader.GetInt32("idVenta").ToString(),
                                reader.GetDecimal("importeTotal").ToString(),
                                reader.GetDecimal("importePagado").ToString(),
                                reader.GetDecimal("importeCambio").ToString(),
                                reader.GetString("nombre")
                            };

                            dtvVentas.Rows.Add(row);
                        }

                        dtvVentas.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && dtvVentas.Rows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtvVentas.CurrentRow;
                verMasInfoVenta(filaSeleccionada);
            }
        }

        private void verMasInfoVenta(DataGridViewRow filaSeleccionada)
        {
            int idVentaSel = Convert.ToInt32(filaSeleccionada.Cells[2].Value);
            Venta datosVenta = Venta.buscarVentaPorId(idVentaSel);

            groupBox1.Visible = true;
            dtvVentas.Enabled = false;
            panelBuscar.Enabled = false;

            //Datos de la venta
            txtIdVenta.Text = idVentaSel.ToString();
            txtFecha.Text = datosVenta.Fecha + " ";
            txtHora.Text = datosVenta.Hora + " ";
            lblTotalVenta.Text = "TOTAL VENTA: $" + datosVenta.ImporteTotal;

            //Datos Cliente
            Cliente cliente = Cliente.buscarClientePorId(datosVenta.IdCliente);
            txtNombreCliente.Text = cliente.Apellido + ", " + cliente.Nombre;
            txtDniCliente.Text = cliente.Dni;
            txtDireccionCliente.Text = cliente.Direccion + ", " + cliente.Localidad;
            txtMailCliente.Text = cliente.Mail;

            //Datos Vendedor
            Personal vendedor = Personal.buscarPersonalPorId(datosVenta.IdPersonal);
            txtIdPersonal.Text = vendedor.Id.ToString();
            txtNombrePersonal.Text = vendedor.Apellido + ", " + vendedor.Nombre;
            txtCargo.Text = Personal.buscarNombreRol(vendedor.Id);

            //Carga de dtvPedido
            Detalle.cargarDetallesVentaPorId(dtvPedido, datosVenta.Id);
        }

        private void btnCerrarInfo_Click(object sender, EventArgs e)
        {
            dtvPedido.Rows.Clear();
            groupBox1.Visible = false;
            dtvVentas.Enabled = true;
            panelBuscar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDtvVentas();
            txtBuscar.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                cargarDtvVentas();
            }
            else
            {
                try
                {
                    string connectionString = "Server=localhost;Database=sdg;Uid=root;Pwd=";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT v.idVenta, CONCAT(v.fechaVenta, ' '), CONCAT(v.horaVenta, ' '), v.importeTotal, v.importePagado, " +
                                   "v.importeCambio, c.nombre " +
                                   "FROM venta AS v INNER JOIN caja AS c ON v.idCaja = c.idCaja " +
                                   "WHERE idVenta like @texto";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@texto", "%" + txtBuscar.Text + "%");
                            MySqlDataReader reader = command.ExecuteReader();

                            dtvVentas.Rows.Clear();

                            while (reader.Read())
                            {

                                string[] row = {
                                    reader.GetString("CONCAT(v.fechaVenta, ' ')"),
                                    reader.GetString("CONCAT(v.horaVenta, ' ')"),
                                    reader.GetInt32("idVenta").ToString(),
                                    reader.GetDecimal("importeTotal").ToString(),
                                    reader.GetDecimal("importePagado").ToString(),
                                    reader.GetDecimal("importeCambio").ToString(),
                                    reader.GetString("nombre")
                                };

                                dtvVentas.Rows.Add(row);
                            }

                            dtvVentas.ClearSelection();
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
