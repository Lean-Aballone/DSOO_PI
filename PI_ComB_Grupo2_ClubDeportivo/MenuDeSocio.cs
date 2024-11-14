using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using PI_ComB_Grupo2_ClubDeportivo.Entidades.Inscripcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_ComB_Grupo2_ClubDeportivo {
    public partial class MenuDeSocio : Form {
        public MainWindow MainWindow { set; get; }
        private Actividades actividades;
        Form form;
        public MenuDeSocio(MainWindow MainWindow) {
            this.MainWindow = MainWindow;
            this.form = MainWindow;
            InitializeComponent();
        }
        public MenuDeSocio(Actividades actividades) {
            this.actividades = actividades;
            this.form = actividades;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e) {
            form.Show();
            this.Close();
        }

        private void socioExiste(uint n, bool esDNI) {
            Datos.Socios dato = new Datos.Socios();
            E_Socio socio = dato.getSocioFromDatabase(n, esDNI);
            if (socio.DNI.Equals(null)) { return; }
            siguienteVentana(socio);
        }

        private void siguienteVentana(E_Socio socio) {
            if (form.GetType() == typeof(MainWindow)) {
                AdministrarSocio administrarSocio = new AdministrarSocio((MainWindow)form, socio);
                administrarSocio.Show();
                this.Close();
            }
            if (form.GetType() == typeof(Actividades)) {
                actividades.Show();
                actividades.setLabel(socio);
                this.Close();

            }
            
        }

        private void button1_Click(object sender, EventArgs e) {
            bool esDNI = true;
            if (!String.IsNullOrEmpty(this.textBox1.Text)) {
                uint dni = Convert.ToUInt32(this.textBox1.Text);
                socioExiste(dni, esDNI);
            } else {
                if (!String.IsNullOrEmpty(this.textBox2.Text)) {
                    uint idSocio = Convert.ToUInt32(this.textBox2.Text);
                    socioExiste(idSocio, !esDNI);
                } else {
                    MessageBox.Show("Se debe completar al menos uno de los campos.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
