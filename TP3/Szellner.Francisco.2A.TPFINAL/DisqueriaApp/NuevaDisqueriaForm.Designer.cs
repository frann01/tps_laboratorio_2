
namespace DisqueriaApp
{
    partial class NuevaDisqueriaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAceptarNuevaDisqueria = new System.Windows.Forms.Button();
            this.btnCancelNewDisqueria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limite de Stock";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(45, 49);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(157, 23);
            this.txtCantidad.TabIndex = 1;
            // 
            // btnAceptarNuevaDisqueria
            // 
            this.btnAceptarNuevaDisqueria.Location = new System.Drawing.Point(12, 115);
            this.btnAceptarNuevaDisqueria.Name = "btnAceptarNuevaDisqueria";
            this.btnAceptarNuevaDisqueria.Size = new System.Drawing.Size(93, 36);
            this.btnAceptarNuevaDisqueria.TabIndex = 2;
            this.btnAceptarNuevaDisqueria.Text = "Aceptar";
            this.btnAceptarNuevaDisqueria.UseVisualStyleBackColor = true;
            this.btnAceptarNuevaDisqueria.Click += new System.EventHandler(this.btnAceptarNuevaDisqueria_Click);
            // 
            // btnCancelNewDisqueria
            // 
            this.btnCancelNewDisqueria.Location = new System.Drawing.Point(146, 115);
            this.btnCancelNewDisqueria.Name = "btnCancelNewDisqueria";
            this.btnCancelNewDisqueria.Size = new System.Drawing.Size(93, 36);
            this.btnCancelNewDisqueria.TabIndex = 3;
            this.btnCancelNewDisqueria.Text = "Cancelar";
            this.btnCancelNewDisqueria.UseVisualStyleBackColor = true;
            this.btnCancelNewDisqueria.Click += new System.EventHandler(this.btnCancelNewDisqueria_Click);
            // 
            // NuevaDisqueriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 165);
            this.Controls.Add(this.btnCancelNewDisqueria);
            this.Controls.Add(this.btnAceptarNuevaDisqueria);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Name = "NuevaDisqueriaForm";
            this.Text = "Nueva Disqueria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAceptarNuevaDisqueria;
        private System.Windows.Forms.Button btnCancelNewDisqueria;
    }
}