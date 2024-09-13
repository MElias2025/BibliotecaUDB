using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros
{
    public partial class gestionLibros : Form
    {
        //Array para gestion de libros
        private Libro [] libros = new Libro[100];
        //variable para cantidad de libros
        private int contador = 0;
        private int contadorCodigo = 1; // Variable global para generar códigos automáticos

        public gestionLibros()
        {
            InitializeComponent();
            dvgLibros.CellClick += dvgLibros_CellClick;
            btnActualizar.Click += btnActualizar_Click;
        }

        //Accesos a ventanas de Gestion
        private void pbUsuarios_Click(object sender, EventArgs e)
        {
            gestionUsuarios formGestionUsuarios = new gestionUsuarios();
            formGestionUsuarios.Show();
            this.Hide();
        }
        private void pbLibros_Click(object sender, EventArgs e)
        {
            gestionLibros formGestionLibros = new gestionLibros();
            formGestionLibros.Show();
            this.Hide();
        }
        private void pbPrestamos_Click(object sender, EventArgs e)
        {
            gestionPrestamos formGestionPrestamos = new gestionPrestamos();
            formGestionPrestamos.Show();
            this.Hide();
        }
        private void pbGraficos_Click(object sender, EventArgs e)
        {
            gestionGraficos formGestionGraficos = new gestionGraficos();
            formGestionGraficos.Show();
            this.Hide();
        }
        
        private void gestionLibros_Load(object sender, EventArgs e)
        {}

        //Boton Ingresar Libro
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(contador >= libros.GetLength(0))
            {
                MessageBox.Show("No se pueden agregar mas libros");
                return;
            }

            if(string.IsNullOrWhiteSpace(txtTitulo.Text) ||
        string.IsNullOrWhiteSpace(txtAutor.Text) ||
        string.IsNullOrWhiteSpace(dateTimePickerAnoPublicacion.Value.ToString("dd-MM-yyyy")) ||
        string.IsNullOrWhiteSpace(txtISBN.Text) ||
        string.IsNullOrWhiteSpace(txtEditorial.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            //Generar el codigo unico
            string codigoGenerado = "LIB" + contadorCodigo.ToString("D4"); // "LIB0001", "LIB0002", etc.

            // Crear una instancia de Libro
            Libro nuevoLibro = new Libro(
                codigoGenerado,
                txtTitulo.Text,
                txtAutor.Text,
                dateTimePickerAnoPublicacion.Value,
                txtISBN.Text,
                txtEditorial.Text
            );

            // Agregar el libro al array
            libros[contador] = nuevoLibro;
          
            contador++;
            contadorCodigo++; // Incrementar el contador de códigos para el próximo libro
            actualizarDataGridView();
            LimpiarCampos();

            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            dateTimePickerAnoPublicacion.Value = DateTime.Now;
            txtISBN.Clear();
            txtEditorial.Clear();
            txtCodigo.Enabled = false;
        }

        //Actualizar dataviewgriew
        private void actualizarDataGridView()
        {
            // Limpiar las filas actuales en el DataGridView
            dvgLibros.Rows.Clear();

            // Llenar el DataGridView con los datos del array
            for (int i = 0; i < contador; i++)
            {
                dvgLibros.Rows.Add(
                 libros[i].Codigo,
                 libros[i].Titulo,
                 libros[i].Autor,
                 libros[i].AnoPublicacion.ToString("dd-MM-yyyy"),
                 libros[i].ISBN,
                 libros[i].Editorial
                 );
            }
        }

        //Boton Buscar Libro
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener los términos de búsqueda de los TextBox
            string codigoBusqueda = txtCodigo.Text.Trim();
            string tituloBusqueda = txtTitulo.Text.Trim();
            string autorBusqueda = txtAutor.Text.Trim();
            DateTime? anoBusqueda = null;
            if (!string.IsNullOrWhiteSpace(dateTimePickerAnoPublicacion.Text))
            {
                anoBusqueda = dateTimePickerAnoPublicacion.Value.Date;
            }
            string isbnBusqueda = txtISBN.Text.Trim();
            string editorialBusqueda = txtEditorial.Text.Trim();

            // Limpiar el DataGridView
            dvgLibros.Rows.Clear();

            // Buscar libros que coincidan con los criterios de búsqueda
            for (int i = 0; i < contador; i++)
            {
                bool coincide = true;

                // Comparar cada campo con el término de búsqueda si está lleno
                if (!string.IsNullOrWhiteSpace(codigoBusqueda) && !libros[i].Codigo.Equals(codigoBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;
                if (!string.IsNullOrWhiteSpace(tituloBusqueda) && !libros[i].Titulo.Equals(tituloBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;
                if (!string.IsNullOrWhiteSpace(autorBusqueda) && !libros[i].Autor.Equals(autorBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;
                if (anoBusqueda.HasValue && libros[i].AnoPublicacion.Date != anoBusqueda.Value)
                    coincide = false;
                if (!string.IsNullOrWhiteSpace(isbnBusqueda) && !libros[i].ISBN.Equals(isbnBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;
                if (!string.IsNullOrWhiteSpace(editorialBusqueda) && !libros[i].Editorial.Equals(editorialBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;

                if (coincide)
                {
                    // Agregar la fila al DataGridView si hay una coincidencia
                    dvgLibros.Rows.Add(
                libros[i].Codigo,
                libros[i].Titulo,
                libros[i].Autor,
                libros[i].AnoPublicacion.ToString("dd-MM-yyyy"),
                libros[i].ISBN,
                libros[i].Editorial
                );
                }
            }

            if (dvgLibros.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron libros que coincidan con los criterios de búsqueda.");
            }
        }

        //Rellenar textbox
        private void dvgLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la fila seleccionada sea válida
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dvgLibros.Rows[e.RowIndex];

                // Rellena los TextBox con los datos de la fila seleccionada
                txtCodigo.Text = filaSeleccionada.Cells[0].Value?.ToString();
                txtTitulo.Text = filaSeleccionada.Cells[1].Value?.ToString();
                txtAutor.Text = filaSeleccionada.Cells[2].Value?.ToString();
                dateTimePickerAnoPublicacion.Value = DateTime.ParseExact(filaSeleccionada.Cells[3].Value?.ToString(), "dd-MM-yyyy", null);
                txtISBN.Text = filaSeleccionada.Cells[4].Value?.ToString();
                txtEditorial.Text = filaSeleccionada.Cells[5].Value?.ToString();
            }
        }


        //Boton Actualizar Libro
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verifica que el campo de código no esté vacío
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, seleccione un libro para actualizar.");
                return;
            }

            // Buscar el libro por el código
            bool libroEncontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (libros[i].Codigo.Equals(txtCodigo.Text, StringComparison.OrdinalIgnoreCase))
                {
                    // Actualizar los campos del libro
                    libros[i].Titulo = txtTitulo.Text;
                    libros[i].Autor = txtAutor.Text;
                    libros[i].AnoPublicacion = dateTimePickerAnoPublicacion.Value;
                    libros[i].ISBN = txtISBN.Text;
                    libros[i].Editorial = txtEditorial.Text;

                    libroEncontrado = true;
                    break;
                }
            }

            if (!libroEncontrado)
            {
                MessageBox.Show("No se encontró un libro con el código especificado.");
                return;
            }

            actualizarDataGridView();
            MessageBox.Show("El libro ha sido actualizado exitosamente.");
        }

        // Limpiar los campos después de actualizar
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            dateTimePickerAnoPublicacion.Value = DateTime.Now;
            txtISBN.Clear();
            txtEditorial.Clear();
        }

        //Boton Eliminar Libro
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica que el campo de código no esté vacío
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, seleccione un libro para eliminar.");
                return;
            }

            // Busca el libro por el código ingresado
            bool libroEncontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (libros[i].Codigo.Equals(txtCodigo.Text, StringComparison.OrdinalIgnoreCase))
                {
                    // Desplazar los elementos para eliminar el libro encontrado
                    for (int j = i; j < contador - 1; j++)
                    {
                        libros[j] = libros[j + 1];
                    
                    }
                    libros[contador - 1] = null;
                    libroEncontrado = true;
                    contador--; // Reducir el contador de libros
                    break;
                }
            }

            if (!libroEncontrado)
            {
                MessageBox.Show("No se encontró un libro con el código especificado.");
                return;
            }

            // Actualizar el DataGridView
            actualizarDataGridView();

            // Limpiar los campos después de eliminar
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            dateTimePickerAnoPublicacion.Value = DateTime.Now;
            txtISBN.Clear();
            txtEditorial.Clear();

            MessageBox.Show("El libro ha sido eliminado exitosamente.");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }


    }
}
