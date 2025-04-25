using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;


namespace proyecto_cafeteria.interfaz_principal
{
    public partial class interfaz : Form
    {

        
        // 1. Declara los UserControls (asegúrate de usar los nombres correctos)
        private UserPerfil UserPerfil = new UserPerfil(); 
        private UserCategoria UserCategoria = new UserCategoria(); 
        private UserPedidos UserPedidos = new UserPedidos();
        private UserInventario userInventario = new UserInventario();
        private UserAyuda userAyuda = new UserAyuda();
       

        public interfaz()
        {
            InitializeComponent();

            UserPerfil.Dock = DockStyle.Fill;
            UserCategoria.Dock = DockStyle.Fill;
            UserPedidos.Dock = DockStyle.Fill;
            userInventario.Dock = DockStyle.Fill;
            userAyuda.Dock = DockStyle.Fill;

            panel_contenedor.Controls.Add(UserPerfil);
            panel_contenedor.Controls.Add(UserCategoria);
            panel_contenedor.Controls.Add(UserPedidos);
            panel_contenedor.Controls.Add(userInventario);
            panel_contenedor.Controls.Add(userAyuda);

            // Estado inicial
            UserPerfil.Visible = true;
            UserPerfil.BringToFront();
            UserCategoria.Visible = false;
            UserPedidos.Visible = false;
            userInventario.Visible = false;
            userAyuda.Visible = false;

            // Mueve el indicador
            panel3.Height = btn_perfil.Height;
            panel3.Top = btn_perfil.Top;

        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            
           

            UserPerfil.Visible = true;
            UserCategoria.Visible = false;
            UserPedidos.Visible = false;
            userInventario.Visible = false;
            userAyuda.Visible = false;
            UserPerfil.BringToFront(); // Asegura que esté al frente

            panel3.Height = btn_perfil.Height;
            panel3.Top = btn_perfil.Top;
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            // 7. Muestra solo UserCategoria
           

            UserCategoria.Visible = true;
            UserPerfil.Visible = false;
            UserPedidos.Visible = false;
            userInventario.Visible = false;
            userAyuda.Visible = false;
            UserCategoria.BringToFront(); // Asegura que esté al frente

            panel3.Height = btn_cat.Height;  
            panel3.Top = btn_cat.Top;
        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            UserPedidos.Visible = true;
            UserPerfil.Visible = false;
            UserCategoria.Visible = false;
            userInventario.Visible = false;
            userAyuda.Visible = false;
            UserPedidos.BringToFront();


            panel3.Height = btn_pedidos.Height;
            panel3.Top = btn_pedidos.Top;
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {

            userInventario.Visible=true;
            UserPerfil.Visible = false;
            UserCategoria.Visible = false;
            UserPedidos.Visible = false;
            userAyuda.Visible = false;
            userInventario.BringToFront();


            panel3.Height = btn_inventario.Height;
            panel3.Top = btn_inventario.Top;

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
            userInventario.Visible = false;
            UserPerfil.Visible = false;
            UserCategoria.Visible = false;
            UserPedidos.Visible = false;
            userAyuda.BringToFront();

            panel3.Height = btn_ayuda.Height;
            panel3.Top = btn_ayuda.Top;
        }
    }
}