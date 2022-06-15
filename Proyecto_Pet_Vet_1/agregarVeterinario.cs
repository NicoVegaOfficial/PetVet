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
    public partial class agregarVeterinario : Form
    {
        conexionsqlserver sql = new conexionsqlserver();
        public agregarVeterinario()
        {

            InitializeComponent();

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            sql.insertarVeterinario(txtNombre.Text, txtApellido.Text);
            this.Close();
        }

        private void agregarVeterinario_Load(object sender, EventArgs e)
        {

        }
    }
}
