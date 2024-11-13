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
    public partial class AdministrarSocio : Form {
        private MainWindow MainWindow;
        private E_Socio Socio;
        public AdministrarSocio(MainWindow mainWindow, E_Socio socio) {
            InitializeComponent();
            MainWindow = mainWindow;
            this.Socio = socio;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
            MainWindow.Show();
        }



        private void button2_Click(object sender, EventArgs e) {
            FichaMedica completarFicha = new FichaMedica(Socio, this);
            completarFicha.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) {
            CarnetSocio carnetSocio = new CarnetSocio(Socio, this);
            carnetSocio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) {
            GrillaCuotasSocio grillaCuotasSocio = new GrillaCuotasSocio(Socio, this);
            grillaCuotasSocio.Show();
            this.Hide();
        }

        private void onLoad(object sender, EventArgs e) {
            label1.Text = "Nombre: " + Socio.Nombre + " " + Socio.Apellido +
                "\nDNI: " + Socio.DNI;
        }

        private void button5_Click(object sender, EventArgs e) {
            PagoCuota pagoCuota = new PagoCuota(Socio, this);
            pagoCuota.Show();
            this.Hide();
        }
    }
}
