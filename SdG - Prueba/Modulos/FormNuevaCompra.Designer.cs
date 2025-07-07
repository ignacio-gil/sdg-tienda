namespace SdG___Prueba.Modulos
{
    partial class FormNuevaCompra
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            gbxDatosEmpleado = new GroupBox();
            panelEmpleado = new TableLayoutPanel();
            txtRol = new TextBox();
            lblRol = new Label();
            txtPersonalNombre = new TextBox();
            label8 = new Label();
            txtIdPersonal = new TextBox();
            lblIdPersonal = new Label();
            panelDatosGeneral = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            btnLimpiarTodo = new Button();
            btnRegistrarCompra = new Button();
            gbxListaProductos = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            dtvProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Agregar = new DataGridViewImageColumn();
            tableLayoutBuscarPor = new TableLayoutPanel();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            labelBuscarPor = new Label();
            lblBuscarPor = new Label();
            cbxBuscarPor = new ComboBox();
            gbxCompra = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panelEditar = new TableLayoutPanel();
            numPrecioCompra = new NumericUpDown();
            label1 = new Label();
            btnCambiarCantidad = new Button();
            txtProductoPedido = new TextBox();
            lblProductoPedido = new Label();
            lblCantidadProducto = new Label();
            numCantidadProducto = new NumericUpDown();
            btnCancelarCambio = new Button();
            dtvCompra = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            Borrar = new DataGridViewImageColumn();
            gbxDatosProveedor = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtProveedorMail = new TextBox();
            lblMail = new Label();
            txtProveedorDireccion = new TextBox();
            lblProveedorDireccion = new Label();
            txtRazonSocial = new TextBox();
            lblClienteNombre = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnCancelarProveedor = new Button();
            txtCuilProveedor = new TextBox();
            lblCuilProveedor = new Label();
            btnBuscarProveedor = new Button();
            gpxDatosCompra = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            cbxCajas = new ComboBox();
            lblCaja = new Label();
            txtFecha = new TextBox();
            lblFecha = new Label();
            lblTotalPagar = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gbxDatosEmpleado.SuspendLayout();
            panelEmpleado.SuspendLayout();
            panelDatosGeneral.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            gbxListaProductos.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvProductos).BeginInit();
            tableLayoutBuscarPor.SuspendLayout();
            gbxCompra.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecioCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvCompra).BeginInit();
            gbxDatosProveedor.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            gpxDatosCompra.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Location = new Point(-9, 31);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1113, 784);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(gbxDatosEmpleado, 0, 1);
            tableLayoutPanel1.Controls.Add(panelDatosGeneral, 0, 2);
            tableLayoutPanel1.Location = new Point(50, 0);
            tableLayoutPanel1.Margin = new Padding(50, 0, 50, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1013, 731);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 40, 0, 25);
            lblTitulo.Size = new Size(1007, 95);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Nueva compra";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxDatosEmpleado
            // 
            gbxDatosEmpleado.AutoSize = true;
            gbxDatosEmpleado.Controls.Add(panelEmpleado);
            gbxDatosEmpleado.Dock = DockStyle.Fill;
            gbxDatosEmpleado.Location = new Point(3, 98);
            gbxDatosEmpleado.Name = "gbxDatosEmpleado";
            gbxDatosEmpleado.Size = new Size(1007, 56);
            gbxDatosEmpleado.TabIndex = 2;
            gbxDatosEmpleado.TabStop = false;
            gbxDatosEmpleado.Text = "Datos del Empleado";
            // 
            // panelEmpleado
            // 
            panelEmpleado.AutoSize = true;
            panelEmpleado.ColumnCount = 6;
            panelEmpleado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66556F));
            panelEmpleado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.66942F));
            panelEmpleado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.665554F));
            panelEmpleado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6683521F));
            panelEmpleado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.665554F));
            panelEmpleado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.665554F));
            panelEmpleado.Controls.Add(txtRol, 5, 0);
            panelEmpleado.Controls.Add(lblRol, 4, 0);
            panelEmpleado.Controls.Add(txtPersonalNombre, 3, 0);
            panelEmpleado.Controls.Add(label8, 2, 0);
            panelEmpleado.Controls.Add(txtIdPersonal, 1, 0);
            panelEmpleado.Controls.Add(lblIdPersonal, 0, 0);
            panelEmpleado.Dock = DockStyle.Fill;
            panelEmpleado.Location = new Point(3, 19);
            panelEmpleado.Name = "panelEmpleado";
            panelEmpleado.Padding = new Padding(0, 0, 0, 5);
            panelEmpleado.RowCount = 1;
            panelEmpleado.RowStyles.Add(new RowStyle());
            panelEmpleado.Size = new Size(1001, 34);
            panelEmpleado.TabIndex = 0;
            // 
            // txtRol
            // 
            txtRol.Anchor = AnchorStyles.Left;
            txtRol.Location = new Point(833, 3);
            txtRol.Name = "txtRol";
            txtRol.ReadOnly = true;
            txtRol.Size = new Size(86, 23);
            txtRol.TabIndex = 18;
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.Right;
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 12F);
            lblRol.Location = new Point(772, 4);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(55, 21);
            lblRol.TabIndex = 17;
            lblRol.Text = "Cargo:";
            // 
            // txtPersonalNombre
            // 
            txtPersonalNombre.Anchor = AnchorStyles.Left;
            txtPersonalNombre.Location = new Point(421, 3);
            txtPersonalNombre.Name = "txtPersonalNombre";
            txtPersonalNombre.ReadOnly = true;
            txtPersonalNombre.Size = new Size(130, 23);
            txtPersonalNombre.TabIndex = 16;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(344, 4);
            label8.Name = "label8";
            label8.Size = new Size(71, 21);
            label8.TabIndex = 15;
            label8.Text = "Nombre:";
            // 
            // txtIdPersonal
            // 
            txtIdPersonal.Anchor = AnchorStyles.Left;
            txtIdPersonal.Location = new Point(169, 3);
            txtIdPersonal.Name = "txtIdPersonal";
            txtIdPersonal.ReadOnly = true;
            txtIdPersonal.Size = new Size(50, 23);
            txtIdPersonal.TabIndex = 14;
            // 
            // lblIdPersonal
            // 
            lblIdPersonal.Anchor = AnchorStyles.Right;
            lblIdPersonal.AutoSize = true;
            lblIdPersonal.Font = new Font("Segoe UI", 12F);
            lblIdPersonal.Location = new Point(72, 4);
            lblIdPersonal.Name = "lblIdPersonal";
            lblIdPersonal.Size = new Size(91, 21);
            lblIdPersonal.TabIndex = 13;
            lblIdPersonal.Text = "ID Personal:";
            // 
            // panelDatosGeneral
            // 
            panelDatosGeneral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDatosGeneral.ColumnCount = 2;
            panelDatosGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.2523F));
            panelDatosGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.7477074F));
            panelDatosGeneral.Controls.Add(tableLayoutPanel9, 0, 2);
            panelDatosGeneral.Controls.Add(gbxListaProductos, 0, 0);
            panelDatosGeneral.Controls.Add(gbxCompra, 0, 1);
            panelDatosGeneral.Controls.Add(gbxDatosProveedor, 1, 0);
            panelDatosGeneral.Controls.Add(gpxDatosCompra, 1, 1);
            panelDatosGeneral.Location = new Point(3, 160);
            panelDatosGeneral.Name = "panelDatosGeneral";
            panelDatosGeneral.RowCount = 3;
            panelDatosGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 30.45775F));
            panelDatosGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 69.54225F));
            panelDatosGeneral.RowStyles.Add(new RowStyle());
            panelDatosGeneral.Size = new Size(1007, 568);
            panelDatosGeneral.TabIndex = 3;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.AutoSize = true;
            tableLayoutPanel9.ColumnCount = 3;
            panelDatosGeneral.SetColumnSpan(tableLayoutPanel9, 2);
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.Controls.Add(btnLimpiarTodo, 0, 0);
            tableLayoutPanel9.Controls.Add(btnRegistrarCompra, 4, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(10, 527);
            tableLayoutPanel9.Margin = new Padding(10, 3, 3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(994, 38);
            tableLayoutPanel9.TabIndex = 5;
            // 
            // btnLimpiarTodo
            // 
            btnLimpiarTodo.Anchor = AnchorStyles.Left;
            btnLimpiarTodo.AutoSize = true;
            btnLimpiarTodo.BackgroundImage = Properties.Resources.clean;
            btnLimpiarTodo.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiarTodo.Font = new Font("Segoe UI", 12F);
            btnLimpiarTodo.Location = new Point(3, 4);
            btnLimpiarTodo.Name = "btnLimpiarTodo";
            btnLimpiarTodo.Size = new Size(30, 30);
            btnLimpiarTodo.TabIndex = 10;
            btnLimpiarTodo.UseVisualStyleBackColor = true;
            btnLimpiarTodo.Click += btnLimpiarTodo_Click;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.Anchor = AnchorStyles.Right;
            btnRegistrarCompra.AutoSize = true;
            btnRegistrarCompra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCompra.Location = new Point(843, 3);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(148, 31);
            btnRegistrarCompra.TabIndex = 9;
            btnRegistrarCompra.Text = "Registrar Compra";
            btnRegistrarCompra.UseVisualStyleBackColor = true;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // gbxListaProductos
            // 
            gbxListaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxListaProductos.AutoSize = true;
            gbxListaProductos.Controls.Add(tableLayoutPanel3);
            gbxListaProductos.Location = new Point(3, 3);
            gbxListaProductos.Name = "gbxListaProductos";
            gbxListaProductos.Size = new Size(651, 153);
            gbxListaProductos.TabIndex = 0;
            gbxListaProductos.TabStop = false;
            gbxListaProductos.Text = "Productos existentes";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.45182F));
            tableLayoutPanel3.Controls.Add(dtvProductos, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutBuscarPor, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(645, 131);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // dtvProductos
            // 
            dtvProductos.AllowUserToAddRows = false;
            dtvProductos.AllowUserToDeleteRows = false;
            dtvProductos.AllowUserToResizeRows = false;
            dtvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvProductos.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Stock, Precio, Agregar });
            dtvProductos.Dock = DockStyle.Fill;
            dtvProductos.Location = new Point(10, 45);
            dtvProductos.Margin = new Padding(10, 3, 10, 3);
            dtvProductos.MultiSelect = false;
            dtvProductos.Name = "dtvProductos";
            dtvProductos.ReadOnly = true;
            dtvProductos.RowHeadersVisible = false;
            dtvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvProductos.Size = new Size(625, 83);
            dtvProductos.TabIndex = 5;
            dtvProductos.CellClick += dtvProductos_CellClick;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 120;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 60;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 90;
            // 
            // Agregar
            // 
            Agregar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Agregar.HeaderText = "Agregar";
            Agregar.Image = Properties.Resources.plus;
            Agregar.Name = "Agregar";
            Agregar.ReadOnly = true;
            Agregar.Width = 50;
            // 
            // tableLayoutBuscarPor
            // 
            tableLayoutBuscarPor.AutoSize = true;
            tableLayoutBuscarPor.ColumnCount = 6;
            tableLayoutPanel3.SetColumnSpan(tableLayoutBuscarPor, 2);
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle());
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle());
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.0000038F));
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle());
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle());
            tableLayoutBuscarPor.Controls.Add(btnActualizar, 5, 0);
            tableLayoutBuscarPor.Controls.Add(txtBuscar, 1, 0);
            tableLayoutBuscarPor.Controls.Add(labelBuscarPor, 0, 0);
            tableLayoutBuscarPor.Controls.Add(lblBuscarPor, 2, 0);
            tableLayoutBuscarPor.Controls.Add(cbxBuscarPor, 3, 0);
            tableLayoutBuscarPor.Dock = DockStyle.Fill;
            tableLayoutBuscarPor.Location = new Point(10, 3);
            tableLayoutBuscarPor.Margin = new Padding(10, 3, 3, 3);
            tableLayoutBuscarPor.Name = "tableLayoutBuscarPor";
            tableLayoutBuscarPor.RowCount = 1;
            tableLayoutBuscarPor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutBuscarPor.Size = new Size(632, 36);
            tableLayoutBuscarPor.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Right;
            btnActualizar.BackgroundImage = Properties.Resources.update;
            btnActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizar.Location = new Point(592, 3);
            btnActualizar.Margin = new Padding(3, 3, 10, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(30, 30);
            btnActualizar.TabIndex = 2;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.Location = new Point(54, 6);
            txtBuscar.MaxLength = 20;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // labelBuscarPor
            // 
            labelBuscarPor.Anchor = AnchorStyles.Right;
            labelBuscarPor.AutoSize = true;
            labelBuscarPor.Location = new Point(3, 10);
            labelBuscarPor.Name = "labelBuscarPor";
            labelBuscarPor.Size = new Size(45, 15);
            labelBuscarPor.TabIndex = 0;
            labelBuscarPor.Text = "Buscar:";
            labelBuscarPor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBuscarPor
            // 
            lblBuscarPor.Anchor = AnchorStyles.Right;
            lblBuscarPor.AutoSize = true;
            lblBuscarPor.Location = new Point(320, 10);
            lblBuscarPor.Name = "lblBuscarPor";
            lblBuscarPor.Size = new Size(66, 15);
            lblBuscarPor.TabIndex = 8;
            lblBuscarPor.Text = "Buscar por:";
            // 
            // cbxBuscarPor
            // 
            cbxBuscarPor.Anchor = AnchorStyles.Left;
            cbxBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarPor.FormattingEnabled = true;
            cbxBuscarPor.Items.AddRange(new object[] { "Código", "Marca", "Modelo" });
            cbxBuscarPor.Location = new Point(392, 6);
            cbxBuscarPor.Name = "cbxBuscarPor";
            cbxBuscarPor.Size = new Size(112, 23);
            cbxBuscarPor.TabIndex = 9;
            // 
            // gbxCompra
            // 
            gbxCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxCompra.AutoSize = true;
            gbxCompra.Controls.Add(tableLayoutPanel4);
            gbxCompra.Location = new Point(3, 162);
            gbxCompra.Name = "gbxCompra";
            gbxCompra.Size = new Size(651, 359);
            gbxCompra.TabIndex = 1;
            gbxCompra.TabStop = false;
            gbxCompra.Text = "Lista de la Compra";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panelEditar, 0, 1);
            tableLayoutPanel4.Controls.Add(dtvCompra, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(645, 337);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panelEditar
            // 
            panelEditar.AutoSize = true;
            panelEditar.ColumnCount = 8;
            tableLayoutPanel4.SetColumnSpan(panelEditar, 2);
            panelEditar.ColumnStyles.Add(new ColumnStyle());
            panelEditar.ColumnStyles.Add(new ColumnStyle());
            panelEditar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            panelEditar.ColumnStyles.Add(new ColumnStyle());
            panelEditar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            panelEditar.ColumnStyles.Add(new ColumnStyle());
            panelEditar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            panelEditar.ColumnStyles.Add(new ColumnStyle());
            panelEditar.Controls.Add(numPrecioCompra, 5, 0);
            panelEditar.Controls.Add(label1, 4, 0);
            panelEditar.Controls.Add(btnCambiarCantidad, 6, 0);
            panelEditar.Controls.Add(txtProductoPedido, 1, 0);
            panelEditar.Controls.Add(lblProductoPedido, 0, 0);
            panelEditar.Controls.Add(lblCantidadProducto, 2, 0);
            panelEditar.Controls.Add(numCantidadProducto, 3, 0);
            panelEditar.Controls.Add(btnCancelarCambio, 7, 0);
            panelEditar.Dock = DockStyle.Fill;
            panelEditar.Enabled = false;
            panelEditar.Location = new Point(10, 298);
            panelEditar.Margin = new Padding(10, 3, 3, 3);
            panelEditar.Name = "panelEditar";
            panelEditar.RowCount = 1;
            panelEditar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelEditar.Size = new Size(632, 36);
            panelEditar.TabIndex = 6;
            // 
            // numPrecioCompra
            // 
            numPrecioCompra.Anchor = AnchorStyles.Left;
            numPrecioCompra.DecimalPlaces = 2;
            numPrecioCompra.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrecioCompra.Location = new Point(462, 6);
            numPrecioCompra.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrecioCompra.Name = "numPrecioCompra";
            numPrecioCompra.Size = new Size(60, 23);
            numPrecioCompra.TabIndex = 15;
            numPrecioCompra.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(413, 10);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 14;
            label1.Text = "Precio:";
            // 
            // btnCambiarCantidad
            // 
            btnCambiarCantidad.Anchor = AnchorStyles.Right;
            btnCambiarCantidad.BackgroundImage = Properties.Resources.check;
            btnCambiarCantidad.BackgroundImageLayout = ImageLayout.Stretch;
            btnCambiarCantidad.Location = new Point(560, 3);
            btnCambiarCantidad.Name = "btnCambiarCantidad";
            btnCambiarCantidad.Size = new Size(30, 30);
            btnCambiarCantidad.TabIndex = 11;
            btnCambiarCantidad.UseVisualStyleBackColor = true;
            btnCambiarCantidad.Click += btnCambiarCantidad_Click;
            // 
            // txtProductoPedido
            // 
            txtProductoPedido.Anchor = AnchorStyles.Left;
            txtProductoPedido.Location = new Point(68, 6);
            txtProductoPedido.MaxLength = 20;
            txtProductoPedido.Name = "txtProductoPedido";
            txtProductoPedido.ReadOnly = true;
            txtProductoPedido.Size = new Size(186, 23);
            txtProductoPedido.TabIndex = 2;
            // 
            // lblProductoPedido
            // 
            lblProductoPedido.Anchor = AnchorStyles.Right;
            lblProductoPedido.AutoSize = true;
            lblProductoPedido.Location = new Point(3, 10);
            lblProductoPedido.Name = "lblProductoPedido";
            lblProductoPedido.Size = new Size(59, 15);
            lblProductoPedido.TabIndex = 0;
            lblProductoPedido.Text = "Producto:";
            lblProductoPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.Anchor = AnchorStyles.Right;
            lblCantidadProducto.AutoSize = true;
            lblCantidadProducto.Location = new Point(264, 10);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(58, 15);
            lblCantidadProducto.TabIndex = 8;
            lblCantidadProducto.Text = "Cantidad:";
            // 
            // numCantidadProducto
            // 
            numCantidadProducto.Anchor = AnchorStyles.Left;
            numCantidadProducto.Location = new Point(328, 6);
            numCantidadProducto.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCantidadProducto.Name = "numCantidadProducto";
            numCantidadProducto.Size = new Size(60, 23);
            numCantidadProducto.TabIndex = 9;
            numCantidadProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCancelarCambio
            // 
            btnCancelarCambio.Anchor = AnchorStyles.Left;
            btnCancelarCambio.BackgroundImage = Properties.Resources.equis;
            btnCancelarCambio.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelarCambio.Location = new Point(596, 3);
            btnCancelarCambio.Name = "btnCancelarCambio";
            btnCancelarCambio.Size = new Size(30, 30);
            btnCancelarCambio.TabIndex = 10;
            btnCancelarCambio.UseVisualStyleBackColor = true;
            btnCancelarCambio.Click += btnCancelarCambio_Click;
            // 
            // dtvCompra
            // 
            dtvCompra.AllowUserToAddRows = false;
            dtvCompra.AllowUserToDeleteRows = false;
            dtvCompra.AllowUserToResizeRows = false;
            dtvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvCompra.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvCompra.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Subtotal, Editar, Borrar });
            dtvCompra.Dock = DockStyle.Fill;
            dtvCompra.Location = new Point(10, 3);
            dtvCompra.Margin = new Padding(10, 3, 10, 3);
            dtvCompra.MultiSelect = false;
            dtvCompra.Name = "dtvCompra";
            dtvCompra.ReadOnly = true;
            dtvCompra.RowHeadersVisible = false;
            dtvCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvCompra.Size = new Size(625, 289);
            dtvCompra.TabIndex = 5;
            dtvCompra.CellClick += dtvCompra_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn4.HeaderText = "Precio Compra";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 90;
            // 
            // Subtotal
            // 
            Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 90;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.edit;
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = DataGridViewTriState.True;
            Editar.SortMode = DataGridViewColumnSortMode.Automatic;
            Editar.Width = 50;
            // 
            // Borrar
            // 
            Borrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Borrar.HeaderText = "Borrar";
            Borrar.Image = Properties.Resources.x;
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            Borrar.Width = 50;
            // 
            // gbxDatosProveedor
            // 
            gbxDatosProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxDatosProveedor.Controls.Add(tableLayoutPanel6);
            gbxDatosProveedor.Location = new Point(660, 3);
            gbxDatosProveedor.Name = "gbxDatosProveedor";
            gbxDatosProveedor.Size = new Size(344, 153);
            gbxDatosProveedor.TabIndex = 2;
            gbxDatosProveedor.TabStop = false;
            gbxDatosProveedor.Text = "Datos del Proveedor";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.49141F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.50859F));
            tableLayoutPanel6.Controls.Add(txtProveedorMail, 1, 3);
            tableLayoutPanel6.Controls.Add(lblMail, 0, 3);
            tableLayoutPanel6.Controls.Add(txtProveedorDireccion, 1, 2);
            tableLayoutPanel6.Controls.Add(lblProveedorDireccion, 0, 2);
            tableLayoutPanel6.Controls.Add(txtRazonSocial, 1, 1);
            tableLayoutPanel6.Controls.Add(lblClienteNombre, 0, 1);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 19);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 4;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Size = new Size(338, 131);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // txtProveedorMail
            // 
            txtProveedorMail.Anchor = AnchorStyles.Left;
            txtProveedorMail.Location = new Point(95, 104);
            txtProveedorMail.MaxLength = 20;
            txtProveedorMail.Name = "txtProveedorMail";
            txtProveedorMail.ReadOnly = true;
            txtProveedorMail.Size = new Size(200, 23);
            txtProveedorMail.TabIndex = 10;
            // 
            // lblMail
            // 
            lblMail.Anchor = AnchorStyles.Right;
            lblMail.AutoSize = true;
            lblMail.Location = new Point(50, 108);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(39, 15);
            lblMail.TabIndex = 9;
            lblMail.Text = "Email:";
            lblMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProveedorDireccion
            // 
            txtProveedorDireccion.Anchor = AnchorStyles.Left;
            txtProveedorDireccion.Location = new Point(95, 74);
            txtProveedorDireccion.MaxLength = 20;
            txtProveedorDireccion.Name = "txtProveedorDireccion";
            txtProveedorDireccion.ReadOnly = true;
            txtProveedorDireccion.Size = new Size(200, 23);
            txtProveedorDireccion.TabIndex = 8;
            // 
            // lblProveedorDireccion
            // 
            lblProveedorDireccion.Anchor = AnchorStyles.Right;
            lblProveedorDireccion.AutoSize = true;
            lblProveedorDireccion.Location = new Point(29, 78);
            lblProveedorDireccion.Name = "lblProveedorDireccion";
            lblProveedorDireccion.Size = new Size(60, 15);
            lblProveedorDireccion.TabIndex = 7;
            lblProveedorDireccion.Text = "Dirección:";
            lblProveedorDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Anchor = AnchorStyles.Left;
            txtRazonSocial.Location = new Point(95, 45);
            txtRazonSocial.MaxLength = 20;
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.ReadOnly = true;
            txtRazonSocial.Size = new Size(200, 23);
            txtRazonSocial.TabIndex = 6;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.Anchor = AnchorStyles.Right;
            lblClienteNombre.AutoSize = true;
            lblClienteNombre.Location = new Point(14, 49);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(75, 15);
            lblClienteNombre.TabIndex = 5;
            lblClienteNombre.Text = "Razón social:";
            lblClienteNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.AutoSize = true;
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel6.SetColumnSpan(tableLayoutPanel7, 2);
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.Controls.Add(btnCancelarProveedor, 3, 0);
            tableLayoutPanel7.Controls.Add(txtCuilProveedor, 1, 0);
            tableLayoutPanel7.Controls.Add(lblCuilProveedor, 0, 0);
            tableLayoutPanel7.Controls.Add(btnBuscarProveedor, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(10, 3);
            tableLayoutPanel7.Margin = new Padding(10, 3, 3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(325, 36);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // btnCancelarProveedor
            // 
            btnCancelarProveedor.BackgroundImage = Properties.Resources.equis;
            btnCancelarProveedor.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelarProveedor.Enabled = false;
            btnCancelarProveedor.Location = new Point(292, 3);
            btnCancelarProveedor.Name = "btnCancelarProveedor";
            btnCancelarProveedor.Size = new Size(30, 30);
            btnCancelarProveedor.TabIndex = 4;
            btnCancelarProveedor.UseVisualStyleBackColor = true;
            btnCancelarProveedor.Click += btnCancelarProveedor_Click;
            // 
            // txtCuilProveedor
            // 
            txtCuilProveedor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCuilProveedor.Location = new Point(44, 6);
            txtCuilProveedor.MaxLength = 20;
            txtCuilProveedor.Name = "txtCuilProveedor";
            txtCuilProveedor.Size = new Size(206, 23);
            txtCuilProveedor.TabIndex = 2;
            // 
            // lblCuilProveedor
            // 
            lblCuilProveedor.Anchor = AnchorStyles.Right;
            lblCuilProveedor.AutoSize = true;
            lblCuilProveedor.Location = new Point(3, 10);
            lblCuilProveedor.Name = "lblCuilProveedor";
            lblCuilProveedor.Size = new Size(35, 15);
            lblCuilProveedor.TabIndex = 0;
            lblCuilProveedor.Text = "CUIL:";
            lblCuilProveedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.BackgroundImage = Properties.Resources.search;
            btnBuscarProveedor.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscarProveedor.Location = new Point(256, 3);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(30, 30);
            btnBuscarProveedor.TabIndex = 3;
            btnBuscarProveedor.UseVisualStyleBackColor = true;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // gpxDatosCompra
            // 
            gpxDatosCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpxDatosCompra.Controls.Add(tableLayoutPanel8);
            gpxDatosCompra.Location = new Point(660, 162);
            gpxDatosCompra.Name = "gpxDatosCompra";
            gpxDatosCompra.Size = new Size(344, 359);
            gpxDatosCompra.TabIndex = 3;
            gpxDatosCompra.TabStop = false;
            gpxDatosCompra.Text = "Datos de la Compra";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.1134F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.8865967F));
            tableLayoutPanel8.Controls.Add(cbxCajas, 1, 1);
            tableLayoutPanel8.Controls.Add(lblCaja, 0, 1);
            tableLayoutPanel8.Controls.Add(txtFecha, 1, 0);
            tableLayoutPanel8.Controls.Add(lblFecha, 0, 0);
            tableLayoutPanel8.Controls.Add(lblTotalPagar, 0, 3);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 19);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 5;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Size = new Size(338, 337);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // cbxCajas
            // 
            cbxCajas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxCajas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCajas.FormattingEnabled = true;
            cbxCajas.Location = new Point(128, 72);
            cbxCajas.Name = "cbxCajas";
            cbxCajas.Size = new Size(207, 23);
            cbxCajas.TabIndex = 10;
            // 
            // lblCaja
            // 
            lblCaja.Anchor = AnchorStyles.Right;
            lblCaja.AutoSize = true;
            lblCaja.Location = new Point(89, 76);
            lblCaja.Name = "lblCaja";
            lblCaja.Size = new Size(33, 15);
            lblCaja.TabIndex = 8;
            lblCaja.Text = "Caja:";
            lblCaja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Left;
            txtFecha.Location = new Point(128, 16);
            txtFecha.MaxLength = 20;
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(93, 23);
            txtFecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(81, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.Anchor = AnchorStyles.None;
            lblTotalPagar.AutoSize = true;
            tableLayoutPanel8.SetColumnSpan(lblTotalPagar, 2);
            lblTotalPagar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPagar.Location = new Point(100, 181);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(137, 30);
            lblTotalPagar.TabIndex = 15;
            lblTotalPagar.Text = "TOTAL: $0.00";
            // 
            // FormNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 214, 255);
            ClientSize = new Size(1096, 846);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNuevaCompra";
            Text = "FormNuevaCompra";
            Load += FormNuevaCompra_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            gbxDatosEmpleado.ResumeLayout(false);
            gbxDatosEmpleado.PerformLayout();
            panelEmpleado.ResumeLayout(false);
            panelEmpleado.PerformLayout();
            panelDatosGeneral.ResumeLayout(false);
            panelDatosGeneral.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            gbxListaProductos.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvProductos).EndInit();
            tableLayoutBuscarPor.ResumeLayout(false);
            tableLayoutBuscarPor.PerformLayout();
            gbxCompra.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecioCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvCompra).EndInit();
            gbxDatosProveedor.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            gpxDatosCompra.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private GroupBox gbxDatosEmpleado;
        private TableLayoutPanel panelEmpleado;
        private TextBox txtRol;
        private Label lblRol;
        private TextBox txtPersonalNombre;
        private Label label8;
        private TextBox txtIdPersonal;
        private Label lblIdPersonal;
        private TableLayoutPanel panelDatosGeneral;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnLimpiarTodo;
        private Button btnRegistrarCompra;
        private GroupBox gbxListaProductos;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dtvProductos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewImageColumn Agregar;
        private TableLayoutPanel tableLayoutBuscarPor;
        private Button btnActualizar;
        private TextBox txtBuscar;
        private Label labelBuscarPor;
        private Label lblBuscarPor;
        private ComboBox cbxBuscarPor;
        private GroupBox gbxCompra;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel panelEditar;
        private Button btnCambiarCantidad;
        private TextBox txtProductoPedido;
        private Label lblProductoPedido;
        private Label lblCantidadProducto;
        private NumericUpDown numCantidadProducto;
        private Button btnCancelarCambio;
        private DataGridView dtvCompra;
        private GroupBox gbxDatosProveedor;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtProveedorMail;
        private Label lblMail;
        private TextBox txtProveedorDireccion;
        private Label lblProveedorDireccion;
        private TextBox txtRazonSocial;
        private Label lblClienteNombre;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnCancelarProveedor;
        private TextBox txtCuilProveedor;
        private Label lblCuilProveedor;
        private Button btnBuscarProveedor;
        private GroupBox gpxDatosCompra;
        private TableLayoutPanel tableLayoutPanel8;
        private ComboBox cbxCajas;
        private Label lblCaja;
        private TextBox txtFecha;
        private Label lblFecha;
        private Label lblTotalPagar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Borrar;
        private NumericUpDown numPrecioCompra;
        private Label label1;
    }
}