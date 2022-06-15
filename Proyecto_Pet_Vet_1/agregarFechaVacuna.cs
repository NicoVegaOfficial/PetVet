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
    public partial class agregarFechaVacuna : Form
    {
        conexionsqlserver sql = new conexionsqlserver();
        string fecha;
        public agregarFechaVacuna()
        {
            InitializeComponent();
        }

        private void agregarFechaVacuna_Load(object sender, EventArgs e)
        {
            labelidsocio.Text = datos.idCliente;
            labelnombremascota.Text = datos.nombreMascota;
            labelespecie.Text = datos.especie;
            labelraza.Text = datos.raza;
            labelcolor.Text = datos.color;
            labelfechanacimiento.Text = datos.fechaNacimiento;
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            fecha = calendario_pet.SelectionRange.Start.ToString();
        }

        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
           // sql.insertarFechaVacuna(calendario_pet.SetDate);
        }
    }
}
