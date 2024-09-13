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
        private string [,] libros = new string[100,6];
        //variable para cantidad de libros
        private int contador = 0;

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

            if(string.IsNullOrWhiteSpace(txtCodigo.Text) ||
        string.IsNullOrWhiteSpace(txtTitulo.Text) ||
        string.IsNullOrWhiteSpace(txtAutor.Text) ||
        string.IsNullOrWhiteSpace(txtAnoPublicacion.Text) ||
        string.IsNullOrWhiteSpace(txtISBN.Text) ||
        string.IsNullOrWhiteSpace(txtEditorial.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Verificar si el código ya existe
            for (int i = 0; i < contador; i++)
            {
                if (libros[i, 0].Equals(txtCodigo.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Ya existe un libro con este código.");
                    return;
                }
            }

            libros[contador,0] = txtCodigo.Text;
            libros[contador,1] = txtTitulo.Text;
            libros[contador,2] = txtAutor.Text;
            libros[contador,3] = txtAnoPublicacion.Text;
            libros[contador,4] = txtISBN.Text;
            libros[contador,5] = txtEditorial.Text;

            contador++;
            actualizarDataGridView();

            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnoPublicacion.Clear();
            txtISBN.Clear();
            txtEditorial.Clear();
        }

        //Actualizar dataviewgriew
        private void actualizarDataGridView()
        {
            // Limpiar las filas actuales en el DataGridView
            dvgLibros.Rows.Clear();

            // Llenar el DataGridView con los datos del array
            for (int i = 0; i < contador; i++)
            {
                dvgLibros.Rows.Add(libros[i, 0], libros[i, 1], libros[i, 2], libros[i, 3], libros[i, 4], libros[i, 5]);
            }
        }

        //Boton Buscar Libro
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener los términos de búsqueda de los TextBox
            string codigoBusqueda = txtCodigo.Text.Trim();
            string tituloBusqueda = txtTitulo.Text.Trim();
            string autorBusqueda = txtAutor.Text.Trim();
            string anoBusqueda = txtAnoPublicacion.Text.Trim();
            string isbnBusqueda = txtISBN.Text.Trim();
            string editorialBusqueda = txtEditorial.Text.Trim();

            // Limpiar el DataGridView
            dvgLibros.Rows.Clear();

            // Buscar libros que coincidan con los criterios de búsqueda
            for (int i = 0; i < contador; i++)
            {
                bool coincide = true;

                // Comparar cada campo con el término de búsqueda si está lleno
                if (!string.IsNullOrWhiteSpace(codigoBusqueda) && !libros[i, 0].Equals(codigoBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;
                if (!string.IsNullOrWhiteSpace(tituloBusqueda) && !libros[i, 1].Equals(tituloBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;
                if (!string.IsNullOrWhiteSpace(autorBusqueda) && !libros[i, 2].Equals(autorBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;
                if (!string.IsNullOrWhiteSpace(anoBusqueda) && !libros[i, 3].Equals(anoBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;
                if (!string.IsNullOrWhiteSpace(isbnBusqueda) && !libros[i, 4].Equals(isbnBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;
                if (!string.IsNullOrWhiteSpace(editorialBusqueda) && !libros[i, 5].Equals(editorialBusqueda, StringComparison.OrdinalIgnoreCase))
                    coincide = false;

                if (coincide)
                {
                    // Agregar la fila al DataGridView si hay una coincidencia
                    dvgLibros.Rows.Add(libros[i, 0], libros[i, 1], libros[i, 2], libros[i, 3], libros[i, 4], libros[i, 5]);
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
                txtAnoPublicacion.Text = filaSeleccionada.Cells[3].Value?.ToString();
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

            // Busca el libro por el código ingresado
            bool libroEncontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (libros[i, 0].Equals(txtCodigo.Text, StringComparison.OrdinalIgnoreCase))
                {
                    // Actualizar los campos del libro (excepto el código)
                    libros[i, 1] = txtTitulo.Text;
                    libros[i, 2] = txtAutor.Text;
                    libros[i, 3] = txtAnoPublicacion.Text;
                    libros[i, 4] = txtISBN.Text;
                    libros[i, 5] = txtEditorial.Text;

                    libroEncontrado = true;
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

            // Limpiar los campos después de actualizar
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnoPublicacion.Clear();
            txtISBN.Clear();
            txtEditorial.Clear();

            MessageBox.Show("El libro ha sido actualizado exitosamente.");
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
                if (libros[i, 0].Equals(txtCodigo.Text, StringComparison.OrdinalIgnoreCase))
                {
                    // Desplazar los elementos para eliminar el libro encontrado
                    for (int j = i; j < contador - 1; j++)
                    {
                        for (int k = 0; k < libros.GetLength(1); k++)
                        {
                            libros[j, k] = libros[j + 1, k]; // Mover cada campo
                        }
                    }

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
            txtAnoPublicacion.Clear();
            txtISBN.Clear();
            txtEditorial.Clear();

            MessageBox.Show("El libro ha sido eliminado exitosamente.");
        }
    }
}
