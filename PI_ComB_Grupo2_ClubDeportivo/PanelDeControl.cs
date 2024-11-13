using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_ComB_Grupo2_ClubDeportivo {
    public partial class PanelDeControl : Form {
        private Form form;
        public PanelDeControl(Form form) {
            this.form = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            form.Show();
            this.Close();
        }

        private void GenerarColumnasSocios(string[] columns) {
            DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
            foreach (string column in columns) {

                if (column == "Activo" || column == "Abonada") {
                    dataGridViewColumn = new DataGridViewCheckBoxColumn();
                    dataGridViewColumn.FillWeight = 40;
                } else {
                    dataGridViewColumn = new DataGridViewTextBoxColumn();
                    if (column == "DNI") dataGridViewColumn.FillWeight = 45;
                    if (column == "ID_Socio" || column == "ID_Cuota") dataGridViewColumn.FillWeight = 40;
                    if (column == "ID") dataGridViewColumn.FillWeight = 30;
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
        private void dataGridClear() {
            label1.Visible = false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void button2_Click(object sender, EventArgs e) {
            dataGridClear();

            string[] columns = { "ID", "Nombre", "Apellido", "DNI", "Activo", "Fecha Inscripción" };
            GenerarColumnasSocios(columns);
            Action<int, MySqlDataReader> rows = (int renglon, MySqlDataReader reader) => {
                dataGridView1.Rows[renglon].Cells[0].Value = Convert.ToString(reader.GetUInt32(0));  //IdSocio
                dataGridView1.Rows[renglon].Cells[1].Value = Convert.ToString(reader.GetString(1));  //Nombre
                dataGridView1.Rows[renglon].Cells[2].Value = Convert.ToString(reader.GetString(2));  //Apellido
                dataGridView1.Rows[renglon].Cells[3].Value = Convert.ToString(reader.GetUInt32(3));  //DNI
                dataGridView1.Rows[renglon].Cells[4].Value = Convert.ToString(reader.GetBoolean(4)); //Activo
                dataGridView1.Rows[renglon].Cells[5].Value = Convert.ToString(reader.GetDateTime(5));//FechaInscripcion
            };
            CargarGrilla("SELECT * FROM comb_grupo2_clubdeportivo.socios;", rows);
        }

        private void button3_Click(object sender, EventArgs e) {
            dataGridClear();
            label1.Visible = true;
            label1.Text = "Fecha: " + DateTime.UtcNow.ToShortDateString();
            string[] columns = { "ID_Socio", "Nombre", "Apellido", "DNI", "ID_Cuota", "Abonada" };
            string query = "SELECT " +
                "socios.IdSocio as ID_Socio, socios.Nombre, Socios.Apellido, socios.DNI, cuota.Id as ID_Cuota, cuota.Pagada " +
                "from comb_grupo2_clubdeportivo.socios " +
                "inner join cuota on socios.IdSocio = cuota.IdSocio " +
                "where cuota.Vencimiento = curdate();";
            Action<int, MySqlDataReader> rows = (int renglon, MySqlDataReader reader) => {
                dataGridView1.Rows[renglon].Cells[0].Value = Convert.ToString(reader.GetUInt32(0));  //IdSocio
                dataGridView1.Rows[renglon].Cells[1].Value = Convert.ToString(reader.GetString(1));  //Nombre
                dataGridView1.Rows[renglon].Cells[2].Value = Convert.ToString(reader.GetString(2));  //Apellido
                dataGridView1.Rows[renglon].Cells[3].Value = Convert.ToString(reader.GetUInt32(3));  //DNI
                dataGridView1.Rows[renglon].Cells[4].Value = Convert.ToString(reader.GetUInt32(4));  //IdCuota
                dataGridView1.Rows[renglon].Cells[5].Value = Convert.ToString(reader.GetBoolean(5)); //Pagada
                dataGridView1.Rows[renglon].DefaultCellStyle.BackColor = reader.GetBoolean(5) ? Color.White : Color.MistyRose;
            };
            GenerarColumnasSocios(columns);
            CargarGrilla(query,rows);


        }
    }
}
