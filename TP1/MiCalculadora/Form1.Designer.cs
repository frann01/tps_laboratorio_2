
namespace MiCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBoxOperando = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convertir a binario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonBin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Convertir a Decimal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Operar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(370, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cerrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // comboBoxOperando
            // 
            this.comboBoxOperando.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOperando.FormattingEnabled = true;
            this.comboBoxOperando.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperando.Location = new System.Drawing.Point(208, 64);
            this.comboBoxOperando.Name = "comboBoxOperando";
            this.comboBoxOperando.Size = new System.Drawing.Size(121, 45);
            this.comboBoxOperando.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(514, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 274);
            this.listBox1.TabIndex = 6;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNum2.Location = new System.Drawing.Point(370, 64);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(138, 43);
            this.textBoxNum2.TabIndex = 7;
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNum1.Location = new System.Drawing.Point(12, 64);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(149, 43);
            this.textBoxNum1.TabIndex = 8;
            this.textBoxNum1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 300);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxOperando);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Francisco Szellner division 2do A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBoxOperando;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxNum1;
    }
}

