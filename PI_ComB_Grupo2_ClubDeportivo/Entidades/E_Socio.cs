using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades {
    internal class E_Socio {
        public uint IdSocio { set; get; }
        public bool activo { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public uint DNI { set; get; }
        public DateTime FechaIngreso { set; get; }

    }
}
