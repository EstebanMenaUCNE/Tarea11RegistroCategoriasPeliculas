using RegistroCategoriasPeliculas.UI.Consultas;
using RegistroCategoriasPeliculas.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroCategoriasPeliculas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegistroCategorias().Show();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultaCategorias().Show();
        }

        private void películasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegistroPeliculas().Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegistroUsuarios().Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmConsultaUsuarios().Show();
        }

        private void películasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmConsultaPeliculas().Show();
        }
    }
}
