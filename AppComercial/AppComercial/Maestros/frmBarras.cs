using CADAppComercial;
using System;
using System.Windows.Forms;

namespace AppComercial
{
    public partial class frmBarras : Form
    {
        private long barra=0;

        public long Barra { get => barra; }

        public frmBarras()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(barraTextBox.Text==string.Empty)
            {
                errorProvider1.SetError(barraTextBox, "Debe ingresar un Código de Barras");
                barraTextBox.Focus();
                return;
            }

            if (!long.TryParse(barraTextBox.Text,out barra))
            {
                errorProvider1.SetError(barraTextBox, "El Código de Barras debe ser un N° entero");
                barraTextBox.Focus();
                return;
            }

            if (barra <1000000)
            {
                errorProvider1.SetError(barraTextBox, "El Código de Barras debe ser un N° de por lo menos 7 cifras");
                barraTextBox.Focus();
                return;
            }

            if (CADBarra.ExisteBarra(barra))
            {
                errorProvider1.SetError(barraTextBox, "Este Código de Barras ya existe para otro Producto");
                barraTextBox.Focus();
                return;
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            barra = 0;
            this.Close();
        }

        private void frmBarras_Load(object sender, EventArgs e)
        {

        }
    }
}
