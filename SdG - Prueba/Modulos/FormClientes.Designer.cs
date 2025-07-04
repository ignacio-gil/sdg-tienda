namespace SdG___Prueba.Modulos
{
    partial class FormClientes
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutSuperior = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutBuscarPor = new TableLayoutPanel();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            labelBuscarPor = new Label();
            lblBuscarPor = new Label();
            btnAgregar = new Button();
            cbxBuscarPor = new ComboBox();
            dtvClientes = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            info = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            Borrar = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            tableLayoutInferior = new TableLayoutPanel();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            txtDni = new TextBox();
            btnCerrarInfo = new Button();
            lblIDCliente = new Label();
            txtCod = new TextBox();
            lblDni = new Label();
            lblNombres = new Label();
            txtNombre = new TextBox();
            lblApellidos = new Label();
            lblFechaNacimiento = new Label();
            lblTelefono = new Label();
            btnAceptar = new Button();
            dateFechaNacimiento = new DateTimePicker();
            lblMail = new Label();
            txtMail = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblLocalidad = new Label();
            txtLocalidad = new TextBox();
            lblProvincia = new Label();
            cbxProvincias = new ComboBox();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutSuperior.SuspendLayout();
            tableLayoutBuscarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvClientes).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutInferior.SuspendLayout();
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
            tableLayoutPanel2.TabIndex = 2;
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
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 432F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(878, 731);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutSuperior
            // 
            tableLayoutSuperior.ColumnCount = 3;
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.Controls.Add(lblTitulo, 0, 0);
            tableLayoutSuperior.Controls.Add(tableLayoutBuscarPor, 0, 1);
            tableLayoutSuperior.Controls.Add(dtvClientes, 0, 2);
            tableLayoutSuperior.Dock = DockStyle.Fill;
            tableLayoutSuperior.Location = new Point(3, 3);
            tableLayoutSuperior.Name = "tableLayoutSuperior";
            tableLayoutSuperior.RowCount = 4;
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.Size = new Size(872, 426);
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
            lblTitulo.Size = new Size(866, 95);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutBuscarPor
            // 
            tableLayoutBuscarPor.AutoSize = true;
            tableLayoutBuscarPor.ColumnCount = 6;
            tableLayoutSuperior.SetColumnSpan(tableLayoutBuscarPor, 3);
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
            tableLayoutBuscarPor.Controls.Add(btnAgregar, 4, 0);
            tableLayoutBuscarPor.Controls.Add(cbxBuscarPor, 3, 0);
            tableLayoutBuscarPor.Dock = DockStyle.Fill;
            tableLayoutBuscarPor.Location = new Point(10, 98);
            tableLayoutBuscarPor.Margin = new Padding(10, 3, 3, 3);
            tableLayoutBuscarPor.Name = "tableLayoutBuscarPor";
            tableLayoutBuscarPor.RowCount = 1;
            tableLayoutBuscarPor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutBuscarPor.Size = new Size(859, 37);
            tableLayoutBuscarPor.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Right;
            btnActualizar.BackgroundImage = Properties.Resources.update;
            btnActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizar.Location = new Point(819, 3);
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
            txtBuscar.Location = new Point(54, 7);
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
            labelBuscarPor.Location = new Point(3, 11);
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
            lblBuscarPor.Location = new Point(352, 11);
            lblBuscarPor.Name = "lblBuscarPor";
            lblBuscarPor.Size = new Size(66, 15);
            lblBuscarPor.TabIndex = 8;
            lblBuscarPor.Text = "Buscar por:";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Right;
            btnAgregar.AutoSize = true;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.plus;
            btnAgregar.Location = new Point(670, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 31);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Nuevo Cliente";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbxBuscarPor
            // 
            cbxBuscarPor.Anchor = AnchorStyles.Left;
            cbxBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarPor.FormattingEnabled = true;
            cbxBuscarPor.Items.AddRange(new object[] { "ID", "DNI", "Nombre", "Apellido" });
            cbxBuscarPor.Location = new Point(424, 7);
            cbxBuscarPor.Name = "cbxBuscarPor";
            cbxBuscarPor.Size = new Size(121, 23);
            cbxBuscarPor.TabIndex = 9;
            // 
            // dtvClientes
            // 
            dtvClientes.AllowUserToAddRows = false;
            dtvClientes.AllowUserToDeleteRows = false;
            dtvClientes.AllowUserToResizeRows = false;
            dtvClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvClientes.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvClientes.Columns.AddRange(new DataGridViewColumn[] { Codigo, NombreCompleto, Dni, Telefono, Direccion, info, Editar, Borrar });
            tableLayoutSuperior.SetColumnSpan(dtvClientes, 3);
            dtvClientes.Location = new Point(10, 141);
            dtvClientes.Margin = new Padding(10, 3, 10, 3);
            dtvClientes.MultiSelect = false;
            dtvClientes.Name = "dtvClientes";
            dtvClientes.ReadOnly = true;
            dtvClientes.RowHeadersVisible = false;
            dtvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvClientes.Size = new Size(852, 250);
            dtvClientes.TabIndex = 4;
            dtvClientes.CellClick += dtvClientes_CellClick;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // Dni
            // 
            Dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dni.HeaderText = "DNI";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 120;
            // 
            // Direccion
            // 
            Direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Direccion.HeaderText = "Dirección";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
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
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.edit;
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Width = 40;
            // 
            // Borrar
            // 
            Borrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Borrar.HeaderText = "Borrar";
            Borrar.Image = Properties.Resources.trash_2;
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            Borrar.Width = 40;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutInferior);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 435);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(872, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle Cliente";
            groupBox1.Visible = false;
            // 
            // tableLayoutInferior
            // 
            tableLayoutInferior.ColumnCount = 6;
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.Controls.Add(txtTelefono, 3, 2);
            tableLayoutInferior.Controls.Add(txtApellidos, 3, 1);
            tableLayoutInferior.Controls.Add(txtDni, 3, 0);
            tableLayoutInferior.Controls.Add(btnCerrarInfo, 5, 0);
            tableLayoutInferior.Controls.Add(lblIDCliente, 0, 0);
            tableLayoutInferior.Controls.Add(txtCod, 1, 0);
            tableLayoutInferior.Controls.Add(lblDni, 2, 0);
            tableLayoutInferior.Controls.Add(lblNombres, 0, 1);
            tableLayoutInferior.Controls.Add(txtNombre, 1, 1);
            tableLayoutInferior.Controls.Add(lblApellidos, 2, 1);
            tableLayoutInferior.Controls.Add(lblFechaNacimiento, 0, 2);
            tableLayoutInferior.Controls.Add(lblTelefono, 2, 2);
            tableLayoutInferior.Controls.Add(btnAceptar, 0, 5);
            tableLayoutInferior.Controls.Add(dateFechaNacimiento, 1, 2);
            tableLayoutInferior.Controls.Add(lblMail, 0, 3);
            tableLayoutInferior.Controls.Add(txtMail, 1, 3);
            tableLayoutInferior.Controls.Add(lblDireccion, 2, 3);
            tableLayoutInferior.Controls.Add(txtDireccion, 3, 3);
            tableLayoutInferior.Controls.Add(lblLocalidad, 0, 4);
            tableLayoutInferior.Controls.Add(txtLocalidad, 1, 4);
            tableLayoutInferior.Controls.Add(lblProvincia, 2, 4);
            tableLayoutInferior.Controls.Add(cbxProvincias, 3, 4);
            tableLayoutInferior.Dock = DockStyle.Fill;
            tableLayoutInferior.Location = new Point(10, 26);
            tableLayoutInferior.Name = "tableLayoutInferior";
            tableLayoutInferior.RowCount = 6;
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.Size = new Size(852, 205);
            tableLayoutInferior.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left;
            txtTelefono.Location = new Point(516, 66);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ShortcutsEnabled = false;
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 32;
            // 
            // txtApellidos
            // 
            txtApellidos.Anchor = AnchorStyles.Left;
            txtApellidos.Location = new Point(516, 35);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ShortcutsEnabled = false;
            txtApellidos.Size = new Size(130, 23);
            txtApellidos.TabIndex = 29;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Left;
            txtDni.Location = new Point(516, 4);
            txtDni.Name = "txtDni";
            txtDni.ShortcutsEnabled = false;
            txtDni.Size = new Size(130, 23);
            txtDni.TabIndex = 28;
            // 
            // btnCerrarInfo
            // 
            btnCerrarInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarInfo.BackgroundImage = Properties.Resources.equis;
            btnCerrarInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarInfo.FlatAppearance.BorderSize = 0;
            btnCerrarInfo.FlatStyle = FlatStyle.Flat;
            btnCerrarInfo.Location = new Point(824, 3);
            btnCerrarInfo.Name = "btnCerrarInfo";
            btnCerrarInfo.Size = new Size(25, 25);
            btnCerrarInfo.TabIndex = 25;
            btnCerrarInfo.UseVisualStyleBackColor = true;
            btnCerrarInfo.Click += btnCerrarInfo_Click;
            // 
            // lblIDCliente
            // 
            lblIDCliente.Anchor = AnchorStyles.Right;
            lblIDCliente.AutoSize = true;
            lblIDCliente.Font = new Font("Segoe UI", 12F);
            lblIDCliente.Location = new Point(88, 5);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(80, 21);
            lblIDCliente.TabIndex = 0;
            lblIDCliente.Text = "ID Cliente:";
            // 
            // txtCod
            // 
            txtCod.Anchor = AnchorStyles.Left;
            txtCod.Enabled = false;
            txtCod.Location = new Point(174, 4);
            txtCod.Name = "txtCod";
            txtCod.ShortcutsEnabled = false;
            txtCod.Size = new Size(130, 23);
            txtCod.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F);
            lblDni.Location = new Point(470, 5);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(40, 21);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblNombres
            // 
            lblNombres.Anchor = AnchorStyles.Right;
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 12F);
            lblNombres.Location = new Point(90, 36);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(78, 21);
            lblNombres.TabIndex = 4;
            lblNombres.Text = "Nombres:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.Location = new Point(174, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblApellidos
            // 
            lblApellidos.Anchor = AnchorStyles.Right;
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 12F);
            lblApellidos.Location = new Point(433, 36);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(77, 21);
            lblApellidos.TabIndex = 6;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.Anchor = AnchorStyles.Right;
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 12F);
            lblFechaNacimiento.Location = new Point(81, 67);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(87, 21);
            lblFechaNacimiento.TabIndex = 8;
            lblFechaNacimiento.Text = "Fecha Nac.:";
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(439, 67);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 21);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Teléfono:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.AutoSize = true;
            tableLayoutInferior.SetColumnSpan(btnAceptar, 6);
            btnAceptar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Image = Properties.Resources.check;
            btnAceptar.Location = new Point(381, 170);
            btnAceptar.Margin = new Padding(3, 15, 3, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(89, 31);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Anchor = AnchorStyles.Left;
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(174, 66);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(130, 23);
            dateFechaNacimiento.TabIndex = 33;
            // 
            // lblMail
            // 
            lblMail.Anchor = AnchorStyles.Right;
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F);
            lblMail.Location = new Point(117, 98);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(51, 21);
            lblMail.TabIndex = 34;
            lblMail.Text = "Email:";
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.Left;
            txtMail.Location = new Point(174, 97);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(130, 23);
            txtMail.TabIndex = 35;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(432, 98);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 21);
            lblDireccion.TabIndex = 36;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left;
            txtDireccion.Location = new Point(516, 97);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(130, 23);
            txtDireccion.TabIndex = 37;
            // 
            // lblLocalidad
            // 
            lblLocalidad.Anchor = AnchorStyles.Right;
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Segoe UI", 12F);
            lblLocalidad.Location = new Point(89, 129);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(79, 21);
            lblLocalidad.TabIndex = 38;
            lblLocalidad.Text = "Localidad:";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Anchor = AnchorStyles.Left;
            txtLocalidad.Location = new Point(174, 128);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(130, 23);
            txtLocalidad.TabIndex = 39;
            // 
            // lblProvincia
            // 
            lblProvincia.Anchor = AnchorStyles.Right;
            lblProvincia.AutoSize = true;
            lblProvincia.Font = new Font("Segoe UI", 12F);
            lblProvincia.Location = new Point(433, 129);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(77, 21);
            lblProvincia.TabIndex = 40;
            lblProvincia.Text = "Provincia:";
            // 
            // cbxProvincias
            // 
            cbxProvincias.Anchor = AnchorStyles.Left;
            cbxProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProvincias.FormattingEnabled = true;
            cbxProvincias.Items.AddRange(new object[] { "CABA", "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán" });
            cbxProvincias.Location = new Point(516, 128);
            cbxProvincias.Name = "cbxProvincias";
            cbxProvincias.Size = new Size(130, 23);
            cbxProvincias.TabIndex = 41;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(164, 214, 255);
            ClientSize = new Size(961, 846);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutSuperior.ResumeLayout(false);
            tableLayoutSuperior.PerformLayout();
            tableLayoutBuscarPor.ResumeLayout(false);
            tableLayoutBuscarPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutInferior.ResumeLayout(false);
            tableLayoutInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutSuperior;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutBuscarPor;
        private Button btnActualizar;
        private TextBox txtBuscar;
        private Label labelBuscarPor;
        private Label lblBuscarPor;
        private Button btnAgregar;
        private ComboBox cbxBuscarPor;
        private DataGridView dtvClientes;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutInferior;
        private Button btnCerrarInfo;
        private Label lblIDCliente;
        private TextBox txtCod;
        private Label lblDni;
        private Label lblNombres;
        private TextBox txtNombre;
        private Label lblApellidos;
        private Label lblFechaNacimiento;
        private Label lblTelefono;
        private Button btnAceptar;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private TextBox txtApellidos;
        private DateTimePicker dateFechaNacimiento;
        private Label lblMail;
        private TextBox txtMail;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblLocalidad;
        private TextBox txtLocalidad;
        private Label lblProvincia;
        private ComboBox cbxProvincias;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewImageColumn info;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Borrar;
    }
}