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
    public partial class frmReporteUtilidad : Form
    {
        public frmReporteUtilidad()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            cryReporteUtilidadACostoPromedio miReporte = new cryReporteUtilidadACostoPromedio();
            DSAppComercial miDS = new DSAppComercial();
            ReporteDeUtilidadACostoPromedioTableAdapter miAdaptador = new ReporteDeUtilidadACostoPromedioTableAdapter();

            if(todasLasFechasCheckBox.Checked)
            {
                miAdaptador.Fill(miDS.ReporteDeUtilidadACostoPromedio);
            }
            else
            {
                string desde = desdeDateTimePicker.Value.Year.ToString() + '-' + desdeDateTimePicker.Value.Month.ToString() + '-' + desdeDateTimePicker.Value.Day.ToString();
                string hasta = hastaDateTimePicker.Value.Year.ToString() + '-' + hastaDateTimePicker.Value.Month.ToString() + '-' + hastaDateTimePicker.Value.Day.ToString();
                miAdaptador.FillByDesdeAndHasta(miDS.ReporteDeUtilidadACostoPromedio,desde,hasta);
            }

            
            
            miReporte.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miReporte;
        }

        private void todasLasFechasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(todasLasFechasCheckBox.Checked)
            {
                desdeDateTimePicker.Enabled = false;
                hastaDateTimePicker.Enabled = false;
            }
            else
            {
                desdeDateTimePicker.Enabled = true;
                hastaDateTimePicker.Enabled = true;
            }
        }
    }
}
