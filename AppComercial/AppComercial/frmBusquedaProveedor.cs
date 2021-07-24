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
    public partial class frmBusquedaProveedor : Form
    {
        private int idElegido;

        public int IDElegido { get => idElegido;  }

        public frmBusquedaProveedor()
        {
            InitializeComponent();
        }

        private void frmBusquedaProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAppComercial.TipoDocumento);
            this.proveedorTableAdapter.Fill(this.dSAppComercial.Proveedor);
            dgvDatos.AutoResizeColumns();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string documento, nombre, nombreContacto, apellidoContacto;

            if(rbtContenga.Checked)
            {
                documento = "%" + documentoToolStripTextBox.Text + "%";
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                nombreContacto = "%" + nombresContactoToolStripTextBox.Text + "%";
                apellidoContacto = "%" + apellidosContactoToolStripTextBox.Text + "%";
            }

            else if (rbtEmpiece.Checked)
            {
                documento =  documentoToolStripTextBox.Text + "%";
                nombre = nombreToolStripTextBox.Text + "%";
                nombreContacto = nombresContactoToolStripTextBox.Text + "%";
                apellidoContacto = apellidosContactoToolStripTextBox.Text + "%";
            }

            else if (rbtTermina.Checked)
            {
                documento = "%" + documentoToolStripTextBox.Text;
                nombre = "%" + nombreToolStripTextBox.Text;
                nombreContacto = "%" + nombresContactoToolStripTextBox.Text;
                apellidoContacto = "%" + apellidosContactoToolStripTextBox.Text;
            }

            else 
            {
                documento = "%%";
                nombre = "%%";
                nombreContacto = "%%";
                apellidoContacto = "%%";
                if (documentoToolStripTextBox.Text != string.Empty) documento =documentoToolStripTextBox.Text;
                if (nombreToolStripTextBox.Text != string.Empty) nombre = nombreToolStripTextBox.Text;
                if (nombresContactoToolStripTextBox.Text != string.Empty) nombreContacto = nombresContactoToolStripTextBox.Text;
                if (apellidosContactoToolStripTextBox.Text != string.Empty) apellidoContacto = apellidosContactoToolStripTextBox.Text;
            }

            try
            {
                this.proveedorTableAdapter.FillBy(
                    this.dSAppComercial.Proveedor,
                    documento,
                    nombre,
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
            documentoToolStripTextBox.Text=string.Empty;
            nombreToolStripTextBox.Text = string.Empty;
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
            if(dgvDatos.Rows.Count==0)
            {
                idElegido = 0;
            }
            else if (dgvDatos.SelectedRows.Count!=0)
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
