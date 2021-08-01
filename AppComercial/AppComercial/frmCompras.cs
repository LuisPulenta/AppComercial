using CADAppComercial;
using System;

using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmCompras : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            this.bodegaTableAdapter.FillBy(this.dSAppComercial.Bodega);
            this.proveedorTableAdapter.FillBy1(this.dSAppComercial.Proveedor);
            proveedorComboBox.SelectedIndex = -1;
            bodegaComboBox.SelectedIndex = -1;
            fechaDateTimePicker.Value = DateTime.Now;
            productoLabel.Text = string.Empty;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDElegido;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            //productoComboBox.SelectedValue = miBusqueda.IDElegido;
        }

        private void productoTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (productoTextBox.Text==string.Empty)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Código de Producto o un Código de Barras");
                return;
            }

            long producto;
            if (!long.TryParse(productoTextBox.Text, out producto))
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un valor numérico");
                productoTextBox.Focus();
                return;
            }

            if (producto <= 0)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un valor mayor a 0");
                productoTextBox.Focus();
                return;
            }
        }
    }
}