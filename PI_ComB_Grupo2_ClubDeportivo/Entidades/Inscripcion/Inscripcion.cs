using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades.Inscripcion {
    internal class Inscripcion {
        public E_FichaMedica FichaMedica { get; set; }
        public PagoInscripcion Pago { get; set; }
        public E_NoSocio noSocio { get; set; }
        public int Id { get; set; }
    }
}
