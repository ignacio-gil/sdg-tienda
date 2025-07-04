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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblFullName = new Label();
            lblRol = new Label();
            menuStrip1 = new MenuStrip();
            itemHome = new ToolStripMenuItem();
            ItemVentas = new ToolStripMenuItem();
            itemNuevaVenta = new ToolStripMenuItem();
            itemListaDeVentas = new ToolStripMenuItem();
            itemCompras = new ToolStripMenuItem();
            itemNuevaCompra = new ToolStripMenuItem();
            itemListaDeCompras = new ToolStripMenuItem();
            ItemProductos = new ToolStripMenuItem();
            ItemClientes = new ToolStripMenuItem();
            ItemProveedores = new ToolStripMenuItem();
            itemCajas = new ToolStripMenuItem();
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
            tableLayoutPanel1.Size = new Size(200, 575);
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
            tableLayoutPanel2.Size = new Size(194, 104);
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
            lblFullName.Size = new Size(188, 52);
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
            lblRol.Size = new Size(188, 52);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol: Administrador";
            lblRol.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemHome, ItemVentas, itemNuevaVenta, itemListaDeVentas, itemCompras, itemNuevaCompra, itemListaDeCompras, ItemProductos, ItemClientes, ItemProveedores, itemCajas });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            menuStrip1.Location = new Point(0, 110);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(200, 454);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemHome
            // 
            itemHome.Alignment = ToolStripItemAlignment.Right;
            itemHome.AutoSize = false;
            itemHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemHome.ForeColor = Color.White;
            itemHome.Image = Properties.Resources.home;
            itemHome.ImageAlign = ContentAlignment.MiddleLeft;
            itemHome.ImageScaling = ToolStripItemImageScaling.None;
            itemHome.Name = "itemHome";
            itemHome.Padding = new Padding(0);
            itemHome.Size = new Size(200, 45);
            itemHome.Text = "Inicio";
            itemHome.Click += itemHome_Click;
            // 
            // ItemVentas
            // 
            ItemVentas.Alignment = ToolStripItemAlignment.Right;
            ItemVentas.AutoSize = false;
            ItemVentas.BackgroundImage = Properties.Resources.btnLateralNormal;
            ItemVentas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemVentas.ForeColor = Color.White;
            ItemVentas.Image = Properties.Resources.ventas;
            ItemVentas.ImageAlign = ContentAlignment.MiddleLeft;
            ItemVentas.ImageScaling = ToolStripItemImageScaling.None;
            ItemVentas.Name = "ItemVentas";
            ItemVentas.Padding = new Padding(0);
            ItemVentas.Size = new Size(200, 45);
            ItemVentas.Text = "Ventas";
            ItemVentas.Click += ItemVentas_Click;
            // 
            // itemNuevaVenta
            // 
            itemNuevaVenta.AutoSize = false;
            itemNuevaVenta.BackColor = Color.FromArgb(44, 82, 152);
            itemNuevaVenta.Font = new Font("Segoe UI", 10F);
            itemNuevaVenta.ForeColor = Color.White;
            itemNuevaVenta.Image = Properties.Resources.plusWhite;
            itemNuevaVenta.Name = "itemNuevaVenta";
            itemNuevaVenta.Size = new Size(200, 30);
            itemNuevaVenta.Text = "Nueva venta";
            itemNuevaVenta.Visible = false;
            // 
            // itemListaDeVentas
            // 
            itemListaDeVentas.AutoSize = false;
            itemListaDeVentas.BackColor = Color.FromArgb(44, 82, 152);
            itemListaDeVentas.Font = new Font("Segoe UI", 10F);
            itemListaDeVentas.ForeColor = Color.White;
            itemListaDeVentas.Image = Properties.Resources.list;
            itemListaDeVentas.Name = "itemListaDeVentas";
            itemListaDeVentas.Size = new Size(200, 30);
            itemListaDeVentas.Text = "Lista de ventas";
            itemListaDeVentas.Visible = false;
            // 
            // itemCompras
            // 
            itemCompras.Alignment = ToolStripItemAlignment.Right;
            itemCompras.AutoSize = false;
            itemCompras.BackgroundImage = Properties.Resources.btnLateralNormal;
            itemCompras.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemCompras.ForeColor = Color.White;
            itemCompras.Image = Properties.Resources.cartWhite;
            itemCompras.ImageAlign = ContentAlignment.MiddleLeft;
            itemCompras.ImageScaling = ToolStripItemImageScaling.None;
            itemCompras.Name = "itemCompras";
            itemCompras.Padding = new Padding(0);
            itemCompras.Size = new Size(200, 45);
            itemCompras.Text = "Compras";
            itemCompras.Click += itemCompras_Click;
            // 
            // itemNuevaCompra
            // 
            itemNuevaCompra.Alignment = ToolStripItemAlignment.Right;
            itemNuevaCompra.AutoSize = false;
            itemNuevaCompra.BackColor = Color.FromArgb(44, 82, 152);
            itemNuevaCompra.Font = new Font("Segoe UI", 10F);
            itemNuevaCompra.ForeColor = Color.White;
            itemNuevaCompra.Image = Properties.Resources.plusWhite;
            itemNuevaCompra.Name = "itemNuevaCompra";
            itemNuevaCompra.Padding = new Padding(0);
            itemNuevaCompra.Size = new Size(200, 30);
            itemNuevaCompra.Text = "Nueva compra";
            itemNuevaCompra.Visible = false;
            // 
            // itemListaDeCompras
            // 
            itemListaDeCompras.Alignment = ToolStripItemAlignment.Right;
            itemListaDeCompras.AutoSize = false;
            itemListaDeCompras.BackColor = Color.FromArgb(44, 82, 152);
            itemListaDeCompras.Font = new Font("Segoe UI", 10F);
            itemListaDeCompras.ForeColor = Color.White;
            itemListaDeCompras.Image = Properties.Resources.list;
            itemListaDeCompras.Name = "itemListaDeCompras";
            itemListaDeCompras.Padding = new Padding(0);
            itemListaDeCompras.Size = new Size(200, 30);
            itemListaDeCompras.Text = "Lista de compras";
            itemListaDeCompras.Visible = false;
            // 
            // ItemProductos
            // 
            ItemProductos.Alignment = ToolStripItemAlignment.Right;
            ItemProductos.AutoSize = false;
            ItemProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemProductos.ForeColor = Color.White;
            ItemProductos.Image = Properties.Resources.productos;
            ItemProductos.ImageAlign = ContentAlignment.MiddleLeft;
            ItemProductos.ImageScaling = ToolStripItemImageScaling.None;
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
            ItemClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemClientes.ForeColor = Color.White;
            ItemClientes.Image = Properties.Resources.clientes;
            ItemClientes.ImageAlign = ContentAlignment.MiddleLeft;
            ItemClientes.ImageScaling = ToolStripItemImageScaling.None;
            ItemClientes.Name = "ItemClientes";
            ItemClientes.Padding = new Padding(0);
            ItemClientes.Size = new Size(200, 45);
            ItemClientes.Text = "Clientes";
            ItemClientes.Click += ItemClientes_Click;
            // 
            // ItemProveedores
            // 
            ItemProveedores.Alignment = ToolStripItemAlignment.Right;
            ItemProveedores.AutoSize = false;
            ItemProveedores.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemProveedores.ForeColor = Color.White;
            ItemProveedores.Image = Properties.Resources.proveedores;
            ItemProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            ItemProveedores.ImageScaling = ToolStripItemImageScaling.None;
            ItemProveedores.Name = "ItemProveedores";
            ItemProveedores.Padding = new Padding(0);
            ItemProveedores.Size = new Size(200, 45);
            ItemProveedores.Text = "Proveedores";
            ItemProveedores.Click += ItemProveedores_Click;
            // 
            // itemCajas
            // 
            itemCajas.Alignment = ToolStripItemAlignment.Right;
            itemCajas.AutoSize = false;
            itemCajas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemCajas.ForeColor = Color.White;
            itemCajas.Image = Properties.Resources.caja1;
            itemCajas.ImageAlign = ContentAlignment.MiddleLeft;
            itemCajas.ImageScaling = ToolStripItemImageScaling.None;
            itemCajas.Name = "itemCajas";
            itemCajas.Size = new Size(200, 45);
            itemCajas.Text = "Cajas";
            itemCajas.Click += itemCajas_Click;
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
            ClientSize = new Size(800, 599);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip2;
            MaximizeBox = false;
            Name = "FormPrincipal";
            Text = "SdG - Tienda";
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
        private ToolStripMenuItem ItemVentas;
        private ToolStripMenuItem itemHome;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem itemNuevaVenta;
        private ToolStripMenuItem itemListaDeVentas;
        private ToolStripMenuItem itemCompras;
        private ToolStripMenuItem itemNuevaCompra;
        private ToolStripMenuItem itemListaDeCompras;
        private ToolStripMenuItem itemCajas;
    }
}