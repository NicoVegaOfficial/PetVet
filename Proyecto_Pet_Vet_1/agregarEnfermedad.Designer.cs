
namespace Proyecto_Pet_Vet_1
{
    partial class agregarEnfermedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarEnfermedad));
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(31, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nombre de enfermedad";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAgregarCliente.Location = new System.Drawing.Point(211, 98);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(198, 43);
            this.btnAgregarCliente.TabIndex = 17;
            this.btnAgregarCliente.Text = "Agregar Enfermedad";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNombre.Location = new System.Drawing.Point(211, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 26);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // agregarEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 186);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregarEnfermedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarEnfermedad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.agregarEnfermedad_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.TextBox txtNombre;
    }
}