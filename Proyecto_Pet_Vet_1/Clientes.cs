using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Pet_Vet_1
{
    public partial class Clientes : Form
    {
        conexionsqlserver conexion = new conexionsqlserver();
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            iniciarGrillaCliente();
        }
        private void iniciarGrillaCliente()
        {
            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select idCliente as 'Socio N°', Nombre, SegundoNombre, Apellido, CedulaIdentidad, CuentaBancaria, Direccion, Telefono, Ciudad from Cliente";
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataCliente.DataSource = dt;
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
                cmd.CommandText = "select idCliente as 'Socio N°', Nombre, SegundoNombre, Apellido, CedulaIdentidad, CuentaBancaria, Direccion, Telefono, Ciudad from Cliente where idCliente like @termino or Nombre like @termino or SegundoNombre like @termino or Apellido like @termino or CedulaIdentidad like @termino or CuentaBancaria like @termino or Direccion like @termino or Telefono like @termino or Ciudad like @termino";
                cmd.Parameters.AddWithValue("@termino", x);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataCliente.DataSource = dt;
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
            iniciarGrillaCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tomarDatos();
            ModificarCliente modCliente = new ModificarCliente();
            modCliente.Show();
        }
        private bool tomarDatos()
        {
            bool existeDatos = false;

            DataGridViewRowCollection filas = dataCliente.Rows;
            if (filas.Count > 0)
            {
                existeDatos = true;
                datos.idCliente = dataCliente.SelectedCells[0].Value.ToString();
                datos.nombre = dataCliente.SelectedCells[1].Value.ToString();
                datos.segundonombre = dataCliente.SelectedCells[2].Value.ToString();
                datos.apellido = dataCliente.SelectedCells[3].Value.ToString();
                datos.cedulaidentidad = dataCliente.SelectedCells[4].Value.ToString();
                datos.cuentabancaria = dataCliente.SelectedCells[5].Value.ToString();
                datos.direccion = dataCliente.SelectedCells[6].Value.ToString();
                datos.telefono = dataCliente.SelectedCells[7].Value.ToString();
                datos.ciudad = dataCliente.SelectedCells[8].Value.ToString();
            }
            return existeDatos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool existeDatos = tomarDatos();
            if (existeDatos)
            {
                if (MessageBox.Show("¿Estás seguro que quieres eliminar al cliente " + datos.nombre + "?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conexion.eliminarCliente(datos.idCliente);
                    iniciarGrillaCliente();
                }
            }
            else
            {
                MessageBox.Show("No existe datos");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarCliente agrCliente = new agregarCliente();
            agrCliente.Show();
        }
    }

}
