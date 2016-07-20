using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace Aplicada1_2016_2
{
    public partial class rPeliculas : Form
    {
        Peliculas pelicula = new Peliculas();
        public rPeliculas()
        {
            InitializeComponent();
        }

       


        private void rPeliculas_Load(object sender, EventArgs e)
        {
            categoriaIdComboBox.DataSource = CategoriasBll.GetLista();
            categoriaIdComboBox.ValueMember = "CategoriaId";
            categoriaIdComboBox.DisplayMember = "Descripcion";

            autorIdComboBox.DataSource = AutorBLL.GetLista();
            autorIdComboBox.ValueMember = "AutorId";
            autorIdComboBox.DisplayMember = "Nombres";
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            LlenaCampos(PeliculasBll.Buscar(StringToInt(peliculaIdTextBox.Text)));
        }

        private void LlenaCampos(Peliculas pelicula)
        {
            peliculaIdTextBox.Text = pelicula.PeliculaId.ToString();
            tituloTextBox.Text = pelicula.Titulo;
            descripcionTextBox.Text = pelicula.Descripcion;
            peliculasAutoresDataGridView.DataSource = pelicula.Autores;

        }

        private void LlenarClase(Peliculas pelicula)
        {
            pelicula.PeliculaId = StringToInt(peliculaIdTextBox.Text);
            pelicula.Titulo = tituloTextBox.Text;
            pelicula.Descripcion = descripcionTextBox.Text;
            pelicula.CategoriaId = (int)categoriaIdComboBox.SelectedValue;


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            

            LlenarClase(pelicula);

            PeliculasBll.Insertar(pelicula);
        }

        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void peliculasAutoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pelicula.Autores.Add(new Autores((int)autorIdComboBox.SelectedValue, autorIdComboBox.Text));
            peliculasAutoresDataGridView.AutoGenerateColumns = false;
            peliculasAutoresDataGridView.DataSource = pelicula.Autores;
        }

        private void autorIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoriaIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
