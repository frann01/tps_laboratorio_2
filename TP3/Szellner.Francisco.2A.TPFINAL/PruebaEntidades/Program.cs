using System;
using Entidades;
using Excepciones;
using Archivos;

namespace PruebaEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vinilo v1 = new Vinilo("Clics Modernos", EGenero.Rock, 1983, "Charly Garcia", ETipoArtista.Solista, ETipoVinilo.Usado, 500);
            Vinilo v2 = new Vinilo("Clics Modernos", EGenero.Rock, 1983, "Charly Garcia", ETipoArtista.Solista, ETipoVinilo.Nuevo, 500);
            Vinilo v3 = new Vinilo("A love Supreme", EGenero.Jazz, 1964, "John Coltrane", ETipoArtista.Solista, ETipoVinilo.Usado, 500);
            Vinilo v4 = new Vinilo("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, ETipoVinilo.Nuevo, 500);

            CD cd1 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
            CD cd2 = new CD("Pulse Demon", EGenero.Experimental, 1996, "Merzbow", ETipoArtista.Solista, 170);
            CD cd3 = new CD("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500);
            CD cd4 = new CD("Blackout", EGenero.Pop, 2007, "Britney Spears", ETipoArtista.Solista, 500);
            CD cd5 = new CD("Electric lady", EGenero.Rock, 1969, "Jimi Hendrix", ETipoArtista.Solista, 500);

            Cliente c1 = new Cliente("Juan", ESexo.Hombre, 15);
            Cliente c2 = new Cliente("Maria", ESexo.Mujer, 20);
            Cliente c3 = new Cliente("Ana", ESexo.NoBinario, 20);

            try 
            {
                Cliente c4 = new Cliente("Ana", ESexo.NoBinario, 200); // Edad del cliente es invalida
            }
            catch (EdadInvalidaException e) 
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                CD cd6 = new CD("Anoche", EGenero.Rock, 1800, "Babasonicos", ETipoArtista.Banda, 500);
            }
            catch (AñoInvalidoException e)
            {
                Console.WriteLine(e.Message); //Año es invalido
            }


            try
            {
                CD cd7 = new CD("Anoche", EGenero.Rock, 1996, "Babasonicos", ETipoArtista.Banda, -6);
            }
            catch (PrecioInvalidoException e)
            {
                Console.WriteLine(e.Message);  //Precio es invalido
            }

            if (v1 != v2) 
            {
                Console.WriteLine("Son diferentes"); // Tienen distinta condicion  
            }

            if(cd1 == cd3) 
            {
                Console.WriteLine("Son iguales\n"); //Son exactamente iguales
            }

            Tienda<Disco> disqueria = new Tienda<Disco>(6);

            disqueria += v1;
            disqueria += v2;
            disqueria += v3;
            disqueria += cd1;

            try
            {
                disqueria += cd3; // repetido con cd1
            }
            catch (DiscoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }
             
            disqueria += v4;
            disqueria += cd2;

            try 
            {
                disqueria += cd4; //  Ya se cargaron los 6 lugares
            }
            catch (SinLugarException e) 
            {
                Console.WriteLine(e.Message);
            }
             

            Console.WriteLine(Tienda<Disco>.Mostrar(disqueria, ETipoMostrar.Stock));

            Tienda<Disco>.Vender(disqueria, v1, c1);
            Tienda<Disco>.Vender(disqueria,  v4,c2);
            Tienda<Disco>.Vender(disqueria,  cd3, c3);
            Tienda<Disco>.Vender(disqueria, cd2, c3);

            try
            {
                // no esta en la disqueria
                Tienda<Disco>.Vender(disqueria, cd3, c3);

            }
            catch (NoEstaenDisqueriaException e)
            {
                Console.WriteLine(e.Message);
            }

            
            Console.WriteLine(Tienda<Disco>.Mostrar(disqueria, ETipoMostrar.Todos));


            try
            {

                //Serializador<Tienda<Disco>> xml = new Serializador<Tienda<Disco>>();
                //xml.Guardar("ArchivosPrueba.xml", disqueria);

                Tienda<Disco>.Guardar(disqueria, "ArchivoPruebaConsola.xml");
                Console.WriteLine("Archivo de Universidad guardado.");
            }
            catch (ErrorArchivoException e)
            {
                Console.WriteLine(e.Message);
            }

            Tienda<Disco> disqueria2;


            try
            {
                //Serializador<Tienda<Disco>> xml = new Serializador<Tienda<Disco>>();
                disqueria2 = Tienda<Disco>.Leer("ArchivosPrueba.xml");
                Console.WriteLine("Se leyo");
                Console.WriteLine(Tienda<Disco>.Mostrar(disqueria2, ETipoMostrar.Vendidos));
            }
            catch (ErrorArchivoException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
