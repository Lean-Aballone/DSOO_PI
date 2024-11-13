using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Datos;
using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_ComB_Grupo2_ClubDeportivo {
    public partial class ComprobantePago : Form {
        E_Socio socio;
        Form form;
        string idCuota;
        string formaDePago;
        string monto;
        string tipoDeCuota;
        public ComprobantePago(Form form, E_Socio socio, string id, string formaDePago) {
            this.form = form;
            this.socio = socio;
            this.idCuota = id;
            this.formaDePago = formaDePago;
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            form.Show();
            this.Close();
        }

        private void onLoad(object sender, EventArgs e) {
            label3.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            if (obtenerDatos()) {
                label4.Text = socio.Nombre + " " + socio.Apellido +
               "\nAbona la cuota ID: " + idCuota +
               " (" + tipoDeCuota +
               ")\nForma de Pago: " + formaDePago +
               "\nMonto: $" + monto;
            }
        }
        private bool obtenerDatos() {
            string query = "select formadePago.Cobro, cuota.Monto from formadepago inner join cuota on formadepago.IdSocio = cuota.IdSocio where cuota.Id = ";
            query += idCuota + ";";
            MySqlConnection sqlCon = new MySqlConnection();
            bool exito;
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                    tipoDeCuota = reader.GetString(0);
                    monto = Convert.ToString(reader.GetDouble(1));
                }
                exito = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                exito = false;
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return exito;
        }

        private void button1_Click(object sender, EventArgs e) {
            button1.Visible = false;
            button2.Visible = false;
            imprimirCarnet();
            button1.Visible = true;
            button2.Visible = true;
            button2_Click(sender, e);
        }

        private void imprimirCarnet() {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK) {
                pd.Print();
                MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Impresión cancelada", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ImprimirForm1(object o, PrintPageEventArgs e) {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(0, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
