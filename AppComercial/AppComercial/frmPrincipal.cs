using CADAppComercial;
using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmPrincipal : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmClientes miForm = new frmClientes();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmProveedores miForm = new frmProveedores();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void bodegasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmBodegas miForm = new frmBodegas();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void conceptosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmConceptos miForm = new frmConceptos();
            miForm.MdiParent = this;
            miForm.Show();

        }

        private void productosToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            frmProductos miForm = new frmProductos();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void tsbClientes_Click(object sender, System.EventArgs e)
        {
            clientesToolStripMenuItem_Click(sender, e);
        }

        private void tsbProveedores_Click(object sender, System.EventArgs e)
        {
            proveedoresToolStripMenuItem_Click(sender, e);
        }

        private void tsbProductos_Click(object sender, System.EventArgs e)
        {
            productosToolStripMenuItem1_Click(sender, e);
        }

        private void departamentosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmDepartamentos miForm = new frmDepartamentos();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmMedidas miForm = new frmMedidas();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void tiposDeDocumentoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmTiposDocumento miForm = new frmTiposDocumento();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void iVAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmIVA miForm = new frmIVA();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmUsuarios miForm = new frmUsuarios();
            miForm.MdiParent = this;
            miForm.Show();

        }

        private void frmPrincipal_Load(object sender, System.EventArgs e)
        {
            nombresUsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombres + " " + usuarioLogueado.Apellidos;
        }
    }
}