namespace Libros
{
    partial class gestionLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionLibros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbGraficos = new System.Windows.Forms.PictureBox();
            this.pbPrestamos = new System.Windows.Forms.PictureBox();
            this.pbLibros = new System.Windows.Forms.PictureBox();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.dvgLibros = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbLibros = new System.Windows.Forms.GroupBox();
            this.dateTimePickerAnoPublicacion = new System.Windows.Forms.DateTimePicker();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLibros)).BeginInit();
            this.gbLibros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbGraficos);
            this.panel1.Controls.Add(this.pbPrestamos);
            this.panel1.Controls.Add(this.pbLibros);
            this.panel1.Controls.Add(this.pbUsuarios);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 560);
            this.panel1.TabIndex = 0;
            // 
            // pbGraficos
            // 
            this.pbGraficos.Image = ((System.Drawing.Image)(resources.GetObject("pbGraficos.Image")));
            this.pbGraficos.Location = new System.Drawing.Point(39, 426);
            this.pbGraficos.Margin = new System.Windows.Forms.Padding(4);
            this.pbGraficos.Name = "pbGraficos";
            this.pbGraficos.Size = new System.Drawing.Size(133, 103);
            this.pbGraficos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGraficos.TabIndex = 3;
            this.pbGraficos.TabStop = false;
            this.pbGraficos.Click += new System.EventHandler(this.pbGraficos_Click);
            // 
            // pbPrestamos
            // 
            this.pbPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("pbPrestamos.Image")));
            this.pbPrestamos.Location = new System.Drawing.Point(39, 282);
            this.pbPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.pbPrestamos.Name = "pbPrestamos";
            this.pbPrestamos.Size = new System.Drawing.Size(133, 103);
            this.pbPrestamos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrestamos.TabIndex = 2;
            this.pbPrestamos.TabStop = false;
            this.pbPrestamos.Click += new System.EventHandler(this.pbPrestamos_Click);
            // 
            // pbLibros
            // 
            this.pbLibros.Image = ((System.Drawing.Image)(resources.GetObject("pbLibros.Image")));
            this.pbLibros.Location = new System.Drawing.Point(39, 143);
            this.pbLibros.Margin = new System.Windows.Forms.Padding(4);
            this.pbLibros.Name = "pbLibros";
            this.pbLibros.Size = new System.Drawing.Size(133, 103);
            this.pbLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibros.TabIndex = 1;
            this.pbLibros.TabStop = false;
            this.pbLibros.Click += new System.EventHandler(this.pbLibros_Click);
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarios.Image")));
            this.pbUsuarios.Location = new System.Drawing.Point(39, 15);
            this.pbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(133, 103);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuarios.TabIndex = 0;
            this.pbUsuarios.TabStop = false;
            this.pbUsuarios.Click += new System.EventHandler(this.pbUsuarios_Click);
            // 
            // dvgLibros
            // 
            this.dvgLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6});
            this.dvgLibros.Location = new System.Drawing.Point(240, 330);
            this.dvgLibros.Margin = new System.Windows.Forms.Padding(4);
            this.dvgLibros.Name = "dvgLibros";
            this.dvgLibros.RowHeadersVisible = false;
            this.dvgLibros.RowHeadersWidth = 51;
            this.dvgLibros.Size = new System.Drawing.Size(780, 199);
            this.dvgLibros.TabIndex = 2;
            this.dvgLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgLibros_CellClick);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIngresar.Location = new System.Drawing.Point(933, 85);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 28);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.Location = new System.Drawing.Point(933, 133);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(933, 181);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(933, 229);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbLibros
            // 
            this.gbLibros.Controls.Add(this.dateTimePickerAnoPublicacion);
            this.gbLibros.Controls.Add(this.txtEditorial);
            this.gbLibros.Controls.Add(this.txtISBN);
            this.gbLibros.Controls.Add(this.txtAutor);
            this.gbLibros.Controls.Add(this.txtTitulo);
            this.gbLibros.Controls.Add(this.txtCodigo);
            this.gbLibros.Controls.Add(this.label19);
            this.gbLibros.Controls.Add(this.label20);
            this.gbLibros.Controls.Add(this.label21);
            this.gbLibros.Controls.Add(this.label22);
            this.gbLibros.Controls.Add(this.label23);
            this.gbLibros.Controls.Add(this.label24);
            this.gbLibros.Location = new System.Drawing.Point(240, 15);
            this.gbLibros.Margin = new System.Windows.Forms.Padding(4);
            this.gbLibros.Name = "gbLibros";
            this.gbLibros.Padding = new System.Windows.Forms.Padding(4);
            this.gbLibros.Size = new System.Drawing.Size(667, 289);
            this.gbLibros.TabIndex = 7;
            this.gbLibros.TabStop = false;
            this.gbLibros.Text = "Informacion Libros";
            // 
            // dateTimePickerAnoPublicacion
            // 
            this.dateTimePickerAnoPublicacion.Location = new System.Drawing.Point(241, 150);
            this.dateTimePickerAnoPublicacion.Name = "dateTimePickerAnoPublicacion";
            this.dateTimePickerAnoPublicacion.Size = new System.Drawing.Size(331, 22);
            this.dateTimePickerAnoPublicacion.TabIndex = 37;
            this.dateTimePickerAnoPublicacion.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtEditorial
            // 
            this.txtEditorial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEditorial.Location = new System.Drawing.Point(241, 223);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(331, 22);
            this.txtEditorial.TabIndex = 36;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtISBN.Location = new System.Drawing.Point(241, 187);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(331, 22);
            this.txtISBN.TabIndex = 35;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAutor.Location = new System.Drawing.Point(241, 114);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(331, 22);
            this.txtAutor.TabIndex = 33;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTitulo.Location = new System.Drawing.Point(241, 79);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(331, 22);
            this.txtTitulo.TabIndex = 32;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(241, 41);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(331, 22);
            this.txtCodigo.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(95, 226);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = "Editorial:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(95, 191);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 16);
            this.label20.TabIndex = 29;
            this.label20.Text = "ISBN:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(95, 155);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 16);
            this.label21.TabIndex = 28;
            this.label21.Text = "Año de Publicacion:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(95, 118);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 16);
            this.label22.TabIndex = 27;
            this.label22.Text = "Autor:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(95, 82);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 16);
            this.label23.TabIndex = 26;
            this.label23.Text = "Titulo:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(95, 44);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 16);
            this.label24.TabIndex = 25;
            this.label24.Text = "Codigo:";
            // 
            // c1
            // 
            this.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c1.HeaderText = "Codigo";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            // 
            // c2
            // 
            this.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c2.HeaderText = "Titulo";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c3.HeaderText = "Autor";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c4.HeaderText = "Año de Publicacion";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c5.HeaderText = "ISBN";
            this.c5.MinimumWidth = 6;
            this.c5.Name = "c5";
            // 
            // c6
            // 
            this.c6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c6.HeaderText = "Editorial";
            this.c6.MinimumWidth = 6;
            this.c6.Name = "c6";
            // 
            // gestionLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 554);
            this.Controls.Add(this.gbLibros);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dvgLibros);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gestionLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Libros";
            this.Load += new System.EventHandler(this.gestionLibros_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraficos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLibros)).EndInit();
            this.gbLibros.ResumeLayout(false);
            this.gbLibros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvgLibros;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.PictureBox pbGraficos;
        private System.Windows.Forms.PictureBox pbPrestamos;
        private System.Windows.Forms.PictureBox pbLibros;
        private System.Windows.Forms.GroupBox gbLibros;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
    }
}