using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pet_Vet_1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
        conexionsqlserver conexion = new conexionsqlserver();
        DataTable dt = new DataTable();

         private void consultas(string consultax)
         {
            string x = "%" + consultax + "%";
            try
             {
                 conn.Open();
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 cmd.CommandText = "select IdAnimal, IdCliente as 'Socio Nº', Nombre,Especie,Raza, Color, Fecha_Nacimiento as 'Fecha de Nacimiento' from Animal where IdCliente like @termino or Nombre like @termino or Especie like @termino or Raza like @termino or Color like @termino or Fecha_Nacimiento like @termino";
                 cmd.Parameters.AddWithValue("@termino", x);
                 SqlDataReader rdr = cmd.ExecuteReader();
                 DataTable dt = new DataTable();              
                 dt.Load(rdr);
                 rdr.Close();
                 dgInicio.DataSource = dt;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally
             {
                 conn.Close();
             }

         }
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\Pet_Vet.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            iniciargrilla();
        }
        private void iniciargrilla()
        {
            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select IdAnimal, IdCliente as 'Socio Nº', Nombre,Especie,Raza, Color, Fecha_Nacimiento as 'Fecha de Nacimiento' from Animal";                    
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dgInicio.DataSource = dt;
                this.dgInicio.Columns["IdAnimal"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            consultas(txtConsulta.Text);
            DataGridViewRowCollection filas = dgInicio.Rows;
            if (filas.Count<=0)
            {
                datos.idAnimal = null;
                datos.idCliente = null;
                datos.nombre = null;
                datos.especie = null;
                datos.raza = null;
                datos.color = null;
                datos.fechaNacimiento = null;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           bool existeDatos = tomarDatos();
            if (existeDatos) {
                EliminarAnimal FormEliminar = new EliminarAnimal();
                FormEliminar.Show();
            }
            else { MessageBox.Show("No existe datos"); }
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertarAnimal FormInsertar = new InsertarAnimal();
            FormInsertar.Show();
        }
        private bool tomarDatos()
        {
            bool existeDatos = false;
                
            DataGridViewRowCollection filas = dgInicio.Rows;    
            if (filas.Count>0)
            {
                existeDatos = true;
                datos.idAnimal = dgInicio.SelectedCells[0].Value.ToString();
                datos.idCliente = dgInicio.SelectedCells[1].Value.ToString();
                datos.nombre = dgInicio.SelectedCells[2].Value.ToString();
                datos.especie = dgInicio.SelectedCells[3].Value.ToString();
                datos.raza = dgInicio.SelectedCells[4].Value.ToString();
                datos.color = dgInicio.SelectedCells[5].Value.ToString();
                datos.fechaNacimiento = dgInicio.SelectedCells[6].Value.ToString();
            }
            return existeDatos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tomarDatos();
            modificarAnimal FormMod = new modificarAnimal();
            FormMod.Show();

        }

        static public void dgInicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciargrilla();
        }
    }
}
