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
    public class CN_Zona
    {
        CD_Zona objetoCD = new CD_Zona();

        public DataTable Listar_Zonas()
        {
            return objetoCD.Zonas();
        }

        public DataTable Buscar_Zona(string valor)
        {
            CD_Zona objetoCD = new CD_Zona();
            return objetoCD.BuscarZona(valor);
        }


        public void Insertar_Zona(string descripcionZ)
        {

            CD_Zona objetoCD = new CD_Zona();
            CE_Zona obj = new CE_Zona();

            obj.descripcionZ = descripcionZ;

            objetoCD.InsertarZona(obj);
        }


        public void Editar_Zona(string idZona, string descripcionZ)

        {
            CD_Zona objetoCD = new CD_Zona();
            CE_Zona obj = new CE_Zona();

            obj.idZona = Convert.ToInt32(idZona);
            obj.descripcionZ = descripcionZ;

            objetoCD.EditarZona(obj);
        }

        public void Eliminar_Zona(string idZona)
        {
            CD_Zona objetoCD = new CD_Zona();
            CE_Zona obj = new CE_Zona();

            obj.idZona = Convert.ToInt32(idZona);

            objetoCD.EliminarZona(obj);
        }
    }
}
