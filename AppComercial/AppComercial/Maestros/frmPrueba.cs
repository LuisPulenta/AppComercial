using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComercial.Maestros
{
    public partial class frmPrueba : Form
    {
        public frmPrueba()
        {
            InitializeComponent();
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSistema.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dSSistema.Rol);
            // TODO: esta línea de código carga datos en la tabla 'dSSistema.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dSSistema.Rol);

        }
    }
}
