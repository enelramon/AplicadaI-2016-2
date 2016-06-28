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
    public partial class ReportingViewer : Form
    {
        public ReportingViewer()
        {
            InitializeComponent();
        }

        private void ReportingViewer_Load(object sender, EventArgs e)
        {

            this.RptViewer.RefreshReport();
        }
    }
}
