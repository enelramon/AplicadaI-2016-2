using BLL;
using Entidades;
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
    public partial class rCategorias : Form
    {
        public rCategorias()
        {
            InitializeComponent();
        }

        private Categorias LlenaClase()
        {
            Categorias categoria = new Categorias();


            categoria.CategoriaId = 0;
            categoria.Descripcion =  DescripciontextBox.Text  ;

            return categoria;
        }

        private void LlenaCampos(Categorias categoria)
        {
            CategoriaIdtextBox.Text = categoria.CategoriaId.ToString();
            DescripciontextBox.Text = categoria.Descripcion;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            LlenaCampos(CategoriasBll.Buscar(Convert.ToInt32(CategoriaIdtextBox.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            CategoriasBll.Insertar(LlenaClase());


           

        }

     
    }
}
