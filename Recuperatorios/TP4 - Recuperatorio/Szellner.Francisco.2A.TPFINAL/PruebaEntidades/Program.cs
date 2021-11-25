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
            
            //Creo Discos
            Disco v1 = new Disco("Clics Modernos", EGenero.Rock, 1983, "Charly Garcia", ETipoArtista.Solista, 500, ETipoDisco.Vinilo);
            Disco v2 = new Disco("Pubis angelical", EGenero.Rock, 1982, "Charly Garcia", ETipoArtista.Solista, 700, ETipoDisco.Vinilo);
            Disco v3 = new Disco("A love Supreme", EGenero.Jazz, 1964, "John Coltrane", ETipoArtista.Solista,  500, ETipoDisco.Vinilo);
            Disco v4 = new Disco("Loveless", EGenero.Rock, 1983, "My bloody valentine", ETipoArtista.Banda, 500, ETipoDisco.Vinilo);

            Disco cd1 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
            Disco cd2 = new Disco("Pulse Demon", EGenero.Experimental, 1996, "Merzbow", ETipoArtista.Solista, 170, ETipoDisco.CD);
            Disco cd3 = new Disco("Anoche", EGenero.Rock, 2001, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD);
            Disco cd4 = new Disco("Blackout", EGenero.Pop, 2007, "Britney Spears", ETipoArtista.Solista, 500, ETipoDisco.CD);
            Disco cd5 = new Disco("Electric lady", EGenero.Rock, 1969, "Jimi Hendrix", ETipoArtista.Solista, 500, ETipoDisco.CD);

            ///Creo clientes
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
                Disco cd6 = new Disco("Anoche", EGenero.Rock, 1800, "Babasonicos", ETipoArtista.Banda, 500, ETipoDisco.CD); //Año es invalido
            }
            catch (AñoInvalidoException e)
            {
                Console.WriteLine(e.Message); 
            }


            try
            {
                Disco cd7 = new Disco("Anoche", EGenero.Rock, 1996, "Babasonicos", ETipoArtista.Banda, -6, ETipoDisco.CD); //Precio es invalido
            }
            catch (PrecioInvalidoException e)
            {
                Console.WriteLine(e.Message);  
            }

            if (v1 != v2) 
            {
                Console.WriteLine("Son diferentes"); // Tienen distinta condicion  
            }

            if(cd1 == cd3) 
            {
                Console.WriteLine("Son iguales\n"); //Son exactamente iguales
            }

            //Creo disqueria
            Tienda<Disco> disqueria = new Tienda<Disco>(6);
            disqueria.VentaNueva += MostrarEvento;

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
             
            //Muestro solo el stock
            Console.WriteLine(Tienda<Disco>.Mostrar(disqueria, ETipoMostrar.Stock));

            //Genero ventas
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

            //Muestro stock
            Console.WriteLine(Tienda<Disco>.Mostrar(disqueria, ETipoMostrar.Stock));
            
            Console.ReadKey();
        }

        public static void MostrarEvento(Venta v) 
        {
            Console.WriteLine("Se vendio el disco " + v.DiscoVendido.Titulo);
        }
    }
}
