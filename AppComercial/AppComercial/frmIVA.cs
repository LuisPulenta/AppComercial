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
    public partial class frmIVA : Form
    {
        public frmIVA()
        {
            InitializeComponent();
        }

        private void frmIVA_Load(object sender, EventArgs e)
        {
            this.iVATableAdapter.Fill(this.dSAppComercial.IVA);
            dgvDatos.AutoResizeColumns();
        }

        private void Habilitar(bool campo)
        {
            descripcionTextBox.ReadOnly = !campo;
            tarifaTextBox.ReadOnly = !campo;

            bindingNavigatorEditItem.Enabled = !campo;
            bindingNavigatorAddNewItem.Enabled = !campo;
            bindingNavigatorDeleteItem.Enabled = !campo;
            bindingNavigatorSaveItem.Enabled = campo;
            bindingNavigatorCancelItem.Enabled = campo;

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
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una  descripción para el IVA");
                descripcionTextBox.Focus();
                return false;
            }

            if (tarifaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(tarifaTextBox, "Debe ingresar una  tarifa");
                tarifaTextBox.Focus();
                return false;
            }

            float iva;
            if (!float.TryParse(tarifaTextBox.Text, out iva))
            {
                errorProvider1.SetError(tarifaTextBox, "Debe ingresar un valor numérico");
                tarifaTextBox.Focus();
                return false;
            }

            if (iva <= 0)
            {
                errorProvider1.SetError(tarifaTextBox, "Debe ingresar un valor mayor a 0");
                tarifaTextBox.Focus();
                return false;
            }

            return true;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.iVABindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.iVABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAppComercial);
            Habilitar(false);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            iVABindingSource.AddNew();
            descripcionTextBox.Focus();
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
            this.iVABindingSource.RemoveAt(iVABindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSAppComercial);
        }
    }
}
