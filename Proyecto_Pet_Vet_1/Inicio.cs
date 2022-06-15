using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pet_Vet_1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Vacuna vac = new Vacuna();
            vac.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\vacuna.png");
            this.pictureBox4.Image = img;
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;

            Bitmap img2 = new Bitmap(Application.StartupPath + @"\img\veterinario.png");
            this.pictureBox6.Image = img2;
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;

            Bitmap img3 = new Bitmap(Application.StartupPath + @"\img\historiaclinica.png");
            this.pictureBox3.Image = img3;
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;

            Bitmap img4 = new Bitmap(Application.StartupPath + @"\img\animal.png");
            this.pictureBox1.Image = img4;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            Bitmap img5 = new Bitmap(Application.StartupPath + @"\img\cliente.png");
            this.pictureBox2.Image = img5;
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;

            Bitmap img6 = new Bitmap(Application.StartupPath + @"\img\virus.png");
            this.pictureBox5.Image = img6;
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 vermascota = new Form1();
            vermascota.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Veterinarios FormVer = new Veterinarios();
            FormVer.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Enfermedad enf = new Enfermedad();
            enf.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Historia_Clinica historiaCli = new Historia_Clinica();
            historiaCli.Show();
        }
    }
}
