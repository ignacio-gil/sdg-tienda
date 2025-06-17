namespace SdG___Prueba
{
    public partial class Form1 : Form
    {
        bool visiblePanel = false;
        Form loginA;
        public Form1(Form login)
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
    }
}
