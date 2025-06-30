namespace SdG___Prueba.Modulos
{
    partial class FormProductos
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
            dtvProductos = new DataGridView();
            groupBox1 = new GroupBox();
            tableLayoutInferior = new TableLayoutPanel();
            btnCerrarInfo = new Button();
            labelCod = new Label();
            txtCod = new TextBox();
            lblMarca = new Label();
            btnConfigMarca = new Button();
            lblModelo = new Label();
            txtModelo = new TextBox();
            label2 = new Label();
            cbxCategoria = new ComboBox();
            lblCantidad = new Label();
            lblPrecio = new Label();
            cbxMarca = new ComboBox();
            numCantidad = new NumericUpDown();
            numPrecio = new NumericUpDown();
            btnAceptar = new Button();
            btnConfigCategorias = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio_unitario = new DataGridViewTextBoxColumn();
            info = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            Borrar = new DataGridViewImageColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutSuperior.SuspendLayout();
            tableLayoutBuscarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvProductos).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            tableLayoutSuperior.Controls.Add(dtvProductos, 0, 2);
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
            lblTitulo.Text = "Productos";
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
            btnAgregar.Text = "Nuevo producto";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbxBuscarPor
            // 
            cbxBuscarPor.Anchor = AnchorStyles.Left;
            cbxBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarPor.FormattingEnabled = true;
            cbxBuscarPor.Items.AddRange(new object[] { "Código", "Categoría", "Marca", "Modelo" });
            cbxBuscarPor.Location = new Point(424, 7);
            cbxBuscarPor.Name = "cbxBuscarPor";
            cbxBuscarPor.Size = new Size(121, 23);
            cbxBuscarPor.TabIndex = 9;
            // 
            // dtvProductos
            // 
            dtvProductos.AllowUserToAddRows = false;
            dtvProductos.AllowUserToDeleteRows = false;
            dtvProductos.AllowUserToResizeRows = false;
            dtvProductos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            dtvProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Categoria, Cantidad, Precio_unitario, info, Editar, Borrar });
            tableLayoutSuperior.SetColumnSpan(dtvProductos, 3);
            dtvProductos.Location = new Point(10, 141);
            dtvProductos.Margin = new Padding(10, 3, 10, 3);
            dtvProductos.MultiSelect = false;
            dtvProductos.Name = "dtvProductos";
            dtvProductos.ReadOnly = true;
            dtvProductos.RowHeadersVisible = false;
            dtvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvProductos.Size = new Size(852, 250);
            dtvProductos.TabIndex = 4;
            dtvProductos.CellClick += dtvProductos_CellClick;
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
            groupBox1.Text = "Detalle Producto";
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
            tableLayoutInferior.Controls.Add(btnCerrarInfo, 5, 0);
            tableLayoutInferior.Controls.Add(labelCod, 0, 0);
            tableLayoutInferior.Controls.Add(txtCod, 1, 0);
            tableLayoutInferior.Controls.Add(lblMarca, 2, 0);
            tableLayoutInferior.Controls.Add(btnConfigMarca, 4, 0);
            tableLayoutInferior.Controls.Add(lblModelo, 0, 1);
            tableLayoutInferior.Controls.Add(txtModelo, 1, 1);
            tableLayoutInferior.Controls.Add(label2, 2, 1);
            tableLayoutInferior.Controls.Add(cbxCategoria, 3, 1);
            tableLayoutInferior.Controls.Add(lblCantidad, 0, 2);
            tableLayoutInferior.Controls.Add(lblPrecio, 2, 2);
            tableLayoutInferior.Controls.Add(cbxMarca, 3, 0);
            tableLayoutInferior.Controls.Add(numCantidad, 1, 2);
            tableLayoutInferior.Controls.Add(numPrecio, 3, 2);
            tableLayoutInferior.Controls.Add(btnAceptar, 0, 3);
            tableLayoutInferior.Controls.Add(btnConfigCategorias, 4, 1);
            tableLayoutInferior.Dock = DockStyle.Fill;
            tableLayoutInferior.Location = new Point(10, 26);
            tableLayoutInferior.Name = "tableLayoutInferior";
            tableLayoutInferior.RowCount = 4;
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.Size = new Size(852, 205);
            tableLayoutInferior.TabIndex = 0;
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
            btnCerrarInfo.Visible = false;
            btnCerrarInfo.Click += btnCerrarInfo_Click;
            // 
            // labelCod
            // 
            labelCod.Anchor = AnchorStyles.Right;
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Segoe UI", 12F);
            labelCod.Location = new Point(105, 15);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(60, 21);
            labelCod.TabIndex = 0;
            labelCod.Text = "Código";
            // 
            // txtCod
            // 
            txtCod.Anchor = AnchorStyles.Left;
            txtCod.Enabled = false;
            txtCod.Location = new Point(171, 14);
            txtCod.Name = "txtCod";
            txtCod.ShortcutsEnabled = false;
            txtCod.Size = new Size(130, 23);
            txtCod.TabIndex = 1;
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.Right;
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 12F);
            lblMarca.Location = new Point(448, 15);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 21);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca";
            // 
            // btnConfigMarca
            // 
            btnConfigMarca.Anchor = AnchorStyles.Left;
            btnConfigMarca.Image = Properties.Resources.settings;
            btnConfigMarca.Location = new Point(653, 10);
            btnConfigMarca.Name = "btnConfigMarca";
            btnConfigMarca.Size = new Size(30, 30);
            btnConfigMarca.TabIndex = 26;
            btnConfigMarca.UseVisualStyleBackColor = true;
            btnConfigMarca.Click += btnConfigMarcas_Click;
            // 
            // lblModelo
            // 
            lblModelo.Anchor = AnchorStyles.Right;
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 12F);
            lblModelo.Location = new Point(102, 66);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(63, 21);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.Left;
            txtModelo.Enabled = false;
            txtModelo.Location = new Point(171, 65);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(130, 23);
            txtModelo.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(424, 66);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 6;
            label2.Text = "Categoría";
            // 
            // cbxCategoria
            // 
            cbxCategoria.Anchor = AnchorStyles.Left;
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.Enabled = false;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(507, 65);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(140, 23);
            cbxCategoria.TabIndex = 7;
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.Right;
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(93, 118);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 21);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.Right;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F);
            lblPrecio.Location = new Point(448, 118);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 21);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio";
            // 
            // cbxMarca
            // 
            cbxMarca.Anchor = AnchorStyles.Left;
            cbxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMarca.Enabled = false;
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Location = new Point(507, 14);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(140, 23);
            cbxMarca.TabIndex = 14;
            // 
            // numCantidad
            // 
            numCantidad.Anchor = AnchorStyles.Left;
            numCantidad.Enabled = false;
            numCantidad.Location = new Point(171, 117);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(66, 23);
            numCantidad.TabIndex = 15;
            numCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // numPrecio
            // 
            numPrecio.Anchor = AnchorStyles.Left;
            numPrecio.DecimalPlaces = 2;
            numPrecio.Enabled = false;
            numPrecio.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrecio.Location = new Point(507, 117);
            numPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 16;
            numPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.AutoSize = true;
            tableLayoutInferior.SetColumnSpan(btnAceptar, 6);
            btnAceptar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Image = Properties.Resources.check;
            btnAceptar.Location = new Point(377, 170);
            btnAceptar.Margin = new Padding(3, 15, 3, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 31);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnConfigCategorias
            // 
            btnConfigCategorias.Anchor = AnchorStyles.Left;
            btnConfigCategorias.Image = Properties.Resources.settings;
            btnConfigCategorias.Location = new Point(653, 62);
            btnConfigCategorias.Name = "btnConfigCategorias";
            btnConfigCategorias.Size = new Size(30, 30);
            btnConfigCategorias.TabIndex = 27;
            btnConfigCategorias.UseVisualStyleBackColor = true;
            btnConfigCategorias.Click += btnConfigCategorias_Click;
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
            tableLayoutPanel2.Size = new Size(978, 784);
            tableLayoutPanel2.TabIndex = 1;
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
            // Categoria
            // 
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Categoria.HeaderText = "Categoría";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 60;
            // 
            // Precio_unitario
            // 
            Precio_unitario.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Precio_unitario.HeaderText = "Precio /u";
            Precio_unitario.Name = "Precio_unitario";
            Precio_unitario.ReadOnly = true;
            Precio_unitario.Width = 90;
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
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(164, 214, 255);
            ClientSize = new Size(961, 846);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutSuperior.ResumeLayout(false);
            tableLayoutSuperior.PerformLayout();
            tableLayoutBuscarPor.ResumeLayout(false);
            tableLayoutBuscarPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutInferior.ResumeLayout(false);
            tableLayoutInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutSuperior;
        private Label lblTitulo;
        private TextBox txtBuscar;
        private TableLayoutPanel tableLayoutBuscarPor;
        private Label labelBuscarPor;
        private DataGridView dtvProductos;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutInferior;
        private Label labelCod;
        private TextBox txtCod;
        private Label lblMarca;
        private Label lblModelo;
        private TextBox txtModelo;
        private Label label2;
        private ComboBox cbxCategoria;
        private Label lblCantidad;
        private Label lblPrecio;
        private Button btnAceptar;
        private ComboBox cbxMarca;
        private Button btnAgregar;
        private Button btnActualizar;
        private NumericUpDown numCantidad;
        private NumericUpDown numPrecio;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCerrarInfo;
        private Button btnConfigMarca;
        private Button btnConfigCategorias;
        private Label lblBuscarPor;
        private ComboBox cbxBuscarPor;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio_unitario;
        private DataGridViewImageColumn info;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Borrar;
    }
}