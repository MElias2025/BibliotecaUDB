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
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbLibros = new System.Windows.Forms.GroupBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAnoPublicacion = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 455);
            this.panel1.TabIndex = 0;
            // 
            // pbGraficos
            // 
            this.pbGraficos.Image = ((System.Drawing.Image)(resources.GetObject("pbGraficos.Image")));
            this.pbGraficos.Location = new System.Drawing.Point(29, 346);
            this.pbGraficos.Name = "pbGraficos";
            this.pbGraficos.Size = new System.Drawing.Size(100, 84);
            this.pbGraficos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGraficos.TabIndex = 3;
            this.pbGraficos.TabStop = false;
            this.pbGraficos.Click += new System.EventHandler(this.pbGraficos_Click);
            // 
            // pbPrestamos
            // 
            this.pbPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("pbPrestamos.Image")));
            this.pbPrestamos.Location = new System.Drawing.Point(29, 229);
            this.pbPrestamos.Name = "pbPrestamos";
            this.pbPrestamos.Size = new System.Drawing.Size(100, 84);
            this.pbPrestamos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrestamos.TabIndex = 2;
            this.pbPrestamos.TabStop = false;
            this.pbPrestamos.Click += new System.EventHandler(this.pbPrestamos_Click);
            // 
            // pbLibros
            // 
            this.pbLibros.Image = ((System.Drawing.Image)(resources.GetObject("pbLibros.Image")));
            this.pbLibros.Location = new System.Drawing.Point(29, 116);
            this.pbLibros.Name = "pbLibros";
            this.pbLibros.Size = new System.Drawing.Size(100, 84);
            this.pbLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibros.TabIndex = 1;
            this.pbLibros.TabStop = false;
            this.pbLibros.Click += new System.EventHandler(this.pbLibros_Click);
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarios.Image")));
            this.pbUsuarios.Location = new System.Drawing.Point(29, 12);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(100, 84);
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
            this.dvgLibros.Location = new System.Drawing.Point(180, 268);
            this.dvgLibros.Name = "dvgLibros";
            this.dvgLibros.RowHeadersVisible = false;
            this.dvgLibros.Size = new System.Drawing.Size(585, 162);
            this.dvgLibros.TabIndex = 2;
            this.dvgLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgLibros_CellClick);
            // 
            // c1
            // 
            this.c1.HeaderText = "Codigo";
            this.c1.Name = "c1";
            this.c1.Width = 75;
            // 
            // c2
            // 
            this.c2.HeaderText = "Titulo";
            this.c2.Name = "c2";
            this.c2.Width = 106;
            // 
            // c3
            // 
            this.c3.HeaderText = "Autor";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "Año de Publicacion";
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.HeaderText = "ISBN";
            this.c5.Name = "c5";
            // 
            // c6
            // 
            this.c6.HeaderText = "Editorial";
            this.c6.Name = "c6";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIngresar.Location = new System.Drawing.Point(700, 69);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.Location = new System.Drawing.Point(700, 108);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(700, 147);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(700, 186);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbLibros
            // 
            this.gbLibros.Controls.Add(this.txtEditorial);
            this.gbLibros.Controls.Add(this.txtISBN);
            this.gbLibros.Controls.Add(this.txtAnoPublicacion);
            this.gbLibros.Controls.Add(this.txtAutor);
            this.gbLibros.Controls.Add(this.txtTitulo);
            this.gbLibros.Controls.Add(this.txtCodigo);
            this.gbLibros.Controls.Add(this.label19);
            this.gbLibros.Controls.Add(this.label20);
            this.gbLibros.Controls.Add(this.label21);
            this.gbLibros.Controls.Add(this.label22);
            this.gbLibros.Controls.Add(this.label23);
            this.gbLibros.Controls.Add(this.label24);
            this.gbLibros.Location = new System.Drawing.Point(180, 12);
            this.gbLibros.Name = "gbLibros";
            this.gbLibros.Size = new System.Drawing.Size(500, 235);
            this.gbLibros.TabIndex = 7;
            this.gbLibros.TabStop = false;
            this.gbLibros.Text = "Informacion Libros";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEditorial.Location = new System.Drawing.Point(181, 181);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(249, 20);
            this.txtEditorial.TabIndex = 36;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtISBN.Location = new System.Drawing.Point(181, 152);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(249, 20);
            this.txtISBN.TabIndex = 35;
            // 
            // txtAnoPublicacion
            // 
            this.txtAnoPublicacion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAnoPublicacion.Location = new System.Drawing.Point(181, 123);
            this.txtAnoPublicacion.Name = "txtAnoPublicacion";
            this.txtAnoPublicacion.Size = new System.Drawing.Size(249, 20);
            this.txtAnoPublicacion.TabIndex = 34;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAutor.Location = new System.Drawing.Point(181, 93);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(249, 20);
            this.txtAutor.TabIndex = 33;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTitulo.Location = new System.Drawing.Point(181, 64);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(249, 20);
            this.txtTitulo.TabIndex = 32;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCodigo.Location = new System.Drawing.Point(181, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(249, 20);
            this.txtCodigo.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(71, 184);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Editorial:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(71, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "ISBN:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(71, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "Año de Publicacion:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(71, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "Autor:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(71, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "Titulo:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(71, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Codigo:";
            // 
            // gestionLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.gbLibros);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dvgLibros);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.PictureBox pbGraficos;
        private System.Windows.Forms.PictureBox pbPrestamos;
        private System.Windows.Forms.PictureBox pbLibros;
        private System.Windows.Forms.GroupBox gbLibros;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAnoPublicacion;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}