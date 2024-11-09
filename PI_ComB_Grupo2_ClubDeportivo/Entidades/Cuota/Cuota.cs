using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades.Cuota {
    internal class Cuota {
        public int Id { get; set; }
        public int Id_Socio {  get; set; }
        public bool Vencida { get; set; }
        public double Monto { get; set; }
        public DateTime Vencimiento { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Pagada { get; set; }
    }
}
