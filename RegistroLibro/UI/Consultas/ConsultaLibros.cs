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

namespace RegistroLibro.UI.Consultas
{
    public partial class ConsultaLibros : Form
    {
        public ConsultaLibros()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            System.Linq.Expressions.Expression<Func<Libros, bool>> filtro = x => true;

            int id;
            switch (filtrarcomboBox.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.LibroId == id;                   
                    break;
                case 1:// Descripcion
                    filtro = x => x.Descripcion.Contains(CriteriotextBox.Text);                    
                    break;
                case 2:// Siglas
                    filtro = x => x.Siglas.Equals(CriteriotextBox.Text);                    
                    break;
            }


            ConsultadataGridView.DataSource = BLL.LibrosBLL.GetList(filtro);
        }
    }
}
