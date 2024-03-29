﻿using AppComercial.Listados;
using AppComercial.Movimientos;
using AppComercial.Reportes;
using CADAppComercial;
using System;
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
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void bodegasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmBodegas miForm = new frmBodegas();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
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
            VerificaCambioClave(sender, e);
            VerificarPermisos();
        }

        private void VerificarPermisos()
        {
            proveedoresToolStripMenuItem.Visible = CADPermisoRol.PermisoRolPuedeVer(usuarioLogueado.IDRol, "frmProveedores");
            tsbProveedores.Visible = CADPermisoRol.PermisoRolPuedeVer(usuarioLogueado.IDRol, "frmProveedores");

            bodegasToolStripMenuItem.Visible = CADPermisoRol.PermisoRolPuedeVer(usuarioLogueado.IDRol, "frmBodegas");
        }

        private void VerificaCambioClave(object sender, System.EventArgs e)
        {
            if(usuarioLogueado.FechaModificacionClave.AddDays(30)<DateTime.Now)
            {
                cambioDeClaveToolStripMenuItem_Click(sender, e);
            }
        }

        private void cambioDeClaveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmCambioClave miForm = new frmCambioClave();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.ShowDialog();
        }

        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioUsuario miForm = new frmCambioUsuario();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.ShowDialog();
            if(miForm.UsuarioLogueado!=null)
            {
                usuarioLogueado = miForm.UsuarioLogueado;
                nombresUsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombres + " " + usuarioLogueado.Apellidos;
                VerificarPermisos();
            }
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras miForm = new frmCompras();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbCompras_Click(object sender, EventArgs e)
        {
            comprasToolStripMenuItem_Click(sender, e);
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas miForm = new frmVentas();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbVentas_Click(object sender, EventArgs e)
        {
            ventasToolStripMenuItem_Click(sender, e);
        }

        private void verificarConsistenciaDeKardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de querer verificar la consistencia del Kardex?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            CADKardex.ReKardex();

            MessageBox.Show("Verificación de Kardex finalizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaKardex miForm = new frmConsultaKardex();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void dEvolucionesDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucionClientes miForm = new frmDevolucionClientes();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbDevolucionCliente_Click(object sender, EventArgs e)
        {
            dEvolucionesDeClientesToolStripMenuItem_Click(sender, e);
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalidas miForm = new frmSalidas();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbSalidas_Click(object sender, EventArgs e)
        {
            salidasToolStripMenuItem_Click(sender, e);
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListadoProductos miForm = new frmListadoProductos();
            miForm.MdiParent = this;
            //miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void trasladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraslados miForm = new frmTraslados();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbTraslados_Click(object sender, EventArgs e)
        {
            trasladosToolStripMenuItem_Click(sender, e);
        }

        private void tsbKardex_Click(object sender, EventArgs e)
        {
            kardexToolStripMenuItem_Click(sender, e);
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteVentas miForm = new frmReporteVentas();
            miForm.MdiParent = this;
            //miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void devolucionesDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDevolucionProveedores miForm = new frmDevolucionProveedores();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbDevolucionProveedor_Click(object sender, EventArgs e)
        {
            devolucionesDeProveedoresToolStripMenuItem_Click(sender, e);
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValorInventario miForm = new frmValorInventario();
            miForm.MdiParent = this;
            //miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void utilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteUtilidad miForm = new frmReporteUtilidad();
            miForm.MdiParent = this;
            //miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void programarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventarioFisicoPaso1 miForm = new frmInventarioFisicoPaso1();
            miForm.MdiParent = this;
            //miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }
    }
}