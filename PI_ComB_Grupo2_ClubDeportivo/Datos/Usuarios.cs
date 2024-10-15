using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Datos {
    internal class Usuarios {

        public E_Usuario ReadUsuario(string nom, string pass) {
            E_Usuario salida = new E_Usuario();

            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = nom;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = pass;
                sqlCon.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                salida.NombreUsu = dr[0].ToString();
                dr.Read();
                salida.RolUsu = dr[1].ToString();
                       
            }
            catch (Exception ex) {
                salida.NombreUsu = "ERROR";
                salida.RolUsu = ex.Message;
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
                
            return salida;
            
        }
    }
}
