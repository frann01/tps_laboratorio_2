using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoDatos
    {
        public static SqlConnection conexion;
        public static SqlCommand comando;

        static AccesoDatos()
        {
            AccesoDatos.conexion = new SqlConnection(@"Server=localhost;Database=Disqueria;Trusted_Connection=True;");
            AccesoDatos.comando = new SqlCommand();
            AccesoDatos.comando.Connection = AccesoDatos.conexion;
        }

        public static List<Venta> ObtenerListaVentas()
        {
            List<Venta> ventas = new List<Venta>();

            try
            {
                comando.CommandText = "SELECT * FROM dbo.Ventas";

                conexion.Open();
                SqlDataReader sqlReader = comando.ExecuteReader();
                //uType = (EType) Enum.Parse(typeof(EType), row["userType"].ToString(), true);
                
                while (sqlReader.Read())
                {
                    int id = Convert.ToInt32(sqlReader["id"]);
                    string nombre_disco = sqlReader["NOMBRE_DISCO"].ToString();
                    ETipoDisco tipo_disco = (ETipoDisco) Enum.Parse(typeof(ETipoDisco), sqlReader["TIPO_DISCO"].ToString(), true);
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
                throw new Exception("Error al tratar de obtener las ventas de la base de datos", ex);
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


        public static bool AgregarVenta(Venta v)
        {
            bool retorno = false;
            comando.CommandText = "INSERT INTO dbo.Ventas (NOMBRE_DISCO, TIPO_DISCO, GENERO_DISCO, NOMBRE_ARTISTA, AÑO_DISCO, PRECIO_DISCO, NOMBRE_CLIENTE, SEXO_CLIENTE, EDAD_CLIENTE, TIPO_ARTISTA) ";
            comando.CommandText += "VALUES (@nombreDisco, @TipoDisco, @GeneroDisco, @NombreArtista, @AñoDisco, @PrecioDisco, @NombreCLiente, @SexoCliente, @EdadCliente, @TipoArtista)";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombreDisco", v.DiscoVendido.Titulo);
            comando.Parameters.AddWithValue("@TipoDisco", v.DiscoVendido.TipoDIsco.ToString());
            comando.Parameters.AddWithValue("@GeneroDisco", v.DiscoVendido.Genero.ToString());
            comando.Parameters.AddWithValue("@NombreArtista", v.DiscoVendido.Artista.Nombre);
            comando.Parameters.AddWithValue("@AñoDisco", v.DiscoVendido.Año);
            comando.Parameters.AddWithValue("@PrecioDisco", v.DiscoVendido.Precio);
            comando.Parameters.AddWithValue("@NombreCLiente", v.Cliente.Nombre);
            comando.Parameters.AddWithValue("@SexoCliente", v.Cliente.Sexo.ToString());
            comando.Parameters.AddWithValue("@EdadCliente", v.Cliente.Edad);
            comando.Parameters.AddWithValue("@TipoArtista", v.DiscoVendido.Artista.Tipo.ToString());

            conexion.Open();
            int a = comando.ExecuteNonQuery();
            if (a == 1)
            {
                retorno = true;
            }
            conexion.Close();
            return retorno;
        }


        public static bool ModificarVenta(Venta v)
        {
            bool retorno = false;
            comando.CommandText = "UPDATE dbo.Ventas SET NOMBRE_DISCO = @nombreDisco, TIPO_DISCO = @TipoDisco, GENERO_DISCO = @GeneroDisco, NOMBRE_ARTISTA = NombreArtista, AÑO_DISCO = AñoDisco,";
            comando.CommandText += " PRECIO_DISCO = PrecioDisco, NOMBRE_CLIENTE = NombreCLiente, SEXO_CLIENTE = SexoCliente, EDAD_CLIENTE = EdadCliente, TIPO_ARTISTA = TipoArtista";
            comando.CommandText += "  WHERE id = @id";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombreDisco", v.DiscoVendido.Titulo);
            comando.Parameters.AddWithValue("@TipoDisco", v.DiscoVendido.TipoDIsco);
            comando.Parameters.AddWithValue("@GeneroDisco", v.DiscoVendido.Genero);
            comando.Parameters.AddWithValue("@NombreArtista", v.DiscoVendido.Artista.Nombre);
            comando.Parameters.AddWithValue("@AñoDisco", v.DiscoVendido.Año);
            comando.Parameters.AddWithValue("@PrecioDisco", v.DiscoVendido.Precio);
            comando.Parameters.AddWithValue("@NombreCLiente", v.Cliente.Nombre);
            comando.Parameters.AddWithValue("@SexoCliente", v.Cliente.Sexo);
            comando.Parameters.AddWithValue("@EdadCliente", v.Cliente.Edad);
            comando.Parameters.AddWithValue("@TipoArtista", v.DiscoVendido.Artista.Tipo);
            comando.Parameters.AddWithValue("@id", v.Id);

            conexion.Open();
            if (comando.ExecuteNonQuery() == 1)
            {
                retorno = true;
            }
            conexion.Close();
            return retorno;
        }

        public static bool EliminarVenta(int id)
        {
            bool retorno = false;
            comando.CommandText = "DELETE FROM dbo.Ventas WHERE id = @id";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id", id);
            conexion.Open();
            if (comando.ExecuteNonQuery() == 1)
            {
                retorno = true;
            }
            conexion.Close();
            return retorno;
        }















    }
}
