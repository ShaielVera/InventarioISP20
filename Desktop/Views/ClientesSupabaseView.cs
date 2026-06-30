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
    public partial class ClientesSupabaseView : Form
    {
        private ClientesSupabaseService clientesService = new ClientesSupabaseService();
        Cliente clienteModificado;



        public ClientesSupabaseView()
        {
            InitializeComponent();
            LoadClientes();
        }

        public async void LoadClientes()
        {
            var clientes = await clientesService.GetAllAsync();
            if (clientes != null)
            {
                dataGridCLientes.DataSource = clientes;
            }
        }

        public async void btnBuscar_Click(object sender, EventArgs e)
        {
            var clientes = await clientesService.GetAllWithFilterAsync(tbBusqueda.Text);
            if (clientes != null)
            {
                dataGridCLientes.DataSource = clientes;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente
            {
                first_name = tbNombre.Text,
                last_name = tbApellido.Text,
                dni = tbDocumento.Text,
                address = tbDireccion.Text
            };
            bool clienteGuardado;

            if (clienteModificado == null)
            {
                clienteGuardado = await clientesService.AddClienteAsync(cliente);
            }
            else
            {
                cliente.id = clienteModificado.id;
                cliente.created_at = clienteModificado.created_at;
                clienteGuardado = await clientesService.UpdateClienteAsync(cliente);
            }
            if (clienteGuardado)
            {
                MessageBox.Show("Cliente guardado exitosamente");
                LoadClientes();
                clearTextBox();
                this.tabControl1.SelectedTab = this.tpLista;
                clienteModificado = null;
            }
            else
            {
                MessageBox.Show("Error al guardar cliente");
            }
        }

        private void clearTextBox()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbDocumento.Clear();
            tbDireccion.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tpLista;
            clearTextBox();
            clienteModificado = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tpAgregarEditar;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridCLientes.CurrentRow != null)
            {
                clienteModificado = (Cliente)dataGridCLientes.CurrentRow.DataBoundItem;
                tbNombre.Text = clienteModificado.first_name;
                tbApellido.Text = clienteModificado.last_name;
                tbDocumento.Text = clienteModificado.dni;
                tbDireccion.Text = clienteModificado.address;
                this.tabControl1.SelectedTab = this.tpAgregarEditar;
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para modificar");
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
            //capturamos el cliente seleccionado en la grilla
            if (dataGridCLientes.CurrentRow != null)
            {
                var clienteAEliminar = (Cliente)dataGridCLientes.CurrentRow.DataBoundItem;
                //preguntamos si está seguro de eliminar el cliente
                var result = MessageBox.Show($"¿Está seguro de eliminar al cliente {clienteAEliminar.first_name} {clienteAEliminar.last_name}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //eliminamos el cliente
                    var clienteEliminado = await clientesService.DeleteClienteAsync((int)clienteAEliminar.id!);
                    if (clienteEliminado)
                    {
                        MessageBox.Show($"Cliente {clienteAEliminar.first_name} {clienteAEliminar.last_name} eliminado correctamente");
                        LoadClientes();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente para eliminar");
                }

            }
        }
    }
}
