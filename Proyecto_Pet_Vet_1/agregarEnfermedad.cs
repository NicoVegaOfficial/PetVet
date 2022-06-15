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
    public partial class agregarEnfermedad : Form
    {
        public agregarEnfermedad()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            conexionsqlserver sqlenfermedad = new conexionsqlserver();
            sqlenfermedad.insertarEnfermedad(txtNombre.Text);
            this.Close();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarEnfermedad_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
