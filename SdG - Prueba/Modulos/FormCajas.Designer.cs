namespace SdG___Prueba.Modulos
{
    partial class FormCajas
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
            btnAgregar = new Button();
            dtvCajas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Efectivo = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            Borrar = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            tableLayoutInferior = new TableLayoutPanel();
            txtNombre = new TextBox();
            btnCerrarInfo = new Button();
            lblIdCaja = new Label();
            txtIdCaja = new TextBox();
            lblNombre = new Label();
            btnAceptar = new Button();
            lblEfectivo = new Label();
            numEfectivo = new NumericUpDown();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutSuperior.SuspendLayout();
            tableLayoutBuscarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvCajas).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEfectivo).BeginInit();
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
            tableLayoutSuperior.Controls.Add(dtvCajas, 0, 2);
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
            lblTitulo.Text = "Cajas";
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
            tableLayoutBuscarPor.Controls.Add(btnAgregar, 4, 0);
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
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Right;
            btnAgregar.AutoSize = true;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.plus;
            btnAgregar.Location = new Point(685, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 31);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Nueva Caja";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtvCajas
            // 
            dtvCajas.AllowUserToAddRows = false;
            dtvCajas.AllowUserToDeleteRows = false;
            dtvCajas.AllowUserToResizeRows = false;
            dtvCajas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtvCajas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvCajas.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtvCajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtvCajas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvCajas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Efectivo, Editar, Borrar });
            tableLayoutSuperior.SetColumnSpan(dtvCajas, 3);
            dtvCajas.Location = new Point(10, 141);
            dtvCajas.Margin = new Padding(10, 3, 10, 3);
            dtvCajas.MultiSelect = false;
            dtvCajas.Name = "dtvCajas";
            dtvCajas.ReadOnly = true;
            dtvCajas.RowHeadersVisible = false;
            dtvCajas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvCajas.Size = new Size(852, 250);
            dtvCajas.TabIndex = 4;
            dtvCajas.CellClick += dtvCajas_CellClick;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 140;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Efectivo
            // 
            Efectivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Efectivo.HeaderText = "Efectivo";
            Efectivo.Name = "Efectivo";
            Efectivo.ReadOnly = true;
            Efectivo.Width = 160;
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
            groupBox1.Size = new Size(872, 121);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle Caja";
            groupBox1.Visible = false;
            // 
            // tableLayoutInferior
            // 
            tableLayoutInferior.ColumnCount = 7;
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutInferior.ColumnStyles.Add(new ColumnStyle());
            tableLayoutInferior.Controls.Add(txtNombre, 3, 0);
            tableLayoutInferior.Controls.Add(btnCerrarInfo, 6, 0);
            tableLayoutInferior.Controls.Add(lblIdCaja, 0, 0);
            tableLayoutInferior.Controls.Add(txtIdCaja, 1, 0);
            tableLayoutInferior.Controls.Add(lblNombre, 2, 0);
            tableLayoutInferior.Controls.Add(btnAceptar, 0, 1);
            tableLayoutInferior.Controls.Add(lblEfectivo, 4, 0);
            tableLayoutInferior.Controls.Add(numEfectivo, 5, 0);
            tableLayoutInferior.Dock = DockStyle.Fill;
            tableLayoutInferior.Location = new Point(10, 26);
            tableLayoutInferior.Name = "tableLayoutInferior";
            tableLayoutInferior.RowCount = 2;
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.RowStyles.Add(new RowStyle());
            tableLayoutInferior.Size = new Size(852, 85);
            tableLayoutInferior.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.Location = new Point(345, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 28;
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
            // lblIdCaja
            // 
            lblIdCaja.Anchor = AnchorStyles.Right;
            lblIdCaja.AutoSize = true;
            lblIdCaja.Font = new Font("Segoe UI", 12F);
            lblIdCaja.Location = new Point(37, 5);
            lblIdCaja.Name = "lblIdCaja";
            lblIdCaja.Size = new Size(28, 21);
            lblIdCaja.TabIndex = 0;
            lblIdCaja.Text = "ID:";
            // 
            // txtIdCaja
            // 
            txtIdCaja.Anchor = AnchorStyles.Left;
            txtIdCaja.Enabled = false;
            txtIdCaja.Location = new Point(71, 4);
            txtIdCaja.Name = "txtIdCaja";
            txtIdCaja.ShortcutsEnabled = false;
            txtIdCaja.Size = new Size(130, 23);
            txtIdCaja.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(268, 5);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.AutoSize = true;
            tableLayoutInferior.SetColumnSpan(btnAceptar, 7);
            btnAceptar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Image = Properties.Resources.check;
            btnAceptar.Location = new Point(381, 48);
            btnAceptar.Margin = new Padding(3, 15, 3, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(89, 31);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblEfectivo
            // 
            lblEfectivo.Anchor = AnchorStyles.Right;
            lblEfectivo.AutoSize = true;
            lblEfectivo.Font = new Font("Segoe UI", 12F);
            lblEfectivo.Location = new Point(545, 5);
            lblEfectivo.Name = "lblEfectivo";
            lblEfectivo.Size = new Size(67, 21);
            lblEfectivo.TabIndex = 4;
            lblEfectivo.Text = "Efectivo:";
            // 
            // numEfectivo
            // 
            numEfectivo.Anchor = AnchorStyles.Left;
            numEfectivo.DecimalPlaces = 2;
            numEfectivo.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numEfectivo.Location = new Point(618, 4);
            numEfectivo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numEfectivo.Name = "numEfectivo";
            numEfectivo.Size = new Size(130, 23);
            numEfectivo.TabIndex = 29;
            // 
            // FormCajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(164, 214, 255);
            ClientSize = new Size(961, 846);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCajas";
            Text = "FormCajas";
            Load += FormCajas_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutSuperior.ResumeLayout(false);
            tableLayoutSuperior.PerformLayout();
            tableLayoutBuscarPor.ResumeLayout(false);
            tableLayoutBuscarPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvCajas).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutInferior.ResumeLayout(false);
            tableLayoutInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEfectivo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutSuperior;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutBuscarPor;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridView dtvCajas;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutInferior;
        private TextBox txtNombre;
        private Button btnCerrarInfo;
        private Label lblIdCaja;
        private TextBox txtIdCaja;
        private Label lblNombre;
        private Label lblEfectivo;
        private Button btnAceptar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Efectivo;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Borrar;
        private NumericUpDown numEfectivo;
    }
}