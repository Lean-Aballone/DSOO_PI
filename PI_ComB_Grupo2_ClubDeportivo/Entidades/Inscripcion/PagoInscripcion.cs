using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades.Inscripcion {
    internal class PagoInscripcion : E_NoSocio{

        public bool FuePagada { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
