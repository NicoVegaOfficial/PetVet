
namespace Proyecto_Pet_Vet_1
{
    partial class InsertarAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarAnimal));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Insertar = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.DataAnimal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(204, 149);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(322, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(204, 191);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(322, 26);
            this.txtEspecie.TabIndex = 2;
            // 
            // txtRaza
            // 
            this.txtRaza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.Location = new System.Drawing.Point(204, 233);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(322, 26);
            this.txtRaza.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(204, 275);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(322, 26);
            this.txtColor.TabIndex = 4;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNacimiento.Location = new System.Drawing.Point(204, 317);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(322, 26);
            this.dateNacimiento.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(391, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Especie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label6.Location = new System.Drawing.Point(12, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // Insertar
            // 
            this.Insertar.AutoSize = true;
            this.Insertar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertar.Location = new System.Drawing.Point(303, 53);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(135, 37);
            this.Insertar.TabIndex = 7;
            this.Insertar.Text = "Insertar";
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // textCliente
            // 
            this.textCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCliente.Location = new System.Drawing.Point(204, 105);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(322, 26);
            this.textCliente.TabIndex = 1;
            // 
            // DataAnimal
            // 
            this.DataAnimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAnimal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataAnimal.Location = new System.Drawing.Point(573, 50);
            this.DataAnimal.Name = "DataAnimal";
            this.DataAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataAnimal.Size = new System.Drawing.Size(872, 467);
            this.DataAnimal.TabIndex = 8;
            this.DataAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAnimal_CellContentClick);
            // 
            // InsertarAnimal
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1457, 529);
            this.Controls.Add(this.DataAnimal);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.txtNombre);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertarAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertarAnimal";
            this.Load += new System.EventHandler(this.InsertarAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Insertar;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.DataGridView DataAnimal;
    }
}