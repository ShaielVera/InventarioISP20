using Consola.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class ArticulosViews : Form
    {
        public ArticulosViews()
        {
            InitializeComponent();
        }

        private void BtnAgregarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno1 = new Alumno("Shaiel", "Vera");
            ListAlumnos.Items.Add(alumno1);
        }
    }
}
