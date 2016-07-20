using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicada1_2016_2.Consultas
{
    public partial class ConsultaPeliculas : Form
    {
        public ConsultaPeliculas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            DatosDataGridView.DataSource = PeliculasBll.GetLista();
        }
    }
}
