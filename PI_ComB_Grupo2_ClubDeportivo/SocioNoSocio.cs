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
    public partial class SocioNoSocio : Form {

        Form form;

        public SocioNoSocio(Form form) {
            this.form = form;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) {
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            MenuDeSocio menuDeSocio = new MenuDeSocio(this);
            menuDeSocio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {
            Actividades actividades = new Actividades(form);
            actividades.Show();
            this.Close();
        }
    }
}
