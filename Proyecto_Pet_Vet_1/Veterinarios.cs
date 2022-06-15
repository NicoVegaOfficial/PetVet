using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Pet_Vet_1
{
    public partial class Veterinarios : Form
    {
        conexionsqlserver conexion = new conexionsqlserver();
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");

        public Veterinarios()
        {
            InitializeComponent();
        }

        private void Veterinarios_Load(object sender, EventArgs e)
        {
            iniciarGrillaVeterinario();
        }
        private void iniciarGrillaVeterinario()
        {
            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Veterinario";
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataVeterinario.DataSource = dt;
                this.dataVeterinario.Columns["IdVeterinario"].Visible = false;
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
        private void consultas(string consultax)
        {
            string x = "%" + consultax + "%";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Veterinario where IdVeterinario like @termino or Nombre like @termino or Apellido = @termino;";
                cmd.Parameters.AddWithValue("@termino", x);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataVeterinario.DataSource = dt;
                this.dataVeterinario.Columns["IdVeterinario"].Visible = false;
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

        private void btnResfrecar_Click(object sender, EventArgs e)
        {
            iniciarGrillaVeterinario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool existeDatos = tomarDatos();
            if (existeDatos)
            {
                if (MessageBox.Show("¿Estás seguro que quieres eliminar al veterinario " + datos.nombre + "?", "Eliminar veterinario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conexion.eliminarVeterinario(datos.idVeterinario);
                    iniciarGrillaVeterinario();
                }
            }
        }
        private bool tomarDatos()
        {
            bool existeDatos = false;

            DataGridViewRowCollection filas = dataVeterinario.Rows;
            if (filas.Count > 0)
            {
                existeDatos = true;
                datos.idVeterinario = dataVeterinario.SelectedCells[0].Value.ToString();
                datos.nombre = dataVeterinario.SelectedCells[1].Value.ToString();
                datos.apellido = dataVeterinario.SelectedCells[2].Value.ToString();
            }
            return existeDatos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarVeterinario agrVeteti = new agregarVeterinario();
            agrVeteti.Show();

        }

        private void btnModificarVeterinario_Click(object sender, EventArgs e)
        {
            tomarDatos();
            modificarVeterinario modVeterinario = new modificarVeterinario();
            modVeterinario.Show();
            
        }

        private void dataVeterinario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
