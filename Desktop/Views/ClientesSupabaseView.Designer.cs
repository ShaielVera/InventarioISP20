namespace Desktop.Views
{
    partial class ClientesSupabaseView
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tpLista = new TabPage();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            tbBusqueda = new TextBox();
            label2 = new Label();
            dataGridCLientes = new DataGridView();
            tpAgregarEditar = new TabPage();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            tbDireccion = new TextBox();
            tbDocumento = new TextBox();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCLientes).BeginInit();
            tpAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(353, 33);
            label1.TabIndex = 0;
            label1.Text = "Clientes con el paquete Supabase";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpLista);
            tabControl1.Controls.Add(tpAgregarEditar);
            tabControl1.Location = new Point(12, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 399);
            tabControl1.TabIndex = 1;
            // 
            // tpLista
            // 
            tpLista.Controls.Add(btnEliminar);
            tpLista.Controls.Add(btnModificar);
            tpLista.Controls.Add(btnNuevo);
            tpLista.Controls.Add(btnBuscar);
            tpLista.Controls.Add(tbBusqueda);
            tpLista.Controls.Add(label2);
            tpLista.Controls.Add(dataGridCLientes);
            tpLista.Location = new Point(4, 24);
            tpLista.Name = "tpLista";
            tpLista.Padding = new Padding(3);
            tpLista.Size = new Size(768, 371);
            tpLista.TabIndex = 0;
            tpLista.Text = "Lista";
            tpLista.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(660, 164);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 27);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(660, 120);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(102, 27);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(660, 74);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(102, 27);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(660, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 27);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBusqueda
            // 
            tbBusqueda.Location = new Point(91, 30);
            tbBusqueda.Name = "tbBusqueda";
            tbBusqueda.Size = new Size(532, 23);
            tbBusqueda.TabIndex = 2;
            tbBusqueda.KeyPress += tbBusqueda_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 31);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Buscar :";
            // 
            // dataGridCLientes
            // 
            dataGridCLientes.AllowUserToAddRows = false;
            dataGridCLientes.AllowUserToDeleteRows = false;
            dataGridCLientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCLientes.Location = new Point(6, 81);
            dataGridCLientes.Name = "dataGridCLientes";
            dataGridCLientes.ReadOnly = true;
            dataGridCLientes.Size = new Size(645, 284);
            dataGridCLientes.TabIndex = 0;
            // 
            // tpAgregarEditar
            // 
            tpAgregarEditar.Controls.Add(btnCancelar);
            tpAgregarEditar.Controls.Add(btnGuardar);
            tpAgregarEditar.Controls.Add(tbDireccion);
            tpAgregarEditar.Controls.Add(tbDocumento);
            tpAgregarEditar.Controls.Add(tbApellido);
            tpAgregarEditar.Controls.Add(tbNombre);
            tpAgregarEditar.Controls.Add(label6);
            tpAgregarEditar.Controls.Add(label5);
            tpAgregarEditar.Controls.Add(label4);
            tpAgregarEditar.Controls.Add(label3);
            tpAgregarEditar.Location = new Point(4, 24);
            tpAgregarEditar.Name = "tpAgregarEditar";
            tpAgregarEditar.Padding = new Padding(3);
            tpAgregarEditar.Size = new Size(768, 371);
            tpAgregarEditar.TabIndex = 1;
            tpAgregarEditar.Text = "Agregar/Editar";
            tpAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 20;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(667, 120);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 32);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 23;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(667, 60);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 32);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(126, 284);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(504, 23);
            tbDireccion.TabIndex = 7;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(126, 213);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(504, 23);
            tbDocumento.TabIndex = 6;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(126, 142);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(504, 23);
            tbApellido.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(126, 71);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(504, 23);
            tbNombre.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(17, 285);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 3;
            label6.Text = "Dirección :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(17, 214);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 2;
            label5.Text = "Documento :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(17, 143);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 1;
            label4.Text = "Apellido :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 72);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Nombre :";
            // 
            // ClientesSupabaseView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "ClientesSupabaseView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            tabControl1.ResumeLayout(false);
            tpLista.ResumeLayout(false);
            tpLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCLientes).EndInit();
            tpAgregarEditar.ResumeLayout(false);
            tpAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tpLista;
        private TabPage tpAgregarEditar;
        private DataGridView dataGridCLientes;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox tbBusqueda;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox tbDireccion;
        private TextBox tbDocumento;
        private TextBox tbApellido;
        private TextBox tbNombre;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}