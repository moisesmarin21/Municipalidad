using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Pago
    {
        public int idPago { get; set; }
        public int idDeuda { get; set; }
        public int idCiudadano { get; set; }
        public int numSemanas { get; set; }
    }
}
