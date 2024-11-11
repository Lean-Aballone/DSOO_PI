using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Datos;
using System;
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

        private void onLoad(object sender, EventArgs e) {
            //GenerarColumnasSocios();
            //CargarGrilla();
        }
        private void GenerarColumnasSocios() {
            DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
            string[] columns = { "ID", "Nombre", "Apellido", "DNI", "Activo", "Fecha Inscripción" };
            foreach (string column in columns) {

                if (column == "Activo") {
                    dataGridViewColumn = new DataGridViewCheckBoxColumn();
                    dataGridViewColumn.FillWeight = 40;
                } else {
                    dataGridViewColumn = new DataGridViewTextBoxColumn();
                    if (column == "ID") dataGridViewColumn.FillWeight = 30;
                }
                dataGridViewColumn.HeaderText = column;
                dataGridView1.Columns.Add(dataGridViewColumn);
            }
        }
        private void CargarGrilla() {
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT * FROM comb_grupo2_clubdeportivo.socios;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        int renglon = dataGridView1.Rows.Add();
                        if (dataGridView1.Rows.Count > 0) {
                            dataGridView1.Rows[renglon].Cells[0].Value = Convert.ToString(reader.GetUInt32(0));
                            dataGridView1.Rows[renglon].Cells[1].Value = Convert.ToString(reader.GetString(1));
                            dataGridView1.Rows[renglon].Cells[2].Value = Convert.ToString(reader.GetString(2));
                            dataGridView1.Rows[renglon].Cells[3].Value = Convert.ToString(reader.GetUInt32(3));
                            dataGridView1.Rows[renglon].Cells[4].Value = Convert.ToString(reader.GetBoolean(4));
                            dataGridView1.Rows[renglon].Cells[5].Value = Convert.ToString(reader.GetDateTime(5));
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

        private void button2_Click(object sender, EventArgs e) {
            GenerarColumnasSocios();
            CargarGrilla();
        }
    }
}
