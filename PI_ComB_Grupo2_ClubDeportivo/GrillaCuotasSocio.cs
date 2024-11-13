using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Datos;
using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_ComB_Grupo2_ClubDeportivo
{
    public partial class GrillaCuotasSocio : Form{

        Form form;
        E_Socio socio;
        public GrillaCuotasSocio(E_Socio socio, Form form) {
            this.form = form;
            this.socio = socio;
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e) {

            string[] columns = { "ID_Cuota", "Abonada", "Vencimiento", "Fecha de Pago"};
            string query = "select cuota.Id, cuota.Pagada as Abonada, cuota.Vencimiento, cuota.FechaPago " +
                "from comb_grupo2_clubdeportivo.cuota INNER JOIN comb_grupo2_clubdeportivo.socios on socios.IdSocio = cuota.IdSocio " +
                "where cuota.IdSocio = " +
                socio.IdSocio + ";";
            

            Action<int, MySqlDataReader> rows = (int renglon, MySqlDataReader reader) => {
                dataGridView1.Rows[renglon].Cells[0].Value = Convert.ToString(reader.GetUInt32(0));  //IdCuota
                dataGridView1.Rows[renglon].Cells[1].Value = Convert.ToString(reader.GetBoolean(1));  //Pagada
                dataGridView1.Rows[renglon].Cells[2].Value = Convert.ToString(reader.GetDateTime(2));  //Vencimiento
                dataGridView1.Rows[renglon].Cells[3].Value = (reader.IsDBNull(3)) ? "" : Convert.ToString(reader.GetDateTime(3));  //FechaPago
                dataGridView1.Rows[renglon].DefaultCellStyle.BackColor = reader.GetBoolean(1) ? Color.White : Color.MistyRose;
            };
            GenerarColumnasSocios(columns);
            CargarGrilla(query, rows);
        }

        private void button1_Click(object sender, EventArgs e) {
            form.Show();
            this.Close();
        }

        private void GenerarColumnasSocios(string[] columns) {
            DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
            foreach (string column in columns) {

                if (column == "Abonada") {
                    dataGridViewColumn = new DataGridViewCheckBoxColumn();
                    dataGridViewColumn.FillWeight = 40;
                } else {
                    dataGridViewColumn = new DataGridViewTextBoxColumn();
                }
                dataGridViewColumn.HeaderText = column;
                dataGridView1.Columns.Add(dataGridViewColumn);
            }
        }
        private void CargarGrilla(string query, Action<int, MySqlDataReader> rows) {
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        int renglon = dataGridView1.Rows.Add();
                        if (dataGridView1.Rows.Count > 0) {
                            rows(renglon, reader);
                        }
                    }
                } else {
                    MessageBox.Show("No hay datos");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
    }
}
