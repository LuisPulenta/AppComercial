using AppComercial.DSAppComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComercial.Reportes
{
    public partial class frmReporteVentas : Form
    {
        private int idVenta;

        public int IdVenta { get => idVenta; set => idVenta = value; }

        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            cryReporteVentas miReporte = new cryReporteVentas();
            DSAppComercial miDS = new DSAppComercial();
            ReporteVentasTableAdapter miAdaptador = new ReporteVentasTableAdapter();
            errorProvider1.Clear();
            if(sinFiltroRadioButton.Checked)
            {
                miAdaptador.Fill(miDS.ReporteVentas);
            }
            else if(porClienteRadioButton.Checked)
            {
                if(clienteComboBox.SelectedIndex==-1)
                {
                    errorProvider1.SetError(clienteComboBox, "Debe seleccionar un Cliente");
                    clienteComboBox.Focus();
                    return;
                }
                miAdaptador.FillByIDCliente(miDS.ReporteVentas,(int)clienteComboBox.SelectedValue);
            }
            else
            {
                if (ventaComboBox.SelectedIndex == -1)
                {
                    errorProvider1.SetError(ventaComboBox, "Debe seleccionar una Venta");
                    ventaComboBox.Focus();
                    return;
                }
                miAdaptador.FillByIDVenta(miDS.ReporteVentas, (int)ventaComboBox.SelectedValue);
            }
            
            miReporte.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miReporte;
        }

        private void sinFiltroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void porClienteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void porVentaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void ActualizaFiltro()
        {
            if(sinFiltroRadioButton.Checked)
            {
                label2.Visible = false;
                clienteComboBox.Visible = false;
                btnBuscarCliente.Visible = false;
                label1.Visible = false;
                ventaComboBox.Visible = false;
                btnBuscarVenta.Visible = false;
            }
            else if (porClienteRadioButton.Checked)
            {
                label2.Visible = true;
                clienteComboBox.Visible = true;
                btnBuscarCliente.Visible = true;
                label1.Visible = false;
                ventaComboBox.Visible = false;
                btnBuscarVenta.Visible = false;
            }
            else if (porVentaRadioButton.Checked)
            {
                label2.Visible = false;
                clienteComboBox.Visible = false;
                btnBuscarCliente.Visible = false;
                label1.Visible = true;
                ventaComboBox.Visible = true;
                btnBuscarVenta.Visible = true;
            }
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            this.ventaTableAdapter.Fill(this.dSAppComercial.Venta);
            this.clienteTableAdapter.FillBy2(this.dSAppComercial.Cliente);
            clienteComboBox.SelectedIndex = -1;
            ventaComboBox.SelectedIndex = -1;

            if (idVenta!=0)
            {
                cryReporteVentas miReporte = new cryReporteVentas();
                DSAppComercial miDS = new DSAppComercial();
                ReporteVentasTableAdapter miAdaptador = new ReporteVentasTableAdapter();
                miAdaptador.FillByIDVenta(miDS.ReporteVentas, idVenta);
                miReporte.SetDataSource(miDS);
                crystalReportViewer1.ReportSource = miReporte;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            clienteComboBox.SelectedValue = miBusqueda.IDElegido;
        }
    }
}