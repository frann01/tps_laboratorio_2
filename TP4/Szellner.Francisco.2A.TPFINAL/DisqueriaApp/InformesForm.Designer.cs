
namespace DisqueriaApp
{
    partial class InformesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.cboCriterio1 = new System.Windows.Forms.ComboBox();
            this.cboCriterio2 = new System.Windows.Forms.ComboBox();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cbo1Btn2 = new System.Windows.Forms.ComboBox();
            this.cbo2crit2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Consulta2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "mas comprado entre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(553, 37);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(86, 24);
            this.btn_Aceptar.TabIndex = 10;
            this.btn_Aceptar.Text = "Consultar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // cboCriterio1
            // 
            this.cboCriterio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio1.FormattingEnabled = true;
            this.cboCriterio1.Items.AddRange(new object[] {
            "Genero",
            "Tipo de disco",
            "Decada"});
            this.cboCriterio1.Location = new System.Drawing.Point(111, 38);
            this.cboCriterio1.Name = "cboCriterio1";
            this.cboCriterio1.Size = new System.Drawing.Size(149, 23);
            this.cboCriterio1.TabIndex = 11;
            // 
            // cboCriterio2
            // 
            this.cboCriterio2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio2.FormattingEnabled = true;
            this.cboCriterio2.Items.AddRange(new object[] {
            "Todos",
            "Hombres",
            "Mujeres",
            "No binarios",
            "Menores de 30",
            "Mayores de 30"});
            this.cboCriterio2.Location = new System.Drawing.Point(389, 37);
            this.cboCriterio2.Name = "cboCriterio2";
            this.cboCriterio2.Size = new System.Drawing.Size(158, 23);
            this.cboCriterio2.TabIndex = 12;
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.ItemHeight = 15;
            this.lstVentas.Location = new System.Drawing.Point(12, 158);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(736, 289);
            this.lstVentas.TabIndex = 13;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 123);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(97, 32);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "";
            // 
            // cbo1Btn2
            // 
            this.cbo1Btn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1Btn2.FormattingEnabled = true;
            this.cbo1Btn2.Items.AddRange(new object[] {
            "Sexo",
            "Rango Etario"});
            this.cbo1Btn2.Location = new System.Drawing.Point(111, 69);
            this.cbo1Btn2.Name = "cbo1Btn2";
            this.cbo1Btn2.Size = new System.Drawing.Size(149, 23);
            this.cbo1Btn2.TabIndex = 15;
            // 
            // cbo2crit2
            // 
            this.cbo2crit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo2crit2.FormattingEnabled = true;
            this.cbo2crit2.Items.AddRange(new object[] {
            "Todos",
            "Rock",
            "Jazz",
            "Pop",
            "Experimental"});
            this.cbo2crit2.Location = new System.Drawing.Point(389, 66);
            this.cbo2crit2.Name = "cbo2crit2";
            this.cbo2crit2.Size = new System.Drawing.Size(158, 23);
            this.cbo2crit2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "que mas compra";
            // 
            // btn_Consulta2
            // 
            this.btn_Consulta2.Location = new System.Drawing.Point(553, 65);
            this.btn_Consulta2.Name = "btn_Consulta2";
            this.btn_Consulta2.Size = new System.Drawing.Size(86, 24);
            this.btn_Consulta2.TabIndex = 18;
            this.btn_Consulta2.Text = "Consultar";
            this.btn_Consulta2.UseVisualStyleBackColor = true;
            this.btn_Consulta2.Click += new System.EventHandler(this.btn_Consulta2_Click);
            // 
            // InformesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 459);
            this.Controls.Add(this.btn_Consulta2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo2crit2);
            this.Controls.Add(this.cbo1Btn2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.cboCriterio2);
            this.Controls.Add(this.cboCriterio1);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InformesForm";
            this.Text = "Informes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.ComboBox cboCriterio1;
        private System.Windows.Forms.ComboBox cboCriterio2;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cbo1Btn2;
        private System.Windows.Forms.ComboBox cbo2crit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Consulta2;
    }
}