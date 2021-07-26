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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSAppComercial.Bodega);
            this.medidaTableAdapter.Fill(this.dSAppComercial.Medida);
            this.iVATableAdapter.Fill(this.dSAppComercial.IVA);
            this.departamentoTableAdapter.Fill(this.dSAppComercial.Departamento);
            this.productoTableAdapter.Fill(this.dSAppComercial.Producto);
            LlenarGrillas();

            dgvDatos.AutoResizeColumns();
            barrasDataGridView.AutoResizeColumns();
            bodegasDataGridView.AutoResizeColumns();

        }

        private void Habilitar(bool campo)
        {
            descripcionTextBox.ReadOnly = !campo;
            iDDepartamentoComboBox.Enabled = campo;
            precioTextBox.ReadOnly = !campo;
            iDIVAComboBox.Enabled = campo;
            btnBuscarImagen.Enabled = campo;
            notasTextBox.ReadOnly = !campo;
            iDMedidaComboBox.Enabled = campo;
            medidaTextBox.ReadOnly = !campo;
            btnAgregarBarra.Enabled = campo;
            btnElminarBarra.Enabled = campo;
            btnAgregarBodega.Enabled = campo;
            btnModificarBodega.Enabled = campo;

            bindingNavigatorEditItem.Enabled = !campo;
            bindingNavigatorAddNewItem.Enabled = !campo;
            bindingNavigatorDeleteItem.Enabled = !campo;
            bindingNavigatorSaveItem.Enabled = campo;
            bindingNavigatorCancelItem.Enabled = campo;
            bindingNavigatorSearchItem.Enabled = !campo;

            bindingNavigatorMoveFirstItem.Enabled = !campo;
            bindingNavigatorMovePreviousItem.Enabled = !campo;
            bindingNavigatorMoveNextItem.Enabled = !campo;
            bindingNavigatorMoveLastItem.Enabled = !campo;
            bindingNavigatorPositionItem.Enabled = !campo;
            bindingNavigatorCountItem.Enabled = !campo;
        }

        private bool Validarcampos()
        {
            errorProvider1.Clear();

            if (descripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una Descripción");
                descripcionTextBox.Focus();
                return false;
            }

            if (iDDepartamentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDDepartamentoComboBox, "Debe seleccionar un Departamento");
                iDDepartamentoComboBox.Focus();
                return false;
            }

            if (precioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un Precio");
                precioTextBox.Focus();
                return false;
            }

            errorProvider1.Clear();
            if (iDIVAComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDIVAComboBox, "Debe seleccionar un IVA");
                iDIVAComboBox.Focus();
                return false;
            }

            errorProvider1.Clear();
            if (iDMedidaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDMedidaComboBox, "Debe seleccionar una Unidad");
                iDMedidaComboBox.Focus();
                return false;
            }

            if (medidaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(medidaTextBox, "Debe ingresar una Medida");
                medidaTextBox.Focus();
                return false;
            }
            return true;
        }


        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void LlenarGrillas()
        {
            this.barraTableAdapter.FillBy(this.dSAppComercial.Barra,Convert.ToInt32(iDProductoTextBox.Text));
            this.bodegaProductoTableAdapter.FillBy(this.dSAppComercial.BodegaProducto, Convert.ToInt32(iDProductoTextBox.Text));
        }

     
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarGrillas();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.productoBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAppComercial);
            Habilitar(false);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            productoBindingSource.AddNew();
            iDDepartamentoComboBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de borrar el Registro actual?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            this.Validate();
            this.productoBindingSource.RemoveAt(productoBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSAppComercial);

        }
    }
}
