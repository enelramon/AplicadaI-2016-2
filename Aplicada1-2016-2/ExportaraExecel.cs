using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClosedXML;
using System.IO;
using ClosedXML.Excel;
using System.Data.SqlClient;

namespace Aplicada1_2016_2
{
    public partial class ExportaraExecel : Form
    {
        public ExportaraExecel()
        {
            InitializeComponent();
        }

        private void ExportaraExecel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
            new DataColumn("Name", typeof(string)),
            new DataColumn("Country",typeof(string)) });
            dt.Rows.Add(1, "John Hammond", "United States");
            dt.Rows.Add(2, "Mudassar Khan", "India");
            dt.Rows.Add(3, "Suzanne Mathews", "France");
            dt.Rows.Add(4, "Robert Schidner", "Russia");

            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = (DataTable)dataGridView1.DataSource;
            //Exporting to Excel
            string folderPath = @"C:\Users\enelr\Desktop\Tareas\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Customers");
                wb.SaveAs(folderPath + "DataGridViewExport.xlsx");

            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SqlExpress;Initial Catalog=Aplicada1Db;Integrated Security=True");
            SqlCommand comando = new SqlCommand("select * from Clientes", con);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            try
            {
                con.Open();
                adapter.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al conectarse" + ex.Message);
            }
            finally
            {
                con.Close();
                adapter.Dispose();
                comando.Dispose();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tabla = new DataTable();

            try
            {
                con.ConnectionString = @"Data Source=.\SqlExpress;Initial Catalog=Aplicada1Db;Integrated Security=True";
                con.Open();

                comando.Connection = con;
                comando.CommandText = "select * from Clientes Where Balance > 0";

                adapter.SelectCommand = comando;

                adapter.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al conectarse" + ex.Message);
            }
            finally
            {
                con.Close();
                adapter.Dispose();
                comando.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SqlExpress;Initial Catalog=Aplicada1Db;Integrated Security=True");
            SqlCommand comando = new SqlCommand("Update Clientes Set Balance = Balance -1 ", con);

            try
            {
                con.Open();
                comando.ExecuteNonQuery();

                BuscarButton.PerformClick();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al Buscar" + ex.Message);
            }
            finally
            {
                con.Close();

                comando.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection=new SqlConnection(@"Data Source=.\SqlExpress;Initial Catalog=Aplicada1Db;Integrated Security=True");
            DataTable tabla = new DataTable();

            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT Id,Nombres,Balance FROM Clientes;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                    tabla.Load(reader);
                    //while (reader.Read())
                    //{
                    //    Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                    //        reader.GetString(1),reade);
                    //}
              
                reader.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ComandoSql = "";

            ComandoSql = string.Format("Insert Into Clientes (Nombres, Balance) Values ('{0}',{1}) ",NombrestextBox.Text,BalancetextBox.Text );

            SqlConnection con = new SqlConnection(@"Data Source=.\SqlExpress;Initial Catalog=Aplicada1Db;Integrated Security=True");
            SqlCommand comando = new SqlCommand(ComandoSql , con);

            try
            {
                con.Open();
                comando.ExecuteNonQuery();

                BuscarButton.PerformClick();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al Buscar" + ex.Message);
            }
            finally
            {
                con.Close();

                comando.Dispose();
            }
        }
    }
}
