using NUnit.Framework;
using Entidades;
using Excepciones;

namespace PruebasUnitarias
{
    /// <summary>
    /// Uso de pruebas Unitarias
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Pruebas Tienda


        [Test]
        public void ValidarDiscoAusente()
        {
            try
            {
                CD cd4 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
                Tienda<Disco> disqueria = new Tienda<Disco>(6);

                disqueria -= cd4;

                Assert.Fail();
            }
            catch (NoEstaenDisqueriaException)
            {

            }
        }

        [Test]
        public void ValidarDiscoAgregado()
        {
            CD cd4 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
            Vinilo v4 = new Vinilo("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, ETipoVinilo.Nuevo, 500);
            Tienda<Disco> disqueria = new Tienda<Disco>(1);

            disqueria += cd4;

            Assert.IsTrue(disqueria.StockListado.Count == 1);
        }

        [Test]
        public void ValidarDiscoEliminado()
        {
            CD cd4 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
            Vinilo v4 = new Vinilo("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, ETipoVinilo.Nuevo, 500);
            Tienda<Disco> disqueria = new Tienda<Disco>(1);

            disqueria += cd4;
            disqueria -= cd4;

            Assert.IsTrue(disqueria.StockListado.Count == 0);
        }

        [Test]
        public void ValidarDiscoEnDisqueria()
        {
                CD cd4 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
                Vinilo v4 = new Vinilo("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, ETipoVinilo.Nuevo, 500);
                Tienda<Disco> disqueria = new Tienda<Disco>(1);

                disqueria += cd4;

                Assert.IsTrue(disqueria == cd4);
        }

        [Test]
        public void ValidarFaltadeLugar()
        {
            try
            {
                CD cd4 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
                Vinilo v4 = new Vinilo("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, ETipoVinilo.Nuevo, 500);
                Tienda<Disco> disqueria = new Tienda<Disco>(1);

                disqueria += cd4;
                disqueria += v4;

                Assert.Fail();
            }
            catch (SinLugarException)
            {

            }
        }

        [Test]
        public void ValidarGanancia()
        {
            CD cd1 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
            CD cd2 = new CD("Pulse Demon", EGenero.Experimental, 1996, "Merzbow", ETipoArtista.Solista, 170);

            Tienda<Disco> disqueria = new Tienda<Disco>(6);

            disqueria += cd1;
            disqueria += cd2;

            disqueria -= cd1;
            disqueria -= cd2;


            Assert.IsTrue(disqueria.Ganacia == 670);
        }

        [Test]
        public void ValidarLista()
        {
            Tienda<Disco> disqueria = new Tienda<Disco>(6);

            Assert.IsNotNull(disqueria.StockListado);
            Assert.IsNotNull(disqueria.VentasListado);

        }

        [Test]
        public void ValidarVenta()
        {
            int retorno;
            Vinilo v4 = new Vinilo("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, ETipoVinilo.Nuevo, 500);
            Cliente c1 = new Cliente("Juan", ESexo.Hombre, 15);
            Tienda<Disco> disqueria = new Tienda<Disco>(6);

            disqueria += v4;
            retorno = Tienda<Disco>.Vender(disqueria, v4, c1);

            Assert.IsTrue(retorno == 0 && disqueria.StockListado.Count == 0);
        }

        #endregion

        #region Pruebas Disco

        [Test]
        public void ValidarPrecioMenor()
        {
            int precioNeg = -50;
            try 
            {
                Vinilo v1 = new Vinilo("Clics Modernos", EGenero.Rock, 1983, "Charly Garcia", ETipoArtista.Solista, ETipoVinilo.Usado, precioNeg);
                Assert.Fail();
            }
            catch(PrecioInvalidoException)
            {
                
            }
        }


        [Test]

        public void ValidarAñoMenor()
        {
            int año = -50;
            try
            {
                Vinilo v1 = new Vinilo("Clics Modernos", EGenero.Rock, año, "Charly Garcia", ETipoArtista.Solista, ETipoVinilo.Usado, 500);
                Assert.Fail();
            }
            catch (AñoInvalidoException)
            {

            }
        }

        [Test]
        public void ValidarAñoMayor()
        {
            
            int año = 30000;
            try
            {
                Vinilo v1 = new Vinilo("Clics Modernos", EGenero.Rock, año, "Charly Garcia", ETipoArtista.Solista, ETipoVinilo.Usado, 500);
                Assert.Fail();
            }
            catch (AñoInvalidoException)
            {

            }

        }

        [Test]
        public void ValidarNuevoDiscos()
        {
            CD cd1 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
            Vinilo v1 = new Vinilo("Pulse Demon", EGenero.Experimental, 1996, "Merzbow", ETipoArtista.Solista, ETipoVinilo.Nuevo, 170);

            Assert.IsNotNull(cd1);
            Assert.IsNotNull(v1);
        }

        [Test]
        public void ValidarIgualdadCD()
        {
            
            CD cd3 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
            CD cd4 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
                
            Assert.IsTrue(cd3 == cd4);
        }

        [Test]
        public void ValidarDiferenciaCDTitulo()
        {
           
            CD cd3 = new CD("Anoche", EGenero.Rock, 2005, "Babasonicos", ETipoArtista.Banda, 500);
            CD cd4 = new CD("Jessico", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);

            Assert.IsTrue(cd3 != cd4);
        }

        [Test]
        public void ValidarDiferenciaCDArtista()
        {

            CD cd3 = new CD("Anoche", EGenero.Rock, 2005, "Babasonicos", ETipoArtista.Banda, 500);
            CD cd4 = new CD("Anoche", EGenero.Rock, 2005, "Callejeros", ETipoArtista.Banda, 500);

            Assert.IsTrue(cd3 != cd4);
        }

        [Test]
        public void ValidarIgualdadVInilo()
        {

            Vinilo cd3 = new Vinilo("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, ETipoVinilo.Nuevo, 500);
            Vinilo cd4 = new Vinilo("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda,ETipoVinilo.Nuevo,500);

            Assert.IsTrue(cd3 == cd4);
        }

        [Test]
        public void ValidarDIferenciaVIniloCondicion()
        {

            Vinilo cd3 = new Vinilo("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, ETipoVinilo.Nuevo, 500);
            Vinilo cd4 = new Vinilo("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, ETipoVinilo.Usado, 500);

            Assert.IsTrue(cd3 != cd4);
        }

        [Test]
        public void ValidarDIferenciaVIniloTitulo()
        {

            Vinilo cd3 = new Vinilo("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, ETipoVinilo.Usado, 500);
            Vinilo cd4 = new Vinilo("Ayer", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, ETipoVinilo.Usado, 500);

            Assert.IsTrue(cd3 != cd4);
        }

        [Test]
        public void ValidarDIferenciaVIniloArtista()
        {

            Vinilo cd3 = new Vinilo("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, ETipoVinilo.Usado, 500);
            Vinilo cd4 = new Vinilo("Anoche", EGenero.Rock, 2001, "Callejeros", ETipoArtista.Banda, ETipoVinilo.Usado, 500);

            Assert.IsTrue(cd3 != cd4);
        }


        #endregion

        #region Pruebas Clientes

        [Test]
        public void ValidarNuevoCliente()
        {
            Cliente c3 = new Cliente("Ana", ESexo.NoBinario, 20);

            Assert.NotNull(c3);
        }

        public void ValidarClienteEdadGrande()
        {
            
            try 
            {
                Cliente c3 = new Cliente("Ana", ESexo.NoBinario, 200);
                Assert.Fail();
            }
            catch (EdadInvalidaException) 
            {

            }

        }

        public void ValidarClienteEdadChica()
        {

            try
            {
                Cliente c3 = new Cliente("Ana", ESexo.NoBinario, -5);
                Assert.Fail();
            }
            catch (EdadInvalidaException)
            {

            }

        }

        #endregion

        #region Pruebas Artistas

        [Test]
        public void ValidarIgualdadArtista()
        {
            Artista a1 = new Artista("Charly Garcia", ETipoArtista.Solista);
            Artista a2 = new Artista("Charly Garcia", ETipoArtista.Solista);

            Assert.IsTrue(a1 == a2);
        }

        [Test]
        public void ValidarDiferenciaArtista()
        {
            Artista a1 = new Artista("Charly Garcia", ETipoArtista.Solista);
            Artista a2 = new Artista("Fito Paez", ETipoArtista.Solista);

            Assert.IsTrue(a1 != a2);
        }

        [Test]
        public void ValidarNuevoArtista()
        {
            Artista a1 = new Artista("Charly Garcia", ETipoArtista.Solista);

            Assert.NotNull(a1);
        }

        #endregion
    }
}