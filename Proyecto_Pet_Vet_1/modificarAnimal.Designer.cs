
namespace Proyecto_Pet_Vet_1
{
    partial class modificarAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarAnimal));
            this.button1 = new System.Windows.Forms.Button();
            this.Modifcar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(312, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modifcar
            // 
            this.Modifcar.AutoSize = true;
            this.Modifcar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifcar.Location = new System.Drawing.Point(241, 21);
            this.Modifcar.Name = "Modifcar";
            this.Modifcar.Size = new System.Drawing.Size(162, 37);
            this.Modifcar.TabIndex = 2;
            this.Modifcar.Text = "Modificar";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // txtColor
            // 
            this.txtColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(203, 252);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(351, 26);
            this.txtColor.TabIndex = 3;
            // 
            // txtRaza
            // 
            this.txtRaza.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtRaza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.Location = new System.Drawing.Point(203, 199);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(351, 26);
            this.txtRaza.TabIndex = 2;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtEspecie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(203, 150);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(351, 26);
            this.txtEspecie.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(203, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(351, 26);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.Location = new System.Drawing.Point(120, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Especie";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.Location = new System.Drawing.Point(132, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label4.Location = new System.Drawing.Point(132, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.Location = new System.Drawing.Point(21, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // calendario
            // 
            this.calendario.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendario.Location = new System.Drawing.Point(203, 315);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(285, 20);
            this.calendario.TabIndex = 4;
            // 
            // modificarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(796, 461);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Modifcar);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "modificarAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarAnimal";
            this.Load += new System.EventHandler(this.modificarAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Modifcar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker calendario;
    }
}