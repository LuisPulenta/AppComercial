﻿
namespace AppComercial
{
    partial class frmBusquedaProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProveedor));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppComercial = new AppComercial.DSAppComercial();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.documentoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.documentoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombresContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.apellidosContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellidosContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iVATableAdapter = new AppComercial.DSAppComercialTableAdapters.IVATableAdapter();
            this.proveedorTableAdapter = new AppComercial.DSAppComercialTableAdapters.ProveedorTableAdapter();
            this.tipoDocumentoTableAdapter = new AppComercial.DSAppComercialTableAdapters.TipoDocumentoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarFiltros = new System.Windows.Forms.Button();
            this.rbtIgual = new System.Windows.Forms.RadioButton();
            this.rbtTermina = new System.Windows.Forms.RadioButton();
            this.rbtEmpiece = new System.Windows.Forms.RadioButton();
            this.rbtContenga = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProveedorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.iDTipoDocumentoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.nombresContactoDataGridViewTextBoxColumn,
            this.apellidosContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.proveedorBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.Location = new System.Drawing.Point(2, 105);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1296, 541);
            this.dgvDatos.TabIndex = 0;
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDTipoDocumentoDataGridViewTextBoxColumn
            // 
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IDTipoDocumento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DataSource = this.tipoDocumentoBindingSource;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.HeaderText = "Tipo Documento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.Name = "iDTipoDocumentoDataGridViewTextBoxColumn";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDTipoDocumentoDataGridViewTextBoxColumn.ValueMember = "IDTipoDocumento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSAppComercial;
            // 
            // dSAppComercial
            // 
            this.dSAppComercial.DataSetName = "DSAppComercial";
            this.dSAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombresContactoDataGridViewTextBoxColumn
            // 
            this.nombresContactoDataGridViewTextBoxColumn.DataPropertyName = "NombresContacto";
            this.nombresContactoDataGridViewTextBoxColumn.HeaderText = "Nombre Contacto";
            this.nombresContactoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombresContactoDataGridViewTextBoxColumn.Name = "nombresContactoDataGridViewTextBoxColumn";
            this.nombresContactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombresContactoDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidosContactoDataGridViewTextBoxColumn
            // 
            this.apellidosContactoDataGridViewTextBoxColumn.DataPropertyName = "ApellidosContacto";
            this.apellidosContactoDataGridViewTextBoxColumn.HeaderText = "Apellido Contacto";
            this.apellidosContactoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosContactoDataGridViewTextBoxColumn.Name = "apellidosContactoDataGridViewTextBoxColumn";
            this.apellidosContactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidosContactoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefono1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            this.telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefono1DataGridViewTextBoxColumn.Width = 125;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "Celular";
            this.telefono2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            this.telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefono2DataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            this.notasDataGridViewTextBoxColumn.Width = 125;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dSAppComercial;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentoToolStripLabel,
            this.documentoToolStripTextBox,
            this.nombreToolStripLabel,
            this.nombreToolStripTextBox,
            this.nombresContactoToolStripLabel,
            this.nombresContactoToolStripTextBox,
            this.apellidosContactoToolStripLabel,
            this.apellidosContactoToolStripTextBox,
            this.tsbBuscar});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1298, 27);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // documentoToolStripLabel
            // 
            this.documentoToolStripLabel.Name = "documentoToolStripLabel";
            this.documentoToolStripLabel.Size = new System.Drawing.Size(90, 28);
            this.documentoToolStripLabel.Text = "Documento:";
            // 
            // documentoToolStripTextBox
            // 
            this.documentoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.documentoToolStripTextBox.Name = "documentoToolStripTextBox";
            this.documentoToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // nombreToolStripLabel
            // 
            this.nombreToolStripLabel.Name = "nombreToolStripLabel";
            this.nombreToolStripLabel.Size = new System.Drawing.Size(67, 28);
            this.nombreToolStripLabel.Text = "Nombre:";
            // 
            // nombreToolStripTextBox
            // 
            this.nombreToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombreToolStripTextBox.Name = "nombreToolStripTextBox";
            this.nombreToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // nombresContactoToolStripLabel
            // 
            this.nombresContactoToolStripLabel.Name = "nombresContactoToolStripLabel";
            this.nombresContactoToolStripLabel.Size = new System.Drawing.Size(131, 28);
            this.nombresContactoToolStripLabel.Text = "Nombre Contacto:";
            // 
            // nombresContactoToolStripTextBox
            // 
            this.nombresContactoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombresContactoToolStripTextBox.Name = "nombresContactoToolStripTextBox";
            this.nombresContactoToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // apellidosContactoToolStripLabel
            // 
            this.apellidosContactoToolStripLabel.Name = "apellidosContactoToolStripLabel";
            this.apellidosContactoToolStripLabel.Size = new System.Drawing.Size(133, 28);
            this.apellidosContactoToolStripLabel.Text = "Apellido Contacto:";
            // 
            // apellidosContactoToolStripTextBox
            // 
            this.apellidosContactoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.apellidosContactoToolStripTextBox.Name = "apellidosContactoToolStripTextBox";
            this.apellidosContactoToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(29, 24);
            this.tsbBuscar.Text = "FillBy";
            this.tsbBuscar.ToolTipText = "Aplica los criterios de búsqueda seleccionados";
            this.tsbBuscar.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSAppComercial;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarFiltros);
            this.groupBox1.Controls.Add(this.rbtIgual);
            this.groupBox1.Controls.Add(this.rbtTermina);
            this.groupBox1.Controls.Add(this.rbtEmpiece);
            this.groupBox1.Controls.Add(this.rbtContenga);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo criterio";
            // 
            // btnQuitarFiltros
            // 
            this.btnQuitarFiltros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitarFiltros.Location = new System.Drawing.Point(466, 12);
            this.btnQuitarFiltros.Name = "btnQuitarFiltros";
            this.btnQuitarFiltros.Size = new System.Drawing.Size(128, 38);
            this.btnQuitarFiltros.TabIndex = 8;
            this.btnQuitarFiltros.Text = "&Quitar Filtros";
            this.btnQuitarFiltros.UseVisualStyleBackColor = true;
            this.btnQuitarFiltros.Click += new System.EventHandler(this.btnQuitarFiltros_Click);
            // 
            // rbtIgual
            // 
            this.rbtIgual.AutoSize = true;
            this.rbtIgual.Location = new System.Drawing.Point(381, 22);
            this.rbtIgual.Name = "rbtIgual";
            this.rbtIgual.Size = new System.Drawing.Size(79, 21);
            this.rbtIgual.TabIndex = 3;
            this.rbtIgual.Text = "Igual a…";
            this.rbtIgual.UseVisualStyleBackColor = true;
            // 
            // rbtTermina
            // 
            this.rbtTermina.AutoSize = true;
            this.rbtTermina.Location = new System.Drawing.Point(255, 22);
            this.rbtTermina.Name = "rbtTermina";
            this.rbtTermina.Size = new System.Drawing.Size(109, 21);
            this.rbtTermina.TabIndex = 2;
            this.rbtTermina.Text = "Termina en…";
            this.rbtTermina.UseVisualStyleBackColor = true;
            // 
            // rbtEmpiece
            // 
            this.rbtEmpiece.AutoSize = true;
            this.rbtEmpiece.Location = new System.Drawing.Point(133, 22);
            this.rbtEmpiece.Name = "rbtEmpiece";
            this.rbtEmpiece.Size = new System.Drawing.Size(116, 21);
            this.rbtEmpiece.TabIndex = 1;
            this.rbtEmpiece.Text = "Empiece por…";
            this.rbtEmpiece.UseVisualStyleBackColor = true;
            // 
            // rbtContenga
            // 
            this.rbtContenga.AutoSize = true;
            this.rbtContenga.Checked = true;
            this.rbtContenga.Location = new System.Drawing.Point(20, 22);
            this.rbtContenga.Name = "rbtContenga";
            this.rbtContenga.Size = new System.Drawing.Size(98, 21);
            this.rbtContenga.TabIndex = 0;
            this.rbtContenga.TabStop = true;
            this.rbtContenga.Text = "Contenga…";
            this.rbtContenga.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(736, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 60);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(618, 39);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 60);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1298, 648);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusquedaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Proveedores";
            this.Load += new System.EventHandler(this.frmBusquedaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private DSAppComercial dSAppComercial;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSAppComercialTableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DSAppComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSAppComercialTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDTipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel documentoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox documentoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombresContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel apellidosContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellidosContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtIgual;
        private System.Windows.Forms.RadioButton rbtTermina;
        private System.Windows.Forms.RadioButton rbtEmpiece;
        private System.Windows.Forms.RadioButton rbtContenga;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnQuitarFiltros;
    }
}