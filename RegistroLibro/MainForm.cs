using RegistroLibro.UI.Consultas;
using RegistroLibro.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLibro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroLibros registro = new RegistroLibros();
            registro.MdiParent = this;
            registro.Show();
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaLibros consulta = new ConsultaLibros();
            consulta.MdiParent = this;
            consulta.Show();
        }

    }
}
