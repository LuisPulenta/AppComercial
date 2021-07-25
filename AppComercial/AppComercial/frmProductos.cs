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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSAppComercial.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.BodegaProducto' Puede moverla o quitarla según sea necesario.
            this.bodegaProductoTableAdapter.Fill(this.dSAppComercial.BodegaProducto);
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Barra' Puede moverla o quitarla según sea necesario.
            this.barraTableAdapter.Fill(this.dSAppComercial.Barra);
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Medida' Puede moverla o quitarla según sea necesario.
            this.medidaTableAdapter.Fill(this.dSAppComercial.Medida);
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.IVA' Puede moverla o quitarla según sea necesario.
            this.iVATableAdapter.Fill(this.dSAppComercial.IVA);
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dSAppComercial.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dSAppComercial.Producto);
            dgvDatos.AutoResizeColumns();
            barrasDataGridView.AutoResizeColumns();
            bodegasDataGridView.AutoResizeColumns();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAppComercial);

        }
    }
}
