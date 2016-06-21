using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PeliculasEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            using (var context = new Aplicada1DbEntities())
            {
                var L2EQuery1 = from cl in context.Clientes
                               where cl.Nombres == "Junior"
                               select cl;

                var cliente = L2EQuery1.FirstOrDefault<Clientes>();

                var L2EQuery2 = from cl in context.Clientes
                               where cl.Balance < 600
                               select cl;

                var listaDeClientes = L2EQuery2.ToList<Clientes>();


            }

        }
    }
}
