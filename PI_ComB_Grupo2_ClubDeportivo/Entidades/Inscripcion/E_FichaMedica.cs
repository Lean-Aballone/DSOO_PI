using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades.Inscripcion {
    public class E_FichaMedica : E_NoSocio {
        public bool? PuedeRealizarActividadFisica {  get; set; }
        public bool? ConsumeMedicamentos { get; set; }
        public string? enfPreex {  get; set; }
        public string? Observaciones { get; set; }

       public E_FichaMedica() { }
       public E_FichaMedica(E_Socio socio) {
            this.Nombre = socio.Nombre;
            this.Apellido = socio.Apellido;
            this.DNI = socio.DNI;
       }
    }

}
