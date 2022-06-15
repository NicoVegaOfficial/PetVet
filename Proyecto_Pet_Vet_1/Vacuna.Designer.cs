
namespace Proyecto_Pet_Vet_1
{
    partial class Vacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacuna));
            this.button2 = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.dataMascotas = new System.Windows.Forms.DataGridView();
            this.dataVacunas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(985, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(24, 21);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(694, 26);
            this.txtConsulta.TabIndex = 10;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultas.Location = new System.Drawing.Point(809, 12);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(135, 43);
            this.btnConsultas.TabIndex = 11;
            this.btnConsultas.Text = "Consultar";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // dataMascotas
            // 
            this.dataMascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMascotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMascotas.Location = new System.Drawing.Point(24, 82);
            this.dataMascotas.Name = "dataMascotas";
            this.dataMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMascotas.Size = new System.Drawing.Size(694, 500);
            this.dataMascotas.TabIndex = 9;
            this.dataMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMascotas_CellContentClick);
            // 
            // dataVacunas
            // 
            this.dataVacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVacunas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataVacunas.Location = new System.Drawing.Point(806, 82);
            this.dataVacunas.Name = "dataVacunas";
            this.dataVacunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVacunas.Size = new System.Drawing.Size(314, 500);
            this.dataVacunas.TabIndex = 13;
            this.dataVacunas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataVacunas_CellContentClick);
            // 
            // Vacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 629);
            this.Controls.Add(this.dataVacunas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.dataMascotas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacuna";
            this.Load += new System.EventHandler(this.Vacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVacunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.DataGridView dataMascotas;
        private System.Windows.Forms.DataGridView dataVacunas;
    }
}