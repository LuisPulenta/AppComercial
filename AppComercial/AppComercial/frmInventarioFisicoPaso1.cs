﻿using CADAppComercial;
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
    public partial class frmInventarioFisicoPaso1 : Form
    {
        public frmInventarioFisicoPaso1()
        {
            InitializeComponent();
        }

        private void frmInventarioFisicoPaso1_Load(object sender, EventArgs e)
        {
            this.departamentoTableAdapter.FillBy1(this.dSAppComercial.Departamento);
            this.bodegaTableAdapter.Fill(this.dSAppComercial.Bodega);
            bodegaComboBox.SelectedIndex = -1;
            departamentoComboBox.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                departamentoComboBox.Enabled = true;
            }
            else
            {
                departamentoComboBox.SelectedIndex = -1;
                departamentoComboBox.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                departamentoComboBox.SelectedIndex = -1;
                departamentoComboBox.Enabled = false;
            }
            else
            {
                departamentoComboBox.Enabled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de programar el Inventario Físico?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            errorProvider1.Clear();
            if (bodegaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                bodegaComboBox.Focus();
                return;
            }
            if (radioButton2.Checked)
            {
                if (departamentoComboBox.SelectedIndex == -1)
                {
                    errorProvider1.SetError(departamentoComboBox, "Debe seleccionar un Departamento");
                    departamentoComboBox.Focus();
                    return;
                }
            }

            //Grabamos la Cabecera del Inventario

            int IDInventario = CADInventario.InventarioInsertInventario(
                fechaDateTimePicker.Value,
                (int) bodegaComboBox.SelectedValue);

            //Grabamos el Detalle del Inventario
                    //Hay que obtener la lista de productos y guardarla en InventarioDetalle

            //Mensaje Final
            MessageBox.Show(
                string.Format("El Inventario Físico {0}, fue grabado de forma exitosa. Puede proceder a hacer los Conteos.", IDInventario),
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void departamentoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
