
namespace DisqueriaApp
{
    partial class FormVinilo
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
            this.cboCondicionVinilo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condicion";
            // 
            // cboCondicionVinilo
            // 
            this.cboCondicionVinilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicionVinilo.FormattingEnabled = true;
            this.cboCondicionVinilo.Location = new System.Drawing.Point(23, 297);
            this.cboCondicionVinilo.Name = "cboCondicionVinilo";
            this.cboCondicionVinilo.Size = new System.Drawing.Size(236, 23);
            this.cboCondicionVinilo.TabIndex = 1;
            // 
            // FormVinilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 407);
            this.Controls.Add(this.cboCondicionVinilo);
            this.Controls.Add(this.label1);
            this.Name = "FormVinilo";
            this.Text = "Nuevo Vinilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCondicionVinilo;
    }
}