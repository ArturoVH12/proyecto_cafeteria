using proyecto_cafeteria.interfaz_principal;
using proyecto_cafeteria.recuperar_contraseña;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cafeteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            interfaz interfaz = new interfaz();
            interfaz.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperacion recuperacion = new Recuperacion();
            recuperacion.Show();
            this.Hide();
        }
    }
}
