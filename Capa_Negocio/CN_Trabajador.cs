using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Trabajador
    {
        CD_Trabajador objetoCD = new CD_Trabajador();

        // Método para listar todos los trabajadores
        public DataTable ListarTrabajadores()
        {
            return objetoCD.ListarTrabajadores();
        }

        // Método para insertar un nuevo trabajador
        public void InsertarTrabajador(string nombreT, string telefonoT, string emailT, string dniT, string usuario, string contraseña, int idZona, int idRol, int idTipoGenero)
        {
            CE_Trabajador obj = new CE_Trabajador
            {
                nombreT = nombreT,
                telefonoT = telefonoT,
                emailT = emailT,
                dniT = dniT,
                usuario = usuario,
                contraseña = contraseña,
                idZona = idZona,
                idRol = idRol,
                idTipoGenero = idTipoGenero
            };

            objetoCD.InsertarTrabajador(obj);
        }

        // Método para eliminar un trabajador por su ID
        public void EliminarTrabajador(string idTrabajador)
        {
            objetoCD.EliminarTrabajador(Convert.ToInt32(idTrabajador));
        }

        // Método para verificar si el usuario y la contraseña son correctos
        public bool VerificarUsuario(string usuario, string contraseña)
        {
            return objetoCD.VerificarUsuario(usuario, contraseña);
        }
    }
}
