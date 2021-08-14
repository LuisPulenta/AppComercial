
namespace AppComercial.Listados
{
    partial class frmListadoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.todosCheckBox = new System.Windows.Forms.CheckBox();
            this.dSAppComercial = new AppComercial.DSAppComercial();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.departamentoComboBox = new System.Windows.Forms.ComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new AppComercial.DSAppComercialTableAdapters.DepartamentoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 678);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1343, 678);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // verReporteButton
            // 
            this.verReporteButton.Image = ((System.Drawing.Image)(resources.GetObject("verReporteButton.Image")));
            this.verReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verReporteButton.Location = new System.Drawing.Point(582, 8);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(143, 49);
            this.verReporteButton.TabIndex = 3;
            this.verReporteButton.Text = "Ver Reporte";
            this.verReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.verReporteButton.UseVisualStyleBackColor = true;
            this.verReporteButton.Click += new System.EventHandler(this.verReporteButton_Click);
            // 
            // todosCheckBox
            // 
            this.todosCheckBox.AutoSize = true;
            this.todosCheckBox.Checked = true;
            this.todosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todosCheckBox.Location = new System.Drawing.Point(12, 22);
            this.todosCheckBox.Name = "todosCheckBox";
            this.todosCheckBox.Size = new System.Drawing.Size(70, 21);
            this.todosCheckBox.TabIndex = 0;
            this.todosCheckBox.Text = "Todos";
            this.todosCheckBox.UseVisualStyleBackColor = true;
            this.todosCheckBox.CheckedChanged += new System.EventHandler(this.todosCheckBox_CheckedChanged);
            // 
            // dSAppComercial
            // 
            this.dSAppComercial.DataSetName = "DSAppComercial";
            this.dSAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departamento:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // departamentoComboBox
            // 
            this.departamentoComboBox.DataSource = this.departamentoBindingSource;
            this.departamentoComboBox.DisplayMember = "Descripcion";
            this.departamentoComboBox.FormattingEnabled = true;
            this.departamentoComboBox.Location = new System.Drawing.Point(217, 20);
            this.departamentoComboBox.Name = "departamentoComboBox";
            this.departamentoComboBox.Size = new System.Drawing.Size(308, 24);
            this.departamentoComboBox.TabIndex = 2;
            this.departamentoComboBox.ValueMember = "IDDepartamento";
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.dSAppComercial;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 761);
            this.Controls.Add(this.departamentoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todosCheckBox);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Productos";
            this.Load += new System.EventHandler(this.frmListadoProductos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button verReporteButton;
        private System.Windows.Forms.CheckBox todosCheckBox;
        private System.Windows.Forms.Label label1;
        private DSAppComercial dSAppComercial;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox departamentoComboBox;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DSAppComercialTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
    }
}