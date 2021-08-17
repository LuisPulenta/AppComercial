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
    public partial class frmValorInventario : Form
    {
        public frmValorInventario()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            

            if (costoPromedioRadioButton.Checked)
            {
                cryValorInventarioCostoPromedio miReporte = new cryValorInventarioCostoPromedio();
                DSAppComercial miDS = new DSAppComercial();
                ReporteValorInventarioCostoPromedioTableAdapter miAdaptador = new ReporteValorInventarioCostoPromedioTableAdapter();

                if(todasLasBodegasCheckBox.Checked && todosRadioButton.Checked)
                {
                    miAdaptador.Fill(miDS.ReporteValorInventarioCostoPromedio);
                }
                else if (todasLasBodegasCheckBox.Checked && positivosRadioButton.Checked)
                {
                    miAdaptador.FillByPositivos(miDS.ReporteValorInventarioCostoPromedio);
                }
                else if (todasLasBodegasCheckBox.Checked && negativosRadioButton.Checked)
                {
                    miAdaptador.FillByNegativos(miDS.ReporteValorInventarioCostoPromedio);
                }
                else if (!todasLasBodegasCheckBox.Checked && todosRadioButton.Checked)
                {
                    if (bodegaComboBox.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                        bodegaComboBox.Focus();
                        return;
                    }
                    miAdaptador.FillByIDBodega(miDS.ReporteValorInventarioCostoPromedio,(int)bodegaComboBox.SelectedValue);
                }
                else if (!todasLasBodegasCheckBox.Checked && positivosRadioButton.Checked)
                {
                    if (bodegaComboBox.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                        bodegaComboBox.Focus();
                        return;
                    }
                    miAdaptador.FillByIDBodegaAndPositivos(miDS.ReporteValorInventarioCostoPromedio, (int)bodegaComboBox.SelectedValue);
                }
                else 
                {
                    if (bodegaComboBox.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                        bodegaComboBox.Focus();
                        return;
                    }
                    miAdaptador.FillByIDBodegaAndNegativos(miDS.ReporteValorInventarioCostoPromedio, (int)bodegaComboBox.SelectedValue);
                }
                miReporte.SetDataSource(miDS);
                crystalReportViewer1.ReportSource = miReporte;
            }
            else
            {
                cryValorInventarioUltimoCosto miReporte = new cryValorInventarioUltimoCosto();
                DSAppComercial miDS = new DSAppComercial();
                ReporteValorInventarioUltimoCostoTableAdapter miAdaptador = new ReporteValorInventarioUltimoCostoTableAdapter();
                if (todasLasBodegasCheckBox.Checked && todosRadioButton.Checked)
                {
                    miAdaptador.Fill(miDS.ReporteValorInventarioUltimoCosto);
                }
                else if (todasLasBodegasCheckBox.Checked && positivosRadioButton.Checked)
                {
                    miAdaptador.FillByPositivos(miDS.ReporteValorInventarioUltimoCosto);
                }
                else if (todasLasBodegasCheckBox.Checked && negativosRadioButton.Checked)
                {
                    miAdaptador.FillByNegativos(miDS.ReporteValorInventarioUltimoCosto);
                }
                else if (!todasLasBodegasCheckBox.Checked && todosRadioButton.Checked)
                {
                    if(bodegaComboBox.SelectedIndex==-1)
                    {
                        errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                        bodegaComboBox.Focus();
                        return;
                    }
                    miAdaptador.FillByIDBodega(miDS.ReporteValorInventarioUltimoCosto, (int)bodegaComboBox.SelectedValue);
                }
                else if (!todasLasBodegasCheckBox.Checked && positivosRadioButton.Checked)
                {
                    if (bodegaComboBox.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                        bodegaComboBox.Focus();
                        return;
                    }
                    miAdaptador.FillByIDBodegaAndPositivos(miDS.ReporteValorInventarioUltimoCosto, (int)bodegaComboBox.SelectedValue);
                }
                else
                {
                    if (bodegaComboBox.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                        bodegaComboBox.Focus();
                        return;
                    }
                    miAdaptador.FillByIDBodegaAndNegativos(miDS.ReporteValorInventarioUltimoCosto, (int)bodegaComboBox.SelectedValue);
                }
                miReporte.SetDataSource(miDS);
                crystalReportViewer1.ReportSource = miReporte;
            }
        }

        private void frmValorInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSAppComercial.Bodega);
            bodegaComboBox.SelectedIndex = -1;

        }

        private void todasLasBodegasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(todasLasBodegasCheckBox.Checked)
            {
                bodegaComboBox.Enabled = false;
                bodegaComboBox.SelectedIndex = -1;
            }
            else
            {
                bodegaComboBox.Enabled = true;
                bodegaComboBox.SelectedIndex = -1;
            }
        }
    }
}