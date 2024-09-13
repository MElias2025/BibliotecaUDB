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
    public partial class gestionUsuarios : Form
    {
        public gestionUsuarios()
        {
            InitializeComponent();
        }

        private void pbUsuarios_Click(object sender, EventArgs e)
        {
            gestionUsuarios formGestionUsuarios = new gestionUsuarios();
            formGestionUsuarios.Show();
            this.Hide();
        }

        private void pbLibros_Click_1(object sender, EventArgs e)
        {
            gestionLibros formGestionLibros = new gestionLibros();
            formGestionLibros.Show();
            this.Hide();
        }

        private void pbPrestamos_Click_1(object sender, EventArgs e)
        {
            gestionPrestamos formGestionPrestamos = new gestionPrestamos();
            formGestionPrestamos.Show();
            this.Hide();
        }

        private void pbGraficos_Click_1(object sender, EventArgs e)
        {
            gestionGraficos formGestionGraficos = new gestionGraficos();
            formGestionGraficos.Show();
            this.Hide();
        }
    }
}
