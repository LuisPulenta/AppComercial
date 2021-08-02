using CADAppComercial;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        List<DetalleCompra> misDetalles = new List<DetalleCompra>();
        CADProducto ultimoProducto = null;

        private void frmCompras_Load(object sender, EventArgs e)
        {
            this.bodegaTableAdapter.FillBy(this.dSAppComercial.Bodega);
            this.proveedorTableAdapter.FillBy1(this.dSAppComercial.Proveedor);
            proveedorComboBox.SelectedIndex = -1;
            bodegaComboBox.SelectedIndex = -1;
            fechaDateTimePicker.Value = DateTime.Now;
            productoLabel.Text = string.Empty;
            dgvDatos.DataSource = misDetalles;
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
            productoTextBox.Text = miBusqueda.IDElegido.ToString();
            productoTextBox_Validating(sender, new System.ComponentModel.CancelEventArgs());

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

            CADProducto miProducto = CADProducto.ProductoGetProductoByIDProducto((int)producto);
            if (miProducto==null)
            {
                miProducto = CADProducto.ProductoGetProductoByIDBarra(producto);
            }
            if (miProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Producto no existe");
                productoLabel.Text = string.Empty;
                pbxImagen.Image = null;
                ultimoProducto = null;
            }
            else
            {
                productoLabel.Text = miProducto.Descripcion;
                ultimoProducto = miProducto;
                if (miProducto.Imagen == string.Empty)
                {
                    pbxImagen.Image = null;
                }
                else
                {
                    if (File.Exists(miProducto.Imagen))
                    {
                        pbxImagen.Load(miProducto.Imagen);
                    }
                    else
                    {
                        pbxImagen.Image = null;
                    }
                }
            }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ultimoProducto==null)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Producto");
                productoTextBox.Focus();
                return;
            }
            if (cantidadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar una Cantidad");
                return;
            }

            float cantidad;
            if (!float.TryParse(cantidadTextBox.Text, out cantidad))
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar un valor numérico");
                cantidadTextBox.Focus();
                return;
            }

            if (cantidad <= 0)
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar un valor mayor a 0");
                cantidadTextBox.Focus();
                return;
            }

            if (costoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(costoTextBox, "Debe ingresar un Costo");
                return;
            }

            decimal costo;
            if (!decimal.TryParse(costoTextBox.Text, out costo))
            {
                errorProvider1.SetError(costoTextBox, "Debe ingresar un valor numérico");
                costoTextBox.Focus();
                return;
            }

            if (costo <= 0)
            {
                errorProvider1.SetError(costoTextBox, "Debe ingresar un valor mayor a 0");
                costoTextBox.Focus();
                return;
            }

            float porcentajeDescuento = 0;
            if (porcentajeDescuentoTextBox.Text !=string.Empty)
            {
                if (!float.TryParse(porcentajeDescuentoTextBox.Text, out porcentajeDescuento))
                {
                    errorProvider1.SetError(porcentajeDescuentoTextBox, "Debe ingresar un valor numérico");
                    porcentajeDescuentoTextBox.Focus();
                    return;
                }

                if (porcentajeDescuento < 0 || porcentajeDescuento>100)
                {
                    errorProvider1.SetError(porcentajeDescuentoTextBox, "Debe ingresar un valor igual o mayor a 0 y menor o igual a 100");
                    porcentajeDescuentoTextBox.Focus();
                    return;
                }
                porcentajeDescuento /= 100;
            }

            DetalleCompra miDetalle = new DetalleCompra();
            miDetalle.Cantidad = cantidad;
            miDetalle.Costo = costo;
            miDetalle.Descripcion = ultimoProducto.Descripcion;
            miDetalle.IDProducto = ultimoProducto.IDProducto;
            miDetalle.PorcentajeDescuento = porcentajeDescuento;
            miDetalle.PorcentajeIVA = CADIVA.IVAGetIVAByIDIVA(ultimoProducto.IDIVA).Tarifa;

            misDetalles.Add(miDetalle);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misDetalles;
        }
    }
}