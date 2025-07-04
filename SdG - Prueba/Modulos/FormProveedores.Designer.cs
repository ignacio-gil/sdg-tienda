namespace SdG___Prueba.Modulos
{
    partial class FormProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutSuperior = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutBuscarPor = new TableLayoutPanel();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            labelBuscarPor = new Label();
            btnAgregar = new Button();
            dtvProveedores = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            NroTelefono = new DataGridViewTextBoxColumn();
            Cuil = new DataGridViewTextBoxColumn();
            info = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            tableLayoutInferior = new TableLayoutPanel();
            labelCod = new Label();
            txtCod = new TextBox();
            lblRazonSocial = new Label();
            lblMail = new Label();
            txtMail = new TextBox();
            lblTelefono = new Label();
            lblCuil = new Label();
            txtCuil = new TextBox();
            txtTelefono = new TextBox();
            txtRazonSocial = new TextBox();
            btnCerrarInfo = new Button();
            btnAceptar = new Button();
            lblPagWeb = new Label();
            txtPagWeb = new TextBox();
            lblProvincia = new Label();
            cbxProvincias = new ComboBox();
            lblLocalidad = new Label();
            txtLocalidad = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutSuperior.SuspendLayout();
            tableLayoutBuscarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvProveedores).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutInferior.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutSuperior, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(50, 0, 50, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(934, 696);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutSuperior
            // 
            tableLayoutSuperior.AutoSize = true;
            tableLayoutSuperior.ColumnCount = 3;
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.Controls.Add(lblTitulo, 0, 0);
            tableLayoutSuperior.Controls.Add(tableLayoutBuscarPor, 0, 1);
            tableLayoutSuperior.Controls.Add(dtvProveedores, 0, 2);
            tableLayoutSuperior.Dock = DockStyle.Fill;
            tableLayoutSuperior.Location = new Point(53, 3);
            tableLayoutSuperior.Name = "tableLayoutSuperior";
            tableLayoutSuperior.RowCount = 4;
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.Size = new Size(855, 443);
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
            lblTitulo.Size = new Size(849, 95);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Proveedores";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutBuscarPor
            // 
            tableLayoutBuscarPor.AutoSize = true;
            tableLayoutBuscarPor.ColumnCount = 5;
            tableLayoutSuperior.SetColumnSpan(tableLayoutBuscarPor, 3);
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle());
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle());
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.0000038F));
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle());
            tableLayoutBuscarPor.Controls.Add(btnActualizar, 4, 0);
            tableLayoutBuscarPor.Controls.Add(txtBuscar, 1, 0);
            tableLayoutBuscarPor.Controls.Add(labelBuscarPor, 0, 0);
            tableLayoutBuscarPor.Controls.Add(btnAgregar, 3, 0);
            tableLayoutBuscarPor.Dock = DockStyle.Fill;
            tableLayoutBuscarPor.Location = new Point(10, 98);
            tableLayoutBuscarPor.Margin = new Padding(10, 3, 3, 3);
            tableLayoutBuscarPor.Name = "tableLayoutBuscarPor";
            tableLayoutBuscarPor.RowCount = 1;
            tableLayoutBuscarPor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutBuscarPor.Size = new Size(842, 36);
            tableLayoutBuscarPor.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Right;
            btnActualizar.BackgroundImage = Properties.Resources.update;
            btnActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizar.Location = new Point(802, 3);
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
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Right;
            btnAgregar.AutoSize = true;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.plus;
            btnAgregar.Location = new Point(645, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 30);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Nuevo proveedor";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtvProveedores
            // 
            dtvProveedores.AllowUserToAddRows = false;
            dtvProveedores.AllowUserToDeleteRows = false;
            dtvProveedores.AllowUserToResizeRows = false;
            dtvProveedores.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvProveedores.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvProveedores.Columns.AddRange(new DataGridViewColumn[] { Codigo, RazonSocial, Mail, NroTelefono, Cuil, info, Editar, Eliminar });
            tableLayoutSuperior.SetColumnSpan(dtvProveedores, 3);
            dtvProveedores.Location = new Point(10, 140);
            dtvProveedores.Margin = new Padding(10, 3, 10, 3);
            dtvProveedores.MultiSelect = false;
            dtvProveedores.Name = "dtvProveedores";
            dtvProveedores.ReadOnly = true;
            dtvProveedores.RowHeadersVisible = false;
            dtvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvProveedores.Size = new Size(835, 300);
            dtvProveedores.TabIndex = 4;
            dtvProveedores.CellClick += dtvProveedores_CellClick;
            dtvProveedores.SelectionChanged += dtvProveedores_SelectionChanged;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.FillWeight = 57.86052F;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RazonSocial.FillWeight = 115.721039F;
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // Mail
            // 
            Mail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mail.FillWeight = 115.721039F;
            Mail.HeaderText = "Mail";
            Mail.Name = "Mail";
            Mail.ReadOnly = true;
            // 
            // NroTelefono
            // 
            NroTelefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NroTelefono.FillWeight = 115.721039F;
            NroTelefono.HeaderText = "N° Telefono";
            NroTelefono.Name = "NroTelefono";
            NroTelefono.ReadOnly = true;
            // 
            // Cuil
            // 
            Cuil.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cuil.FillWeight = 115.721039F;
            Cuil.HeaderText = "C.U.I.L";
            Cuil.Name = "Cuil";
            Cuil.ReadOnly = true;
            // 
            // info
            // 
            info.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            info.FillWeight = 29.25532F;
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
            Editar.Resizable = DataGridViewTriState.True;
            Editar.Width = 40;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Eliminar.HeaderText = "Borrar";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.Width = 40;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutInferior);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(53, 452);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(855, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle Proveedor";
            groupBox1.Visible = false;
            // 
            // tableLayoutInferior
            // 
            tableLayoutInferior.ColumnCount = 6;
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutInferior.Controls.Add(labelCod, 0, 0);
            tableLayoutInferior.Controls.Add(txtCod, 1, 0);
            tableLayoutInferior.Controls.Add(lblRazonSocial, 3, 0);
            tableLayoutInferior.Controls.Add(lblMail, 0, 1);
            tableLayoutInferior.Controls.Add(txtMail, 1, 1);
            tableLayoutInferior.Controls.Add(lblTelefono, 3, 1);
            tableLayoutInferior.Controls.Add(lblCuil, 0, 2);
            tableLayoutInferior.Controls.Add(txtCuil, 1, 2);
            tableLayoutInferior.Controls.Add(txtTelefono, 4, 1);
            tableLayoutInferior.Controls.Add(txtRazonSocial, 4, 0);
            tableLayoutInferior.Controls.Add(btnCerrarInfo, 5, 0);
            tableLayoutInferior.Controls.Add(btnAceptar, 0, 5);
            tableLayoutInferior.Controls.Add(lblPagWeb, 3, 2);
            tableLayoutInferior.Controls.Add(txtPagWeb, 4, 2);
            tableLayoutInferior.Controls.Add(lblProvincia, 0, 4);
            tableLayoutInferior.Controls.Add(cbxProvincias, 1, 4);
            tableLayoutInferior.Controls.Add(lblLocalidad, 3, 3);
            tableLayoutInferior.Controls.Add(txtLocalidad, 4, 3);
            tableLayoutInferior.Controls.Add(lblDireccion, 0, 3);
            tableLayoutInferior.Controls.Add(txtDireccion, 1, 3);
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
            tableLayoutInferior.Size = new Size(835, 205);
            tableLayoutInferior.TabIndex = 0;
            // 
            // labelCod
            // 
            labelCod.Anchor = AnchorStyles.Right;
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Segoe UI", 12F);
            labelCod.Location = new Point(115, 6);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(60, 21);
            labelCod.TabIndex = 0;
            labelCod.Text = "Código";
            // 
            // txtCod
            // 
            txtCod.Anchor = AnchorStyles.Left;
            txtCod.Enabled = false;
            txtCod.Location = new Point(181, 5);
            txtCod.Name = "txtCod";
            txtCod.ShortcutsEnabled = false;
            txtCod.Size = new Size(130, 23);
            txtCod.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.Anchor = AnchorStyles.Right;
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Font = new Font("Segoe UI", 12F);
            lblRazonSocial.Location = new Point(417, 6);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(101, 21);
            lblRazonSocial.TabIndex = 2;
            lblRazonSocial.Text = "Razón Social:";
            // 
            // lblMail
            // 
            lblMail.Anchor = AnchorStyles.Right;
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F);
            lblMail.Location = new Point(135, 39);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(40, 21);
            lblMail.TabIndex = 4;
            lblMail.Text = "Mail";
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.Left;
            txtMail.Enabled = false;
            txtMail.Location = new Point(181, 38);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(130, 23);
            txtMail.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(425, 39);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(93, 21);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "N° Teléfono:";
            // 
            // lblCuil
            // 
            lblCuil.Anchor = AnchorStyles.Right;
            lblCuil.AutoSize = true;
            lblCuil.Font = new Font("Segoe UI", 12F);
            lblCuil.Location = new Point(120, 72);
            lblCuil.Name = "lblCuil";
            lblCuil.Size = new Size(55, 21);
            lblCuil.TabIndex = 8;
            lblCuil.Text = "C.U.I.L:";
            // 
            // txtCuil
            // 
            txtCuil.Anchor = AnchorStyles.Left;
            txtCuil.Enabled = false;
            txtCuil.Location = new Point(181, 71);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(130, 23);
            txtCuil.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left;
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(524, 38);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 20;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Anchor = AnchorStyles.Left;
            txtRazonSocial.Enabled = false;
            txtRazonSocial.Location = new Point(524, 5);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(130, 23);
            txtRazonSocial.TabIndex = 21;
            // 
            // btnCerrarInfo
            // 
            btnCerrarInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarInfo.BackgroundImage = Properties.Resources.equis;
            btnCerrarInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarInfo.FlatAppearance.BorderSize = 0;
            btnCerrarInfo.FlatStyle = FlatStyle.Flat;
            btnCerrarInfo.Location = new Point(807, 3);
            btnCerrarInfo.Name = "btnCerrarInfo";
            btnCerrarInfo.Size = new Size(25, 25);
            btnCerrarInfo.TabIndex = 24;
            btnCerrarInfo.UseVisualStyleBackColor = true;
            btnCerrarInfo.Visible = false;
            btnCerrarInfo.Click += btnCerrarInfo_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.AutoSize = true;
            tableLayoutInferior.SetColumnSpan(btnAceptar, 6);
            btnAceptar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Image = Properties.Resources.check;
            btnAceptar.Location = new Point(369, 169);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 31);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblPagWeb
            // 
            lblPagWeb.Anchor = AnchorStyles.Right;
            lblPagWeb.AutoSize = true;
            lblPagWeb.Font = new Font("Segoe UI", 12F);
            lblPagWeb.Location = new Point(441, 72);
            lblPagWeb.Name = "lblPagWeb";
            lblPagWeb.Size = new Size(77, 21);
            lblPagWeb.TabIndex = 22;
            lblPagWeb.Text = "Pág. WEB:";
            // 
            // txtPagWeb
            // 
            txtPagWeb.Anchor = AnchorStyles.Left;
            txtPagWeb.Enabled = false;
            txtPagWeb.Location = new Point(524, 71);
            txtPagWeb.Name = "txtPagWeb";
            txtPagWeb.Size = new Size(130, 23);
            txtPagWeb.TabIndex = 23;
            // 
            // lblProvincia
            // 
            lblProvincia.Anchor = AnchorStyles.Right;
            lblProvincia.AutoSize = true;
            lblProvincia.Font = new Font("Segoe UI", 12F);
            lblProvincia.Location = new Point(98, 138);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(77, 21);
            lblProvincia.TabIndex = 26;
            lblProvincia.Text = "Provincia:";
            // 
            // cbxProvincias
            // 
            cbxProvincias.Anchor = AnchorStyles.Left;
            cbxProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProvincias.FormattingEnabled = true;
            cbxProvincias.Items.AddRange(new object[] { "CABA", "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán" });
            cbxProvincias.Location = new Point(181, 137);
            cbxProvincias.Name = "cbxProvincias";
            cbxProvincias.Size = new Size(130, 23);
            cbxProvincias.TabIndex = 28;
            // 
            // lblLocalidad
            // 
            lblLocalidad.Anchor = AnchorStyles.Right;
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Segoe UI", 12F);
            lblLocalidad.Location = new Point(439, 105);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(79, 21);
            lblLocalidad.TabIndex = 25;
            lblLocalidad.Text = "Localidad:";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Anchor = AnchorStyles.Left;
            txtLocalidad.Location = new Point(524, 104);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(130, 23);
            txtLocalidad.TabIndex = 27;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(97, 105);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 21);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left;
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(181, 104);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(130, 23);
            txtDireccion.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(940, 784);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 214, 255);
            ClientSize = new Size(940, 784);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProveedores";
            Text = "FormProveedores";
            WindowState = FormWindowState.Maximized;
            Load += FormProveedores_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutSuperior.ResumeLayout(false);
            tableLayoutSuperior.PerformLayout();
            tableLayoutBuscarPor.ResumeLayout(false);
            tableLayoutBuscarPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvProveedores).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutInferior.ResumeLayout(false);
            tableLayoutInferior.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutSuperior;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutBuscarPor;
        private Button btnActualizar;
        private TextBox txtBuscar;
        private Label labelBuscarPor;
        private DataGridView dtvProveedores;
        private Button btnAgregar;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutInferior;
        private Label labelCod;
        private TextBox txtCod;
        private Label lblRazonSocial;
        private Label lblMail;
        private TextBox txtMail;
        private Label lblTelefono;
        private Label lblCuil;
        private Label lblDireccion;
        private Button btnAceptar;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtCuil;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtRazonSocial;
        private Label lblPagWeb;
        private TextBox txtPagWeb;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewTextBoxColumn NroTelefono;
        private DataGridViewTextBoxColumn Cuil;
        private DataGridViewImageColumn info;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private Button btnCerrarInfo;
        private Label lblLocalidad;
        private Label lblProvincia;
        private TextBox txtLocalidad;
        private ComboBox cbxProvincias;
    }
}