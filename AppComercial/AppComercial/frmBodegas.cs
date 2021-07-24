using System;
using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmBodegas : Form
    {
        public frmBodegas()
        {
            InitializeComponent();
        }

        private void frmBodegas_Load(object sender, EventArgs e)
        {
            this.bodegaTableAdapter.Fill(this.dSAppComercial.Bodega);
            dgvDatos.AutoResizeColumns();
        }

        private void Habilitar(bool campo)
        {
            descripcionTextBox.ReadOnly = !campo;

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

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private bool Validarcampos()
        {
            errorProvider1.Clear();

            if (descripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una  descripción para la Bodega");
                descripcionTextBox.Focus();
                return false;
            }

            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.bodegaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAppComercial);
            Habilitar(false);
        }
     
        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.bodegaBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            bodegaBindingSource.AddNew();
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
            this.bodegaBindingSource.RemoveAt(bodegaBindingSource.Position);

        }
    }
}