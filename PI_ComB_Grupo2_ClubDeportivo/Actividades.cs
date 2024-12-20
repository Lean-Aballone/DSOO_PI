﻿using MySql.Data.MySqlClient;
using PI_ComB_Grupo2_ClubDeportivo.Datos;
using PI_ComB_Grupo2_ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_ComB_Grupo2_ClubDeportivo {
    public partial class Actividades : Form {
        E_Socio socio;
        Image original;
        Form form;
        public bool inscripcionAbonada { get; set; }
        string actividad;
        string soloNumeros;
        bool esSocio;
        public Actividades(Form form) {
            this.form = form;
            esSocio = false;
            InitializeComponent();
            listBox1.Enabled = false;
            original = pictureBox1.Image;
            pictureBox1.Image = MakeGrayscale((Bitmap)pictureBox1.Image);

        }

        public Actividades(Form form, E_Socio socio) {
            this.esSocio = true;
            this.form = form;
            this.socio = socio;
            InitializeComponent();
            original = pictureBox1.Image;
            pictureBox1.Image = MakeGrayscale((Bitmap)pictureBox1.Image);
        }


        public void setLabel(E_Socio socio) {
            tableLayoutPanel2.Visible = false;
            this.socio = socio;
            label1.Text = socio.Nombre + " " + socio.Apellido + 
                "\nEstado: " + (((bool)socio.activo) ? "activo" : "Inactivo") +
                "\nFicha Medica: " + ((socio.FichaMedica is not null) ? "Si" : "No");
            label1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e) {
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (esSocio) {
                ActividadSocio(); 
            }
            else { 
                E_NoSocio noSocio = new E_NoSocio();
                noSocio.Nombre = textBox1.Text + (listBox1.SelectedIndex + 1).ToString(); 
                noSocio.Apellido = textBox2.Text;
                noSocio.DNI = Convert.ToUInt32(soloNumeros);
                PagoCuota pagoCuota = new PagoCuota(noSocio, this);
                pagoCuota.Show();
                this.Hide();
            }
        }

        private void ActividadSocio() {
            string query = "INSERT INTO actividad_socio (IdActividad, IdSocio) VALUES (" +
                    (listBox1.SelectedIndex + 1).ToString() +
                    "," + socio.IdSocio + ");";
            string rta;
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                rta = (comando.ExecuteNonQuery() > 0) ? "Operación realizada exitosamente" : "Hubo un error";
            }
            catch (Exception ex) {
                rta = ex.Message;
                MessageBox.Show(rta);
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            MessageBox.Show(rta);
            if (rta == "Operación realizada exitosamente") {
                button2.Enabled = true;
                button2.BackColor = (button2.Enabled) ? Color.MediumSpringGreen : Color.Gray;
            }
        }

        public Bitmap MakeGrayscale(Bitmap original) {
            Bitmap newBmp = new Bitmap(original.Width, original.Height);
            Graphics g = Graphics.FromImage(newBmp);
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                   new float[] {.3f, .3f, .3f, 0, 0},
                   new float[] {.59f, .59f, .59f, 0, 0},
                   new float[] {.11f, .11f, .11f, 0, 0},
                   new float[] {0, 0, 0, 1, 0},
                   new float[] {0, 0, 0, 0, 1}
               });
            ImageAttributes img = new ImageAttributes();
            img.SetColorMatrix(colorMatrix);
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, img);
            g.Dispose();
            return newBmp;
        }

        private void actividadSeleccionada(object sender, EventArgs e) {
            if (socio is not null) {
                if ((bool)socio.activo && socio.FichaMedica is not null) {
                    actividad = listBox1.SelectedItem.ToString();
                    pictureBox1.Image = original;
                    button2.Enabled = true;
                }
            } else {
                if ( !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text)) {
                    listBox1.Enabled = true;
                    soloNumeros = String.Concat((textBox3.Text.Where(Char.IsDigit).ToArray()));
                    if (listBox1.SelectedItem is not null) { 
                        actividad = listBox1.SelectedItem.ToString(); 
                        pictureBox1.Image = original;
                        button2.Enabled = true;
                    }
                }
            }
        }
    }
}
