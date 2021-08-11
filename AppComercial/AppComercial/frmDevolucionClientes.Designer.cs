
namespace AppComercial
{
    partial class frmDevolucionClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dSAppComercial = new AppComercial.DSAppComercial();
            this.ventaComboBox = new System.Windows.Forms.ComboBox();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new AppComercial.DSAppComercialTableAdapters.VentaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bodegaComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new AppComercial.DSAppComercialTableAdapters.ClienteTableAdapter();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaTableAdapter = new AppComercial.DSAppComercialTableAdapters.BodegaTableAdapter();
            this.dgvDatosDisponible = new System.Windows.Forms.DataGridView();
            this.dgvDatosDevuelto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDevuelto)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(687, 12);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarVenta.TabIndex = 7;
            this.btnBuscarVenta.Text = "...";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Venta:";
            // 
            // dSAppComercial
            // 
            this.dSAppComercial.DataSetName = "DSAppComercial";
            this.dSAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaComboBox
            // 
            this.ventaComboBox.DataSource = this.ventaBindingSource;
            this.ventaComboBox.DisplayMember = "Venta";
            this.ventaComboBox.FormattingEnabled = true;
            this.ventaComboBox.Location = new System.Drawing.Point(128, 12);
            this.ventaComboBox.Name = "ventaComboBox";
            this.ventaComboBox.Size = new System.Drawing.Size(525, 24);
            this.ventaComboBox.TabIndex = 8;
            this.ventaComboBox.ValueMember = "IDVenta";
            this.ventaComboBox.SelectedIndexChanged += new System.EventHandler(this.ventaComboBox_SelectedIndexChanged);
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.dSAppComercial;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha:";
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataSource = this.clienteBindingSource;
            this.clienteComboBox.DisplayMember = "NombreComercial";
            this.clienteComboBox.Enabled = false;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(128, 67);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(323, 24);
            this.clienteComboBox.TabIndex = 12;
            this.clienteComboBox.ValueMember = "IDCliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cliente:";
            // 
            // bodegaComboBox
            // 
            this.bodegaComboBox.DataSource = this.bodegaBindingSource;
            this.bodegaComboBox.DisplayMember = "Descripcion";
            this.bodegaComboBox.Enabled = false;
            this.bodegaComboBox.FormattingEnabled = true;
            this.bodegaComboBox.Location = new System.Drawing.Point(128, 96);
            this.bodegaComboBox.Name = "bodegaComboBox";
            this.bodegaComboBox.Size = new System.Drawing.Size(323, 24);
            this.bodegaComboBox.TabIndex = 14;
            this.bodegaComboBox.ValueMember = "IDBodega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bodega:";
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.Location = new System.Drawing.Point(128, 41);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.ReadOnly = true;
            this.fechaTextBox.Size = new System.Drawing.Size(213, 22);
            this.fechaTextBox.TabIndex = 15;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dSAppComercial;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSAppComercial;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvDatosDisponible
            // 
            this.dgvDatosDisponible.AllowUserToAddRows = false;
            this.dgvDatosDisponible.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatosDisponible.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosDisponible.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatosDisponible.Location = new System.Drawing.Point(12, 148);
            this.dgvDatosDisponible.Name = "dgvDatosDisponible";
            this.dgvDatosDisponible.ReadOnly = true;
            this.dgvDatosDisponible.RowHeadersWidth = 51;
            this.dgvDatosDisponible.RowTemplate.Height = 24;
            this.dgvDatosDisponible.Size = new System.Drawing.Size(1274, 180);
            this.dgvDatosDisponible.TabIndex = 16;
            // 
            // dgvDatosDevuelto
            // 
            this.dgvDatosDevuelto.AllowUserToAddRows = false;
            this.dgvDatosDevuelto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatosDevuelto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosDevuelto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosDevuelto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosDevuelto.Location = new System.Drawing.Point(12, 457);
            this.dgvDatosDevuelto.Name = "dgvDatosDevuelto";
            this.dgvDatosDevuelto.ReadOnly = true;
            this.dgvDatosDevuelto.RowHeadersWidth = 51;
            this.dgvDatosDevuelto.RowTemplate.Height = 24;
            this.dgvDatosDevuelto.Size = new System.Drawing.Size(1274, 180);
            this.dgvDatosDevuelto.TabIndex = 17;
            // 
            // frmDevolucionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1298, 649);
            this.Controls.Add(this.dgvDatosDevuelto);
            this.Controls.Add(this.dgvDatosDisponible);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(this.bodegaComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ventaComboBox);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevolucionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución Clientes";
            this.Load += new System.EventHandler(this.frmDevolucionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDevuelto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label label1;
        private DSAppComercial dSAppComercial;
        private System.Windows.Forms.ComboBox ventaComboBox;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DSAppComercialTableAdapters.VentaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.ComboBox bodegaComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DSAppComercialTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSAppComercialTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.DataGridView dgvDatosDevuelto;
        private System.Windows.Forms.DataGridView dgvDatosDisponible;
    }
}