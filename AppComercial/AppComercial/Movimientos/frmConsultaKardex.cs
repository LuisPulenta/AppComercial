using CADAppComercial;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmConsultaKardex : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmConsultaKardex()
        {
            InitializeComponent();
        }

        private void frmConsultaKardex_Load(object sender, EventArgs e)
        {
            this.bodegaTableAdapter.Fill(this.dSAppComercial.Bodega);
            bodegaComboBox.SelectedIndex = -1;
            productoLabel.Text = string.Empty;
            dgvDatos.AutoResizeColumns();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            productoTextBox.Text = miBusqueda.IDElegido.ToString();
            productoTextBox_Validated(sender, new System.ComponentModel.CancelEventArgs());
        }


        private void productoTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            pbxImagen.Image = null;
            if (productoTextBox.Text == string.Empty)
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

            CADProducto miProducto = CADProducto.ProductoGetProductoByIDProducto((int)producto);
            if (miProducto == null)
            {
                miProducto = CADProducto.ProductoGetProductoByIDBarra(producto);
            }
            if (miProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Producto no existe");
                productoLabel.Text = string.Empty;
                pbxImagen.Image = null;
                return;
            }
            else
            {
                productoLabel.Text = miProducto.Descripcion;
                if (miProducto.Imagen == string.Empty)
                {
                    pbxImagen.Image = null;
                }
                else
                {

                    if (File.Exists("Images\\" + miProducto.Imagen))
                    {
                        if (miProducto.Imagen == string.Empty)
                        {
                            pbxImagen.Image = null;
                        }
                        else
                        {
                            if (File.Exists("Images\\" + miProducto.Imagen))
                            {
                                pbxImagen.Load("Images\\" + miProducto.Imagen);
                            }
                        }
                    }
                    else
                    {
                        pbxImagen.Image = null;
                    }
                }
            }
            productoTextBox.Text = miProducto.IDProducto.ToString();
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            if (bodegaComboBox.SelectedIndex == -1 || productoTextBox.Text == string.Empty) return;

            this.kardexTableAdapter.FillBy(this.dSAppComercial.Kardex, ((int)(System.Convert.ChangeType(bodegaComboBox.SelectedValue, typeof(int)))), ((int)(System.Convert.ChangeType(productoTextBox.Text, typeof(int)))));
            dgvDatos.AutoResizeColumns();
        }

        private void bodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
    }
}
