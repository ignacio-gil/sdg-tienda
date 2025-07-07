namespace SdG___Prueba.Modulos
{
    partial class FormListaDeVentas
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
            tableLayoutSuperior = new TableLayoutPanel();
            lblTitulo = new Label();
            panelBuscar = new TableLayoutPanel();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            labelBuscarPor = new Label();
            dtvVentas = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            NroVenta = new DataGridViewTextBoxColumn();
            ImporteTotal = new DataGridViewTextBoxColumn();
            ImportePagado = new DataGridViewTextBoxColumn();
            ImporteVuelto = new DataGridViewTextBoxColumn();
            Caja = new DataGridViewTextBoxColumn();
            info = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            tableLayoutInferior = new TableLayoutPanel();
            txtHora = new TextBox();
            label2 = new Label();
            lblIDCliente = new Label();
            txtIdVenta = new TextBox();
            dtvPedido = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            txtDireccionCliente = new TextBox();
            lblDireccion = new Label();
            lblMail = new Label();
            txtMailCliente = new TextBox();
            txtDniCliente = new TextBox();
            lblDni = new Label();
            txtNombreCliente = new TextBox();
            lblNombre = new Label();
            label3 = new Label();
            lblProvincia = new Label();
            txtCargo = new TextBox();
            lblApellidos = new Label();
            txtNombrePersonal = new TextBox();
            label5 = new Label();
            txtIdPersonal = new TextBox();
            label4 = new Label();
            txtFecha = new TextBox();
            label1 = new Label();
            lblTotalVenta = new Label();
            btnCerrarInfo = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutSuperior.SuspendLayout();
            panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvVentas).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvPedido).BeginInit();
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
            tableLayoutPanel2.Size = new Size(1116, 784);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutSuperior, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Location = new Point(50, 0);
            tableLayoutPanel1.Margin = new Padding(50, 0, 50, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 422F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1016, 731);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutSuperior
            // 
            tableLayoutSuperior.ColumnCount = 3;
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.Controls.Add(lblTitulo, 0, 0);
            tableLayoutSuperior.Controls.Add(panelBuscar, 0, 1);
            tableLayoutSuperior.Controls.Add(dtvVentas, 0, 2);
            tableLayoutSuperior.Dock = DockStyle.Fill;
            tableLayoutSuperior.Location = new Point(3, 3);
            tableLayoutSuperior.Name = "tableLayoutSuperior";
            tableLayoutSuperior.RowCount = 4;
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.Size = new Size(1010, 416);
            tableLayoutSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            tableLayoutSuperior.SetColumnSpan(lblTitulo, 3);
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 40, 0, 25);
            lblTitulo.Size = new Size(1004, 95);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Lista de Ventas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBuscar
            // 
            panelBuscar.AutoSize = true;
            panelBuscar.ColumnCount = 6;
            tableLayoutSuperior.SetColumnSpan(panelBuscar, 3);
            panelBuscar.ColumnStyles.Add(new ColumnStyle());
            panelBuscar.ColumnStyles.Add(new ColumnStyle());
            panelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.0000038F));
            panelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            panelBuscar.ColumnStyles.Add(new ColumnStyle());
            panelBuscar.ColumnStyles.Add(new ColumnStyle());
            panelBuscar.Controls.Add(btnActualizar, 5, 0);
            panelBuscar.Controls.Add(txtBuscar, 1, 0);
            panelBuscar.Controls.Add(labelBuscarPor, 0, 0);
            panelBuscar.Dock = DockStyle.Fill;
            panelBuscar.Location = new Point(10, 98);
            panelBuscar.Margin = new Padding(10, 3, 3, 3);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.RowCount = 1;
            panelBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBuscar.Size = new Size(997, 36);
            panelBuscar.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Right;
            btnActualizar.BackgroundImage = Properties.Resources.update;
            btnActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizar.Location = new Point(957, 3);
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
            txtBuscar.Location = new Point(113, 6);
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
            labelBuscarPor.Size = new Size(104, 15);
            labelBuscarPor.TabIndex = 0;
            labelBuscarPor.Text = "Buscar N° Factura:";
            labelBuscarPor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtvVentas
            // 
            dtvVentas.AllowUserToAddRows = false;
            dtvVentas.AllowUserToDeleteRows = false;
            dtvVentas.AllowUserToResizeRows = false;
            dtvVentas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvVentas.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvVentas.Columns.AddRange(new DataGridViewColumn[] { Fecha, Hora, NroVenta, ImporteTotal, ImportePagado, ImporteVuelto, Caja, info });
            tableLayoutSuperior.SetColumnSpan(dtvVentas, 3);
            dtvVentas.Location = new Point(10, 140);
            dtvVentas.Margin = new Padding(10, 3, 10, 3);
            dtvVentas.MultiSelect = false;
            dtvVentas.Name = "dtvVentas";
            dtvVentas.ReadOnly = true;
            dtvVentas.RowHeadersVisible = false;
            dtvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvVentas.Size = new Size(990, 250);
            dtvVentas.TabIndex = 4;
            dtvVentas.CellClick += dtvVentas_CellClick;
            // 
            // Fecha
            // 
            Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 80;
            // 
            // Hora
            // 
            Hora.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            Hora.Width = 70;
            // 
            // NroVenta
            // 
            NroVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NroVenta.HeaderText = "N° Venta";
            NroVenta.Name = "NroVenta";
            NroVenta.ReadOnly = true;
            // 
            // ImporteTotal
            // 
            ImporteTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImporteTotal.HeaderText = "Importe Total";
            ImporteTotal.Name = "ImporteTotal";
            ImporteTotal.ReadOnly = true;
            // 
            // ImportePagado
            // 
            ImportePagado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImportePagado.HeaderText = "Importe Pagado";
            ImportePagado.Name = "ImportePagado";
            ImportePagado.ReadOnly = true;
            // 
            // ImporteVuelto
            // 
            ImporteVuelto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImporteVuelto.HeaderText = "Importe Vuelto";
            ImporteVuelto.Name = "ImporteVuelto";
            ImporteVuelto.ReadOnly = true;
            // 
            // Caja
            // 
            Caja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Caja.HeaderText = "Caja";
            Caja.Name = "Caja";
            Caja.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            info.HeaderText = "+Info";
            info.Image = Properties.Resources.info;
            info.Name = "info";
            info.ReadOnly = true;
            info.Resizable = DataGridViewTriState.True;
            info.SortMode = DataGridViewColumnSortMode.Automatic;
            info.Width = 40;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutInferior);
            groupBox1.Location = new Point(3, 425);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(1010, 306);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de la Venta";
            groupBox1.Visible = false;
            // 
            // tableLayoutInferior
            // 
            tableLayoutInferior.ColumnCount = 7;
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.Controls.Add(txtHora, 4, 1);
            tableLayoutInferior.Controls.Add(label2, 3, 1);
            tableLayoutInferior.Controls.Add(lblIDCliente, 0, 0);
            tableLayoutInferior.Controls.Add(txtIdVenta, 1, 0);
            tableLayoutInferior.Controls.Add(dtvPedido, 5, 0);
            tableLayoutInferior.Controls.Add(txtDireccionCliente, 1, 7);
            tableLayoutInferior.Controls.Add(lblDireccion, 0, 7);
            tableLayoutInferior.Controls.Add(lblMail, 0, 6);
            tableLayoutInferior.Controls.Add(txtMailCliente, 1, 6);
            tableLayoutInferior.Controls.Add(txtDniCliente, 1, 5);
            tableLayoutInferior.Controls.Add(lblDni, 0, 5);
            tableLayoutInferior.Controls.Add(txtNombreCliente, 1, 4);
            tableLayoutInferior.Controls.Add(lblNombre, 0, 4);
            tableLayoutInferior.Controls.Add(label3, 0, 3);
            tableLayoutInferior.Controls.Add(lblProvincia, 3, 6);
            tableLayoutInferior.Controls.Add(txtCargo, 4, 6);
            tableLayoutInferior.Controls.Add(lblApellidos, 3, 5);
            tableLayoutInferior.Controls.Add(txtNombrePersonal, 4, 5);
            tableLayoutInferior.Controls.Add(label5, 3, 4);
            tableLayoutInferior.Controls.Add(txtIdPersonal, 4, 4);
            tableLayoutInferior.Controls.Add(label4, 3, 3);
            tableLayoutInferior.Controls.Add(txtFecha, 4, 0);
            tableLayoutInferior.Controls.Add(label1, 3, 0);
            tableLayoutInferior.Controls.Add(btnCerrarInfo, 6, 0);
            tableLayoutInferior.Controls.Add(lblTotalVenta, 3, 8);
            tableLayoutInferior.Dock = DockStyle.Fill;
            tableLayoutInferior.Location = new Point(10, 26);
            tableLayoutInferior.Name = "tableLayoutInferior";
            tableLayoutInferior.RowCount = 9;
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutInferior.Size = new Size(990, 270);
            tableLayoutInferior.TabIndex = 0;
            // 
            // txtHora
            // 
            txtHora.Anchor = AnchorStyles.Left;
            txtHora.Location = new Point(328, 34);
            txtHora.Name = "txtHora";
            txtHora.ReadOnly = true;
            txtHora.ShortcutsEnabled = false;
            txtHora.Size = new Size(107, 23);
            txtHora.TabIndex = 46;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(275, 35);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 45;
            label2.Text = "Hora:";
            // 
            // lblIDCliente
            // 
            lblIDCliente.Anchor = AnchorStyles.Right;
            lblIDCliente.AutoSize = true;
            lblIDCliente.Font = new Font("Segoe UI", 12F);
            lblIDCliente.Location = new Point(3, 5);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(86, 21);
            lblIDCliente.TabIndex = 0;
            lblIDCliente.Text = "Nro. Venta:";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(95, 3);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.ReadOnly = true;
            txtIdVenta.ShortcutsEnabled = false;
            txtIdVenta.Size = new Size(120, 23);
            txtIdVenta.TabIndex = 1;
            // 
            // dtvPedido
            // 
            dtvPedido.AllowUserToAddRows = false;
            dtvPedido.AllowUserToDeleteRows = false;
            dtvPedido.AllowUserToResizeRows = false;
            dtvPedido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dtvPedido.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Subtotal });
            dtvPedido.Location = new Point(471, 3);
            dtvPedido.Margin = new Padding(10, 3, 10, 3);
            dtvPedido.MultiSelect = false;
            dtvPedido.Name = "dtvPedido";
            dtvPedido.ReadOnly = true;
            dtvPedido.RowHeadersVisible = false;
            tableLayoutInferior.SetRowSpan(dtvPedido, 9);
            dtvPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvPedido.Size = new Size(478, 264);
            dtvPedido.TabIndex = 6;
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
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(95, 191);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.ReadOnly = true;
            txtDireccionCliente.Size = new Size(120, 23);
            txtDireccionCliente.TabIndex = 37;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(11, 188);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 21);
            lblDireccion.TabIndex = 36;
            lblDireccion.Text = "Dirección:";
            // 
            // lblMail
            // 
            lblMail.Anchor = AnchorStyles.Right;
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F);
            lblMail.Location = new Point(38, 163);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(51, 21);
            lblMail.TabIndex = 34;
            lblMail.Text = "Email:";
            // 
            // txtMailCliente
            // 
            txtMailCliente.Anchor = AnchorStyles.Left;
            txtMailCliente.Location = new Point(95, 162);
            txtMailCliente.Name = "txtMailCliente";
            txtMailCliente.ReadOnly = true;
            txtMailCliente.Size = new Size(120, 23);
            txtMailCliente.TabIndex = 35;
            // 
            // txtDniCliente
            // 
            txtDniCliente.Anchor = AnchorStyles.Left;
            txtDniCliente.Location = new Point(95, 133);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.ReadOnly = true;
            txtDniCliente.ShortcutsEnabled = false;
            txtDniCliente.Size = new Size(120, 23);
            txtDniCliente.TabIndex = 28;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F);
            lblDni.Location = new Point(49, 134);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(40, 21);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Anchor = AnchorStyles.Left;
            txtNombreCliente.Location = new Point(95, 104);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.ReadOnly = true;
            txtNombreCliente.Size = new Size(120, 23);
            txtNombreCliente.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(18, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            tableLayoutInferior.SetColumnSpan(label3, 2);
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 43;
            label3.Text = "Datos del Cliente:";
            // 
            // lblProvincia
            // 
            lblProvincia.Anchor = AnchorStyles.Right;
            lblProvincia.AutoSize = true;
            lblProvincia.Font = new Font("Segoe UI", 12F);
            lblProvincia.Location = new Point(267, 163);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(55, 21);
            lblProvincia.TabIndex = 40;
            lblProvincia.Text = "Cargo:";
            // 
            // txtCargo
            // 
            txtCargo.Anchor = AnchorStyles.Left;
            txtCargo.Location = new Point(328, 162);
            txtCargo.Name = "txtCargo";
            txtCargo.ReadOnly = true;
            txtCargo.ShortcutsEnabled = false;
            txtCargo.Size = new Size(130, 23);
            txtCargo.TabIndex = 47;
            // 
            // lblApellidos
            // 
            lblApellidos.Anchor = AnchorStyles.Right;
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 12F);
            lblApellidos.Location = new Point(251, 134);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(71, 21);
            lblApellidos.TabIndex = 6;
            lblApellidos.Text = "Nombre:";
            // 
            // txtNombrePersonal
            // 
            txtNombrePersonal.Anchor = AnchorStyles.Left;
            txtNombrePersonal.Location = new Point(328, 133);
            txtNombrePersonal.Name = "txtNombrePersonal";
            txtNombrePersonal.ReadOnly = true;
            txtNombrePersonal.ShortcutsEnabled = false;
            txtNombrePersonal.Size = new Size(130, 23);
            txtNombrePersonal.TabIndex = 29;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(294, 105);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 45;
            label5.Text = "ID:";
            // 
            // txtIdPersonal
            // 
            txtIdPersonal.Anchor = AnchorStyles.Left;
            txtIdPersonal.Location = new Point(328, 104);
            txtIdPersonal.Name = "txtIdPersonal";
            txtIdPersonal.ReadOnly = true;
            txtIdPersonal.ShortcutsEnabled = false;
            txtIdPersonal.Size = new Size(130, 23);
            txtIdPersonal.TabIndex = 46;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            tableLayoutInferior.SetColumnSpan(label4, 2);
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(251, 80);
            label4.Name = "label4";
            label4.Size = new Size(160, 21);
            label4.TabIndex = 44;
            label4.Text = "Datos del Vendedor:";
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Left;
            txtFecha.Location = new Point(328, 4);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.ShortcutsEnabled = false;
            txtFecha.Size = new Size(107, 23);
            txtFecha.TabIndex = 44;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(269, 5);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 43;
            label1.Text = "Fecha:";
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.Anchor = AnchorStyles.Right;
            lblTotalVenta.AutoSize = true;
            tableLayoutInferior.SetColumnSpan(lblTotalVenta, 2);
            lblTotalVenta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVenta.Location = new Point(297, 231);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(161, 25);
            lblTotalVenta.TabIndex = 48;
            lblTotalVenta.Text = "TOTAL VENTA: $0";
            // 
            // btnCerrarInfo
            // 
            btnCerrarInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarInfo.BackgroundImage = Properties.Resources.equis;
            btnCerrarInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarInfo.FlatAppearance.BorderSize = 0;
            btnCerrarInfo.FlatStyle = FlatStyle.Flat;
            btnCerrarInfo.Location = new Point(962, 3);
            btnCerrarInfo.Name = "btnCerrarInfo";
            btnCerrarInfo.Size = new Size(25, 25);
            btnCerrarInfo.TabIndex = 49;
            btnCerrarInfo.UseVisualStyleBackColor = true;
            btnCerrarInfo.Click += btnCerrarInfo_Click;
            // 
            // FormListaDeVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(164, 214, 255);
            ClientSize = new Size(1099, 920);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListaDeVentas";
            Text = "FormListaDeVentas";
            Load += FormListaDeVentas_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutSuperior.ResumeLayout(false);
            tableLayoutSuperior.PerformLayout();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvVentas).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutInferior.ResumeLayout(false);
            tableLayoutInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutSuperior;
        private Label lblTitulo;
        private TableLayoutPanel panelBuscar;
        private Button btnActualizar;
        private TextBox txtBuscar;
        private Label labelBuscarPor;
        private DataGridView dtvVentas;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutInferior;
        private TextBox txtNombrePersonal;
        private TextBox txtDniCliente;
        private Label lblIDCliente;
        private TextBox txtIdVenta;
        private Label lblDni;
        private Label lblMail;
        private TextBox txtMailCliente;
        private Label lblProvincia;
        private Label lblNombre;
        private TextBox txtNombreCliente;
        private Label lblApellidos;
        private TextBox txtFecha;
        private Label label1;
        private TextBox txtHora;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdPersonal;
        private TextBox txtCargo;
        private DataGridView dtvPedido;
        private TextBox txtDireccionCliente;
        private Label lblDireccion;
        private Label lblTotalVenta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn NroVenta;
        private DataGridViewTextBoxColumn ImporteTotal;
        private DataGridViewTextBoxColumn ImportePagado;
        private DataGridViewTextBoxColumn ImporteVuelto;
        private DataGridViewTextBoxColumn Caja;
        private DataGridViewImageColumn info;
        private Button btnCerrarInfo;
    }
}