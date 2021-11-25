using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace DisqueriaApp
{
    public partial class FormPrincipal : Form
    {

        protected Tienda<Disco> disqueria;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void disqueriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaDisqueriaForm frm = new NuevaDisqueriaForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Disqueria creada exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.disqueria = frm.DisqueriaDelForm;

                FormDisqueria frmD = new FormDisqueria(this.disqueria);

                frmD.StartPosition = FormStartPosition.CenterScreen;

                frmD.MdiParent = this;

                frmD.Show();
            }
        }

        private void CargarDisqueriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Tienda<Disco> tiendaForm;
            if(ofd.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    tiendaForm = Tienda<Disco>.Leer(ofd.FileName);
                    MessageBox.Show("Disqueria creada exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormDisqueria frmD = new FormDisqueria(tiendaForm);

                    frmD.StartPosition = FormStartPosition.CenterScreen;

                    frmD.MdiParent = this;

                    frmD.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo encontrar o no existe el archivo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
