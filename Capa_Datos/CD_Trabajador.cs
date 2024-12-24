using Capa_Entidad;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class CD_Trabajador
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        // Método para obtener todos los trabajadores
        public DataTable ListarTrabajadores()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarTrabajadores"; // Supuesto procedimiento almacenado para listar trabajadores
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        // Método para insertar un nuevo trabajador
        public void InsertarTrabajador(CE_Trabajador obj)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_RegistrarTrabajador"; // Supuesto procedimiento almacenado para registrar trabajador
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombreT", obj.nombreT);
            comando.Parameters.AddWithValue("@telefonoT", obj.telefonoT);
            comando.Parameters.AddWithValue("@emailT", obj.emailT);
            comando.Parameters.AddWithValue("@dniT", obj.dniT);
            comando.Parameters.AddWithValue("@usuario", obj.usuario);
            comando.Parameters.AddWithValue("@contraseña", obj.contraseña);
            comando.Parameters.AddWithValue("@idZona", obj.idZona);
            comando.Parameters.AddWithValue("@idRol", obj.idRol);
            comando.Parameters.AddWithValue("@idTipoGenero", obj.idTipoGenero);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        // Método para eliminar un trabajador por su ID
        public void EliminarTrabajador(int idTrabajador)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EliminarTrabajador"; // Supuesto procedimiento almacenado para eliminar trabajador
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idTrabajador", idTrabajador);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        // Método para verificar credenciales de inicio de sesión
        public bool VerificarUsuario(string usuario, string contraseña)
        {
            bool existe = false;
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT COUNT(1) FROM Trabajador WHERE usuario = @usuario AND contraseña = @contraseña";
            comando.CommandType = CommandType.Text;

            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);

            int count = Convert.ToInt32(comando.ExecuteScalar());
            existe = (count > 0);

            conexion.CerrarConexion();
            return existe;
        }
    }
}
