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
            txtBuscar = new TextBox();
            tableLayoutBuscarPor = new TableLayoutPanel();
            labelBuscarPor = new Label();
            btnBuscar = new Button();
            cbxBuscarPor = new ComboBox();
            btnActualizar = new Button();
            dtvProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio_unitario = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            tableLayoutInferior = new TableLayoutPanel();
            labelCod = new Label();
            txtCod = new TextBox();
            lblMarca = new Label();
            lblModelo = new Label();
            txtModelo = new TextBox();
            label2 = new Label();
            cbxCategoria = new ComboBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cbxMarca = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutSuperior.SuspendLayout();
            tableLayoutBuscarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvProductos).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutInferior.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutSuperior, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 432F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(859, 784);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutSuperior
            // 
            tableLayoutSuperior.ColumnCount = 3;
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutSuperior.Controls.Add(lblTitulo, 0, 0);
            tableLayoutSuperior.Controls.Add(txtBuscar, 0, 1);
            tableLayoutSuperior.Controls.Add(tableLayoutBuscarPor, 1, 1);
            tableLayoutSuperior.Controls.Add(dtvProductos, 0, 2);
            tableLayoutSuperior.Controls.Add(btnEliminar, 2, 3);
            tableLayoutSuperior.Controls.Add(btnAgregar, 0, 3);
            tableLayoutSuperior.Controls.Add(btnModificar, 1, 3);
            tableLayoutSuperior.Dock = DockStyle.Fill;
            tableLayoutSuperior.Location = new Point(3, 3);
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
            lblTitulo.Text = "Productos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.None;
            txtBuscar.Location = new Point(67, 105);
            txtBuscar.MaxLength = 20;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(150, 23);
            txtBuscar.TabIndex = 2;
            // 
            // tableLayoutBuscarPor
            // 
            tableLayoutBuscarPor.AutoSize = true;
            tableLayoutBuscarPor.ColumnCount = 4;
            tableLayoutSuperior.SetColumnSpan(tableLayoutBuscarPor, 2);
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222233F));
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222233F));
            tableLayoutBuscarPor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutBuscarPor.Controls.Add(labelBuscarPor, 0, 0);
            tableLayoutBuscarPor.Controls.Add(btnBuscar, 2, 0);
            tableLayoutBuscarPor.Controls.Add(cbxBuscarPor, 1, 0);
            tableLayoutBuscarPor.Controls.Add(btnActualizar, 3, 0);
            tableLayoutBuscarPor.Dock = DockStyle.Fill;
            tableLayoutBuscarPor.Location = new Point(287, 98);
            tableLayoutBuscarPor.Name = "tableLayoutBuscarPor";
            tableLayoutBuscarPor.RowCount = 1;
            tableLayoutBuscarPor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutBuscarPor.Size = new Size(563, 37);
            tableLayoutBuscarPor.TabIndex = 3;
            // 
            // labelBuscarPor
            // 
            labelBuscarPor.Anchor = AnchorStyles.Right;
            labelBuscarPor.AutoSize = true;
            labelBuscarPor.Location = new Point(59, 11);
            labelBuscarPor.Name = "labelBuscarPor";
            labelBuscarPor.Size = new Size(63, 15);
            labelBuscarPor.TabIndex = 0;
            labelBuscarPor.Text = "Buscar Por";
            labelBuscarPor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(279, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 31);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbxBuscarPor
            // 
            cbxBuscarPor.Anchor = AnchorStyles.Left;
            cbxBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarPor.FormattingEnabled = true;
            cbxBuscarPor.Items.AddRange(new object[] { "Categoría", "Código", "Marca" });
            cbxBuscarPor.Location = new Point(128, 7);
            cbxBuscarPor.Name = "cbxBuscarPor";
            cbxBuscarPor.Size = new Size(119, 23);
            cbxBuscarPor.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Right;
            btnActualizar.AutoSize = true;
            btnActualizar.BackgroundImage = Properties.Resources.update;
            btnActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizar.Location = new Point(528, 6);
            btnActualizar.Margin = new Padding(3, 3, 10, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(25, 25);
            btnActualizar.TabIndex = 2;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dtvProductos
            // 
            dtvProductos.AllowUserToAddRows = false;
            dtvProductos.AllowUserToDeleteRows = false;
            dtvProductos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Marca, Modelo, Cantidad, Precio_unitario });
            tableLayoutSuperior.SetColumnSpan(dtvProductos, 3);
            dtvProductos.Location = new Point(10, 141);
            dtvProductos.Margin = new Padding(10, 3, 10, 3);
            dtvProductos.MultiSelect = false;
            dtvProductos.Name = "dtvProductos";
            dtvProductos.ReadOnly = true;
            dtvProductos.RowHeadersVisible = false;
            dtvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvProductos.Size = new Size(833, 250);
            dtvProductos.TabIndex = 4;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            Modelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio_unitario
            // 
            Precio_unitario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio_unitario.HeaderText = "Precio Unitario";
            Precio_unitario.Name = "Precio_unitario";
            Precio_unitario.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.AutoSize = true;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(672, 397);
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
            btnAgregar.Location = new Point(104, 397);
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
            btnModificar.Location = new Point(383, 397);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 31);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutInferior);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 435);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(853, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // tableLayoutInferior
            // 
            tableLayoutInferior.ColumnCount = 4;
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutInferior.Controls.Add(labelCod, 0, 0);
            tableLayoutInferior.Controls.Add(txtCod, 1, 0);
            tableLayoutInferior.Controls.Add(lblMarca, 2, 0);
            tableLayoutInferior.Controls.Add(lblModelo, 0, 1);
            tableLayoutInferior.Controls.Add(txtModelo, 1, 1);
            tableLayoutInferior.Controls.Add(label2, 2, 1);
            tableLayoutInferior.Controls.Add(cbxCategoria, 3, 1);
            tableLayoutInferior.Controls.Add(lblCantidad, 0, 2);
            tableLayoutInferior.Controls.Add(txtCantidad, 1, 2);
            tableLayoutInferior.Controls.Add(lblPrecio, 2, 2);
            tableLayoutInferior.Controls.Add(txtPrecio, 3, 2);
            tableLayoutInferior.Controls.Add(btnAceptar, 1, 3);
            tableLayoutInferior.Controls.Add(btnCancelar, 2, 3);
            tableLayoutInferior.Controls.Add(cbxMarca, 3, 0);
            tableLayoutInferior.Dock = DockStyle.Fill;
            tableLayoutInferior.Location = new Point(3, 19);
            tableLayoutInferior.Name = "tableLayoutInferior";
            tableLayoutInferior.RowCount = 4;
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.Size = new Size(847, 219);
            tableLayoutInferior.TabIndex = 0;
            // 
            // labelCod
            // 
            labelCod.Anchor = AnchorStyles.Right;
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Segoe UI", 12F);
            labelCod.Location = new Point(148, 19);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(60, 21);
            labelCod.TabIndex = 0;
            labelCod.Text = "Código";
            // 
            // txtCod
            // 
            txtCod.Anchor = AnchorStyles.Left;
            txtCod.Enabled = false;
            txtCod.Location = new Point(214, 18);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(130, 23);
            txtCod.TabIndex = 1;
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.Right;
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 12F);
            lblMarca.Location = new Point(577, 19);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 21);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.Anchor = AnchorStyles.Right;
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 12F);
            lblModelo.Location = new Point(145, 79);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(63, 21);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.Left;
            txtModelo.Enabled = false;
            txtModelo.Location = new Point(214, 78);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(130, 23);
            txtModelo.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(553, 79);
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
            cbxCategoria.Location = new Point(636, 78);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(130, 23);
            cbxCategoria.TabIndex = 7;
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.Right;
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(136, 139);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 21);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.Left;
            txtCantidad.Enabled = false;
            txtCantidad.Location = new Point(214, 138);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(130, 23);
            txtCantidad.TabIndex = 9;
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.Right;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F);
            lblPrecio.Location = new Point(577, 139);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 21);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Left;
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(636, 138);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(130, 23);
            txtPrecio.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.AutoSize = true;
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(279, 184);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 31);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(487, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 31);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbxMarca
            // 
            cbxMarca.Anchor = AnchorStyles.Left;
            cbxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMarca.Enabled = false;
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Location = new Point(636, 18);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(130, 23);
            cbxMarca.TabIndex = 14;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 214, 255);
            ClientSize = new Size(859, 784);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutSuperior;
        private Label lblTitulo;
        private TextBox txtBuscar;
        private TableLayoutPanel tableLayoutBuscarPor;
        private Label labelBuscarPor;
        private ComboBox cbxBuscarPor;
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
        private TextBox txtCantidad;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio_unitario;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cbxMarca;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnActualizar;
    }
}