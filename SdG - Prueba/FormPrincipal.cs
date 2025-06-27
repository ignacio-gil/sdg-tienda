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

namespace SdG___Prueba
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
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
            FormHome formHome = new FormHome();
            formHome.MdiParent = this;
            formHome.Show();
        }

        private void ItemProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FormProductos));
        }

        private void ItemProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FormProveedores));
        }
    }


}
