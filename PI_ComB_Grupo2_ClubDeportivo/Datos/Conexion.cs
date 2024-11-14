using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Entidades;

namespace PI_ComB_Grupo2_ClubDeportivo.Datos {
    public class Conexion {

        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        private Conexion(){
            bool correcto = false;
            int mensaje;
            this.baseDatos = "ComB_Grupo2_ClubDeportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";

            while (!correcto) {
                string title = "DATOS DE INSTALACIÓN MySQL";
                servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingresar Servidor", title);
                puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingresar Puerto", title);
                usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingresar Usuario", title);
                clave = Microsoft.VisualBasic.Interaction.InputBox("Ingresar clave", title);

                mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " +
                servidor + " PUERTO= " + puerto + " USUARIO: " +
                usuario + " CLAVE: " + clave,
                "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (mensaje != 6) {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                } else { 
                    correcto = true;
                }
            }


        }

        public MySqlConnection CrearConexion() {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }

            catch (Exception ex) {
                cadena = null;
                throw;
            }
            return cadena;
        }
        public static Conexion getInstancia() {
            if (con == null) con = new Conexion();
            return con;
        }

    }
}
