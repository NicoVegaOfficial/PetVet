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
    public partial class agregarCliente : Form
    {
        conexionsqlserver sql = new conexionsqlserver();
        public agregarCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
        //idCliente nombre segundonombre apellido cedulaidentidad cuentabancaria direccion telefono ciudad
            sql.insertarCliente(txtNombre.Text, txtSegundoNombre.Text, txtApellido.Text, txtCedulaIdentidad.Text, txtCuentaBancaria.Text, txtDireccion.Text, txtTelefono.Text, txtCiudad.Text);
        }
    }
}
