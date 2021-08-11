using CADAppComercial;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmDevolucionClientes : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private List<DevolucionClienteDisponible> misDisponibles = new List<DevolucionClienteDisponible>();
        private List<DevolucionClienteDevuelto> misDevueltos = new List<DevolucionClienteDevuelto>();

        public frmDevolucionClientes()
        {
            InitializeComponent();
        }

        private void frmDevolucionClientes_Load(object sender, EventArgs e)
        {
            this.bodegaTableAdapter.Fill(this.dSAppComercial.Bodega);
            this.clienteTableAdapter.Fill(this.dSAppComercial.Cliente);
            this.ventaTableAdapter.Fill(this.dSAppComercial.Venta);
            ventaComboBox.SelectedIndex = -1;
            clienteComboBox.SelectedIndex = -1;
            bodegaComboBox.SelectedIndex = -1;
            dgvDatosDisponible.DataSource = misDisponibles;
            dgvDatosDevuelto.DataSource = misDevueltos;
        }

        private void ventaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ventaComboBox.SelectedValue == null) return;
            CADVenta miVenta = CADVenta.VentasGetVentaByIDVenta((int)ventaComboBox.SelectedValue);
            fechaTextBox.Text = miVenta.Fecha.ToString();
            bodegaComboBox.SelectedValue = miVenta.IDBodega;
            clienteComboBox.SelectedValue = miVenta.IDCliente;

            CADAppComercial.DSAppComercial.VentaDetalleDataTable miTabla = CADVentaDetalle.VentaDetalleGetVentaDetalleByIDVenta(miVenta.IDVenta);
            misDisponibles.Clear();
            foreach(CADAppComercial.DSAppComercial.VentaDetalleRow miRegistro in miTabla.Rows)
            {
                DevolucionClienteDisponible miDisponible = new DevolucionClienteDisponible();
                miDisponible.CantidadDevuelta = 0;
                miDisponible.CantidadOriginal = (float)miRegistro.Cantidad;
                miDisponible.Descripcion = miRegistro.Descripcion;
                miDisponible.IDProducto = miRegistro.IDProducto;
                miDisponible.PorcentajeDescuento = (float)miRegistro.PorcentajeDescuento;
                miDisponible.PorcentajeIVA = (float)miRegistro.PorcentajeIVA;
                miDisponible.Precio = miRegistro.Precio;
                misDisponibles.Add(miDisponible);
            }
            dgvDatosDisponible.DataSource = null;
            dgvDatosDisponible.DataSource = misDisponibles;
            PersonalizarDisponibles();
            dgvDatosDisponible.AutoResizeColumns();
        }

        private void PersonalizarDisponibles()
        {
            dgvDatosDisponible.Columns["IDProducto"].HeaderText = "ID Producto";
            dgvDatosDisponible.Columns["IDProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatosDisponible.Columns["Descripcion"].HeaderText = "Descripción";

            dgvDatosDisponible.Columns["Precio"].HeaderText = "Precio";
            dgvDatosDisponible.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["Precio"].DefaultCellStyle.Format = "C2";

            dgvDatosDisponible.Columns["CantidadOriginal"].HeaderText = "Cant. Orig.";
            dgvDatosDisponible.Columns["CantidadOriginal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["CantidadOriginal"].DefaultCellStyle.Format = "N2";

            dgvDatosDisponible.Columns["PorcentajeIVA"].HeaderText = "% IVA";
            dgvDatosDisponible.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2";

            dgvDatosDisponible.Columns["PorcentajeDescuento"].HeaderText = "% Descuento";
            dgvDatosDisponible.Columns["PorcentajeDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["PorcentajeDescuento"].DefaultCellStyle.Format = "P2";

            dgvDatosDisponible.Columns["CantidadDevuelta"].HeaderText = "Cant. Dev.";
            dgvDatosDisponible.Columns["CantidadDevuelta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["CantidadDevuelta"].DefaultCellStyle.Format = "N2";

            dgvDatosDisponible.Columns["CantidadDisponible"].HeaderText = "Cant. Disp.";
            dgvDatosDisponible.Columns["CantidadDisponible"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["CantidadDisponible"].DefaultCellStyle.Format = "N2";


            //dgvDatosDisponible.AutoResizeColumns();

            dgvDatosDisponible.Columns["IDProducto"].Width = 80;
            dgvDatosDisponible.Columns["Descripcion"].Width = 200;
            dgvDatosDisponible.Columns["CantidadOriginal"].Width = 80;
            dgvDatosDisponible.Columns["Precio"].Width = 80;
            dgvDatosDisponible.Columns["PorcentajeIVA"].Width = 80;
            dgvDatosDisponible.Columns["PorcentajeDescuento"].Width = 80;
            dgvDatosDisponible.Columns["CantidadDevuelta"].Width = 80;
            dgvDatosDisponible.Columns["CantidadDisponible"].Width = 80;
        }
    }
}