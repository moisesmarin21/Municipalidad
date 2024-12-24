using Capa_Entidad;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Capa_Datos
{
    public class CD_Ciudadano
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Ciudadanos()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarCiudadano";

            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ListarTipoGenero()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from tipogenero";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ListarZona()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from zona";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarSituacion()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from situacion";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarTipoTarifa()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TipoTarifa";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable BuscarCiudadano(string valor)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_Ciudadano";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@valor", valor);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public void InsertarCiudadano(CE_Ciudadano obj)
        {

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_RegistrarCiudadano";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombreC", obj.nombreC);
            comando.Parameters.AddWithValue("@apellidoC", obj.apellidoC);
            comando.Parameters.AddWithValue("@telefonoC", obj.telefonoC);
            comando.Parameters.AddWithValue("@dniC", obj.dniC);
            //comando.Parameters.AddWithValue("@fechaRegistro", obj.fechaRegistro);

            comando.Parameters.AddWithValue("@idTipoGenero", obj.idTipoGenero);
            comando.Parameters.AddWithValue("@idZona", obj.idZona);
            comando.Parameters.AddWithValue("@idSituacion", obj.idSituacion);
            comando.Parameters.AddWithValue("@idTipoTarifa", obj.idTipoTarifa);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EditarCiudadano(CE_Ciudadano obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EditarCiudadano";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idCiudadano", obj.@idCiudadano);
            comando.Parameters.AddWithValue("@nombreC", obj.nombreC);
            comando.Parameters.AddWithValue("@apellidoC", obj.apellidoC);
            comando.Parameters.AddWithValue("@telefonoC", obj.telefonoC);
            comando.Parameters.AddWithValue("@dniC", obj.dniC);

            comando.Parameters.AddWithValue("@idTipoGenero", obj.idTipoGenero);
            comando.Parameters.AddWithValue("@idZona", obj.idZona);
            comando.Parameters.AddWithValue("@idSituacion", obj.idSituacion);
            comando.Parameters.AddWithValue("@idTipoTarifa", obj.idTipoTarifa);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EliminarCiudadano(CE_Ciudadano obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EliminarCiudadano";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idCiudadano", obj.idCiudadano);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
