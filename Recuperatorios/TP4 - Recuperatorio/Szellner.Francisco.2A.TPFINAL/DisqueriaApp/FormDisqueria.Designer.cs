
namespace DisqueriaApp
{
    partial class FormDisqueria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisqueria));
            this.lstStock = new System.Windows.Forms.ListBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_informes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.btn_NuevoDisco = new System.Windows.Forms.Button();
            this.lstVendidos = new System.Windows.Forms.ListBox();
            this.btn_Vender = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brn_Eliminar_Disco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstStock
            // 
            this.lstStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstStock.FormattingEnabled = true;
            this.lstStock.ItemHeight = 15;
            this.lstStock.Location = new System.Drawing.Point(6, 36);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(795, 259);
            this.lstStock.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Guardar.Location = new System.Drawing.Point(821, 186);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(179, 47);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar Stock ";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_informes
            // 
            this.btn_informes.BackColor = System.Drawing.Color.LightBlue;
            this.btn_informes.Location = new System.Drawing.Point(820, 239);
            this.btn_informes.Name = "btn_informes";
            this.btn_informes.Size = new System.Drawing.Size(180, 50);
            this.btn_informes.TabIndex = 2;
            this.btn_informes.Text = "Informes";
            this.btn_informes.UseVisualStyleBackColor = false;
            this.btn_informes.Click += new System.EventHandler(this.btn_informes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(837, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(821, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ganancia";
            // 
            // txtGanancia
            // 
            this.txtGanancia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGanancia.Location = new System.Drawing.Point(821, 349);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.ReadOnly = true;
            this.txtGanancia.Size = new System.Drawing.Size(178, 39);
            this.txtGanancia.TabIndex = 5;
            // 
            // btn_NuevoDisco
            // 
            this.btn_NuevoDisco.BackColor = System.Drawing.Color.LightBlue;
            this.btn_NuevoDisco.Location = new System.Drawing.Point(819, 394);
            this.btn_NuevoDisco.Name = "btn_NuevoDisco";
            this.btn_NuevoDisco.Size = new System.Drawing.Size(180, 42);
            this.btn_NuevoDisco.TabIndex = 6;
            this.btn_NuevoDisco.Text = "Nuevo Disco";
            this.btn_NuevoDisco.UseVisualStyleBackColor = false;
            this.btn_NuevoDisco.Click += new System.EventHandler(this.btn_NuevoVinilo_Click);
            // 
            // lstVendidos
            // 
            this.lstVendidos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstVendidos.FormattingEnabled = true;
            this.lstVendidos.ItemHeight = 15;
            this.lstVendidos.Location = new System.Drawing.Point(6, 325);
            this.lstVendidos.Name = "lstVendidos";
            this.lstVendidos.Size = new System.Drawing.Size(795, 244);
            this.lstVendidos.TabIndex = 7;
            // 
            // btn_Vender
            // 
            this.btn_Vender.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Vender.Location = new System.Drawing.Point(819, 490);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(180, 43);
            this.btn_Vender.TabIndex = 9;
            this.btn_Vender.Text = "Vender Disco";
            this.btn_Vender.UseVisualStyleBackColor = false;
            this.btn_Vender.Click += new System.EventHandler(this.btn_Vender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vendidos";
            // 
            // brn_Eliminar_Disco
            // 
            this.brn_Eliminar_Disco.BackColor = System.Drawing.Color.LightBlue;
            this.brn_Eliminar_Disco.Location = new System.Drawing.Point(821, 442);
            this.brn_Eliminar_Disco.Name = "brn_Eliminar_Disco";
            this.brn_Eliminar_Disco.Size = new System.Drawing.Size(180, 42);
            this.brn_Eliminar_Disco.TabIndex = 13;
            this.brn_Eliminar_Disco.Text = "Eliminar Disco";
            this.brn_Eliminar_Disco.UseVisualStyleBackColor = false;
            this.brn_Eliminar_Disco.Click += new System.EventHandler(this.brn_Eliminar_Disco_Click);
            // 
            // FormDisqueria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1012, 579);
            this.Controls.Add(this.brn_Eliminar_Disco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Vender);
            this.Controls.Add(this.lstVendidos);
            this.Controls.Add(this.btn_NuevoDisco);
            this.Controls.Add(this.txtGanancia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_informes);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lstStock);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDisqueria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disqueria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDisqueria_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_informes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Button btn_NuevoDisco;
        private System.Windows.Forms.ListBox lstVendidos;
        private System.Windows.Forms.Button btn_Vender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button brn_Eliminar_Disco;
    }
}