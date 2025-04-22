namespace proyecto_cafeteria.interfaz_principal
{
    partial class interfaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_pedidos = new System.Windows.Forms.Button();
            this.btn_cat = new System.Windows.Forms.Button();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.userInventario1 = new proyecto_cafeteria.interfaz_principal.UserInventario();
            this.userPedidos1 = new proyecto_cafeteria.interfaz_principal.UserPedidos();
            this.userPerfil1 = new proyecto_cafeteria.interfaz_principal.UserPerfil();
            this.userCategoria1 = new proyecto_cafeteria.interfaz_principal.UserCategoria();
            this.userAyuda1 = new proyecto_cafeteria.interfaz_principal.UserAyuda();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_ayuda);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_inventario);
            this.panel1.Controls.Add(this.btn_pedidos);
            this.panel1.Controls.Add(this.btn_cat);
            this.panel1.Controls.Add(this.btn_perfil);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 602);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(3, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 30);
            this.panel3.TabIndex = 7;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.ForeColor = System.Drawing.Color.Black;
            this.btn_ayuda.Image = global::proyecto_cafeteria.Properties.Resources.boton_web_de_ayuda;
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.Location = new System.Drawing.Point(12, 512);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(198, 54);
            this.btn_ayuda.TabIndex = 6;
            this.btn_ayuda.Text = "   Ayuda";
            this.btn_ayuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Black;
            this.btn_salir.Image = global::proyecto_cafeteria.Properties.Resources.cerrar_sesion;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(12, 435);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(198, 54);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "   Salir";
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.ForeColor = System.Drawing.Color.Black;
            this.btn_inventario.Image = global::proyecto_cafeteria.Properties.Resources.lista_de_verificacion;
            this.btn_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventario.Location = new System.Drawing.Point(12, 353);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(198, 54);
            this.btn_inventario.TabIndex = 4;
            this.btn_inventario.Text = "   Inventario";
            this.btn_inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.FlatAppearance.BorderSize = 0;
            this.btn_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedidos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedidos.ForeColor = System.Drawing.Color.Black;
            this.btn_pedidos.Image = global::proyecto_cafeteria.Properties.Resources.pedido;
            this.btn_pedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pedidos.Location = new System.Drawing.Point(12, 276);
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Size = new System.Drawing.Size(198, 54);
            this.btn_pedidos.TabIndex = 3;
            this.btn_pedidos.Text = "   Pedidos";
            this.btn_pedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pedidos.UseVisualStyleBackColor = true;
            this.btn_pedidos.Click += new System.EventHandler(this.btn_pedidos_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.FlatAppearance.BorderSize = 0;
            this.btn_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat.ForeColor = System.Drawing.Color.Black;
            this.btn_cat.Image = global::proyecto_cafeteria.Properties.Resources.categorias;
            this.btn_cat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cat.Location = new System.Drawing.Point(12, 207);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(198, 54);
            this.btn_cat.TabIndex = 2;
            this.btn_cat.Text = "  Categorias";
            this.btn_cat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cat.UseVisualStyleBackColor = true;
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // btn_perfil
            // 
            this.btn_perfil.FlatAppearance.BorderSize = 0;
            this.btn_perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perfil.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perfil.ForeColor = System.Drawing.Color.Black;
            this.btn_perfil.Image = global::proyecto_cafeteria.Properties.Resources.avatar;
            this.btn_perfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perfil.Location = new System.Drawing.Point(12, 146);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(198, 54);
            this.btn_perfil.TabIndex = 1;
            this.btn_perfil.Text = "   Perfil";
            this.btn_perfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_perfil.UseVisualStyleBackColor = true;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto_cafeteria.Properties.Resources.WhatsApp_Image_2025_04_15_at_6_091;
            this.pictureBox1.Location = new System.Drawing.Point(24, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel_contenedor.Controls.Add(this.userAyuda1);
            this.panel_contenedor.Controls.Add(this.userInventario1);
            this.panel_contenedor.Controls.Add(this.userPedidos1);
            this.panel_contenedor.Controls.Add(this.userPerfil1);
            this.panel_contenedor.Controls.Add(this.userCategoria1);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_contenedor.Location = new System.Drawing.Point(210, 0);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(741, 599);
            this.panel_contenedor.TabIndex = 1;
            // 
            // userInventario1
            // 
            this.userInventario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userInventario1.Location = new System.Drawing.Point(115, 46);
            this.userInventario1.Name = "userInventario1";
            this.userInventario1.Size = new System.Drawing.Size(566, 454);
            this.userInventario1.TabIndex = 4;
            // 
            // userPedidos1
            // 
            this.userPedidos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userPedidos1.Location = new System.Drawing.Point(115, 46);
            this.userPedidos1.Name = "userPedidos1";
            this.userPedidos1.Size = new System.Drawing.Size(566, 454);
            this.userPedidos1.TabIndex = 3;
            // 
            // userPerfil1
            // 
            this.userPerfil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userPerfil1.Location = new System.Drawing.Point(115, 46);
            this.userPerfil1.Name = "userPerfil1";
            this.userPerfil1.Size = new System.Drawing.Size(566, 443);
            this.userPerfil1.TabIndex = 2;
            // 
            // userCategoria1
            // 
            this.userCategoria1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userCategoria1.Location = new System.Drawing.Point(115, 46);
            this.userCategoria1.Name = "userCategoria1";
            this.userCategoria1.Size = new System.Drawing.Size(566, 443);
            this.userCategoria1.TabIndex = 1;
            // 
            // userAyuda1
            // 
            this.userAyuda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userAyuda1.Location = new System.Drawing.Point(115, 46);
            this.userAyuda1.Name = "userAyuda1";
            this.userAyuda1.Size = new System.Drawing.Size(566, 454);
            this.userAyuda1.TabIndex = 5;
            // 
            // interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 602);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "interfaz";
            this.Text = "interfaz";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Button btn_cat;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_pedidos;
       
        private System.Windows.Forms.Panel panel3;
        private UserCategoria userCategoria1;
        private UserPerfil userPerfil1;
        private UserPedidos userPedidos1;
        private UserInventario userInventario1;
        private UserAyuda userAyuda1;
    }
}