using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmPrincipal : Form
    {
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
    }
}