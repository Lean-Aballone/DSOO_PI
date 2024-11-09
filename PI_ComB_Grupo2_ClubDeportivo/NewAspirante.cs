using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using PI_ComB_Grupo2_ClubDeportivo.Entidades.Inscripcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PI_ComB_Grupo2_ClubDeportivo {
    public partial class NewAspirante : Form {
        public MainWindow MainWindow { set; get; }
        public E_Usuario usuario { set; get; }
        private bool fichaMedicaPresentada;
        public NewAspirante(MainWindow mainWindow) {
            InitializeComponent();
            fichaMedicaPresentada = false;
            MainWindow = mainWindow;
        }

        protected void buttonIngresar_Click(object sender, EventArgs e) {

            if (textBox1.Text == "" || textBox2.Text == "" ||
                textBox3.Text == "") {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {
                E_Socio socio = new E_Socio();
                socio.Nombre = textBox1.Text;
                socio.Apellido = textBox2.Text;
                socio.DNI = Convert.ToUInt32(textBox3.Text);
                Datos.Socios dbSocio = new Datos.Socios();
                if (dbSocio.insertSocio(socio).Length != 29) {
                    MessageBox.Show("EL SOCIO YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    MessageBox.Show("Socio Ingresado Correctamente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // SI ENTREGA LA FICHA MEDICA CAMBIAR A PANTALLA FICHAMEDICA
                    // CARGAR LOS DATOS DE LA FICHA
                    if (fichaMedicaPresentada) { 
                        FichaMedica completarFicha = new FichaMedica(socio.Nombre,socio.Apellido,socio.DNI, this);
                        completarFicha.Show();
                        this.Hide();
                    }
                
                
                }
                btnLimpiar_Click(sender, e);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void buttonVolver_Click(object sender, EventArgs e) {
            MainWindow.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

            fichaMedicaPresentada = (checkBox1.Checked) ? true : false;
            
        }


    }
}
