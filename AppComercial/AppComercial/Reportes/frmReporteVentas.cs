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
            //if (todosCheckBox.Checked)
            //{
            //    miAdaptador.Fill(miDS.ListadoProductos);
            //    departamentoComboBox.SelectedIndex = -1;
            //    departamentoComboBox.Enabled = false;
            //}
            //else
            //{
            //    departamentoComboBox.Enabled = true;
            //    if (departamentoComboBox.SelectedIndex == -1)
            //    {
            //        errorProvider1.SetError(departamentoComboBox, "Debe seleccionar un Departamento");
            //        return;
            //    }
            //    miAdaptador.FillBy(miDS.ListadoProductos, (int)departamentoComboBox.SelectedValue);
            //}

            miAdaptador.Fill(miDS.ReporteVentas);
            miReporte.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miReporte;
        }
    }
}
