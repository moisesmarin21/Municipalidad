using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Reporte
    {
        CD_Reporte objetoCD = new CD_Reporte();

        public DataTable Listar_PagosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return objetoCD.ListarPagosPorFecha(fechaInicio, fechaFin);
        }

        public DataTable Listar_DeudasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return objetoCD.ListarDeudasPorFecha(fechaInicio, fechaFin);
        }
    }
}
