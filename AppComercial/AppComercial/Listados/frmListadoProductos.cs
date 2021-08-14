using AppComercial.DSAppComercialTableAdapters;
using System;
using System.Windows.Forms;

namespace AppComercial.Listados
{
    public partial class frmListadoProductos : Form
    {
        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            cryListadoProductos miReporte = new cryListadoProductos();
            DSAppComercial miDS = new DSAppComercial();
            ListadoProductosTableAdapter miAdaptador = new ListadoProductosTableAdapter();
            errorProvider1.Clear();
            if(todosCheckBox.Checked)
            {
                miAdaptador.Fill(miDS.ListadoProductos);
                departamentoComboBox.SelectedIndex = -1;
                departamentoComboBox.Enabled = false;
            }
            else
            {
                departamentoComboBox.Enabled = true;
                if (departamentoComboBox.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(departamentoComboBox, "Debe seleccionar un Departamento");
                        return;
                    }
                miAdaptador.FillBy(miDS.ListadoProductos,(int)departamentoComboBox.SelectedValue);
            }
            miReporte.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miReporte;
        }

        private void frmListadoProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.FillBy(this.dSAppComercial.Departamento);
            departamentoComboBox.SelectedIndex = -1;
            departamentoComboBox.Enabled = false;
        }

        private void todosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(todosCheckBox.Checked)
            {
                departamentoComboBox.Enabled = false;
            }
            else
            {
                departamentoComboBox.Enabled = true;
            }
        }
    }
}
