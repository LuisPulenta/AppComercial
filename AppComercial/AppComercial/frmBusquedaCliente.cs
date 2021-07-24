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
    public partial class frmBusquedaCliente : Form
    {
        private int idElegido;

        public int IDElegido { get => idElegido; }

        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void frmBusquedaCliente_Load(object sender, EventArgs e)
        {
            this.tipoDocumentoTableAdapter.Fill(this.dSAppComercial.TipoDocumento);
            this.clienteTableAdapter.Fill(this.dSAppComercial.Cliente);
            dgvDatos.AutoResizeColumns();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string documento, nombreComercial, nombreContacto, apellidoContacto;

            if (rbtContenga.Checked)
            {
                documento = "%" + documentoToolStripTextBox.Text + "%";
                nombreComercial = "%" + nombreComercialToolStripTextBox.Text + "%";
                nombreContacto = "%" + nombresContactoToolStripTextBox.Text + "%";
                apellidoContacto = "%" + apellidosContactoToolStripTextBox.Text + "%";
            }

            else if (rbtEmpiece.Checked)
            {
                documento = documentoToolStripTextBox.Text + "%";
                nombreComercial = nombreComercialToolStripTextBox.Text + "%";
                nombreContacto = nombresContactoToolStripTextBox.Text + "%";
                apellidoContacto = apellidosContactoToolStripTextBox.Text + "%";
            }
            else if (rbtTermina.Checked)
            {
                documento = "%" + documentoToolStripTextBox.Text;
                nombreComercial = "%" + nombreComercialToolStripTextBox.Text;
                nombreContacto = "%" + nombresContactoToolStripTextBox.Text;
                apellidoContacto = "%" + apellidosContactoToolStripTextBox.Text;
            }
            else
            {
                documento = documentoToolStripTextBox.Text;
                nombreComercial = nombreComercialToolStripTextBox.Text;
                nombreContacto = nombresContactoToolStripTextBox.Text;
                apellidoContacto = apellidosContactoToolStripTextBox.Text;
            }
            try
            {
                this.clienteTableAdapter.FillBy(
                    this.dSAppComercial.Cliente,
                    documento,
                    nombreComercial,
                    nombreContacto,
                    apellidoContacto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            documentoToolStripTextBox.Text = string.Empty;
            nombreComercialToolStripTextBox.Text = string.Empty;
            nombresContactoToolStripTextBox.Text = string.Empty;
            apellidosContactoToolStripTextBox.Text = string.Empty;
            fillByToolStripButton_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idElegido = 0;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                idElegido = 0;
            }
            else if (dgvDatos.SelectedRows.Count != 0)
            {
                idElegido = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                idElegido = Convert.ToInt32(dgvDatos.Rows[0].Cells[0].Value);
            }
            this.Close();
        }
    }
}