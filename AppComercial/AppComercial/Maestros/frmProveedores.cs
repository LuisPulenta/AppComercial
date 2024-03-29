﻿using CADAppComercial;
using System;
using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmProveedores : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            this.tipoDocumentoTableAdapter.Fill(this.dSAppComercial.TipoDocumento);
            this.proveedorTableAdapter.Fill(this.dSAppComercial.Proveedor);
            dgvDatos.AutoResizeColumns();
            VerificarPermisos();
        }

        private void VerificarPermisos()
        {
            bindingNavigatorAddNewItem.Enabled = CADPermisoRol.PermisoRolPuedeModificar(usuarioLogueado.IDRol, this.Name);
            bindingNavigatorEditItem.Enabled = CADPermisoRol.PermisoRolPuedeModificar(usuarioLogueado.IDRol, this.Name);
            bindingNavigatorDeleteItem.Enabled = CADPermisoRol.PermisoRolPuedeBorrar(usuarioLogueado.IDRol, this.Name);
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            proveedorBindingSource.AddNew();
            iDTipoDocumentoComboBox.Focus();
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

            if (CADCompra.ProveedorTieneCompras(Convert.ToInt32(iDProveedorTextBox.Text)))
            {
                MessageBox.Show(
                    "No se puede borrar Proveedor porque tiene movimientos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            this.Validate();
            this.proveedorBindingSource.RemoveAt(proveedorBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSAppComercial);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dSAppComercial);
                errorProvider1.Clear();
            }
            catch (Exception)
            {
                errorProvider1.SetError(documentoTextBox, "Este N° de Documento ya está asignado");
                documentoTextBox.Focus();
                return;
            }
            Habilitar(false);
            VerificarPermisos();
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.proveedorBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
            VerificarPermisos();
        }

        private void Habilitar(bool campo)
        {
            iDTipoDocumentoComboBox.Enabled = campo;
            documentoTextBox.ReadOnly = !campo;
            nombreTextBox.ReadOnly = !campo;
            nombresContactoTextBox.ReadOnly = !campo;
            apellidosContactoTextBox.ReadOnly = !campo;
            direccionTextBox.ReadOnly = !campo;
            telefono1TextBox.ReadOnly = !campo;
            telefono2TextBox.ReadOnly = !campo;
            correoTextBox.ReadOnly = !campo;
            notasTextBox.ReadOnly = !campo;

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

        private void nombresContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            ArmaNombre();
        }

        private void apellidosContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            ArmaNombre();
        }

        private void ArmaNombre()
        {
            if(iDTipoDocumentoComboBox.SelectedIndex==0)
            {
                nombreTextBox.Text = nombresContactoTextBox.Text + " " + apellidosContactoTextBox.Text;
            }    
        }

        private bool Validarcampos()
        {
            errorProvider1.Clear();
            if (iDTipoDocumentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDTipoDocumentoComboBox, "Debe seleccionar un Tipo de Documento");
                iDTipoDocumentoComboBox.Focus();
                return false;
            }

            if (documentoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(documentoTextBox, "Debe ingresar un N° de Documento");
                documentoTextBox.Focus();
                return false;
            }

            if (nombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "Debe ingresar un Nombre de Proveedor");
                nombreTextBox.Focus();
                return false;
            }

            if (nombresContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombresContactoTextBox, "Debe ingresar un Nombre de Contacto");
                nombresContactoTextBox.Focus();
                return false;
            }

            if (apellidosContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidosContactoTextBox, "Debe ingresar un Apellido de Contacto");
                apellidosContactoTextBox.Focus();
                return false;
            }

            if (correoTextBox.Text != string.Empty)
            {
                RegexUtilities regexUtilities = new RegexUtilities();
                if (!regexUtilities.IsValidEmail(correoTextBox.Text))
                {
                    errorProvider1.SetError(correoTextBox, "Si ingresa un correo, éste debe ser válido");
                    correoTextBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            int position = proveedorBindingSource.Find("IDProveedor", miBusqueda.IDElegido);
            proveedorBindingSource.Position = position;
        }
    }
}