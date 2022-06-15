using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Pet_Vet_1
{
    public partial class Historia_Clinica : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
        conexionsqlserver conexion = new conexionsqlserver();
        public Historia_Clinica()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {

        }

        private void Historia_Clinica_Load(object sender, EventArgs e)
        {
            iniciargrillaHistoria();
        }
        private void iniciargrillaHistoria()
        {
            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select HistoriaClinica.idHistoriaClinica, Animal.IdAnimal as 'Nº de Socio', Animal.Nombre as 'Mascota', Animal.Especie, Animal.Raza"
                    + " from HistoriaClinica"
                    + " inner join Enfermedad on HistoriaClinica.IdEnfermedad = Enfermedad.IdEnfermedad"
                    + " inner join Animal on HistoriaClinica.IdAnimal = Animal.IdAnimal"
                    + " inner join Veterinario on HistoriaClinica.IdVeterinario = Veterinario.IdVeterinario"
                    + " order by HistoriaClinica.idHistoriaClinica asc";
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataHistoriaClinica.DataSource = dt;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tomarDatos();
            registrarHistorial regHistorial = new registrarHistorial();
            regHistorial.Show();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            bool existeDatos = tomarDatos();
            if (existeDatos)
            {
                if (MessageBox.Show("¿Estás seguro que quieres eliminar la historia clinica de " + datos.nombreMascota + "?", "Eliminar Historia clinica", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    conexion.eliminarHC(datos.idHistoriaClinica);
                    iniciargrillaHistoria();
                }
            }
            else
            {
                MessageBox.Show("No existe datos");
            }
        }
        private bool tomarDatos()
        {
            bool existeDatos = false;

            DataGridViewRowCollection filas = dataHistoriaClinica.Rows;
            if (filas.Count > 0)
            {
                existeDatos = true;
                datos.idHistoriaClinica = dataHistoriaClinica.SelectedCells[0].Value.ToString();
                datos.idAnimal = dataHistoriaClinica.SelectedCells[1].Value.ToString();
                datos.nombreMascota = dataHistoriaClinica.SelectedCells[2].Value.ToString();
            }
            return existeDatos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciargrillaHistoria();
        }
        private void consultas(string consultax)
        {
            string x = "%" + consultax + "%";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select HistoriaClinica.idHistoriaClinica, IdAnimal, IdCliente as 'Socio Nº', Nombre,Especie,Raza, Color, Fecha_Nacimiento as 'Fecha de Nacimiento' from Animal where IdCliente like @termino or Nombre like @termino or Especie like @termino or Raza like @termino or Color like @termino or Fecha_Nacimiento like @termino";
                cmd.Parameters.AddWithValue("@termino", x);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataHistoriaClinica.DataSource = dt;
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
        private void btnConsultas_Click_1(object sender, EventArgs e)
        {
            consultas(txtConsulta.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iniciargrillaClinica();
        }
        private void iniciargrillaClinica()
        {
            string Idconsulta = dataHistoriaClinica.SelectedCells[0].Value.ToString();
            
            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select HistoriaClinica.IdHistoriaClinica as 'Nº de H.C.', Enfermedad.Nombre as 'Enfermedad',  HistoriaClinica.Fecha_Enfermedad as 'Fecha de Enfermedad', Veterinario.Nombre as 'Nombre del Veterinario', Veterinario.Apellido as 'Apellido del Veterinario'
                     from HistoriaClinica
                    inner join Enfermedad on HistoriaClinica.IdEnfermedad = Enfermedad.IdEnfermedad
                    inner join Animal on HistoriaClinica.IdAnimal = Animal.IdAnimal
                     inner join Veterinario on HistoriaClinica.IdVeterinario = Veterinario.IdVeterinario where HistoriaClinica.IdHistoriaClinica = " + Idconsulta;                 
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataGridView1.DataSource = dt;
                

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

        private void dataHistoriaClinica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iniciargrillaClinica();
        }
    }
}
