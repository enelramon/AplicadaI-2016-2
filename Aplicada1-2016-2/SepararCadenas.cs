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
    public partial class SepararCadenas : Form
    {
        public SepararCadenas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                errorProvider1.SetError(textBox1, "No puede estar vacio");

            listBox1.Items.Add("a");

            int row;

            row = dataGridView2.Rows.Add();

            // dataGridView2.Rows[row].Cells["Palabras"].Value = textBox1.Text;
            dataGridView1.Rows.Add("100", "algo", 1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show(  dateTimePicker1.Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text  =openFileDialog1.FileName;
        }
    }
}
