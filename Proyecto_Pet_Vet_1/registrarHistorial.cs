using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Pet_Vet_1
{
    public partial class registrarHistorial : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
        conexionsqlserver conexion = new conexionsqlserver();
        public registrarHistorial()
        {
            InitializeComponent();
        }

        private void registrarHistorial_Load(object sender, EventArgs e)
        {
            iniciarGrillaVeterinarios();
            iniciarGrillaEnfermedades();
            label9.Text = datos.idAnimal;
        }

        private void btnAgregarHC_Click(object sender, EventArgs e)
        {
            conexionsqlserver sql = new conexionsqlserver();
            sql.insertarHC(datos.idAnimal, datos.idVeterinario, datos.idEnfermedad, datos.fechaEnfermedad);
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            datos.fechaEnfermedad = calendario.SelectionStart.Year.ToString() + "-" + calendario.SelectionStart.Month.ToString() + "-" + calendario.SelectionStart.Day.ToString();
        }
        private void iniciarGrillaEnfermedades()
        {

            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Enfermedad;";
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataEnfermedades.DataSource = dt;

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
        private void iniciarGrillaVeterinarios()
        {

            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Veterinario;";
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataVeterinario.DataSource = dt;

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

        private void dataEnfermedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datos.idEnfermedad = dataEnfermedades.SelectedCells[0].Value.ToString();
            datos.nombreEnfermedad = dataEnfermedades.SelectedCells[1].Value.ToString();
            labelEnfermedad.Text = datos.nombreEnfermedad;
        }

        private void dataVeterinario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datos.idVeterinario = dataVeterinario.SelectedCells[0].Value.ToString();
            datos.nombreVeterinario = dataVeterinario.SelectedCells[1].Value.ToString();
            datos.apellidoVeterinario = dataVeterinario.SelectedCells[2].Value.ToString();
            labelNombreVeterinario.Text = datos.nombreVeterinario;
            labelApellidoVeterinario.Text = datos.apellidoVeterinario;
        }
    }
}
