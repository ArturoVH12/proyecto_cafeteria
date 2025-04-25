using proyecto_cafeteria.interfaz_de_administrador;
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
using static proyecto_cafeteria.Form1;

namespace proyecto_cafeteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class usuarios
        {
            public string nombre { get; set; }
            public string contraseña { get; set; }
            public string rol { get; set; }

        }
        private List<usuarios> usuariosFicticios = new List<usuarios>
        {
              new usuarios { nombre = "admin", contraseña = "123", rol = "admin" },
    new usuarios { nombre = "mario", contraseña = "1234", rol = "empleado" },
        };

        private bool Autenticar(string usuario, string contraseña, out string rol)
        {
            rol = null;
            var user = usuariosFicticios.FirstOrDefault(u =>
                u.nombre == usuario && u.contraseña == contraseña);

            if (user != null)
            {
                rol = user.rol;
                return true;
            }
            return false;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string rol;
            if (Autenticar(txtUsuario.Text, txtContraseña.Text, out rol))
            {
                MessageBox.Show($"Bienvenido, {txtUsuario.Text} ({rol})");

                // Oculta el formulario de login
                this.Hide();

                // Redirige según el rol
                if (rol == "admin")
                {
                    principal_admin adminForm = new principal_admin();
                    adminForm.FormClosed += (s, args) => this.Close(); // Cierra el login al salir
                    adminForm.Show();
                }
                else
                {
                    interfaz empleadoForm = new interfaz();
                    empleadoForm.FormClosed += (s, args) => this.Close(); // Cierra el login al salir
                    empleadoForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperacion recuperacion = new Recuperacion();
            recuperacion.Show();
            this.Hide();
        }
    }
}
