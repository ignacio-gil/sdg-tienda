namespace SdG___Prueba
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblFullName = new Label();
            lblRol = new Label();
            menuStrip1 = new MenuStrip();
            itemHome = new ToolStripMenuItem();
            ItemProductos = new ToolStripMenuItem();
            ItemClientes = new ToolStripMenuItem();
            ItemProveedores = new ToolStripMenuItem();
            ItemCompras = new ToolStripMenuItem();
            ItemVentas = new ToolStripMenuItem();
            ItemCaja = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 119, 255);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(205, 426);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblFullName, 0, 0);
            tableLayoutPanel2.Controls.Add(lblRol, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(199, 104);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(lblFullName, 2);
            lblFullName.Dock = DockStyle.Fill;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(3, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(193, 52);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Apellido, Nombre";
            lblFullName.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(lblRol, 2);
            lblRol.Dock = DockStyle.Fill;
            lblRol.Font = new Font("Segoe UI", 10F);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(3, 52);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(193, 52);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol: Administrador";
            lblRol.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemHome, ItemProductos, ItemClientes, ItemProveedores, ItemCompras, ItemVentas, ItemCaja });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            menuStrip1.Location = new Point(0, 110);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(205, 316);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemHome
            // 
            itemHome.Alignment = ToolStripItemAlignment.Right;
            itemHome.AutoSize = false;
            itemHome.ForeColor = Color.White;
            itemHome.Name = "itemHome";
            itemHome.Padding = new Padding(0);
            itemHome.Size = new Size(200, 45);
            itemHome.Text = "HOME";
            itemHome.Click += itemHome_Click;
            // 
            // ItemProductos
            // 
            ItemProductos.Alignment = ToolStripItemAlignment.Right;
            ItemProductos.AutoSize = false;
            ItemProductos.ForeColor = Color.White;
            ItemProductos.Name = "ItemProductos";
            ItemProductos.Padding = new Padding(0);
            ItemProductos.Size = new Size(200, 45);
            ItemProductos.Text = "Productos";
            ItemProductos.Click += ItemProductos_Click;
            // 
            // ItemClientes
            // 
            ItemClientes.Alignment = ToolStripItemAlignment.Right;
            ItemClientes.AutoSize = false;
            ItemClientes.ForeColor = Color.White;
            ItemClientes.Name = "ItemClientes";
            ItemClientes.Padding = new Padding(0);
            ItemClientes.Size = new Size(200, 45);
            ItemClientes.Text = "Clientes";
            // 
            // ItemProveedores
            // 
            ItemProveedores.Alignment = ToolStripItemAlignment.Right;
            ItemProveedores.AutoSize = false;
            ItemProveedores.ForeColor = Color.White;
            ItemProveedores.Name = "ItemProveedores";
            ItemProveedores.Padding = new Padding(0);
            ItemProveedores.Size = new Size(200, 45);
            ItemProveedores.Text = "Proveedores";
            ItemProveedores.Click += ItemProveedores_Click;
            // 
            // ItemCompras
            // 
            ItemCompras.Alignment = ToolStripItemAlignment.Right;
            ItemCompras.AutoSize = false;
            ItemCompras.ForeColor = Color.White;
            ItemCompras.Name = "ItemCompras";
            ItemCompras.Padding = new Padding(0);
            ItemCompras.Size = new Size(200, 45);
            ItemCompras.Text = "Compras";
            // 
            // ItemVentas
            // 
            ItemVentas.Alignment = ToolStripItemAlignment.Right;
            ItemVentas.AutoSize = false;
            ItemVentas.ForeColor = Color.White;
            ItemVentas.Name = "ItemVentas";
            ItemVentas.Padding = new Padding(0);
            ItemVentas.Size = new Size(200, 45);
            ItemVentas.Text = "Ventas";
            ItemVentas.Click += ItemVentas_Click;
            // 
            // ItemCaja
            // 
            ItemCaja.Alignment = ToolStripItemAlignment.Right;
            ItemCaja.AutoSize = false;
            ItemCaja.ForeColor = Color.White;
            ItemCaja.Name = "ItemCaja";
            ItemCaja.Padding = new Padding(0);
            ItemCaja.Size = new Size(200, 45);
            ItemCaja.Text = "Caja";
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.FromArgb(0, 119, 255);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 9;
            menuStrip2.Text = "menuStrip2";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "FormPrincipal";
            Text = "Form2";
            TransparencyKey = Color.Salmon;
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblFullName;
        private Label lblRol;
        private ToolStripMenuItem ItemProductos;
        private ToolStripMenuItem ItemClientes;
        private ToolStripMenuItem ItemProveedores;
        private ToolStripMenuItem ItemCompras;
        private ToolStripMenuItem ItemVentas;
        private ToolStripMenuItem ItemCaja;
        private ToolStripMenuItem itemHome;
        private MenuStrip menuStrip2;
    }
}