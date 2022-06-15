using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Pet_Vet_1
{
    public partial class InsertarAnimal : Form
    {
        conexionsqlserver conexion = new conexionsqlserver();
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
        public InsertarAnimal()
        {
            InitializeComponent();
        }

        private void InsertarAnimal_Load(object sender, EventArgs e)
        {
            iniciarGrillaAnimal();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.insertar(textCliente.Text, txtNombre.Text, txtEspecie.Text, txtRaza.Text, txtColor.Text, dateNacimiento.Value);
        }
        private void iniciarGrillaAnimal()
        {
            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Cliente";
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                DataAnimal.DataSource = dt;
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


        private void Insertar_Click(object sender, EventArgs e)
        {

        }

        private void DataAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textCliente.Text = DataAnimal.SelectedCells[0].Value.ToString();
        }
    }
}
