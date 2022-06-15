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
    public partial class modificarVeterinario : Form
    {
        conexionsqlserver sql = new conexionsqlserver();
        public modificarVeterinario()
        {
            InitializeComponent();
        }

        private void modificarVeterinario_Load(object sender, EventArgs e)
        {
            label2.Text = datos.idVeterinario;
            txtNombre.Text = datos.nombre;
            txtApellido.Text = datos.apellido;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            sql.modificarVeterinario(datos.idVeterinario, txtNombre.Text, txtApellido.Text);
            this.Close();
        }
    }
}
