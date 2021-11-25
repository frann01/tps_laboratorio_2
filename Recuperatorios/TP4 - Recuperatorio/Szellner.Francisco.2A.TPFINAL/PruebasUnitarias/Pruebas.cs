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
        
        /// <summary>
        /// Valida que salte la excepcion NoEstaenDisqueriaException al tratar de borrar un disco que no este en la disqueria
        /// </summary>
        [Test]
        public void ValidarDiscoAusente()
        {
            try
            {
                Disco cd4 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
                Tienda<Disco> disqueria = new Tienda<Disco>(6);

                disqueria -= cd4;

                Assert.Fail();
            }
            catch (NoEstaenDisqueriaException)
            {

            }
        }

        /// <summary>
        /// Valida que se haya agregado un disco a la lista 
        /// </summary>
        [Test]
        public void ValidarDiscoAgregado()
        {
            Disco cd4 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
            Disco v4 = new Disco("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, 500, ETipoDisco.Vinilo);
            Tienda<Disco> disqueria = new Tienda<Disco>(1);

            disqueria += cd4;

            Assert.IsTrue(disqueria.StockListado.Count == 1 && disqueria == cd4);
        }

        /// <summary>
        /// Valida que se haya eliminado un disco de la disqueria
        /// </summary>
        [Test]
        public void ValidarDiscoEliminado()
        {
            Disco cd4 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
            Disco v4 = new Disco("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, 500, ETipoDisco.Vinilo);
            Tienda<Disco> disqueria = new Tienda<Disco>(1);

            disqueria += cd4;
            disqueria -= cd4;

            Assert.IsTrue(disqueria.StockListado.Count == 0 && disqueria != cd4);
        }

        /// <summary>
        /// Valida que se haya agregado un disco a la disqueria
        /// </summary>
        [Test]
        public void ValidarDiscoEnDisqueria()
        {
                Disco cd4 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
                Disco v4 = new Disco("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, 500,ETipoDisco.Vinilo);
                Tienda<Disco> disqueria = new Tienda<Disco>(1);

                disqueria += cd4;

                Assert.IsTrue(disqueria == cd4);
        }

        /// <summary>
        /// Valida que no se puede agregar un disco de mas a la Tienda
        /// </summary>
        [Test]
        public void ValidarFaltadeLugar()
        {
            try
            {
                Disco cd4 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
                Disco v4 = new Disco("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda,  500, ETipoDisco.Vinilo);
                Tienda<Disco> disqueria = new Tienda<Disco>(1);

                disqueria += cd4;
                disqueria += v4;

                Assert.Fail();
            }
            catch (SinLugarException)
            {

            }
        }

       

        /// <summary>
        /// Valida que la lista no se creen en null en una nueva instancia de Tienda
        /// </summary>
        [Test]
        public void ValidarLista()
        {
            Tienda<Disco> disqueria = new Tienda<Disco>(6);

            Assert.IsNotNull(disqueria.StockListado);
            Assert.IsNotNull(disqueria.VentasListado);

        }

        
        #endregion

        #region Pruebas Disco
        
        /// <summary>
        /// Valida que no se pueda agregar un precio invalido
        /// </summary>
        [Test]
        public void ValidarPrecioMenor()
        {
            int precioNeg = -50;
            try 
            {
                Disco v1 = new Disco("Clics Modernos", EGenero.Rock, 1983, "Charly Garcia", ETipoArtista.Solista,  precioNeg, ETipoDisco.Vinilo);
                Assert.Fail();
            }
            catch(PrecioInvalidoException)
            {
                
            }
        }

        /// <summary>
        /// Valida que no se pueda agregar un año invalido
        /// </summary>
        [Test]
        public void ValidarAñoMenor()
        {
            int año = -50;
            try
            {
                Disco v1 = new Disco("Clics Modernos", EGenero.Rock, año, "Charly Garcia", ETipoArtista.Solista, 500, ETipoDisco.Vinilo);
                Assert.Fail();
            }
            catch (AñoInvalidoException)
            {

            }
        }

        /// <summary>
        /// Valida que no se pueda agregar un año invalido
        /// </summary>
        [Test]
        public void ValidarAñoMayor()
        {
            
            int año = 30000;
            try
            {
                Disco v1 = new Disco("Clics Modernos", EGenero.Rock, año, "Charly Garcia", ETipoArtista.Solista, 500, ETipoDisco.Vinilo);
                Assert.Fail();
            }
            catch (AñoInvalidoException)
            {

            }

        }

        /// <summary>
        /// Valida que los discos no se creen en null
        /// </summary>
        [Test]
        public void ValidarNuevoDiscos()
        {
            Disco cd1 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
            Disco v1 = new Disco("Pulse Demon", EGenero.Experimental, 1996, "Merzbow", ETipoArtista.Solista, 170, ETipoDisco.Vinilo);

            Assert.IsNotNull(cd1);
            Assert.IsNotNull(v1);
        }

        /// <summary>
        /// Valida que dos discos sean iguales
        /// </summary>
        [Test]
        public void ValidarIgualdad()
        {
            
            Disco cd3 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
            Disco cd4 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500,ETipoDisco.CD);
                
            Assert.IsTrue(cd3 == cd4);
        }

        [Test]
        public void ValidarDiferenciaTitulo()
        {
           
            Disco cd3 = new Disco("Anoche", EGenero.Rock, 2005, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
            Disco cd4 = new Disco("Jessico", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);

            Assert.IsTrue(cd3 != cd4);
        }

        [Test]
        public void ValidarDiferenciaArtista()
        {

            Disco cd3 = new Disco("Anoche", EGenero.Rock, 2005, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
            Disco cd4 = new Disco("Anoche", EGenero.Rock, 2005, "Callejeros", ETipoArtista.Banda, 500, ETipoDisco.CD);

            Assert.IsTrue(cd3 != cd4);
        }



        #endregion

        #region Pruebas Clientes

        /// <summary>
        /// Valida que un nuevo cliente no se cree en null
        /// </summary>
        [Test]
        public void ValidarNuevoCliente()
        {
            Cliente c3 = new Cliente("Ana", ESexo.NoBinario, 20);

            Assert.NotNull(c3);
        }

        /// <summary>
        /// Valida que no se pueda ingresar una edad invalida
        /// </summary>
        [Test]
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

        /// <summary>
        /// Valida que no se pueda ingresar una edad invalida
        /// </summary>
        [Test]
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

        /// <summary>
        /// Valida que dos artistas sean iguales
        /// </summary>
        [Test]
        public void ValidarIgualdadArtista()
        {
            Artista a1 = new Artista("Charly Garcia", ETipoArtista.Solista);
            Artista a2 = new Artista("Charly Garcia", ETipoArtista.Solista);

            Assert.IsTrue(a1 == a2);
        }

        [Test]
        public void ValidarDiferenciaArtistas()
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