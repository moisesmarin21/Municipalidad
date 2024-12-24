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
    public class CN_Deuda
    {
        CD_Deuda objetoCD = new CD_Deuda();
        public DataTable Listar_Deudas()
        {
            return objetoCD.Deudas();
        }

        public DataTable Buscar_Deuda(string valor)
        {
            CD_Deuda objetoCD = new CD_Deuda();
            return objetoCD.BuscarDeuda(valor);
        }

        public DataTable Listar_DetalleDeuda(string valor)
        {
            CD_Deuda objetoCD = new CD_Deuda();
            return objetoCD.DetalleDeuda(valor);
        }
    }
}
