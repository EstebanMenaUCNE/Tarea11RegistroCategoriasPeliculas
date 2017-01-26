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
                List<Categoria> categorias = new List<Categoria>();
                var db = new PeliculasDb();
                categorias = db.Categorias.ToList();
                CategoriasDataGridView.DataSource = categorias;
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
