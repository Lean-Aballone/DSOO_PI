using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Datos;
using System.Data;

namespace PI_ComB_Grupo2_ClubDeportivo {
    internal static class Program {
        [STAThread]
        static void Main() {

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

        }
    }
}