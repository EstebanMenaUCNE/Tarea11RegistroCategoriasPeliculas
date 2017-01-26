using RegistroCategoriasPeliculas.DAL;
using RegistroCategoriasPeliculas.Entidades;
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
    public partial class FrmConsultaUsuarios : Form
    {
        public FrmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void FrmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                PeliculasDb db = new PeliculasDb();
                usuarios = db.Usuarios.ToList();
                UsuariosDataGridView.DataSource = usuarios;
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
