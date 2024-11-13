using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades.Cuota {
    internal class Cuota {
        public int Id { get; set; }
        public uint? Id_Socio {  get; set; }
        public bool Vencida { get; set; }
        public double Monto { get; set; }
        public DateTime Vencimiento { get; set; }
        public DateTime? FechaPago { get; set; }
        public bool Pagada { get; set; }
        public Cuota(bool fp) {
            this.Monto = fp ? Program.VALORCUOTAMENSUAL : Program.VALORCUOTADIARIO;
            this.Vencida = false;
            this.Pagada = false;
            Vencimiento = fp ? DateTime.Now.AddMonths(1) : DateTime.Now.AddDays(1);
        }
    }

}
