using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Datos {
    internal class Socios {
        public string insertSocio(E_Socio socio) {
            string? salida;
            // E_Socio salida = new E_Socio();
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("IntroducirSocio", sqlCon);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add("nom", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("ape", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("dni", MySqlDbType.UInt32).Value = socio.DNI;
                
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.String;
                ParCodigo.Direction = System.Data.ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex) {
                salida = ex.Message;
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return salida;
        }
    }
}
