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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void LoginFormContainer_Paint(object sender, PaintEventArgs e) {

        }

        private void Login_Load(object sender, EventArgs e) {

        }
        
        private void btnIngresarClick(object sender, EventArgs e) {
            
            Datos.Usuarios dato = new Datos.Usuarios();
            E_Usuario usuario = dato.ReadUsuario(textBox1.Text, textBox2.Text);

            if (usuario.NombreUsu == "ERROR") {
                MessageBox.Show(usuario.RolUsu, "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainWindow mainWindow = new MainWindow();

                mainWindow.usuario = usuario;
                mainWindow.Show();
                this.Hide();
            
            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
