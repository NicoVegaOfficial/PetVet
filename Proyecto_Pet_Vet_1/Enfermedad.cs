using System;
using System.Data.SqlClient;
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
    public partial class Enfermedad : Form
    {
        conexionsqlserver conexion = new conexionsqlserver();
        private Button button2;
        private DataGridView dataEnfermedad;
        private TextBox txtConsulta;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnConsultas;
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
        public Enfermedad()
        {
            InitializeComponent();
            iniciarGrillaEnfermedad();
        }

        private void Enfermedad_Load(object sender, EventArgs e)
        {
            iniciarGrillaEnfermedad();
        }
        private void iniciarGrillaEnfermedad()
        {
            conexion.abrir();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Enfermedad";
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataEnfermedad.DataSource = dt;
                this.dataEnfermedad.Columns["IdEnfermedad"].Visible = false;
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

        }
        private void consultas(string consultax)
        {
            string x = "%" + consultax + "%";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select IdEnfermedad, Nombre from Enfermedad where IdEnfermedad like @termino or Nombre like @termino";
                cmd.Parameters.AddWithValue("@termino", x);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                dataEnfermedad.DataSource = dt;
                this.dataEnfermedad.Columns["IdEnfermedad"].Visible = false;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private bool tomarDatos()
        {
            bool existeDatos = false;

            DataGridViewRowCollection filas = dataEnfermedad.Rows;
            if (filas.Count > 0)
            {
                existeDatos = true;
                datos.idEnfermedad = dataEnfermedad.SelectedCells[0].Value.ToString();
                datos.nombreEnfermedad = dataEnfermedad.SelectedCells[1].Value.ToString();
            }
            return existeDatos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           


        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataEnfermedad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Enfermedad_Load_1(object sender, EventArgs e)
        {
            iniciarGrillaEnfermedad();
        }

        private void btnConsultas_Click_1(object sender, EventArgs e)
        {
            consultas(txtConsulta.Text);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            bool existeDatos = tomarDatos();
            if (existeDatos)
            {
                if (MessageBox.Show("¿Estás seguro que quieres eliminar la enfermedad " + datos.nombreEnfermedad + "?", "Eliminar enfermedad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conexion.eliminarEnfermedad(datos.idEnfermedad);
                    iniciarGrillaEnfermedad();
                }
            }
            else
            {
                MessageBox.Show("No existe datos");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            iniciarGrillaEnfermedad();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            agregarEnfermedad agrenf = new agregarEnfermedad();
            agrenf.Show();
        }

        private void dataEnfermedad_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enfermedad));
            this.button2 = new System.Windows.Forms.Button();
            this.dataEnfermedad = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnfermedad)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(540, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataEnfermedad
            // 
            this.dataEnfermedad.AllowUserToAddRows = false;
            this.dataEnfermedad.AllowUserToDeleteRows = false;
            this.dataEnfermedad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEnfermedad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEnfermedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEnfermedad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataEnfermedad.Location = new System.Drawing.Point(34, 114);
            this.dataEnfermedad.Name = "dataEnfermedad";
            this.dataEnfermedad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEnfermedad.Size = new System.Drawing.Size(787, 255);
            this.dataEnfermedad.TabIndex = 13;
            this.dataEnfermedad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEnfermedad_CellContentClick_1);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(34, 28);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(305, 26);
            this.txtConsulta.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(540, 375);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 70);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Ingresar enfermedad";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(332, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 70);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar enfermedad";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultas.Location = new System.Drawing.Point(364, 19);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(135, 43);
            this.btnConsultas.TabIndex = 8;
            this.btnConsultas.Text = "Consultar";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click_1);
            // 
            // Enfermedad
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataEnfermedad);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Enfermedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enfermedad";
            this.Load += new System.EventHandler(this.Enfermedad_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataEnfermedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
