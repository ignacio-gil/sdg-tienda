namespace SdG___Prueba.Modulos.Productos
{
    partial class FormMarca
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
            panelPrincipal = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCerrar = new Button();
            label1 = new Label();
            lstMarcas = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            panelMod = new TableLayoutPanel();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            panelPrincipal.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelMod.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(164, 214, 255);
            panelPrincipal.ColumnCount = 2;
            panelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelPrincipal.ColumnStyles.Add(new ColumnStyle());
            panelPrincipal.Controls.Add(tableLayoutPanel2, 0, 0);
            panelPrincipal.Controls.Add(lstMarcas, 0, 2);
            panelPrincipal.Controls.Add(tableLayoutPanel1, 1, 2);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(2, 2);
            panelPrincipal.Margin = new Padding(0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.RowCount = 3;
            panelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            panelPrincipal.RowStyles.Add(new RowStyle());
            panelPrincipal.RowStyles.Add(new RowStyle());
            panelPrincipal.Size = new Size(313, 332);
            panelPrincipal.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            panelPrincipal.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(btnCerrar, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.Size = new Size(307, 52);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Right;
            btnCerrar.BackgroundImage = Properties.Resources.equis;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(279, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 14);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 0, 0, 0);
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "Marcas";
            // 
            // lstMarcas
            // 
            lstMarcas.Dock = DockStyle.Fill;
            lstMarcas.FormattingEnabled = true;
            lstMarcas.ItemHeight = 15;
            lstMarcas.Location = new Point(10, 68);
            lstMarcas.Margin = new Padding(10, 10, 5, 50);
            lstMarcas.Name = "lstMarcas";
            lstMarcas.Size = new Size(256, 214);
            lstMarcas.TabIndex = 2;
            lstMarcas.SelectedIndexChanged += lstMarcas_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btnAgregar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEditar, 0, 1);
            tableLayoutPanel1.Controls.Add(btnBorrar, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(274, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(36, 268);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.Image = Properties.Resources.plus;
            btnAgregar.Location = new Point(3, 10);
            btnAgregar.Margin = new Padding(3, 10, 3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(30, 30);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = Properties.Resources.edit;
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(3, 46);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(30, 30);
            btnEditar.TabIndex = 1;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Enabled = false;
            btnBorrar.Image = Properties.Resources.trash_2;
            btnBorrar.Location = new Point(3, 82);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(30, 30);
            btnBorrar.TabIndex = 2;
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // panelMod
            // 
            panelMod.BackColor = Color.FromArgb(164, 214, 255);
            panelMod.ColumnCount = 4;
            panelMod.ColumnStyles.Add(new ColumnStyle());
            panelMod.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelMod.ColumnStyles.Add(new ColumnStyle());
            panelMod.ColumnStyles.Add(new ColumnStyle());
            panelMod.Controls.Add(btnAceptar, 2, 0);
            panelMod.Controls.Add(btnCancelar, 3, 0);
            panelMod.Controls.Add(txtNombre, 1, 0);
            panelMod.Controls.Add(lblNombre, 0, 0);
            panelMod.Dock = DockStyle.Bottom;
            panelMod.Location = new Point(2, 289);
            panelMod.Name = "panelMod";
            panelMod.RowCount = 1;
            panelMod.RowStyles.Add(new RowStyle());
            panelMod.Size = new Size(313, 45);
            panelMod.TabIndex = 7;
            panelMod.Visible = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Image = Properties.Resources.check;
            btnAceptar.Location = new Point(244, 7);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(30, 30);
            btnAceptar.TabIndex = 1;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Image = Properties.Resources.x;
            btnCancelar.Location = new Point(280, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(30, 30);
            btnCancelar.TabIndex = 2;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(75, 11);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(10, 13);
            lblNombre.Margin = new Padding(10, 0, 0, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // FormMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 119, 255);
            ClientSize = new Size(317, 336);
            ControlBox = false;
            Controls.Add(panelMod);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMarca";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMarca";
            Load += FormMarca_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panelMod.ResumeLayout(false);
            panelMod.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panelPrincipal;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCerrar;
        private Label label1;
        private TableLayoutPanel panelMod;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private Label lblNombre;
        private ListBox lstMarcas;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnBorrar;
    }
}