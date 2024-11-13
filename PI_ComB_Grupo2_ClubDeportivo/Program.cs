using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Datos;
using System.Data;

namespace PI_ComB_Grupo2_ClubDeportivo {
    internal static class Program {
        public const double VALORCUOTAMENSUAL = 10000;
        public const double VALORCUOTADIARIO = 400;
        [STAThread]
        static void Main() {

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

        }
    }
}