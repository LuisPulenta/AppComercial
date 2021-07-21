using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmClientesTemp : Form
    {
        public frmClientesTemp()
        {
            InitializeComponent();
        }

        private void frmClientesTemp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAppComercial.TipoDocumento);

        }

        private void fillActivosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoDocumentoTableAdapter.FillActivos(this.dSAppComercial.TipoDocumento);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillActivosToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tipoDocumentoTableAdapter.FillActivos(this.dSAppComercial.TipoDocumento);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillActivosToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.tipoDocumentoTableAdapter.FillActivos(this.dSAppComercial.TipoDocumento);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
