using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicada1_2016_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void separarCadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SepararCadenas separarCadenas = new SepararCadenas();
            separarCadenas.MdiParent = this;
            separarCadenas.Show();
        }

        private void exportarExellToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategorias rCategoria = new rCategorias();
            rCategoria.Show();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaCategorias consulta = new Consultas.ConsultaCategorias();
            consulta.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPeliculas rpelicula = new rPeliculas();
            rpelicula.ShowDialog(); 
        }

        private void categoriasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rCategorias rcategoria = new rCategorias();
            rcategoria.Show();
        }

        private void peliculasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaPeliculas consulta = new Consultas.ConsultaPeliculas();
            consulta.Show();
        }
    }
}
