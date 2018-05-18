using RegistroLibro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLibro.UI.Registros
{
    public partial class RegistroLibros : Form
    {
        public RegistroLibros()
        {
            InitializeComponent();
        }

        private Libros LlenarClase()
        {

            Libros libro = new Libros();

            libro.LibroId = Convert.ToInt32(IdnumericUpDown.Value);
            libro.Descripcion = DescripciontextBox.Text;
            libro.Siglas = SiglastextBox.Text;

            return libro;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            Libros libro = LlenarClase();
            bool paso = false;

            if (IdnumericUpDown.Value == 0)
                paso = BLL.LibrosBLL.Guardar(libro);
            else
                paso = BLL.LibrosBLL.Modificar(LlenarClase());

            if (paso)

                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            SiglastextBox.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Libros libro = BLL.LibrosBLL.Buscar(id);

            if (libro != null)
            {

                DescripciontextBox.Text = libro.Descripcion;
                SiglastextBox.Text = libro.Siglas;
            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.LibrosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegistroLibros_Load(object sender, EventArgs e)
        {

        }
    }
}
