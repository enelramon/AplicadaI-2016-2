using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace Aplicada1_2016_2.Consultas
{
    public partial class ConsultaCategorias : Form
    {
        public ConsultaCategorias()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            DatosDataGridView.DataSource = CategoriasBll.GetLista();
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReportingViewer viewer = new ReportingViewer();

            viewer.RptViewer.Reset();
            viewer.RptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.RptViewer.LocalReport.ReportPath = @"Reportes\ListadoCategorias.rdlc";

            viewer.RptViewer.LocalReport.DataSources.Clear();

            viewer.RptViewer.LocalReport.DataSources.Add(
                new ReportDataSource("Categorias",
                CategoriasBll.GetLista()                ));

            viewer.RptViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
