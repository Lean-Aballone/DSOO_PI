using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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

namespace PI_ComB_Grupo2_ClubDeportivo {
    public partial class PagoCuota : Form {
        private Padding padding;
        Form form;
        E_Socio socio;
        private uint IdCuota;
        private string formaDePago;
        public PagoCuota(E_Socio socio, Form form) {
            this.form = form;
            this.socio = socio;
            padding = new Padding();
            InitializeComponent();
            button2.BackColor = Color.Gray;
            padding = groupBox1.Margin;
            padding.Bottom = 80;
            groupBox1.Margin = padding;
        }

        private void button3_Click(object sender, EventArgs e) {
            form.Show();
            this.Close();
        }

        private void showCuotas(object sender, EventArgs e) {
            textOrSelectionChanged(sender, e);
            if (radioButton2.Checked) {
                padding = groupBox1.Margin;
                padding.Bottom = 25;
                groupBox1.Margin = padding;
                groupBox2.Visible = true;
            } else {
                padding = groupBox1.Margin;
                padding.Bottom = 80;
                groupBox1.Margin = padding;
                groupBox2.Visible = false;
            }
        }

        private void textOrSelectionChanged(object sender, EventArgs e) {
            string soloNumeros = String.Concat((textBox1.Text.Where(Char.IsDigit).ToArray()));
            button1.Enabled = ((radioButton1.Checked || radioButton2.Checked) && !String.IsNullOrWhiteSpace(soloNumeros)) ? true : false;
            formaDePago = (radioButton1.Checked) ? radioButton1.Text : radioButton2.Text;
        }

        private void button1_Click(object sender, EventArgs e) {
            button1.Enabled = false;
            string query = "update cuota set Pagada = true, FechaPago = now() " +
                "where cuota.Id = " +
                Convert.ToString(IdCuota) + ";";
            string rta;
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                rta = (comando.ExecuteNonQuery() > 0) ? "Operación realizada exitosamente": "Hubo un error";
            }
            catch (Exception ex) {
                rta = ex.Message;
                MessageBox.Show(rta);
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            MessageBox.Show(rta);
            if(rta == "Operación realizada exitosamente") {
                button2.Enabled = true;
                button2.BackColor = (button2.Enabled) ? Color.MediumSpringGreen : Color.Gray;
            }
        }

        private void guardarID(object sender, EventArgs e) {
            if (button1.Enabled) IdCuota = Convert.ToUInt32(String.Concat((textBox1.Text.Where(Char.IsDigit).ToArray())));
        }

        private void button2_Click(object sender, EventArgs e) {
            ComprobantePago comprobantePago = new ComprobantePago(form, socio, Convert.ToString(IdCuota),formaDePago);
            comprobantePago.Show();
            this.Close();
        }

    }
}
