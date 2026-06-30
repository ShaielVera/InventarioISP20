using Desktop.Models;
using Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class VehiculosView : Form
    {
        private VehiculosService vehiculosService = new VehiculosService();
        Vehiculos vehiculoModificado;



        public VehiculosView()
        {
            InitializeComponent();
            LoadVehiculos();
        }

        public async void LoadVehiculos()
        {
            var vehiculos = await vehiculosService.GetAllAsync();
            if (vehiculos != null)
            {
                dataGridVehiculos.DataSource = vehiculos;
            }
        }

        public async void btnBuscar_Click(object sender, EventArgs e)
        {
            var vehiculos = await vehiculosService.GetAllWithFilterAsync(tbBusqueda.Text);
            if (vehiculos != null)
            {
                dataGridVehiculos.DataSource = vehiculos;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            Vehiculos vehiculo = new Vehiculos
            {
                patent = tbPatent.Text,
                vehicle = tbVehicle.Text,
                brand = tbBrand.Text,
                model = tbModel.Text,
                year = tbYear.Text,
            };
            bool vehiculoGuardado;

            if (vehiculoModificado == null)
            {
                vehiculoGuardado = await vehiculosService.AddVehicleAsync(vehiculo);
            }
            else
            {
                vehiculo.id = vehiculoModificado.id;
                vehiculo.created_at = vehiculoModificado.created_at;
                vehiculoGuardado = await vehiculosService.UpdateVehicleAsync(vehiculo);
            }
            if (vehiculoGuardado)
            {
                MessageBox.Show("Vehículo guardado exitosamente");
                LoadVehiculos();
                clearTextBox();
                this.tabControl1.SelectedTab = this.tpLista;
                vehiculoModificado = null;
            }
            else
            {
                MessageBox.Show("Error al guardar vehículo");
            }
        }

        private void clearTextBox()
        {
            tbPatent.Clear();
            tbVehicle.Clear();
            tbBrand.Clear();
            tbModel.Clear();
            tbYear.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tpLista;
            clearTextBox();
            vehiculoModificado = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tpAgregarEditar;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridVehiculos.CurrentRow != null)
            {
                vehiculoModificado = (Vehiculos)dataGridVehiculos.CurrentRow.DataBoundItem;
                tbPatent.Text = vehiculoModificado.patent;
                tbVehicle.Text = vehiculoModificado.vehicle;
                tbBrand.Text = vehiculoModificado.brand;
                tbModel.Text = vehiculoModificado.model;
                tbYear.Text = vehiculoModificado.year;
                this.tabControl1.SelectedTab = this.tpAgregarEditar;
            }
            else
            {
                MessageBox.Show("Seleccione un vehículo para modificar");
            }
        }

        private void tbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Crequeamos si la tecla presionada es Enter y pulsamos el botón de buscar
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
                e.Handled = true; // Evita que el sonido de "ding" se reproduzca al presionar Enter
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            //capturamos el vehículo seleccionado en la grilla
            if (dataGridVehiculos.CurrentRow != null)
            {
                var vehiculoAEliminar = (Vehiculos)dataGridVehiculos.CurrentRow.DataBoundItem;
                //preguntamos si está seguro de eliminar el vehículo
                var result = MessageBox.Show($"¿Está seguro de eliminar el vehículo {vehiculoAEliminar.patent}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //eliminamos el vehículo
                    var vehiculoEliminado = await vehiculosService.DeleteVehicleAsync((int)vehiculoAEliminar.id!);
                    if (vehiculoEliminado)
                    {
                        MessageBox.Show($"Vehículo {vehiculoAEliminar.patent} eliminado correctamente");
                        LoadVehiculos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el vehículo");
                    }
                }
            }

            else
            {
                MessageBox.Show("Seleccione un vehículo para eliminar");
            }
        }

    }
        
}
