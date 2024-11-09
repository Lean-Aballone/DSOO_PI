using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades.Plantel
{
    internal class Profesor : E_Usuario {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Actividad> Clases {  get; set; }
        public List<Alumno> AlumnosAsignados { get; set; }

    }
}
