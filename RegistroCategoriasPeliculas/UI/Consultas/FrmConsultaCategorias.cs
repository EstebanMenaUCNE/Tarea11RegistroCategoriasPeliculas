using RegistroCategoriasPeliculas.DAL;
using RegistroCategoriasPeliculas.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroCategoriasPeliculas.UI.Consultas
{
    public partial class FrmConsultaCategorias : Form
    {
        public FrmConsultaCategorias()
        {
            InitializeComponent();
        }

        private void FrmConsultaCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                var db = new PeliculasDb();
                CategoriasDataGridView.DataSource = db.Categorias.ToList();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void CategoriasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
