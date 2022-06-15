namespace Proyecto_Pet_Vet_1
{
    partial class registrarHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrarHistorial));
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarHC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.labelEnfermedad = new System.Windows.Forms.Label();
            this.dataEnfermedades = new System.Windows.Forms.DataGridView();
            this.labelNombreVeterinario = new System.Windows.Forms.Label();
            this.labelApellidoVeterinario = new System.Windows.Forms.Label();
            this.dataVeterinario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnfermedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVeterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(604, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nº de H.C.";
            // 
            // btnAgregarHC
            // 
            this.btnAgregarHC.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAgregarHC.Location = new System.Drawing.Point(816, 510);
            this.btnAgregarHC.Name = "btnAgregarHC";
            this.btnAgregarHC.Size = new System.Drawing.Size(144, 62);
            this.btnAgregarHC.TabIndex = 17;
            this.btnAgregarHC.Text = "Ingresar Registro";
            this.btnAgregarHC.UseVisualStyleBackColor = true;
            this.btnAgregarHC.Click += new System.EventHandler(this.btnAgregarHC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(604, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha de enfermedad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(604, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Enfermedad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(604, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Apellido Veterinario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(604, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nombre Veterinario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.Location = new System.Drawing.Point(824, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "label9";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(807, 140);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 33;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // labelEnfermedad
            // 
            this.labelEnfermedad.AutoSize = true;
            this.labelEnfermedad.Font = new System.Drawing.Font("Arial", 12F);
            this.labelEnfermedad.Location = new System.Drawing.Point(824, 92);
            this.labelEnfermedad.Name = "labelEnfermedad";
            this.labelEnfermedad.Size = new System.Drawing.Size(50, 18);
            this.labelEnfermedad.TabIndex = 34;
            this.labelEnfermedad.Text = "label1";
            // 
            // dataEnfermedades
            // 
            this.dataEnfermedades.AllowUserToAddRows = false;
            this.dataEnfermedades.AllowUserToDeleteRows = false;
            this.dataEnfermedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEnfermedades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataEnfermedades.Location = new System.Drawing.Point(12, 26);
            this.dataEnfermedades.Name = "dataEnfermedades";
            this.dataEnfermedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEnfermedades.Size = new System.Drawing.Size(290, 545);
            this.dataEnfermedades.TabIndex = 35;
            this.dataEnfermedades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEnfermedades_CellContentClick);
            // 
            // labelNombreVeterinario
            // 
            this.labelNombreVeterinario.AutoSize = true;
            this.labelNombreVeterinario.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNombreVeterinario.Location = new System.Drawing.Point(824, 331);
            this.labelNombreVeterinario.Name = "labelNombreVeterinario";
            this.labelNombreVeterinario.Size = new System.Drawing.Size(50, 18);
            this.labelNombreVeterinario.TabIndex = 36;
            this.labelNombreVeterinario.Text = "label1";
            // 
            // labelApellidoVeterinario
            // 
            this.labelApellidoVeterinario.AutoSize = true;
            this.labelApellidoVeterinario.Font = new System.Drawing.Font("Arial", 12F);
            this.labelApellidoVeterinario.Location = new System.Drawing.Point(824, 382);
            this.labelApellidoVeterinario.Name = "labelApellidoVeterinario";
            this.labelApellidoVeterinario.Size = new System.Drawing.Size(50, 18);
            this.labelApellidoVeterinario.TabIndex = 37;
            this.labelApellidoVeterinario.Text = "label2";
            // 
            // dataVeterinario
            // 
            this.dataVeterinario.AllowUserToAddRows = false;
            this.dataVeterinario.AllowUserToDeleteRows = false;
            this.dataVeterinario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVeterinario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataVeterinario.Location = new System.Drawing.Point(308, 26);
            this.dataVeterinario.Name = "dataVeterinario";
            this.dataVeterinario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVeterinario.Size = new System.Drawing.Size(290, 545);
            this.dataVeterinario.TabIndex = 35;
            this.dataVeterinario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataVeterinario_CellContentClick);
            // 
            // registrarHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 584);
            this.Controls.Add(this.labelApellidoVeterinario);
            this.Controls.Add(this.labelNombreVeterinario);
            this.Controls.Add(this.dataVeterinario);
            this.Controls.Add(this.dataEnfermedades);
            this.Controls.Add(this.labelEnfermedad);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAgregarHC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registrarHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrarHistorial";
            this.Load += new System.EventHandler(this.registrarHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEnfermedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVeterinario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarHC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label labelEnfermedad;
        private System.Windows.Forms.DataGridView dataEnfermedades;
        private System.Windows.Forms.Label labelNombreVeterinario;
        private System.Windows.Forms.Label labelApellidoVeterinario;
        private System.Windows.Forms.DataGridView dataVeterinario;
    }
}