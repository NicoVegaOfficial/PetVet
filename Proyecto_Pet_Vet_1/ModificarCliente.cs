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
    public partial class ModificarCliente : Form
    {
        conexionsqlserver sql = new conexionsqlserver();
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {//idCliente nombre segundonombre apellido cedulaidentidad cuentabancaria direccion telefono ciudad
            {
                if (datos.nombre != null)
                {
                    labelSocio.Text = datos.idCliente;
                    txtNombre.Text = datos.nombre;
                    txtSegundoNombre.Text = datos.segundonombre;
                    txtApellido.Text = datos.apellido;
                    txtCedulaIdentidad.Text = datos.cedulaidentidad;
                    txtCuentaBancaria.Text = datos.cuentabancaria;
                    txtDireccion.Text = datos.direccion;
                    txtTelefono.Text = datos.telefono;
                    txtCiudad.Text = datos.ciudad;
                }
                else
                {
                    MessageBox.Show("No se selecciono ninguna mascota");
                    Form1 Form = new Form1();
                    Form.Show();
                    this.Close();
                }
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            sql.modificarCliente(labelSocio.Text, txtNombre.Text, txtSegundoNombre.Text, txtApellido.Text, txtCedulaIdentidad.Text, txtCuentaBancaria.Text, txtDireccion.Text, txtTelefono.Text, txtCiudad.Text);
        }
    }
}
