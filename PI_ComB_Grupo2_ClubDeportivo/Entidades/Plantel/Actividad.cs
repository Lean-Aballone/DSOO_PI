using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades.Plantel {
    internal class Actividad {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin {  get; set; }
        public string DiasDeActividad {  get; set; }
    }
}
