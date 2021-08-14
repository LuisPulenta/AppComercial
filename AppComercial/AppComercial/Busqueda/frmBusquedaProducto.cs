using System;
using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmBusquedaProducto : Form
    {
        private int idElegido;

        public int IDElegido { get => idElegido; }

        public frmBusquedaProducto()
        {
            InitializeComponent();
        }

        private void frmBusquedaProducto_Load(object sender, EventArgs e)
        {
            this.iVATableAdapter.Fill(this.dSAppComercial.IVA);
            this.departamentoTableAdapter.Fill(this.dSAppComercial.Departamento);
            this.productoTableAdapter.Fill(this.dSAppComercial.Producto);
            dgvDatos.AutoResizeColumns();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string descripcion;

            if (rbtContenga.Checked)
            {
                descripcion = "%" + descripcionToolStripTextBox.Text + "%";
            }

            else if (rbtEmpiece.Checked)
            {
                descripcion = descripcionToolStripTextBox.Text + "%";
            }
            else if (rbtTermina.Checked)
            {
                descripcion = "%" + descripcionToolStripTextBox.Text;
            }
            else
            {
                descripcion = descripcionToolStripTextBox.Text;
            }
            try
            {
                this.productoTableAdapter.FillBy(
                    this.dSAppComercial.Producto,
                    descripcion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            descripcionToolStripTextBox.Text = string.Empty;
            fillByToolStripButton_Click(sender, e);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idElegido = 0;
            this.Close();
        }
    }
}