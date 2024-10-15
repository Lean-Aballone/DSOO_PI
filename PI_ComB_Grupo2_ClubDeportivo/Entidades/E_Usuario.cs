using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Entidades {
    public class E_Usuario {
        public int CodUsu { get; set; }
        public string? NombreUsu { get; set; }
        public string? PassUsu { get; set; }
        public string? RolUsu { get; set; }
        public bool Activo { get; set; }
    }
}
