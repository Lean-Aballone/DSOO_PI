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
        private uint IdCuota;
        public PagoCuota() {
            padding = new Padding();
            InitializeComponent();
            button2.BackColor = Color.Gray;
            padding = groupBox1.Margin;
            padding.Bottom = 80;
            groupBox1.Margin = padding;
        }

        private void button3_Click(object sender, EventArgs e) {
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
        }

        private void button1_Click(object sender, EventArgs e) {
            button1.Enabled = false;

            //MessageBox.Show(IdCuota.ToString());

            //TODO: Si el pago fue exitoso.
            // 0) Guardar en base de datos.
            // 1) Mostrar Mensaje
            // 2) Activar boton de generar comprobante
            button2.Enabled = button1.Enabled;
            button2.BackColor = (button2.Enabled) ? Color.MediumSpringGreen : Color.Gray;
        }

        private void guardarID(object sender, EventArgs e) {
            if (button1.Enabled) IdCuota = Convert.ToUInt32(String.Concat((textBox1.Text.Where(Char.IsDigit).ToArray())));
        }
    }
}
