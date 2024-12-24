using Capa_Entidad;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class CD_Zona
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Zonas()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarZona";

            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarZona(string valor)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_Zona";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@valor", valor);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public void InsertarZona(CE_Zona obj)
        {

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_RegistrarZona";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcionZ", obj.descripcionZ);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EditarZona(CE_Zona obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EditarZona";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idZona", obj.idZona);
            comando.Parameters.AddWithValue("@descripcionZ", obj.descripcionZ);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EliminarZona(CE_Zona obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EliminarZona";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idZona", obj.idZona);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
