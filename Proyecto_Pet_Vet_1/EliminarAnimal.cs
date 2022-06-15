using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Pet_Vet_1
{

    public partial class EliminarAnimal : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
        conexionsqlserver conexion = new conexionsqlserver();
        public EliminarAnimal()
        {
            InitializeComponent();
        }
        private void EliminarAnimal_Load(object sender, EventArgs e)
        {
            label1.Text = "¿Estás seguro que quieres eliminar el animal " + datos.nombre + " ?";
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\Cat.Boat.png");
            this.pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

      
        private void button2_Click(object sender, EventArgs e)
        {//Botón no
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //botón sí
            conexion.eliminar(datos.idAnimal);
            this.Close();
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EliminarAnimal_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }
    }
}
