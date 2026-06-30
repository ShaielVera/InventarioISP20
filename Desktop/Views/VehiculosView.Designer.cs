namespace Desktop.Views
{
    partial class VehiculosView
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
            dataGridVehiculos = new DataGridView();
            tpAgregarEditar = new TabPage();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            tbPatent = new TextBox();
            tbVehicle = new TextBox();
            tbBrand = new TextBox();
            tbModel = new TextBox();
            tbYear = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVehiculos).BeginInit();
            tpAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(115, 33);
            label1.TabIndex = 0;
            label1.Text = "Vehículos";
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
            tpLista.Controls.Add(dataGridVehiculos);
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
            // dataGridVehiculos
            // 
            dataGridVehiculos.AllowUserToAddRows = false;
            dataGridVehiculos.AllowUserToDeleteRows = false;
            dataGridVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVehiculos.Location = new Point(6, 81);
            dataGridVehiculos.Name = "dataGridVehiculos";
            dataGridVehiculos.ReadOnly = true;
            dataGridVehiculos.Size = new Size(645, 284);
            dataGridVehiculos.TabIndex = 0;
            // 
            // tpAgregarEditar
            // 
            tpAgregarEditar.Controls.Add(label7);
            tpAgregarEditar.Controls.Add(btnCancelar);
            tpAgregarEditar.Controls.Add(btnGuardar);
            tpAgregarEditar.Controls.Add(tbPatent);
            tpAgregarEditar.Controls.Add(tbVehicle);
            tpAgregarEditar.Controls.Add(tbBrand);
            tpAgregarEditar.Controls.Add(tbModel);
            tpAgregarEditar.Controls.Add(tbYear);
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
            btnCancelar.Location = new Point(663, 70);
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
            btnGuardar.Location = new Point(663, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 32);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tbPatent
            // 
            tbPatent.Location = new Point(126, 52);
            tbPatent.Name = "tbPatent";
            tbPatent.Size = new Size(504, 23);
            tbPatent.TabIndex = 4;
            // 
            // tbVehicle
            // 
            tbVehicle.Location = new Point(126, 118);
            tbVehicle.Name = "tbVehicle";
            tbVehicle.Size = new Size(504, 23);
            tbVehicle.TabIndex = 5;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(126, 184);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(504, 23);
            tbBrand.TabIndex = 5;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(126, 250);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(504, 23);
            tbModel.TabIndex = 6;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(126, 316);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(504, 23);
            tbYear.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(17, 251);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 3;
            label6.Text = "Modelo :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(17, 185);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 2;
            label5.Text = "Marca :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(17, 119);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "Vehiculo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 53);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 0;
            label3.Text = "Patente :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(17, 317);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 10;
            label7.Text = "Año :";
            // 
            // VehiculosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "VehiculosView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehículos";
            tabControl1.ResumeLayout(false);
            tpLista.ResumeLayout(false);
            tpLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVehiculos).EndInit();
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
        private DataGridView dataGridVehiculos;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox tbBusqueda;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox tbPatent;
        private TextBox tbVehicle;
        private TextBox tbBrand;
        private TextBox tbModel;
        private TextBox tbYear;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Label label7;
    }
}