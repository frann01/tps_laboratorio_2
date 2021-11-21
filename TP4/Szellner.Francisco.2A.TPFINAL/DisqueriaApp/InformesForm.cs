using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace DisqueriaApp
{
    public partial class InformesForm : Form
    {
        private List<Venta> VentasDelForm;
        public static SqlConnection conexion;
        public static SqlCommand comando;


        public InformesForm()
        {
            InitializeComponent();

            conexion = new SqlConnection(@"Server=localhost;Database=Disqueria;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        #region Funciones Generales
        public List<Venta> ObtenerLista(string query)
        {
            List<Venta> ventas = new List<Venta>();

            try
            {
                comando.CommandText = query;

                conexion.Open();
                SqlDataReader sqlReader = comando.ExecuteReader();

                while (sqlReader.Read())
                {
                    int id = Convert.ToInt32(sqlReader["id"]);
                    string nombre_disco = sqlReader["NOMBRE_DISCO"].ToString();
                    ETipoDisco tipo_disco = (ETipoDisco)Enum.Parse(typeof(ETipoDisco), sqlReader["TIPO_DISCO"].ToString(), true);
                    EGenero genero_disco = (EGenero)Enum.Parse(typeof(EGenero), sqlReader["GENERO_DISCO"].ToString(), true);
                    string nombre_artista = sqlReader["NOMBRE_ARTISTA"].ToString();
                    int año_disco = Convert.ToInt32(sqlReader["AÑO_DISCO"]);
                    float precio_disco = Convert.ToSingle(sqlReader["PRECIO_DISCO"]);
                    string nombre_cliente = sqlReader["NOMBRE_CLIENTE"].ToString();
                    ESexo sexo_cliente = (ESexo)Enum.Parse(typeof(ESexo), sqlReader["SEXO_CLIENTE"].ToString(), true);
                    int edad_cliente = Convert.ToInt32(sqlReader["EDAD_CLIENTE"]);
                    ETipoArtista tipo_artista = (ETipoArtista)Enum.Parse(typeof(ETipoArtista), sqlReader["TIPO_ARTISTA"].ToString(), true);

                    Artista a = new Artista(nombre_artista, tipo_artista);
                    Disco d = new Disco(nombre_disco, genero_disco, año_disco, a, precio_disco, tipo_disco);
                    Cliente c = new Cliente(nombre_cliente, sexo_cliente, edad_cliente);
                    Venta v = new Venta(id, d, c);

                    ventas.Add(v);
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException("Error al tratar de obtener las ventas de la base de datos", ex);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return ventas;
        }

        public string GenerarQuery() 
        {
            string query = "SELECT * FROM dbo.Ventas";


            switch (this.cboCriterio2.SelectedItem) 
            {
                case "Todos":
                    break;

                case "Hombres":
                    query += " WHERE SEXO_CLIENTE = 'Hombre'";
                    break;

                case "Mujeres":
                    query += " WHERE SEXO_CLIENTE = 'Mujer'";
                    break;

                case "No binarios":
                    query += " WHERE SEXO_CLIENTE = 'NoBinario'";
                    break;

                case "Menores de 30":
                    query += " WHERE EDAD_CLIENTE <= 30";
                    break;

                case "Mayores de 30":
                    query += " WHERE EDAD_CLIENTE >= 30";
                    break;
            }

            return query;

        }

        public string GenerarQuery2()
        {
            string query = "SELECT * FROM dbo.Ventas";


            switch (this.cbo2crit2.SelectedItem)
            {
                case "Todos":
                    break;

                case "Rock":
                    query += " WHERE GENERO_DISCO = 'Rock'";
                    break;

                case "Jazz":
                    query += " WHERE GENERO_DISCO = 'Jazz'";
                    break;

                case "Pop":
                    query += " WHERE GENERO_DISCO = 'Pop'";
                    break;

                case "Experimental":
                    query += " WHERE GENERO_DISCO = 'Experimental'";
                    break;

            }

            return query;

        }

        private bool todosIguales(List<int> lista) 
        {
            bool retorno = true;
            int valor0 = lista[0];
            foreach(int item in lista) 
            {
                if(item != valor0) 
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        #endregion

        #region Funciones Informes

        private void obtenerDecada()
        {
            string mostrarMayor = "";
            List<Venta> d60s = this.VentasDelForm.FindAll(Es60);
            List<Venta> d70s = this.VentasDelForm.FindAll(Es70);
            List<Venta> d80s = this.VentasDelForm.FindAll(Es80);
            List<Venta> d90s = this.VentasDelForm.FindAll(Es90);
            List<Venta> d00s = this.VentasDelForm.FindAll(Es00);
            List<Venta> d10s = this.VentasDelForm.FindAll(Es10);

            List<int> cantidades = new List<int>() { d60s.Count, d70s.Count, d80s.Count, d90s.Count, d00s.Count, d10s.Count };

            int mayor = cantidades.Max();

            if (todosIguales(cantidades))
            {
                this.lblResultado.Text = "Se vendio la misma cantidad de todas las decadas, " + mayor + " discos";
                this.ActualizarLista(this.VentasDelForm);
            }
            else
            {
                if (d60s.Count == mayor)
                {
                    mostrarMayor += "60s, ";
                    this.ActualizarLista(d60s);
                }

                if (d70s.Count == mayor)
                {
                    mostrarMayor += "70s, ";
                    this.ActualizarLista(d70s);
                }

                if (d80s.Count == mayor)
                {
                    mostrarMayor += "80s, ";
                    this.ActualizarLista(d80s);
                }

                if (d90s.Count == mayor)
                {
                    mostrarMayor += "90s, ";
                    this.ActualizarLista(d90s);
                }

                if (d00s.Count == mayor)
                {
                    mostrarMayor += "00s, ";
                    this.ActualizarLista(d00s);
                }

                if (d10s.Count == mayor)
                {
                    mostrarMayor += "10s, ";
                    this.ActualizarLista(d10s);
                }

                this.lblResultado.Text = mostrarMayor + "con " + mayor + " discos";
            }

        }


        private void ObtenerTipoDisco()
        {
            List<Venta> vCd = this.VentasDelForm.FindAll(EsCD);
            List<Venta> vVinilo = this.VentasDelForm.FindAll(EsVinilo);

            int cantCD = vCd.Count;
            int cantVinilo = vVinilo.Count;

            if (cantCD == cantVinilo)
            {
                this.lblResultado.Text = "Se vendio la misma cantidad, " + cantCD + " discos";
                this.ActualizarLista(this.VentasDelForm);
            }
            else
            {
                if(cantCD < cantVinilo) 
                {
                    this.lblResultado.Text = "Vinilos";
                    this.ActualizarLista(vVinilo);
                }
                else 
                {
                    this.lblResultado.Text = "CDs";
                    this.ActualizarLista(vCd);
                }
            }
        }

        private void ObtenerEdadQueMasCompro()
        {
            List<Venta> v30plus = this.VentasDelForm.FindAll(esMayorde30);
            List<Venta> v30minus = this.VentasDelForm.FindAll(esMenorDe30);

            int cantPlus = v30plus.Count;
            int cantMinus = v30minus.Count;

            if (cantPlus == cantMinus)
            {
                this.lblResultado.Text = "Se vendio la misma cantidad entre ambos rangos etarios, " + cantPlus + " discos";
                this.ActualizarLista(this.VentasDelForm);
            }
            else
            {
                if (cantPlus < cantMinus)
                {
                    this.lblResultado.Text = "Menores de 30 años";
                    this.ActualizarLista(v30minus);
                }
                else
                {
                    this.lblResultado.Text = "Mayores de 30 años";
                    this.ActualizarLista(v30plus);
                }
            }
        }
        private void obtenerGeneroMasComprado() 
        {
            string mostrarMayor = "";
            List<Venta> vJazz = this.VentasDelForm.FindAll(esDeJazz); 
            List<Venta> vRock = this.VentasDelForm.FindAll(esDeRock);
            List<Venta> vPop = this.VentasDelForm.FindAll(esDePop);
            List<Venta> vExperimental = this.VentasDelForm.FindAll(esDeExperimental);

            List<int> cantidades = new List<int>() { vRock.Count, vJazz.Count, vPop.Count, vExperimental.Count };

            int mayor = cantidades.Max();

            if(todosIguales(cantidades)) 
            {
                this.lblResultado.Text = "Se vendio la misma cantidad de todos los generos, " + mayor +" discos";
                this.ActualizarLista(this.VentasDelForm);
            }
            else 
            {
                if (vRock.Count == mayor)
                {
                    mostrarMayor += "Rock, ";
                    this.ActualizarLista(vRock);
                }

                if (vJazz.Count == mayor)
                {
                    mostrarMayor += "Jazz, ";
                    this.ActualizarLista(vJazz);
                }

                if (vPop.Count == mayor)
                {
                    mostrarMayor += "Pop, ";
                    this.ActualizarLista(vPop);
                }

                if (vExperimental.Count == mayor)
                {
                    mostrarMayor += "Experimental, ";
                    this.ActualizarLista(vExperimental);
                }

                this.lblResultado.Text = mostrarMayor + "con " + mayor + " discos";
            }
            
        }

        private void obtenerSexoQueMasCompro()
        {
            string mostrarMayor = "";
            List<Venta> vHombre = this.VentasDelForm.FindAll(esHombre);
            List<Venta> vMujer = this.VentasDelForm.FindAll(esMujer);
            List<Venta> vNoBinario = this.VentasDelForm.FindAll(esBinario);

            List<int> cantidades = new List<int>() { vHombre.Count, vMujer.Count, vNoBinario.Count };

            int mayor = cantidades.Max();

            if (todosIguales(cantidades))
            {
                this.lblResultado.Text = "Los 3 sexos compraron la misma cantidad " + mayor + " discos";
                this.ActualizarLista(this.VentasDelForm);
            }
            else
            {
                if (vHombre.Count == mayor)
                {
                    mostrarMayor += "Hombres, ";
                    this.ActualizarLista(vHombre);
                }

                if (vMujer.Count == mayor)
                {
                    mostrarMayor += "Mujeres, ";
                    this.ActualizarLista(vMujer);
                }

                if (vNoBinario.Count == mayor)
                {
                    mostrarMayor += "No Binarios, ";
                    this.ActualizarLista(vNoBinario);
                }

                this.lblResultado.Text = mostrarMayor + "con " + mayor + " discos";
            }

        }


        private void ActualizarLista(List<Venta> lista) 
        {
            foreach (Venta item in lista)
            {
                this.lstVentas.Items.Add(item);
            }
        }

        #endregion

        #region filtros

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

        private static bool esMenorDe30(Venta v)
        {
            return v.Cliente.Edad < 30;
        }

        private static bool esMayorde30(Venta v)
        {
            return v.Cliente.Edad > 30;
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
            return v.DiscoVendido.TipoDIsco == ETipoDisco.CD;
        }

        private static bool EsVinilo(Venta v)
        {
            return v.DiscoVendido.TipoDIsco == ETipoDisco.Vinilo;
        }


        private static bool Es60(Venta v)
        {
            return v.DiscoVendido.Año < 1970 && v.DiscoVendido.Año > 1959;
        }

        private static bool Es70(Venta v)
        {
            return v.DiscoVendido.Año < 1980 && v.DiscoVendido.Año > 1969;
        }

        private static bool Es80(Venta v)
        {
            return v.DiscoVendido.Año < 1990 && v.DiscoVendido.Año > 1979;
        }

        private static bool Es90(Venta v)
        {
            return v.DiscoVendido.Año < 2000 && v.DiscoVendido.Año > 1989;
        }

        private static bool Es00(Venta v)
        {
            return v.DiscoVendido.Año < 2010 && v.DiscoVendido.Año > 1999;
        }

        private static bool Es10(Venta v)
        {
            return v.DiscoVendido.Año < 2020 && v.DiscoVendido.Año > 2009;
        }
        #endregion


        private void InformesForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try 
            {
                this.VentasDelForm = this.ObtenerLista(GenerarQuery());
                this.lstVentas.Items.Clear();
                switch (this.cboCriterio1.SelectedItem)
                {
                    case "Genero":
                        obtenerGeneroMasComprado();
                        break;

                    case "Tipo de disco":
                        ObtenerTipoDisco();
                        break;

                    case "Decada":
                        obtenerDecada();
                        break;
                }
            }
            catch (ErrorArchivoException ex) 
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Consulta2_Click(object sender, EventArgs e)
        {
            try 
            {
                this.VentasDelForm = this.ObtenerLista(GenerarQuery2());
                this.lstVentas.Items.Clear();
                switch (this.cbo1Btn2.SelectedItem)
                {
                    case "Sexo":
                        obtenerSexoQueMasCompro();
                        break;

                    case "Rango Etario":
                        ObtenerEdadQueMasCompro();
                        break;

                }
            }
            catch (ErrorArchivoException ex) 
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) 
            {
                MessageBox.Show("Hubo un error!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
