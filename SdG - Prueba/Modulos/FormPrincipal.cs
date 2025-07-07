using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using SdG___Prueba.Clases;
using SdG___Prueba.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SdG___Prueba
{
    public partial class FormPrincipal : Form
    {
        bool verItemsVentas = false;
        bool verItemsCompras = false;
        public readonly Personal personal;
        public FormPrincipal(Personal personal)
        {
            this.personal = personal;
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        private void itemHome_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FormHome));
        }

        private void AbrirFormulario(Type tipoFormulario)
        {
            bool existe = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == tipoFormulario)
                {
                    frm.Show();
                    frm.WindowState = FormWindowState.Maximized;
                    existe = true;
                }
                else
                {
                    frm.Hide();
                }
            }

            if (existe) { return; }

            Form formularioHijo = (Form)Activator.CreateInstance(tipoFormulario);
            formularioHijo.MdiParent = this;
            formularioHijo.WindowState = FormWindowState.Maximized;
            formularioHijo.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (personal.IdRol == 2)
            {
                ItemProductos.Visible = false;
                ItemProveedores.Visible = false;
            }
            else if (personal.IdRol == 3)
            {
                ItemProductos.Visible = false;
                ItemProveedores.Visible = false;
            }

            FormHome formHome = new FormHome();
            formHome.MdiParent = this;
            formHome.Show();

            lblFullName.Text = personal.Apellido + ", " + personal.Nombre;
            lblRol.Text = "Rol: " + buscarRolPorId(personal.IdRol);
        }

        private void ItemProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FormProductos));
        }

        private void ItemProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FormProveedores));
        }

        private void ItemVentas_Click(object sender, EventArgs e)
        {
            itemNuevaVenta.Visible = !verItemsVentas;
            itemListaDeVentas.Visible = !verItemsVentas;
            verItemsVentas = !verItemsVentas;
            ItemVentas.BackgroundImage = (verItemsVentas) ? Properties.Resources.btnLateralPressed : Properties.Resources.btnLateralNormal;
            //AbrirFormulario(typeof(FormVentas));
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

        private void itemCompras_Click(object sender, EventArgs e)
        {
            itemNuevaCompra.Visible = !verItemsCompras;
            itemListaDeCompras.Visible = !verItemsCompras;
            verItemsCompras = !verItemsCompras;
            itemCompras.BackgroundImage = (verItemsCompras) ? Properties.Resources.btnLateralPressed : Properties.Resources.btnLateralNormal;
        }

        private void ItemClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FormClientes));
        }

        private void itemCajas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FormCajas));
        }

        private void itemNuevaVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FormNuevaVenta));
        }

        private void itemListaDeVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FormListaDeVentas));
        }
    }


}
