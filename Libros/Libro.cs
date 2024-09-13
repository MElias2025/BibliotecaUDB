using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Libro
    {
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime AnoPublicacion { get; set; }
        public string ISBN { get; set; }
        public string Editorial { get; set; }

        // Constructor para inicializar un libro
        public Libro(string codigo, string titulo, string autor, DateTime anoPublicacion, string isbn, string editorial)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            AnoPublicacion = anoPublicacion;
            ISBN = isbn;
            Editorial = editorial;
        }
    }

}
