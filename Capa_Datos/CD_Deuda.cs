using Microsoft.Data.SqlClient;
using System.Data;


namespace Capa_Datos
{
    public class CD_Deuda
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();


        public DataTable Deudas()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarDeuda";

            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarDeuda(string valor)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_Deuda";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@valor", valor);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable DetalleDeuda(string idDeuda)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarDetallesDeuda";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idDeuda", idDeuda);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

    }
}