namespace Desktop.Views
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        #region Código para el boton de saludo
        private void BtnWelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, Bienvenidos a mi aplicacion de escritorio!");
        }
        #endregion

        private void SubMenuSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMenuArticulos_Click(object sender, EventArgs e)
        {
            ArticulosViews articulosViews = new();
            articulosViews.MdiParent = this;
            articulosViews.Show();
        }

        private void SubMenuCategorias_Click(object sender, EventArgs e)
        {
            CategoriasView categoriasView = new();
            categoriasView.MdiParent = this;
            categoriasView.Show();
        }

        private void SubMenuClientes_Click(object sender, EventArgs e)
        {
            ClientesView clientesview = new();
            clientesview.ShowDialog();
        }
    }
}