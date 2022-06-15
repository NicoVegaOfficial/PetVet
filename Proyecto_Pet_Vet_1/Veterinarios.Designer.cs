namespace Proyecto_Pet_Vet_1
{
    partial class Veterinarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veterinarios));
            this.btnModificarVeterinario = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnResfrecar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.dataVeterinario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataVeterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarVeterinario
            // 
            this.btnModificarVeterinario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificarVeterinario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarVeterinario.Location = new System.Drawing.Point(111, 366);
            this.btnModificarVeterinario.Name = "btnModificarVeterinario";
            this.btnModificarVeterinario.Size = new System.Drawing.Size(197, 70);
            this.btnModificarVeterinario.TabIndex = 13;
            this.btnModificarVeterinario.Text = "Modificar veterinario";
            this.btnModificarVeterinario.UseVisualStyleBackColor = false;
            this.btnModificarVeterinario.Click += new System.EventHandler(this.btnModificarVeterinario_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(555, 366);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(197, 70);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar veterinario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(323, 366);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 70);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar veterinario";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnResfrecar
            // 
            this.btnResfrecar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResfrecar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnResfrecar.Location = new System.Drawing.Point(617, 14);
            this.btnResfrecar.Name = "btnResfrecar";
            this.btnResfrecar.Size = new System.Drawing.Size(135, 43);
            this.btnResfrecar.TabIndex = 12;
            this.btnResfrecar.Text = "Refrescar";
            this.btnResfrecar.UseVisualStyleBackColor = false;
            this.btnResfrecar.Click += new System.EventHandler(this.btnResfrecar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(111, 23);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(305, 26);
            this.txtConsulta.TabIndex = 10;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultas.Location = new System.Drawing.Point(441, 14);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(135, 43);
            this.btnConsultas.TabIndex = 11;
            this.btnConsultas.Text = "Consultar";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // dataVeterinario
            // 
            this.dataVeterinario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVeterinario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataVeterinario.Location = new System.Drawing.Point(12, 88);
            this.dataVeterinario.Name = "dataVeterinario";
            this.dataVeterinario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVeterinario.Size = new System.Drawing.Size(776, 255);
            this.dataVeterinario.TabIndex = 9;
            this.dataVeterinario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataVeterinario_CellContentClick);
            // 
            // Veterinarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificarVeterinario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnResfrecar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.dataVeterinario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Veterinarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinario";
            this.Load += new System.EventHandler(this.Veterinarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVeterinario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarVeterinario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnResfrecar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.DataGridView dataVeterinario;
    }
}