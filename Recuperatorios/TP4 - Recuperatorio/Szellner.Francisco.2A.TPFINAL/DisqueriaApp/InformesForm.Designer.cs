
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.lstVentas.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.lblResultado.Size = new System.Drawing.Size(108, 32);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Informes";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "- Se vendieron ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "- Las personas que mas compran son ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(770, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "- Los generos que vendieron menor cantidad son";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(124, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(17, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(17, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(9, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "- El porcentaje de vinilos vendidos es";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(16, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "label12";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(754, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 435);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(17, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(9, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(305, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "- El precio promedio de un Disco vendido es";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(17, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(9, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(341, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "- El porcentaje hombres, mujeres y No binarios es ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // InformesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
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
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "InformesForm";
            this.Text = "Informes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}