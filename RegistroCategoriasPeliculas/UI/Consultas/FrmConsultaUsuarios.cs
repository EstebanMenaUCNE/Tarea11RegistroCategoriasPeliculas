﻿using RegistroCategoriasPeliculas.DAL;
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
                PeliculasDb db = new PeliculasDb();
                UsuariosDataGridView.DataSource = db.Usuarios.ToList();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
