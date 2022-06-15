using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Pet_Vet_1
{
    public partial class modificarAnimal : Form
    {
        string calendariox;
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
        conexionsqlserver conexion = new conexionsqlserver();
        public modificarAnimal()
        {
            InitializeComponent();
        }

        private void modificarAnimal_Load(object sender, EventArgs e)
        { if (datos.nombre != null)
            {
                txtNombre.Text = datos.nombre;
                txtEspecie.Text = datos.especie;
                txtRaza.Text = datos.raza;
                txtColor.Text = datos.color;
                DateTime nuevafecha = DateTime.Parse(datos.fechaNacimiento);
                calendario.Value = nuevafecha;
            }
        else { MessageBox.Show("No se selecciono ninguna mascota");
                Form1 Form = new Form1();
                Form.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calendariox = calendario.Value.ToString();
            //(string nombre, string especie, string raza, string color, string fechaNacimiento, string idAnimal)
            conexion.modificar(txtNombre.Text, txtEspecie.Text, txtRaza.Text, txtColor.Text, calendariox, datos.idAnimal);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
