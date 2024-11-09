using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using PI_ComB_Grupo2_ClubDeportivo.Entidades.Inscripcion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ComB_Grupo2_ClubDeportivo.Datos {
    internal class Socios {

        public E_Socio getSocioFromDatabase(uint identificacion, bool esDNI) { 
            E_Socio rta = new E_Socio();
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("GetSocio", sqlCon);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetros de entrada
                comando.Parameters.AddWithValue("@identificacion", identificacion);
                comando.Parameters.AddWithValue("@esDni", esDNI);

                // Agregar parámetros de salida
                comando.Parameters.AddWithValue("@IdSocio", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                comando.Parameters.Add("@n", MySqlDbType.VarChar, 30).Direction = ParameterDirection.Output;
                comando.Parameters.Add("@a", MySqlDbType.VarChar, 40).Direction = ParameterDirection.Output;
                comando.Parameters.AddWithValue("@DNI", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                comando.Parameters.AddWithValue("@activo", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                comando.Parameters.Add("@fIngreso", MySqlDbType.DateTime).Direction = ParameterDirection.Output;
                comando.Parameters.AddWithValue("@apto", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                comando.Parameters.AddWithValue("@med", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                comando.Parameters.Add("@enf", MySqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                comando.Parameters.Add("@obs", MySqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                //Datos Socio
                rta.IdSocio = Convert.ToUInt32(comando.Parameters["@IdSocio"].Value);
                rta.Nombre = comando.Parameters["@n"].Value.ToString();
                rta.Apellido = comando.Parameters["@a"].Value.ToString();
                rta.DNI = Convert.ToUInt32(comando.Parameters["@DNI"].Value);
                rta.activo = Convert.ToBoolean(comando.Parameters["@activo"].Value);
                rta.FechaIngreso = Convert.ToDateTime(comando.Parameters["@fIngreso"].Value);
                //Datos Ficha Medica
                if (comando.Parameters["@apto"].Value != DBNull.Value) {
                    E_FichaMedica fm = new E_FichaMedica();
                    fm.PuedeRealizarActividadFisica = Convert.ToBoolean(comando.Parameters["@apto"].Value);
                    fm.ConsumeMedicamentos = Convert.ToBoolean(comando.Parameters["@med"].Value);
                    fm.enfPreex = comando.Parameters["@enf"].Value.ToString();
                    fm.Observaciones = comando.Parameters["@obs"].Value.ToString();
                    //Carga fm a Socio
                    rta.FichaMedica = fm;
                }
                MessageBox.Show("Socio: " + rta.Apellido + ", " + rta.Nombre + " \nSe ha cargado correctamente.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rta;
        }

        public string insertSocio(E_Socio socio) {
            string? salida;
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

        public string insertFicha(E_FichaMedica FM) {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("IntroducirFicha", sqlCon);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add("dni", MySqlDbType.UInt32).Value = FM.DNI;
                comando.Parameters.Add("apto", MySqlDbType.Bit).Value = FM.PuedeRealizarActividadFisica;
                comando.Parameters.Add("med", MySqlDbType.Bit).Value = FM.ConsumeMedicamentos;
                comando.Parameters.Add("enf", MySqlDbType.VarChar).Value = FM.enfPreex;
                comando.Parameters.Add("obs", MySqlDbType.VarChar).Value = FM.Observaciones;

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
