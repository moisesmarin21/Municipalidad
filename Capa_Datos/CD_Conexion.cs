using Microsoft.Data.SqlClient;
using System.Data;
namespace Capa_Datos
{
    class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=(local); DataBase=agua_potable; Integrated Security=true; TrustServerCertificate = True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
