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
    }
}
