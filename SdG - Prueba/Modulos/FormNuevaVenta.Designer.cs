namespace SdG___Prueba.Modulos
{
    partial class FormNuevaVenta
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
            btnRegistrarVenta = new Button();
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
            gbxPedido = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panelEditar = new TableLayoutPanel();
            lblStockProducto = new Label();
            btnCambiarCantidad = new Button();
            txtProductoPedido = new TextBox();
            lblProductoPedido = new Label();
            lblCantidadProducto = new Label();
            numCantidadProducto = new NumericUpDown();
            btnCancelarCambio = new Button();
            lblCantidadStock = new Label();
            dtvPedido = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            Borrar = new DataGridViewImageColumn();
            gbxDatosCliente = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtClienteMail = new TextBox();
            lblClienteMail = new Label();
            txtClienteDireccion = new TextBox();
            lblClienteDireccion = new Label();
            txtClienteNombre = new TextBox();
            lblClienteNombre = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnCancelarCliente = new Button();
            txtClienteDni = new TextBox();
            lblClienteDni = new Label();
            btnBuscarCliente = new Button();
            gpxDatosVenta = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            numCambioDevuelto = new NumericUpDown();
            lblCambio = new Label();
            lblTotalPagado = new Label();
            cbxCajas = new ComboBox();
            lblCaja = new Label();
            txtFecha = new TextBox();
            lblFecha = new Label();
            numTotalPagado = new NumericUpDown();
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
            gbxPedido.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvPedido).BeginInit();
            gbxDatosCliente.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            gpxDatosVenta.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCambioDevuelto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalPagado).BeginInit();
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
            tableLayoutPanel2.Size = new Size(978, 784);
            tableLayoutPanel2.TabIndex = 3;
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
            tableLayoutPanel1.Size = new Size(878, 731);
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
            lblTitulo.Size = new Size(872, 95);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Nueva venta";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxDatosEmpleado
            // 
            gbxDatosEmpleado.AutoSize = true;
            gbxDatosEmpleado.Controls.Add(panelEmpleado);
            gbxDatosEmpleado.Dock = DockStyle.Fill;
            gbxDatosEmpleado.Location = new Point(3, 98);
            gbxDatosEmpleado.Name = "gbxDatosEmpleado";
            gbxDatosEmpleado.Size = new Size(872, 56);
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
            panelEmpleado.Size = new Size(866, 34);
            panelEmpleado.TabIndex = 0;
            // 
            // txtRol
            // 
            txtRol.Anchor = AnchorStyles.Left;
            txtRol.Location = new Point(723, 3);
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
            lblRol.Location = new Point(662, 4);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(55, 21);
            lblRol.TabIndex = 17;
            lblRol.Text = "Cargo:";
            // 
            // txtPersonalNombre
            // 
            txtPersonalNombre.Anchor = AnchorStyles.Left;
            txtPersonalNombre.Location = new Point(366, 3);
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
            label8.Location = new Point(289, 4);
            label8.Name = "label8";
            label8.Size = new Size(71, 21);
            label8.TabIndex = 15;
            label8.Text = "Nombre:";
            // 
            // txtIdPersonal
            // 
            txtIdPersonal.Anchor = AnchorStyles.Left;
            txtIdPersonal.Location = new Point(147, 3);
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
            lblIdPersonal.Location = new Point(50, 4);
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
            panelDatosGeneral.Controls.Add(gbxPedido, 0, 1);
            panelDatosGeneral.Controls.Add(gbxDatosCliente, 1, 0);
            panelDatosGeneral.Controls.Add(gpxDatosVenta, 1, 1);
            panelDatosGeneral.Location = new Point(3, 160);
            panelDatosGeneral.Name = "panelDatosGeneral";
            panelDatosGeneral.RowCount = 3;
            panelDatosGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 30.45775F));
            panelDatosGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 69.54225F));
            panelDatosGeneral.RowStyles.Add(new RowStyle());
            panelDatosGeneral.Size = new Size(872, 568);
            panelDatosGeneral.TabIndex = 3;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.AutoSize = true;
            tableLayoutPanel9.ColumnCount = 2;
            panelDatosGeneral.SetColumnSpan(tableLayoutPanel9, 2);
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Controls.Add(btnLimpiarTodo, 0, 0);
            tableLayoutPanel9.Controls.Add(btnRegistrarVenta, 3, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(10, 527);
            tableLayoutPanel9.Margin = new Padding(10, 3, 3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(859, 38);
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
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Anchor = AnchorStyles.Right;
            btnRegistrarVenta.AutoSize = true;
            btnRegistrarVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarVenta.Location = new Point(725, 3);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(131, 31);
            btnRegistrarVenta.TabIndex = 9;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // gbxListaProductos
            // 
            gbxListaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxListaProductos.AutoSize = true;
            gbxListaProductos.Controls.Add(tableLayoutPanel3);
            gbxListaProductos.Location = new Point(3, 3);
            gbxListaProductos.Name = "gbxListaProductos";
            gbxListaProductos.Size = new Size(563, 153);
            gbxListaProductos.TabIndex = 0;
            gbxListaProductos.TabStop = false;
            gbxListaProductos.Text = "Productos en Stock";
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
            tableLayoutPanel3.Size = new Size(557, 131);
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
            dtvProductos.Size = new Size(537, 83);
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
            tableLayoutBuscarPor.Size = new Size(544, 36);
            tableLayoutBuscarPor.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Right;
            btnActualizar.BackgroundImage = Properties.Resources.update;
            btnActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizar.Location = new Point(504, 3);
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
            lblBuscarPor.Location = new Point(285, 10);
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
            cbxBuscarPor.Location = new Point(357, 6);
            cbxBuscarPor.Name = "cbxBuscarPor";
            cbxBuscarPor.Size = new Size(112, 23);
            cbxBuscarPor.TabIndex = 9;
            // 
            // gbxPedido
            // 
            gbxPedido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxPedido.AutoSize = true;
            gbxPedido.Controls.Add(tableLayoutPanel4);
            gbxPedido.Location = new Point(3, 162);
            gbxPedido.Name = "gbxPedido";
            gbxPedido.Size = new Size(563, 359);
            gbxPedido.TabIndex = 1;
            gbxPedido.TabStop = false;
            gbxPedido.Text = "Lista del Pedido";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panelEditar, 0, 1);
            tableLayoutPanel4.Controls.Add(dtvPedido, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(557, 337);
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
            panelEditar.Controls.Add(lblStockProducto, 4, 0);
            panelEditar.Controls.Add(btnCambiarCantidad, 6, 0);
            panelEditar.Controls.Add(txtProductoPedido, 1, 0);
            panelEditar.Controls.Add(lblProductoPedido, 0, 0);
            panelEditar.Controls.Add(lblCantidadProducto, 2, 0);
            panelEditar.Controls.Add(numCantidadProducto, 3, 0);
            panelEditar.Controls.Add(btnCancelarCambio, 7, 0);
            panelEditar.Controls.Add(lblCantidadStock, 5, 0);
            panelEditar.Dock = DockStyle.Fill;
            panelEditar.Enabled = false;
            panelEditar.Location = new Point(10, 298);
            panelEditar.Margin = new Padding(10, 3, 3, 3);
            panelEditar.Name = "panelEditar";
            panelEditar.RowCount = 1;
            panelEditar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelEditar.Size = new Size(544, 36);
            panelEditar.TabIndex = 6;
            // 
            // lblStockProducto
            // 
            lblStockProducto.Anchor = AnchorStyles.Right;
            lblStockProducto.AutoSize = true;
            lblStockProducto.Location = new Point(389, 10);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(39, 15);
            lblStockProducto.TabIndex = 12;
            lblStockProducto.Text = "Stock:";
            // 
            // btnCambiarCantidad
            // 
            btnCambiarCantidad.Anchor = AnchorStyles.Right;
            btnCambiarCantidad.BackgroundImage = Properties.Resources.check;
            btnCambiarCantidad.BackgroundImageLayout = ImageLayout.Stretch;
            btnCambiarCantidad.Location = new Point(475, 3);
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
            lblCantidadProducto.Location = new Point(260, 3);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(48, 30);
            lblCantidadProducto.TabIndex = 8;
            lblCantidadProducto.Text = "Cantidad:";
            // 
            // numCantidadProducto
            // 
            numCantidadProducto.Anchor = AnchorStyles.Left;
            numCantidadProducto.Location = new Point(314, 6);
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
            btnCancelarCambio.Location = new Point(511, 3);
            btnCancelarCambio.Name = "btnCancelarCambio";
            btnCancelarCambio.Size = new Size(30, 30);
            btnCancelarCambio.TabIndex = 10;
            btnCancelarCambio.UseVisualStyleBackColor = true;
            btnCancelarCambio.Click += btnCancelarCambio_Click;
            // 
            // lblCantidadStock
            // 
            lblCantidadStock.Anchor = AnchorStyles.Left;
            lblCantidadStock.AutoSize = true;
            lblCantidadStock.Font = new Font("Segoe UI", 10F);
            lblCantidadStock.Location = new Point(434, 8);
            lblCantidadStock.Name = "lblCantidadStock";
            lblCantidadStock.Size = new Size(17, 19);
            lblCantidadStock.TabIndex = 13;
            lblCantidadStock.Text = "0";
            // 
            // dtvPedido
            // 
            dtvPedido.AllowUserToAddRows = false;
            dtvPedido.AllowUserToDeleteRows = false;
            dtvPedido.AllowUserToResizeRows = false;
            dtvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvPedido.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvPedido.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Subtotal, Editar, Borrar });
            dtvPedido.Dock = DockStyle.Fill;
            dtvPedido.Location = new Point(10, 3);
            dtvPedido.Margin = new Padding(10, 3, 10, 3);
            dtvPedido.MultiSelect = false;
            dtvPedido.Name = "dtvPedido";
            dtvPedido.ReadOnly = true;
            dtvPedido.RowHeadersVisible = false;
            dtvPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvPedido.Size = new Size(537, 289);
            dtvPedido.TabIndex = 5;
            dtvPedido.CellClick += dtvPedido_CellClick;
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
            dataGridViewTextBoxColumn4.HeaderText = "Precio";
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
            // gbxDatosCliente
            // 
            gbxDatosCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbxDatosCliente.Controls.Add(tableLayoutPanel6);
            gbxDatosCliente.Location = new Point(572, 3);
            gbxDatosCliente.Name = "gbxDatosCliente";
            gbxDatosCliente.Size = new Size(297, 153);
            gbxDatosCliente.TabIndex = 2;
            gbxDatosCliente.TabStop = false;
            gbxDatosCliente.Text = "Datos del Cliente";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.49141F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.50859F));
            tableLayoutPanel6.Controls.Add(txtClienteMail, 1, 3);
            tableLayoutPanel6.Controls.Add(lblClienteMail, 0, 3);
            tableLayoutPanel6.Controls.Add(txtClienteDireccion, 1, 2);
            tableLayoutPanel6.Controls.Add(lblClienteDireccion, 0, 2);
            tableLayoutPanel6.Controls.Add(txtClienteNombre, 1, 1);
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
            tableLayoutPanel6.Size = new Size(291, 131);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // txtClienteMail
            // 
            txtClienteMail.Anchor = AnchorStyles.Left;
            txtClienteMail.Location = new Point(83, 104);
            txtClienteMail.MaxLength = 20;
            txtClienteMail.Name = "txtClienteMail";
            txtClienteMail.ReadOnly = true;
            txtClienteMail.Size = new Size(200, 23);
            txtClienteMail.TabIndex = 10;
            // 
            // lblClienteMail
            // 
            lblClienteMail.Anchor = AnchorStyles.Right;
            lblClienteMail.AutoSize = true;
            lblClienteMail.Location = new Point(38, 108);
            lblClienteMail.Name = "lblClienteMail";
            lblClienteMail.Size = new Size(39, 15);
            lblClienteMail.TabIndex = 9;
            lblClienteMail.Text = "Email:";
            lblClienteMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClienteDireccion
            // 
            txtClienteDireccion.Anchor = AnchorStyles.Left;
            txtClienteDireccion.Location = new Point(83, 74);
            txtClienteDireccion.MaxLength = 20;
            txtClienteDireccion.Name = "txtClienteDireccion";
            txtClienteDireccion.ReadOnly = true;
            txtClienteDireccion.Size = new Size(200, 23);
            txtClienteDireccion.TabIndex = 8;
            // 
            // lblClienteDireccion
            // 
            lblClienteDireccion.Anchor = AnchorStyles.Right;
            lblClienteDireccion.AutoSize = true;
            lblClienteDireccion.Location = new Point(17, 78);
            lblClienteDireccion.Name = "lblClienteDireccion";
            lblClienteDireccion.Size = new Size(60, 15);
            lblClienteDireccion.TabIndex = 7;
            lblClienteDireccion.Text = "Dirección:";
            lblClienteDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Anchor = AnchorStyles.Left;
            txtClienteNombre.Location = new Point(83, 45);
            txtClienteNombre.MaxLength = 20;
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.ReadOnly = true;
            txtClienteNombre.Size = new Size(200, 23);
            txtClienteNombre.TabIndex = 6;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.Anchor = AnchorStyles.Right;
            lblClienteNombre.AutoSize = true;
            lblClienteNombre.Location = new Point(23, 49);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(54, 15);
            lblClienteNombre.TabIndex = 5;
            lblClienteNombre.Text = "Nombre:";
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
            tableLayoutPanel7.Controls.Add(btnCancelarCliente, 3, 0);
            tableLayoutPanel7.Controls.Add(txtClienteDni, 1, 0);
            tableLayoutPanel7.Controls.Add(lblClienteDni, 0, 0);
            tableLayoutPanel7.Controls.Add(btnBuscarCliente, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(10, 3);
            tableLayoutPanel7.Margin = new Padding(10, 3, 3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(278, 36);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // btnCancelarCliente
            // 
            btnCancelarCliente.BackgroundImage = Properties.Resources.equis;
            btnCancelarCliente.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelarCliente.Enabled = false;
            btnCancelarCliente.Location = new Point(245, 3);
            btnCancelarCliente.Name = "btnCancelarCliente";
            btnCancelarCliente.Size = new Size(30, 30);
            btnCancelarCliente.TabIndex = 4;
            btnCancelarCliente.UseVisualStyleBackColor = true;
            btnCancelarCliente.Click += btnCancelarCliente_Click;
            // 
            // txtClienteDni
            // 
            txtClienteDni.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtClienteDni.Location = new Point(39, 6);
            txtClienteDni.MaxLength = 20;
            txtClienteDni.Name = "txtClienteDni";
            txtClienteDni.Size = new Size(164, 23);
            txtClienteDni.TabIndex = 2;
            // 
            // lblClienteDni
            // 
            lblClienteDni.Anchor = AnchorStyles.Right;
            lblClienteDni.AutoSize = true;
            lblClienteDni.Location = new Point(3, 10);
            lblClienteDni.Name = "lblClienteDni";
            lblClienteDni.Size = new Size(30, 15);
            lblClienteDni.TabIndex = 0;
            lblClienteDni.Text = "DNI:";
            lblClienteDni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackgroundImage = Properties.Resources.search;
            btnBuscarCliente.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscarCliente.Location = new Point(209, 3);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(30, 30);
            btnBuscarCliente.TabIndex = 3;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // gpxDatosVenta
            // 
            gpxDatosVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpxDatosVenta.Controls.Add(tableLayoutPanel8);
            gpxDatosVenta.Location = new Point(572, 162);
            gpxDatosVenta.Name = "gpxDatosVenta";
            gpxDatosVenta.Size = new Size(297, 359);
            gpxDatosVenta.TabIndex = 3;
            gpxDatosVenta.TabStop = false;
            gpxDatosVenta.Text = "Datos de la Venta";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.1134F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.8865967F));
            tableLayoutPanel8.Controls.Add(numCambioDevuelto, 1, 3);
            tableLayoutPanel8.Controls.Add(lblCambio, 0, 3);
            tableLayoutPanel8.Controls.Add(lblTotalPagado, 0, 2);
            tableLayoutPanel8.Controls.Add(cbxCajas, 1, 1);
            tableLayoutPanel8.Controls.Add(lblCaja, 0, 1);
            tableLayoutPanel8.Controls.Add(txtFecha, 1, 0);
            tableLayoutPanel8.Controls.Add(lblFecha, 0, 0);
            tableLayoutPanel8.Controls.Add(numTotalPagado, 1, 2);
            tableLayoutPanel8.Controls.Add(lblTotalPagar, 0, 4);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 19);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 5;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Size = new Size(291, 337);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // numCambioDevuelto
            // 
            numCambioDevuelto.Anchor = AnchorStyles.Left;
            numCambioDevuelto.DecimalPlaces = 2;
            numCambioDevuelto.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numCambioDevuelto.Location = new Point(110, 184);
            numCambioDevuelto.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numCambioDevuelto.Name = "numCambioDevuelto";
            numCambioDevuelto.ReadOnly = true;
            numCambioDevuelto.Size = new Size(120, 23);
            numCambioDevuelto.TabIndex = 14;
            // 
            // lblCambio
            // 
            lblCambio.Anchor = AnchorStyles.Right;
            lblCambio.AutoSize = true;
            lblCambio.Location = new Point(3, 188);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(101, 15);
            lblCambio.TabIndex = 13;
            lblCambio.Text = "Cambio devuelto:";
            lblCambio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPagado
            // 
            lblTotalPagado.Anchor = AnchorStyles.Right;
            lblTotalPagado.AutoSize = true;
            lblTotalPagado.Location = new Point(25, 132);
            lblTotalPagado.Name = "lblTotalPagado";
            lblTotalPagado.Size = new Size(79, 15);
            lblTotalPagado.TabIndex = 11;
            lblTotalPagado.Text = "Total pagado:";
            lblTotalPagado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxCajas
            // 
            cbxCajas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxCajas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCajas.FormattingEnabled = true;
            cbxCajas.Location = new Point(110, 72);
            cbxCajas.Name = "cbxCajas";
            cbxCajas.Size = new Size(178, 23);
            cbxCajas.TabIndex = 10;
            // 
            // lblCaja
            // 
            lblCaja.Anchor = AnchorStyles.Right;
            lblCaja.AutoSize = true;
            lblCaja.Location = new Point(71, 76);
            lblCaja.Name = "lblCaja";
            lblCaja.Size = new Size(33, 15);
            lblCaja.TabIndex = 8;
            lblCaja.Text = "Caja:";
            lblCaja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Left;
            txtFecha.Location = new Point(110, 16);
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
            lblFecha.Location = new Point(63, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numTotalPagado
            // 
            numTotalPagado.Anchor = AnchorStyles.Left;
            numTotalPagado.DecimalPlaces = 2;
            numTotalPagado.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numTotalPagado.Location = new Point(110, 128);
            numTotalPagado.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numTotalPagado.Name = "numTotalPagado";
            numTotalPagado.Size = new Size(120, 23);
            numTotalPagado.TabIndex = 12;
            numTotalPagado.ValueChanged += numTotalPagado_ValueChanged;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.Anchor = AnchorStyles.None;
            lblTotalPagar.AutoSize = true;
            tableLayoutPanel8.SetColumnSpan(lblTotalPagar, 2);
            lblTotalPagar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPagar.Location = new Point(30, 265);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(230, 30);
            lblTotalPagar.TabIndex = 15;
            lblTotalPagar.Text = "TOTAL A PAGAR: $0.00";
            // 
            // FormNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(164, 214, 255);
            ClientSize = new Size(961, 846);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNuevaVenta";
            Text = "FormVentas";
            Load += FormNuevaVenta_Load;
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
            gbxPedido.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvPedido).EndInit();
            gbxDatosCliente.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            gpxDatosVenta.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCambioDevuelto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalPagado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private GroupBox gbxDatosEmpleado;
        private TableLayoutPanel panelEmpleado;
        private Label lblIdPersonal;
        private TextBox txtIdPersonal;
        private Label label8;
        private TextBox txtPersonalNombre;
        private Label lblRol;
        private TextBox txtRol;
        private TableLayoutPanel panelDatosGeneral;
        private GroupBox gbxListaProductos;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutBuscarPor;
        private Button btnActualizar;
        private TextBox txtBuscar;
        private Label labelBuscarPor;
        private Label lblBuscarPor;
        private ComboBox cbxBuscarPor;
        private DataGridView dtvProductos;
        private GroupBox gbxPedido;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dtvPedido;
        private GroupBox gbxDatosCliente;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox txtClienteDni;
        private Label lblClienteDni;
        private Button btnBuscarCliente;
        private Button btnCancelarCliente;
        private TextBox txtClienteNombre;
        private Label lblClienteNombre;
        private TextBox txtClienteMail;
        private Label lblClienteMail;
        private TextBox txtClienteDireccion;
        private Label lblClienteDireccion;
        private GroupBox gpxDatosVenta;
        private TableLayoutPanel tableLayoutPanel8;
        private Label lblTotalPagado;
        private ComboBox cbxCajas;
        private Label lblCaja;
        private TextBox txtFecha;
        private Label lblFecha;
        private NumericUpDown numCambioDevuelto;
        private Label lblCambio;
        private NumericUpDown numTotalPagado;
        private Label lblTotalPagar;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnLimpiarTodo;
        private Button btnRegistrarVenta;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewImageColumn Agregar;
        private TableLayoutPanel panelEditar;
        private TextBox txtProductoPedido;
        private Label lblProductoPedido;
        private Label lblCantidadProducto;
        private NumericUpDown numCantidadProducto;
        private Button btnCambiarCantidad;
        private Button btnCancelarCambio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Borrar;
        private Label lblStockProducto;
        private Label lblCantidadStock;
    }
}