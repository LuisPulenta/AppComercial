
namespace AppComercial.Reportes
{
    partial class frmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.porVentaRadioButton = new System.Windows.Forms.RadioButton();
            this.porClienteRadioButton = new System.Windows.Forms.RadioButton();
            this.sinFiltroRadioButton = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppComercial = new AppComercial.DSAppComercial();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.ventaComboBox = new System.Windows.Forms.ComboBox();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new AppComercial.DSAppComercialTableAdapters.ClienteTableAdapter();
            this.ventaTableAdapter = new AppComercial.DSAppComercialTableAdapters.VentaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 661);
            this.panel1.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1343, 661);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // verReporteButton
            // 
            this.verReporteButton.Image = ((System.Drawing.Image)(resources.GetObject("verReporteButton.Image")));
            this.verReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verReporteButton.Location = new System.Drawing.Point(1032, 15);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(143, 49);
            this.verReporteButton.TabIndex = 4;
            this.verReporteButton.Text = "Ver Reporte";
            this.verReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.verReporteButton.UseVisualStyleBackColor = true;
            this.verReporteButton.Click += new System.EventHandler(this.verReporteButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.porVentaRadioButton);
            this.groupBox1.Controls.Add(this.porClienteRadioButton);
            this.groupBox1.Controls.Add(this.sinFiltroRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 40);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // porVentaRadioButton
            // 
            this.porVentaRadioButton.AutoSize = true;
            this.porVentaRadioButton.Location = new System.Drawing.Point(281, 13);
            this.porVentaRadioButton.Name = "porVentaRadioButton";
            this.porVentaRadioButton.Size = new System.Drawing.Size(92, 21);
            this.porVentaRadioButton.TabIndex = 2;
            this.porVentaRadioButton.TabStop = true;
            this.porVentaRadioButton.Text = "Por Venta";
            this.porVentaRadioButton.UseVisualStyleBackColor = true;
            this.porVentaRadioButton.CheckedChanged += new System.EventHandler(this.porVentaRadioButton_CheckedChanged);
            // 
            // porClienteRadioButton
            // 
            this.porClienteRadioButton.AutoSize = true;
            this.porClienteRadioButton.Location = new System.Drawing.Point(158, 13);
            this.porClienteRadioButton.Name = "porClienteRadioButton";
            this.porClienteRadioButton.Size = new System.Drawing.Size(98, 21);
            this.porClienteRadioButton.TabIndex = 1;
            this.porClienteRadioButton.TabStop = true;
            this.porClienteRadioButton.Text = "Por Cliente";
            this.porClienteRadioButton.UseVisualStyleBackColor = true;
            this.porClienteRadioButton.CheckedChanged += new System.EventHandler(this.porClienteRadioButton_CheckedChanged);
            // 
            // sinFiltroRadioButton
            // 
            this.sinFiltroRadioButton.AutoSize = true;
            this.sinFiltroRadioButton.Checked = true;
            this.sinFiltroRadioButton.Location = new System.Drawing.Point(49, 13);
            this.sinFiltroRadioButton.Name = "sinFiltroRadioButton";
            this.sinFiltroRadioButton.Size = new System.Drawing.Size(84, 21);
            this.sinFiltroRadioButton.TabIndex = 0;
            this.sinFiltroRadioButton.TabStop = true;
            this.sinFiltroRadioButton.Text = "Sin Filtro";
            this.sinFiltroRadioButton.UseVisualStyleBackColor = true;
            this.sinFiltroRadioButton.CheckedChanged += new System.EventHandler(this.sinFiltroRadioButton_CheckedChanged);
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataSource = this.clienteBindingSource;
            this.clienteComboBox.DisplayMember = "NombreComercial";
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(482, 27);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(433, 24);
            this.clienteComboBox.TabIndex = 7;
            this.clienteComboBox.ValueMember = "IDCliente";
            this.clienteComboBox.Visible = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dSAppComercial;
            // 
            // dSAppComercial
            // 
            this.dSAppComercial.DataSetName = "DSAppComercial";
            this.dSAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente:";
            this.label2.Visible = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(960, 27);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarCliente.TabIndex = 8;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Visible = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // ventaComboBox
            // 
            this.ventaComboBox.DataSource = this.ventaBindingSource;
            this.ventaComboBox.DisplayMember = "Venta";
            this.ventaComboBox.FormattingEnabled = true;
            this.ventaComboBox.Location = new System.Drawing.Point(482, 27);
            this.ventaComboBox.Name = "ventaComboBox";
            this.ventaComboBox.Size = new System.Drawing.Size(433, 24);
            this.ventaComboBox.TabIndex = 10;
            this.ventaComboBox.ValueMember = "IDVenta";
            this.ventaComboBox.Visible = false;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.dSAppComercial;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(960, 27);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarVenta.TabIndex = 11;
            this.btnBuscarVenta.Text = "...";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Venta:";
            this.label1.Visible = false;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.ventaComboBox);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Ventas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button verReporteButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton porVentaRadioButton;
        private System.Windows.Forms.RadioButton porClienteRadioButton;
        private System.Windows.Forms.RadioButton sinFiltroRadioButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ComboBox ventaComboBox;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label label1;
        private DSAppComercial dSAppComercial;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DSAppComercialTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DSAppComercialTableAdapters.VentaTableAdapter ventaTableAdapter;
    }
}