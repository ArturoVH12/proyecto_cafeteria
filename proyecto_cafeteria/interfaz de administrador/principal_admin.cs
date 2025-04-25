using proyecto_cafeteria.interfaz_principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cafeteria.interfaz_de_administrador
{
    public partial class principal_admin : Form

    {
        private UserAdmin userAdmin = new UserAdmin();
        private UserCategoria2 userCategoria2 = new UserCategoria2();
        private UserPedidos2 userPedidos2 = new UserPedidos2();
        private UserInventario2 userInventario2 = new UserInventario2();
        private UserVentas userVentas = new UserVentas();
        private UserAyuda userAyuda = new UserAyuda();
        public principal_admin()
        {
            InitializeComponent();
            userAdmin.Dock = DockStyle.Fill;
            userCategoria2.Dock = DockStyle.Fill;
            userPedidos2.Dock = DockStyle.Fill;
            userInventario2.Dock = DockStyle.Fill;
            userVentas.Dock = DockStyle.Fill;
            userAyuda.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(userAyuda);
            panel_contenedor.Controls.Add(userVentas);
            panel_contenedor.Controls.Add(userInventario2);
            panel_contenedor.Controls.Add(userPedidos2);
            panel_contenedor.Controls.Add(userCategoria2);
            panel_contenedor.Controls.Add(userAdmin);

            userAdmin.Visible = true;
            userCategoria2.Visible = false;
            userPedidos2.Visible = false;
            userInventario2.Visible = false;
            userVentas.Visible = false;
            userAyuda.Visible = false;
            userAdmin.BringToFront();

            panel3.Height = btn_perfil.Height;
            panel3.Top = btn_perfil.Top;
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            userAdmin.Visible = true;
            userCategoria2.Visible = false;
            userAdmin.BringToFront();
            panel3.Height = btn_perfil.Height;
            panel3.Top = btn_perfil.Top;
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            userAdmin.Visible = false;
            userCategoria2.Visible = true;
            userCategoria2.BringToFront();
            panel3.Height = btn_cat.Height;
            panel3.Top = btn_cat.Top;
        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {

            userAdmin.Visible = false;
            userPedidos2.Visible = true;
            userCategoria2.Visible = false;
            userPedidos2.BringToFront();
            panel3.Height = btn_pedidos.Height;
            panel3.Top = btn_pedidos.Top;
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            userAdmin.Visible = false;
            userPedidos2.Visible = false;
            userCategoria2.Visible = false;
            userInventario2.Visible = true;
            userInventario2.BringToFront();
            panel3.Height = btn_inventario.Height;
            panel3.Top = btn_inventario.Top;
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            userAdmin.Visible = false;
            userPedidos2.Visible = false;
            userCategoria2.Visible = false;
            userInventario2.Visible = false;
            userVentas.Visible = true;
            userVentas.BringToFront();
            panel3.Height = btn_ventas.Height;
            panel3.Top = btn_ventas.Top;
        }
        private int panel3OldTop;
        private void btn_salir_Click(object sender, EventArgs e)
        {
            panel3OldTop = panel3.Top;
            panel3.Height = btn_salir.Height;
            panel3.Top = btn_salir.Top;

            DialogResult result = MessageBox.Show(
       "¿Estás seguro que quieres salir?",
       "Confirmar salida",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                panel3OldTop = panel3.Top;
            }
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            userAyuda.Visible = true;
            userAdmin.Visible = false;
            userPedidos2.Visible = false;
            userCategoria2.Visible = false;
            userInventario2.Visible = false;
            userVentas.Visible = false;
            userAyuda.BringToFront();
            panel3.Height = btn_ayuda.Height;
            panel3.Top = btn_ayuda.Top;

        }
    }
}
