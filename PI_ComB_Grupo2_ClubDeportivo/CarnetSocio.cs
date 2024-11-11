using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_ComB_Grupo2_ClubDeportivo {
    public partial class CarnetSocio : Form {

        private AdministrarSocio administrarSocio;
        private E_Socio socio;
        public CarnetSocio(E_Socio socio, AdministrarSocio administrarSocio) {
            this.socio = socio;
            InitializeComponent();
            this.administrarSocio = administrarSocio;
        }

        private void button2_Click(object sender, EventArgs e) {
            regresar();
        }

        private void CarnetSocio_Load(object sender, EventArgs e) {
            labelNombre.Text = socio.Nombre.ToUpper() + " " + socio.Apellido.ToUpper();
            labelFechaIngreso.Text += Convert.ToString(socio.FechaIngreso);
            labelIDSocio.Text += Convert.ToString(socio.IdSocio);
            label1.Text += DateTime.UtcNow.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e) {
            PanelBtnHide.Visible = false;
            imprimirCarnet();
            PanelBtnHide.Visible = true;
            regresar();
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

        private void regresar() {
            administrarSocio.Show();
            this.Close();
        }
    }
}
