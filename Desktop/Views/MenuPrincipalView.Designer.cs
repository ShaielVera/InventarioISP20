namespace Desktop.Views
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnWelcome = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            SubMenuArticulos = new FontAwesome.Sharp.IconMenuItem();
            SubMenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            SubMenuClientesSupabase = new FontAwesome.Sharp.IconMenuItem();
            SubMenuVehiculos = new FontAwesome.Sharp.IconMenuItem();
            SubMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            SubMenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnWelcome
            // 
            BtnWelcome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnWelcome.BackColor = SystemColors.ActiveCaption;
            BtnWelcome.Cursor = Cursors.Hand;
            BtnWelcome.IconChar = FontAwesome.Sharp.IconChar.HeartPulse;
            BtnWelcome.IconColor = Color.Black;
            BtnWelcome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnWelcome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnWelcome.Location = new Point(12, 394);
            BtnWelcome.Name = "BtnWelcome";
            BtnWelcome.Size = new Size(139, 44);
            BtnWelcome.TabIndex = 0;
            BtnWelcome.Text = "Saludo";
            BtnWelcome.UseVisualStyleBackColor = false;
            BtnWelcome.Click += BtnWelcome_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SubMenuArticulos, SubMenuCategorias, SubMenuClientes, SubMenuClientesSupabase, SubMenuVehiculos });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(122, 20);
            iconMenuItem1.Text = "Principal";
            // 
            // SubMenuArticulos
            // 
            SubMenuArticulos.IconChar = FontAwesome.Sharp.IconChar.Bars;
            SubMenuArticulos.IconColor = Color.Black;
            SubMenuArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuArticulos.Name = "SubMenuArticulos";
            SubMenuArticulos.Size = new Size(192, 22);
            SubMenuArticulos.Text = "Articulos";
            SubMenuArticulos.Click += SubMenuArticulos_Click;
            // 
            // SubMenuCategorias
            // 
            SubMenuCategorias.IconChar = FontAwesome.Sharp.IconChar.Cube;
            SubMenuCategorias.IconColor = Color.Black;
            SubMenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuCategorias.Name = "SubMenuCategorias";
            SubMenuCategorias.Size = new Size(192, 22);
            SubMenuCategorias.Text = "Categorías";
            SubMenuCategorias.Click += SubMenuCategorias_Click;
            // 
            // SubMenuClientesSupabase
            // 
            SubMenuClientesSupabase.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            SubMenuClientesSupabase.IconColor = Color.Black;
            SubMenuClientesSupabase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuClientesSupabase.Name = "SubMenuClientesSupabase";
            SubMenuClientesSupabase.Size = new Size(192, 22);
            SubMenuClientesSupabase.Text = "Clientes con Supabase";
            SubMenuClientesSupabase.Click += SubMenuClientesSupabase_Click;
            // 
            // SubMenuVehiculos
            // 
            SubMenuVehiculos.IconChar = FontAwesome.Sharp.IconChar.Car;
            SubMenuVehiculos.IconColor = Color.Black;
            SubMenuVehiculos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuVehiculos.Name = "SubMenuVehiculos";
            SubMenuVehiculos.Size = new Size(192, 22);
            SubMenuVehiculos.Text = "Vehiculos";
            SubMenuVehiculos.Click += SubMenuVehiculos_Click;
            // 
            // SubMenuClientes
            // 
            SubMenuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            SubMenuClientes.IconColor = Color.Black;
            SubMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuClientes.Name = "SubMenuClientes";
            SubMenuClientes.Size = new Size(192, 22);
            SubMenuClientes.Text = "Clientes";
            SubMenuClientes.Click += SubMenuClientes_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { SubMenuSalirDelSistema });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(57, 20);
            iconMenuItem2.Text = "Salir";
            // 
            // SubMenuSalirDelSistema
            // 
            SubMenuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            SubMenuSalirDelSistema.IconColor = Color.Black;
            SubMenuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuSalirDelSistema.Name = "SubMenuSalirDelSistema";
            SubMenuSalirDelSistema.Size = new Size(159, 22);
            SubMenuSalirDelSistema.Text = "Salir del Sistema";
            SubMenuSalirDelSistema.Click += SubMenuSalirDelSistema_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnWelcome);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "MenuPrincipalView";
            Text = "Sistema de Inventario ISP20 - 2do año TSDS";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnWelcome;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem SubMenuArticulos;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem SubMenuSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem SubMenuCategorias;
        private FontAwesome.Sharp.IconMenuItem SubMenuClientes;
        private FontAwesome.Sharp.IconMenuItem SubMenuClientesSupabase;
        private FontAwesome.Sharp.IconMenuItem SubMenuVehiculos;
    }
}
