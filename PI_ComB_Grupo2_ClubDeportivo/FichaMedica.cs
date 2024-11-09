using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using PI_ComB_Grupo2_ClubDeportivo.Entidades.Inscripcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_ComB_Grupo2_ClubDeportivo {
    public partial class FichaMedica : Form {

        private NewAspirante NewAspirante;
        private AdministrarSocio AdministrarSocio;
        private bool SocioExistente;
        private E_FichaMedica fichaMedica;

        public FichaMedica(uint? dni) {
            fichaMedica = new E_FichaMedica();
            fichaMedica.DNI = dni;
            SocioExistente = true;
            InitializeComponent();
        }
        public FichaMedica(string? nombre, string? apellido ,uint? dni, NewAspirante newAspirante) {
            NewAspirante = newAspirante;
            fichaMedica = new E_FichaMedica();
            fichaMedica.Nombre = nombre;
            fichaMedica.Apellido = apellido;
            fichaMedica.DNI = dni;
            SocioExistente = false;
            InitializeComponent();
        }

        public FichaMedica(E_Socio socio, AdministrarSocio administrarSocio) { 
            AdministrarSocio = administrarSocio;
            fichaMedica = new E_FichaMedica(socio);
            SocioExistente = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            fichaMedica.PuedeRealizarActividadFisica = checkBox1.Checked;
            fichaMedica.ConsumeMedicamentos = checkBox2.Checked;
            fichaMedica.enfPreex = textBox1.Text;
            fichaMedica.Observaciones = textBox2.Text;

            //Cargar Ficha a base de datos.
            cargarABase();

            //Regresar
            if (SocioExistente) {
                AdministrarSocio.Show();
            } else { 
                NewAspirante.MainWindow.Show();
                NewAspirante.Close();
            }
            this.Close();
        }

        private void cargarABase() {
            Datos.Socios dbSocio = new Datos.Socios();
            string rta = dbSocio.insertFicha(fichaMedica);
            MessageBoxIcon icon = (rta == "Ficha Medica Cargada Correctamente.") ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            MessageBox.Show(rta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, icon);
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            if (SocioExistente) {    
                AdministrarSocio.Show();
                this.Close();
                return;
            }
            NewAspirante.Show();
            this.Close();
        }
    }
}
