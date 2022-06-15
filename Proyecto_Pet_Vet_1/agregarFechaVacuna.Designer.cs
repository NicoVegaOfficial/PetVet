namespace Proyecto_Pet_Vet_1
{
    partial class agregarFechaVacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarFechaVacuna));
            this.calendario_pet = new System.Windows.Forms.MonthCalendar();
            this.labelidsocio = new System.Windows.Forms.Label();
            this.labelnombremascota = new System.Windows.Forms.Label();
            this.labelespecie = new System.Windows.Forms.Label();
            this.labelraza = new System.Windows.Forms.Label();
            this.labelcolor = new System.Windows.Forms.Label();
            this.labelfechanacimiento = new System.Windows.Forms.Label();
            this.btnAgregarFecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calendario_pet
            // 
            this.calendario_pet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calendario_pet.Location = new System.Drawing.Point(647, 18);
            this.calendario_pet.Name = "calendario_pet";
            this.calendario_pet.TabIndex = 0;
            this.calendario_pet.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // labelidsocio
            // 
            this.labelidsocio.AutoSize = true;
            this.labelidsocio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidsocio.Location = new System.Drawing.Point(273, 53);
            this.labelidsocio.Name = "labelidsocio";
            this.labelidsocio.Size = new System.Drawing.Size(65, 18);
            this.labelidsocio.TabIndex = 1;
            this.labelidsocio.Text = "Id Socio";
            // 
            // labelnombremascota
            // 
            this.labelnombremascota.AutoSize = true;
            this.labelnombremascota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombremascota.Location = new System.Drawing.Point(273, 94);
            this.labelnombremascota.Name = "labelnombremascota";
            this.labelnombremascota.Size = new System.Drawing.Size(166, 18);
            this.labelnombremascota.TabIndex = 1;
            this.labelnombremascota.Text = "Nombre de la mascota";
            // 
            // labelespecie
            // 
            this.labelespecie.AutoSize = true;
            this.labelespecie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelespecie.Location = new System.Drawing.Point(273, 142);
            this.labelespecie.Name = "labelespecie";
            this.labelespecie.Size = new System.Drawing.Size(66, 18);
            this.labelespecie.TabIndex = 1;
            this.labelespecie.Text = "Especie";
            // 
            // labelraza
            // 
            this.labelraza.AutoSize = true;
            this.labelraza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelraza.Location = new System.Drawing.Point(273, 185);
            this.labelraza.Name = "labelraza";
            this.labelraza.Size = new System.Drawing.Size(44, 18);
            this.labelraza.TabIndex = 1;
            this.labelraza.Text = "Raza";
            // 
            // labelcolor
            // 
            this.labelcolor.AutoSize = true;
            this.labelcolor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcolor.Location = new System.Drawing.Point(273, 224);
            this.labelcolor.Name = "labelcolor";
            this.labelcolor.Size = new System.Drawing.Size(46, 18);
            this.labelcolor.TabIndex = 1;
            this.labelcolor.Text = "Color";
            // 
            // labelfechanacimiento
            // 
            this.labelfechanacimiento.AutoSize = true;
            this.labelfechanacimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfechanacimiento.Location = new System.Drawing.Point(273, 278);
            this.labelfechanacimiento.Name = "labelfechanacimiento";
            this.labelfechanacimiento.Size = new System.Drawing.Size(154, 18);
            this.labelfechanacimiento.TabIndex = 1;
            this.labelfechanacimiento.Text = "Fecha de nacimiento";
            // 
            // btnAgregarFecha
            // 
            this.btnAgregarFecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFecha.Location = new System.Drawing.Point(375, 339);
            this.btnAgregarFecha.Name = "btnAgregarFecha";
            this.btnAgregarFecha.Size = new System.Drawing.Size(151, 55);
            this.btnAgregarFecha.TabIndex = 2;
            this.btnAgregarFecha.Text = "Agregar fecha";
            this.btnAgregarFecha.UseVisualStyleBackColor = true;
            this.btnAgregarFecha.Click += new System.EventHandler(this.btnAgregarFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Socio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la mascota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Especie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Raza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // agregarFechaVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 406);
            this.Controls.Add(this.btnAgregarFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelfechanacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelcolor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelraza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelespecie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnombremascota);
            this.Controls.Add(this.labelidsocio);
            this.Controls.Add(this.calendario_pet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregarFechaVacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarFechaVacuna";
            this.Load += new System.EventHandler(this.agregarFechaVacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendario_pet;
        private System.Windows.Forms.Label labelidsocio;
        private System.Windows.Forms.Label labelnombremascota;
        private System.Windows.Forms.Label labelespecie;
        private System.Windows.Forms.Label labelraza;
        private System.Windows.Forms.Label labelcolor;
        private System.Windows.Forms.Label labelfechanacimiento;
        private System.Windows.Forms.Button btnAgregarFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}