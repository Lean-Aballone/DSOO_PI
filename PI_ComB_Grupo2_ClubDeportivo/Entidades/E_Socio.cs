using PI_ComB_Grupo2_ClubDeportivo.Entidades.Inscripcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades {
    public class E_Socio : E_NoSocio {
        public uint? IdSocio { set; get; }
        public bool? activo { set; get; }
        public DateTime? FechaIngreso { set; get; }
        public E_FichaMedica? FichaMedica { set; get; }

    }
}
