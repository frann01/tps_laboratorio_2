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
    public partial class InformesForm : Form
    {
        private Tienda<Disco> disqueriaDelForm;
        public InformesForm()
        {
            InitializeComponent();
            
        }

        public InformesForm(Tienda<Disco> disqueria):this()
        {
            this.disqueriaDelForm = disqueria;
            obtenerGeneroMasComprado();
            obtenerSexoQueMasCompra();
            RangoEtario();
            ObtenerTipoDisco();
            this.lblCantDiscos.Text = this.disqueriaDelForm.VentasListado.Count + " discos en total";
        }

        #region Funciones Informes
        private void ObtenerTipoDisco()
        {
            List<Venta> vCd = this.disqueriaDelForm.VentasListado.FindAll(EsCD);
            List<Venta> vVinilo = this.disqueriaDelForm.VentasListado.FindAll(EsVinilo);

            int cantCD = vCd.Count;
            int cantVinilo = vVinilo.Count;

            if (cantCD == cantVinilo)
            {
                this.label5.Text = "Se vendio la misma cantidad de CDs y Vinilos";
                this.lblTipoDisco.Text = "";
            }
            else
            {
                if(cantCD < cantVinilo) 
                {
                    this.lblTipoDisco.Text = "Vinilos";
                }
                else 
                {
                    this.lblTipoDisco.Text = "CDs";
                }
            }
        }
        private void obtenerGeneroMasComprado() 
        {
            string mostrarMayor = "";
            string mostrarMenor = "";
            List<Venta> vJazz = this.disqueriaDelForm.VentasListado.FindAll(esDeJazz); 
            List<Venta> vRock = this.disqueriaDelForm.VentasListado.FindAll(esDeRock);
            List<Venta> vPop = this.disqueriaDelForm.VentasListado.FindAll(esDePop);
            List<Venta> vExperimental = this.disqueriaDelForm.VentasListado.FindAll(esDeExperimental);

            List<int> cantidades = new List<int>() { vRock.Count, vJazz.Count, vPop.Count, vExperimental.Count };

            int mayor = cantidades.Max();
            int minimo = cantidades.Min();
            if(vRock.Count == vJazz.Count && vRock.Count == vPop.Count && vRock.Count == vExperimental.Count) 
            {
                this.label1.Text = "- Se vendio la misma cantidad de todos los generos";
                this.lbl_GeneroMasComprado.Text = "";
                this.label6.Text = "";
                this.lblMenorGenero.Text = "";
            }
            else 
            {
                if (vRock.Count == mayor)
                {
                    mostrarMayor += "Rock ";
                }
                else
                {
                    if (vRock.Count == minimo)
                    {
                        mostrarMenor += "Rock ";
                    }
                }

                if (vJazz.Count == mayor)
                {
                    mostrarMayor += "Jazz ";
                }
                else
                {
                    if (vJazz.Count == minimo)
                    {
                        mostrarMenor += "Jazz ";
                    }
                }

                if (vPop.Count == mayor)
                {
                    mostrarMayor += "Pop ";
                }
                else
                {
                    if (vPop.Count == minimo)
                    {
                        mostrarMenor += "Pop ";
                    }
                }

                if (vExperimental.Count == mayor)
                {
                    mostrarMayor += "Experimental ";
                }
                else
                {
                    if (vExperimental.Count == minimo)
                    {
                        mostrarMenor += "Experimental ";
                    }
                }

                this.lbl_GeneroMasComprado.Text = mostrarMayor + "con " + mayor + " discos";
                this.lblMenorGenero.Text = mostrarMenor + "con " + minimo + " discos";
            }
            
        }

        private void RangoEtario()
        {
            List<Venta> MAYOR30 = this.disqueriaDelForm.VentasListado.FindAll(esMayorde30);
            List<Venta> MENOR30 = this.disqueriaDelForm.VentasListado.FindAll(  esMenorDe30);


            int cant30plus = MAYOR30.Count;
            int cant30minus = MENOR30.Count;


            if (cant30minus > cant30plus)
            {
                this.lblEdad.Text = "menores de 30 años";
            }
            else
            {
                this.lblEdad.Text = "mayores de 30 años";
            }
        }

        private void obtenerSexoQueMasCompra()
        {

            string mostrar = "";
            List<Venta> vHombre = this.disqueriaDelForm.VentasListado.FindAll(esHombre);
            List<Venta> vMujer = this.disqueriaDelForm.VentasListado.FindAll(esMujer);
            List<Venta> vBinario = this.disqueriaDelForm.VentasListado.FindAll(esBinario);

            List<int> cantidades = new List<int>() { vHombre.Count, vMujer.Count, vBinario.Count };

            int mayor = cantidades.Max();


            if (vHombre.Count == mayor)
            {
                mostrar += "Hombres ";
            }
            if (vMujer.Count == mayor)
            {
                mostrar += "Mujeres ";
            }
            if (vBinario.Count == mayor)
            {
                mostrar += "No Binarios ";
            }

            this.lblSexo.Text = mostrar;
        }

        #endregion

        #region Funciones filtro

        private static bool esMenorDe30(Venta v)
        {
            return v.Cliente.Edad <30;
        }

        private static bool esMayorde30(Venta v)
        {
            return v.Cliente.Edad > 30;
        }

        private static bool esDeJazz(Venta v) 
        {
            return v.DiscoVendido.Genero == EGenero.Jazz;
        }

        private static bool esDeRock(Venta v)
        {
            return v.DiscoVendido.Genero == EGenero.Rock;
        }

        private static bool esDePop(Venta v)
        {
            return v.DiscoVendido.Genero == EGenero.Pop;
        }

        private static bool esDeExperimental(Venta v)
        {
            return v.DiscoVendido.Genero == EGenero.Experimental;
        }

        private static bool esHombre(Venta v)
        {
            return v.Cliente.Sexo == ESexo.Hombre;
        }

        private static bool esMujer(Venta v)
        {
            return v.Cliente.Sexo == ESexo.Mujer;
        }

        private static bool esBinario(Venta v)
        {
            return v.Cliente.Sexo == ESexo.NoBinario;
        }

        private static bool EsCD(Venta v)
        {
            return v.DiscoVendido is CD;
        }

        private static bool EsVinilo(Venta v)
        {
            return v.DiscoVendido is Vinilo;
        }

        #endregion 

        private void InformesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
