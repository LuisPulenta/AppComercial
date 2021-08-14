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
    public partial class frmMedidas : Form
    {
        public frmMedidas()
        {
            InitializeComponent();
        }

        private void frmMedidas_Load(object sender, EventArgs e)
        {
            this.medidaTableAdapter.Fill(this.dSAppComercial.Medida);
            dgvDatos.AutoResizeColumns();
        }

        private void Habilitar(bool campo)
        {
            iDMedidaTextBox.ReadOnly = !campo;
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

        private bool Validarcampos()
        {
            errorProvider1.Clear();

            if (iDMedidaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(iDMedidaTextBox, "Debe ingresar una Unidad");
                iDMedidaTextBox.Focus();
                return false;
            }

            if (iDMedidaTextBox.Text.Length !=2)
            {
                errorProvider1.SetError(iDMedidaTextBox, "La Unidad debe ser de 2 caracteres");
                iDMedidaTextBox.Focus();
                return false;
            }

            if (descripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una  descripción para la Unidad de Medida");
                descripcionTextBox.Focus();
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
            this.medidaBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                iDMedidaTextBox.Text = iDMedidaTextBox.Text.ToUpper();
                if (!Validarcampos()) return;
                this.Validate();
                this.medidaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSAppComercial);
                Habilitar(false);
            }
            catch (Exception)
            {
                errorProvider1.SetError(iDMedidaTextBox, "Este Unidad ya existe");
                iDMedidaTextBox.Focus();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            medidaBindingSource.AddNew();
            iDMedidaTextBox.Focus();
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


            try
            {
                this.Validate();
                this.medidaBindingSource.RemoveAt(medidaBindingSource.Position);
                this.tableAdapterManager.UpdateAll(this.dSAppComercial);
            }
            catch (Exception)
            {
                MessageBox.Show("Esta Unidad no se puede eliminar porque tiene Registros Relacionados", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.medidaTableAdapter.Fill(this.dSAppComercial.Medida);
            }
        }
    }
}