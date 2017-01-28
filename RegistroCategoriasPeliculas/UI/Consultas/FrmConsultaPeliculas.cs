using RegistroCategoriasPeliculas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroCategoriasPeliculas.UI.Consultas
{
    public partial class FrmConsultaPeliculas : Form
    {
        public FrmConsultaPeliculas()
        {
            InitializeComponent();
        }

        private void PeliculasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultaPeliculas_Load(object sender, EventArgs e)
        {
            try
            {
                var db = new PeliculasDb();
                PeliculasDataGridView.DataSource = db.Peliculas.ToList();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
