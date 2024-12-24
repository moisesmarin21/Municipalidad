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
    public class CN_Pago
    {
        CD_Pago objetoCD = new CD_Pago();

        public DataTable Listar_Pagos()
        {
            return objetoCD.Pagos();
        }

        public DataTable BuscarPago(string valor)
        {
            CD_Pago objetoCD = new CD_Pago();
            return objetoCD.BuscarPago(valor);
        }

        public void Insertar_Pago(string idDeuda, string numSemanas)
        {

            CD_Pago objetoCD = new CD_Pago();
            CE_Pago obj = new CE_Pago();

            obj.idDeuda = Convert.ToInt32(idDeuda);
            obj.numSemanas = Convert.ToInt32(numSemanas);
            
            objetoCD.RegistarPago(obj);
        }

        public DataTable Listar_DetallePago(string valor)
        {
            CD_Pago objetoCD = new CD_Pago();
            return objetoCD.DetallePago(valor);
        }
    }
}
