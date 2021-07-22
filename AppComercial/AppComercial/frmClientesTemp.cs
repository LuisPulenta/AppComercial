using CADAppComercial;
using System;
using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmClientesTemp : Form
    {
        private int i = 0;
        private bool nuevo;

        public frmClientesTemp()
        {
            InitializeComponent();
        }

        private void frmClientesTemp_Load(object sender, EventArgs e)
        {
            this.tipoDocumentoTableAdapter.FillActivos(this.dSAppComercial.TipoDocumento);
            dgvDatos.DataSource = CADCliente.GetData();
            MostrarRegistro();
            dgvDatos.AutoResizeColumns();
        }

        private void MostrarRegistro()
        {
            if (dgvDatos.Rows.Count == 0) return;
            txtIDCliente.Text = dgvDatos.Rows[i].Cells["IDCliente"].Value.ToString();
            txtNombreComercial.Text = dgvDatos.Rows[i].Cells["NombreComercial"].Value.ToString();
            txtNombreContacto.Text = dgvDatos.Rows[i].Cells["NombresContacto"].Value.ToString();
            txtApellidoContacto.Text = dgvDatos.Rows[i].Cells["ApellidosContacto"].Value.ToString();
            txtDocumento.Text = dgvDatos.Rows[i].Cells["Documento"].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[i].Cells["Direccion"].Value.ToString();
            txtTelefono1.Text = dgvDatos.Rows[i].Cells["Telefono1"].Value.ToString();
            txtTelefono2.Text = dgvDatos.Rows[i].Cells["Telefono2"].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[i].Cells["Direccion"].Value.ToString();
            txtNotas.Text = dgvDatos.Rows[i].Cells["Notas"].Value.ToString();
            txtCorreo.Text = dgvDatos.Rows[i].Cells["Correo"].Value.ToString();
            cbTipoDocumento.SelectedValue= dgvDatos.Rows[i].Cells["IDTipoDocumento"].Value;
            try
            {
                dtpAniversario.Value = Convert.ToDateTime(dgvDatos.Rows[i].Cells["Aniversario"].Value);
            }
            catch (Exception)
            {
                dtpAniversario.Value = DateTime.Now;
            }
            
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

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if(i>=dgvDatos.Rows.Count-1)return;
            i++;
            MostrarRegistro();
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (i == 0) return;
            i--;
            MostrarRegistro();
        }

        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            i=0;
            MostrarRegistro();
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            i = dgvDatos.Rows.Count-1;
            MostrarRegistro();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            nuevo = false;
        }

        private void Habilitar(bool campo)
        {
            tsbPrimero.Enabled = campo;
            tsbUltimo.Enabled = campo;
            tsbSiguiente.Enabled = campo;
            tsbAnterior.Enabled = campo;

            tsbModificar.Enabled = campo;
            tsbNuevo.Enabled = campo;
            tsbBorrar.Enabled = campo;
            tsbGuardar.Enabled = !campo;
            tsbCancelar.Enabled = !campo;
            tsbBuscar.Enabled = campo;

            txtApellidoContacto.ReadOnly = campo;
            txtCorreo.ReadOnly = campo;
            txtDireccion.ReadOnly = campo; ;
            txtDocumento.ReadOnly = campo;
            txtNombreComercial.ReadOnly = campo;
            txtNombreContacto.ReadOnly = campo;
            txtNotas.ReadOnly = campo;
            txtTelefono1.ReadOnly = campo;
            txtTelefono2.ReadOnly = campo;
            cbTipoDocumento.Enabled = !campo;
            dtpAniversario.Enabled = !campo;

            cbTipoDocumento.Focus();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            MostrarRegistro();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            nuevo = true;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIDCliente.Text = string.Empty;
            txtApellidoContacto.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtNombreComercial.Text = string.Empty;
            txtNombreContacto.Text = string.Empty;
            txtNotas.Text = string.Empty;
            txtTelefono1.Text = string.Empty;
            txtTelefono2.Text = string.Empty;
            cbTipoDocumento.SelectedIndex = -1;
            dtpAniversario.Value = DateTime.Now;

            cbTipoDocumento.Focus();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;

            if (nuevo)
            {
                CADCliente.ClienteInsert(
                    (int)cbTipoDocumento.SelectedValue,
                    txtDocumento.Text,
                    txtNombreComercial.Text,
                    txtNombreContacto.Text,
                    txtApellidoContacto.Text,
                    txtDireccion.Text,
                    txtTelefono1.Text,
                    txtTelefono2.Text,
                    txtCorreo.Text,
                    txtNotas.Text,
                    dtpAniversario.Value);
            }
            else 
            {
                CADCliente.ClienteUpdate(
                    (int)cbTipoDocumento.SelectedValue,
                    txtDocumento.Text,
                    txtNombreComercial.Text,
                    txtNombreContacto.Text,
                    txtApellidoContacto.Text,
                    txtDireccion.Text,
                    txtTelefono1.Text,
                    txtTelefono2.Text,
                    txtCorreo.Text,
                    txtNotas.Text,
                    dtpAniversario.Value,
                    Convert.ToInt32(txtIDCliente.Text));
            }

            Habilitar(true);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADCliente.GetData();
            if (nuevo) tsbUltimo_Click(sender, e);
            MostrarRegistro();
        }

        private bool Validarcampos()
        {
            errorProvider1.Clear();
            if (cbTipoDocumento.SelectedIndex==-1)
            {
                errorProvider1.SetError(cbTipoDocumento, "Debe seleccionar un Tipo de Documento");
                cbTipoDocumento.Focus();
                return false;
            }

            if (txtDocumento.Text==string.Empty)
            {
                errorProvider1.SetError(txtDocumento, "Debe ingresar un N° de Documento");
                txtDocumento.Focus();
                return false;
            }

            if (txtNombreComercial.Text == string.Empty)
            {
                errorProvider1.SetError(txtNombreComercial, "Debe ingresar un Nombre Comercial");
                txtNombreComercial.Focus();
                return false;
            }

            if (txtNombreContacto.Text == string.Empty)
            {
                errorProvider1.SetError(txtNombreContacto, "Debe ingresar un Nombre de Contacto");
                txtNombreContacto.Focus();
                return false;
            }

            if (txtApellidoContacto.Text == string.Empty)
            {
                errorProvider1.SetError(txtApellidoContacto, "Debe ingresar un Apellido de Contacto");
                txtApellidoContacto.Focus();
                return false;
            }

            return true;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
                "¿Está seguro de borrar el Registro actual?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            CADCliente.ClienteDelete(Convert.ToInt32(txtIDCliente.Text));
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADCliente.GetData();
            if (i != 0) i--;
            MostrarRegistro();
        }
    }
}