using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Pet_Vet_1
{
    public partial class Vacuna : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
        conexionsqlserver conexion = new conexionsqlserver();
        public Vacuna()
        {
            InitializeComponent();
        }

        private void Vacuna_Load(object sender, EventArgs e)
        {
            iniciargrillaMascotas();
           
        }
        private void iniciargrillaMascotas()
        {
            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select IdAnimal, IdCliente as 'Nº de Socio', Nombre, Especie, Raza, Color, Fecha_Nacimiento as 'Fecha de Nacimiento' from Animal";
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataMascotas.DataSource = dt;
                this.dataMascotas.Columns["IdAnimal"].Visible = false;
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

        private void dataMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FechasVacunas();
        }
        private void FechasVacunas()
        {
            String Idconsulta = dataMascotas.SelectedCells[0].Value.ToString();
            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select IdVacunaAnimal, IdVacuna, IdAnimal, Fecha_Vacuna as 'Fecha de Vacunación' from VacunaAnimal where IdAnimal = " + Idconsulta;
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataVacunas.DataSource = dt;
                this.dataVacunas.Columns["IdVacunaAnimal"].Visible = false;              
                this.dataVacunas.Columns["IdAnimal"].Visible = false;
                this.dataVacunas.Columns["IdVacuna"].Visible = false;

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
        }
        private void consultas(string consultax)
        {
            string x = "%" + consultax + "%";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Animal where Nombre like @termino or Especie like @termino or Raza like @termino or Color like @termino or Fecha_Nacimiento like @termino;";
                cmd.Parameters.AddWithValue("@termino", x);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataMascotas.DataSource = dt;
                this.dataVacunas.Columns["IdAnimal"].Visible = false;
                this.dataVacunas.Columns["IdVacunaAnimal"].Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {

            iniciargrillaMascotas();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tomarDatos();
            agregarFechaVacuna addVac = new agregarFechaVacuna();
            addVac.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idVacunaAnimal = dataVacunas.SelectedCells[0].Value.ToString();
            conexion.EliminarVacunaAnimal(idVacunaAnimal);
            MessageBox.Show("Vacuna eliminada");
        }
        private bool tomarDatos()
        {
            bool existeDatos = false;

            DataGridViewRowCollection filas = dataMascotas.Rows;
            if (filas.Count > 0)
            {
                existeDatos = true;
                datos.idCliente = dataMascotas.SelectedCells[1].Value.ToString();
                datos.nombreMascota = dataMascotas.SelectedCells[2].Value.ToString();
                datos.especie = dataMascotas.SelectedCells[3].Value.ToString();
                datos.raza = dataMascotas.SelectedCells[4].Value.ToString();
                datos.color = dataMascotas.SelectedCells[5].Value.ToString();
                datos.fechaNacimiento = dataMascotas.SelectedCells[6].Value.ToString();                
            }
            return existeDatos;
        }

        private void dataVacunas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
