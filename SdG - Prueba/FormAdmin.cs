namespace SdG___Prueba
{
    public partial class FormAdmin : Form
    {
        bool visiblePanel = false;
        Form loginA;
        bool visiblePanelProveedores = false;
        public FormAdmin(Form login)
        {
            this.loginA = login;
            InitializeComponent();
        }

        private void averToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = (visiblePanel == false) ? true : false;
            visiblePanel = panel1.Visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Closing += Form1_Closing;
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loginA.Visible = true;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (!visiblePanelProveedores)
            {
                button1.BackgroundImage = Properties.Resources.btnLateralHover;
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (!visiblePanelProveedores)
            {
                button1.BackgroundImage = Properties.Resources.btnLateralNormal;
            }
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!visiblePanelProveedores)
            {
                tableLayoutPanel5.Visible = true;
                visiblePanelProveedores = true;
                button1.BackgroundImage = Properties.Resources.btnLateralPressed;
            }
            else
            {
                tableLayoutPanel5.Visible = false;
                visiblePanelProveedores = false;
                button1.BackgroundImage = Properties.Resources.btnLateralNormal;
            }

            
        }
    }
}
