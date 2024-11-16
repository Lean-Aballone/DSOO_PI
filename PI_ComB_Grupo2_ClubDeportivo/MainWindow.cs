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
    public partial class MainWindow : Form {

        public E_Usuario usuario { set; get; }
        public MainWindow() {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e) {
            label1.Text += " " + usuario.NombreUsu + " (" + usuario.RolUsu + ")";
            button1.Enabled = (usuario.RolUsu == "Administrador" || usuario.RolUsu == "Recepcionista");
            button2.Enabled = (usuario.RolUsu == "Administrador" || usuario.RolUsu == "Recepcionista");
            button3.Enabled = (usuario.RolUsu == "Administrador" || usuario.RolUsu == "Profesor");
            if (button3.Enabled) button3.Text = "Inscribir en actividad";
            //button4.Enabled = (usuario.RolUsu == "Administrador");
        }

        private void btnSalirClick(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            NewAspirante newAspirante = new NewAspirante(this);
            newAspirante.usuario = usuario;
            newAspirante.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {
            MenuDeSocio menuDeSocio = new MenuDeSocio(this);
            menuDeSocio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) {
            PanelDeControl panelDeControl = new PanelDeControl(this);
            panelDeControl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) {
            //Actividades actividades = new Actividades(this);
            //MenuDeSocio menuDeSocio = new MenuDeSocio(actividades);
            //menuDeSocio.Show();
            SocioNoSocio socioNoSocio = new SocioNoSocio(this); 
            socioNoSocio.Show();
            this.Hide();
        }
    }
}
