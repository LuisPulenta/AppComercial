
namespace AppComercial.Reportes
{
    partial class frmValorInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValorInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ultimoCostoRadioButton = new System.Windows.Forms.RadioButton();
            this.costoPromedioRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bodegaComboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppComercial = new AppComercial.DSAppComercial();
            this.todasLasBodegasCheckBox = new System.Windows.Forms.CheckBox();
            this.bodegaTableAdapter = new AppComercial.DSAppComercialTableAdapters.BodegaTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.positivosRadioButton = new System.Windows.Forms.RadioButton();
            this.negativosRadioButton = new System.Windows.Forms.RadioButton();
            this.todosRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.panel1.TabIndex = 2;
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
            this.verReporteButton.Location = new System.Drawing.Point(1009, 22);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(143, 49);
            this.verReporteButton.TabIndex = 5;
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
            this.groupBox1.Controls.Add(this.ultimoCostoRadioButton);
            this.groupBox1.Controls.Add(this.costoPromedioRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 62);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valorización";
            // 
            // ultimoCostoRadioButton
            // 
            this.ultimoCostoRadioButton.AutoSize = true;
            this.ultimoCostoRadioButton.Location = new System.Drawing.Point(150, 24);
            this.ultimoCostoRadioButton.Name = "ultimoCostoRadioButton";
            this.ultimoCostoRadioButton.Size = new System.Drawing.Size(108, 21);
            this.ultimoCostoRadioButton.TabIndex = 1;
            this.ultimoCostoRadioButton.TabStop = true;
            this.ultimoCostoRadioButton.Text = "Último Costo";
            this.ultimoCostoRadioButton.UseVisualStyleBackColor = true;
            // 
            // costoPromedioRadioButton
            // 
            this.costoPromedioRadioButton.AutoSize = true;
            this.costoPromedioRadioButton.Checked = true;
            this.costoPromedioRadioButton.Location = new System.Drawing.Point(15, 24);
            this.costoPromedioRadioButton.Name = "costoPromedioRadioButton";
            this.costoPromedioRadioButton.Size = new System.Drawing.Size(129, 21);
            this.costoPromedioRadioButton.TabIndex = 0;
            this.costoPromedioRadioButton.TabStop = true;
            this.costoPromedioRadioButton.Text = "Costo Promedio";
            this.costoPromedioRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bodegaComboBox);
            this.groupBox2.Controls.Add(this.todasLasBodegasCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(282, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 62);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bodegas";
            // 
            // bodegaComboBox
            // 
            this.bodegaComboBox.DataSource = this.bodegaBindingSource;
            this.bodegaComboBox.DisplayMember = "Descripcion";
            this.bodegaComboBox.Enabled = false;
            this.bodegaComboBox.FormattingEnabled = true;
            this.bodegaComboBox.Location = new System.Drawing.Point(83, 24);
            this.bodegaComboBox.Name = "bodegaComboBox";
            this.bodegaComboBox.Size = new System.Drawing.Size(260, 24);
            this.bodegaComboBox.TabIndex = 1;
            this.bodegaComboBox.ValueMember = "IDBodega";
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSAppComercial;
            // 
            // dSAppComercial
            // 
            this.dSAppComercial.DataSetName = "DSAppComercial";
            this.dSAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todasLasBodegasCheckBox
            // 
            this.todasLasBodegasCheckBox.AutoSize = true;
            this.todasLasBodegasCheckBox.Checked = true;
            this.todasLasBodegasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todasLasBodegasCheckBox.Location = new System.Drawing.Point(7, 27);
            this.todasLasBodegasCheckBox.Name = "todasLasBodegasCheckBox";
            this.todasLasBodegasCheckBox.Size = new System.Drawing.Size(70, 21);
            this.todasLasBodegasCheckBox.TabIndex = 0;
            this.todasLasBodegasCheckBox.Text = "Todas";
            this.todasLasBodegasCheckBox.UseVisualStyleBackColor = true;
            this.todasLasBodegasCheckBox.CheckedChanged += new System.EventHandler(this.todasLasBodegasCheckBox_CheckedChanged);
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.positivosRadioButton);
            this.groupBox3.Controls.Add(this.negativosRadioButton);
            this.groupBox3.Controls.Add(this.todosRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(687, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 62);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saldos";
            // 
            // positivosRadioButton
            // 
            this.positivosRadioButton.AutoSize = true;
            this.positivosRadioButton.Location = new System.Drawing.Point(207, 24);
            this.positivosRadioButton.Name = "positivosRadioButton";
            this.positivosRadioButton.Size = new System.Drawing.Size(85, 21);
            this.positivosRadioButton.TabIndex = 2;
            this.positivosRadioButton.TabStop = true;
            this.positivosRadioButton.Text = "Positivos";
            this.positivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // negativosRadioButton
            // 
            this.negativosRadioButton.AutoSize = true;
            this.negativosRadioButton.Location = new System.Drawing.Point(99, 24);
            this.negativosRadioButton.Name = "negativosRadioButton";
            this.negativosRadioButton.Size = new System.Drawing.Size(92, 21);
            this.negativosRadioButton.TabIndex = 1;
            this.negativosRadioButton.TabStop = true;
            this.negativosRadioButton.Text = "Negativos";
            this.negativosRadioButton.UseVisualStyleBackColor = true;
            // 
            // todosRadioButton
            // 
            this.todosRadioButton.AutoSize = true;
            this.todosRadioButton.Checked = true;
            this.todosRadioButton.Location = new System.Drawing.Point(15, 24);
            this.todosRadioButton.Name = "todosRadioButton";
            this.todosRadioButton.Size = new System.Drawing.Size(69, 21);
            this.todosRadioButton.TabIndex = 0;
            this.todosRadioButton.TabStop = true;
            this.todosRadioButton.Text = "Todos";
            this.todosRadioButton.UseVisualStyleBackColor = true;
            // 
            // frmValorInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmValorInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor Inventario";
            this.Load += new System.EventHandler(this.frmValorInventario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button verReporteButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ultimoCostoRadioButton;
        private System.Windows.Forms.RadioButton costoPromedioRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox bodegaComboBox;
        private System.Windows.Forms.CheckBox todasLasBodegasCheckBox;
        private DSAppComercial dSAppComercial;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSAppComercialTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton positivosRadioButton;
        private System.Windows.Forms.RadioButton negativosRadioButton;
        private System.Windows.Forms.RadioButton todosRadioButton;
    }
}