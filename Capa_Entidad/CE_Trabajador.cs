using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Trabajador
    {
        public int idTrabajador { get; set; }
        public string nombreT { get; set; }
        public string telefonoT { get; set; }
        public string emailT { get; set; }
        public string dniT { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public int idZona { get; set; }
        public int idRol { get; set; }
        public int idTipoGenero { get; set; }
    }
}
