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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutSuperior = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutBuscarPor = new TableLayoutPanel();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            labelBuscarPor = new Label();
            dtvProveedores = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            NroTelefono = new DataGridViewTextBoxColumn();
            Cuil = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            tableLayoutInferior = new TableLayoutPanel();
            labelCod = new Label();
            txtCod = new TextBox();
            lblRazonSocial = new Label();
            lblMail = new Label();
            txtMail = new TextBox();
            lblTelefono = new Label();
            lblCuil = new Label();
            lblDireccion = new Label();
            txtCuil = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtRazonSocial = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblPagWeb = new Label();
            txtPagWeb = new TextBox();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 432F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(934, 679);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutSuperior
            // 
            tableLayoutSuperior.ColumnCount = 3;
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.Controls.Add(lblTitulo, 0, 0);
            tableLayoutSuperior.Controls.Add(tableLayoutBuscarPor, 0, 1);
            tableLayoutSuperior.Controls.Add(dtvProveedores, 0, 2);
            tableLayoutSuperior.Controls.Add(btnEliminar, 2, 3);
            tableLayoutSuperior.Controls.Add(btnAgregar, 0, 3);
            tableLayoutSuperior.Controls.Add(btnModificar, 1, 3);
            tableLayoutSuperior.Dock = DockStyle.Fill;
            tableLayoutSuperior.Location = new Point(53, 3);
            tableLayoutSuperior.Name = "tableLayoutSuperior";
            tableLayoutSuperior.RowCount = 4;
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.RowStyles.Add(new RowStyle());
            tableLayoutSuperior.Size = new Size(853, 426);
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
            lblTitulo.Size = new Size(847, 95);
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
            tableLayoutBuscarPor.Dock = DockStyle.Fill;
            tableLayoutBuscarPor.Location = new Point(10, 98);
            tableLayoutBuscarPor.Margin = new Padding(10, 3, 3, 3);
            tableLayoutBuscarPor.Name = "tableLayoutBuscarPor";
            tableLayoutBuscarPor.RowCount = 1;
            tableLayoutBuscarPor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutBuscarPor.Size = new Size(840, 31);
            tableLayoutBuscarPor.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Right;
            btnActualizar.BackgroundImage = Properties.Resources.update;
            btnActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizar.Location = new Point(805, 3);
            btnActualizar.Margin = new Padding(3, 3, 10, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(25, 25);
            btnActualizar.TabIndex = 2;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.Location = new Point(54, 4);
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
            labelBuscarPor.Location = new Point(3, 8);
            labelBuscarPor.Name = "labelBuscarPor";
            labelBuscarPor.Size = new Size(45, 15);
            labelBuscarPor.TabIndex = 0;
            labelBuscarPor.Text = "Buscar:";
            labelBuscarPor.TextAlign = ContentAlignment.MiddleCenter;
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
            dtvProveedores.Columns.AddRange(new DataGridViewColumn[] { Codigo, RazonSocial, Mail, NroTelefono, Cuil });
            tableLayoutSuperior.SetColumnSpan(dtvProveedores, 3);
            dtvProveedores.Location = new Point(10, 135);
            dtvProveedores.Margin = new Padding(10, 3, 10, 3);
            dtvProveedores.MultiSelect = false;
            dtvProveedores.Name = "dtvProveedores";
            dtvProveedores.ReadOnly = true;
            dtvProveedores.RowHeadersVisible = false;
            dtvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvProveedores.Size = new Size(833, 250);
            dtvProveedores.TabIndex = 4;
            dtvProveedores.SelectionChanged += dtvProveedores_SelectionChanged;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.FillWeight = 50F;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // Mail
            // 
            Mail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mail.HeaderText = "Mail";
            Mail.Name = "Mail";
            Mail.ReadOnly = true;
            // 
            // NroTelefono
            // 
            NroTelefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NroTelefono.HeaderText = "N° Telefono";
            NroTelefono.Name = "NroTelefono";
            NroTelefono.ReadOnly = true;
            // 
            // Cuil
            // 
            Cuil.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cuil.HeaderText = "C.U.I.L";
            Cuil.Name = "Cuil";
            Cuil.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.AutoSize = true;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(672, 392);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 31);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.AutoSize = true;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(104, 392);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(76, 31);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.AutoSize = true;
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(383, 391);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 33);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutInferior);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(53, 435);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(853, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle Proveedor";
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
            tableLayoutInferior.Controls.Add(lblDireccion, 3, 2);
            tableLayoutInferior.Controls.Add(txtCuil, 1, 2);
            tableLayoutInferior.Controls.Add(txtDireccion, 4, 2);
            tableLayoutInferior.Controls.Add(txtTelefono, 4, 1);
            tableLayoutInferior.Controls.Add(txtRazonSocial, 4, 0);
            tableLayoutInferior.Controls.Add(btnCancelar, 4, 4);
            tableLayoutInferior.Controls.Add(btnAceptar, 1, 4);
            tableLayoutInferior.Controls.Add(lblPagWeb, 0, 3);
            tableLayoutInferior.Controls.Add(txtPagWeb, 1, 3);
            tableLayoutInferior.Dock = DockStyle.Fill;
            tableLayoutInferior.Location = new Point(10, 26);
            tableLayoutInferior.Name = "tableLayoutInferior";
            tableLayoutInferior.RowCount = 5;
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.Size = new Size(833, 205);
            tableLayoutInferior.TabIndex = 0;
            // 
            // labelCod
            // 
            labelCod.Anchor = AnchorStyles.Right;
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Segoe UI", 12F);
            labelCod.Location = new Point(114, 10);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(60, 21);
            labelCod.TabIndex = 0;
            labelCod.Text = "Código";
            // 
            // txtCod
            // 
            txtCod.Anchor = AnchorStyles.Left;
            txtCod.Enabled = false;
            txtCod.Location = new Point(180, 9);
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
            lblRazonSocial.Location = new Point(416, 10);
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
            lblMail.Location = new Point(134, 52);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(40, 21);
            lblMail.TabIndex = 4;
            lblMail.Text = "Mail";
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.Left;
            txtMail.Enabled = false;
            txtMail.Location = new Point(180, 51);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(130, 23);
            txtMail.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(424, 52);
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
            lblCuil.Location = new Point(119, 94);
            lblCuil.Name = "lblCuil";
            lblCuil.Size = new Size(55, 21);
            lblCuil.TabIndex = 8;
            lblCuil.Text = "C.U.I.L:";
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F);
            lblDireccion.Location = new Point(439, 94);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 21);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección:";
            // 
            // txtCuil
            // 
            txtCuil.Anchor = AnchorStyles.Left;
            txtCuil.Enabled = false;
            txtCuil.Location = new Point(180, 93);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(130, 23);
            txtCuil.TabIndex = 18;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left;
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(523, 93);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(130, 23);
            txtDireccion.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left;
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(523, 51);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 20;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Anchor = AnchorStyles.Left;
            txtRazonSocial.Enabled = false;
            txtRazonSocial.Location = new Point(523, 9);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(130, 23);
            txtRazonSocial.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(548, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 31);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.AutoSize = true;
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(208, 171);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(73, 31);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblPagWeb
            // 
            lblPagWeb.Anchor = AnchorStyles.Right;
            lblPagWeb.AutoSize = true;
            lblPagWeb.Font = new Font("Segoe UI", 12F);
            lblPagWeb.Location = new Point(97, 136);
            lblPagWeb.Name = "lblPagWeb";
            lblPagWeb.Size = new Size(77, 21);
            lblPagWeb.TabIndex = 22;
            lblPagWeb.Text = "Pág. WEB:";
            // 
            // txtPagWeb
            // 
            txtPagWeb.Anchor = AnchorStyles.Left;
            txtPagWeb.Enabled = false;
            txtPagWeb.Location = new Point(180, 135);
            txtPagWeb.Name = "txtPagWeb";
            txtPagWeb.Size = new Size(130, 23);
            txtPagWeb.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
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
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnModificar;
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
        private Button btnCancelar;
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
    }
}