
namespace AppComercial.Reportes
{
    partial class frmReporteUtilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteUtilidad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.positivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ceroRadioButton = new System.Windows.Forms.RadioButton();
            this.todosRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ultimoCostoRadioButton = new System.Windows.Forms.RadioButton();
            this.costoPromedioRadioButton = new System.Windows.Forms.RadioButton();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todasLasFechasCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 643);
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(1343, 643);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.positivosRadioButton);
            this.groupBox3.Controls.Add(this.ceroRadioButton);
            this.groupBox3.Controls.Add(this.todosRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(599, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 62);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Costos";
            // 
            // positivosRadioButton
            // 
            this.positivosRadioButton.AutoSize = true;
            this.positivosRadioButton.Location = new System.Drawing.Point(164, 24);
            this.positivosRadioButton.Name = "positivosRadioButton";
            this.positivosRadioButton.Size = new System.Drawing.Size(85, 21);
            this.positivosRadioButton.TabIndex = 2;
            this.positivosRadioButton.TabStop = true;
            this.positivosRadioButton.Text = "Positivos";
            this.positivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // ceroRadioButton
            // 
            this.ceroRadioButton.AutoSize = true;
            this.ceroRadioButton.Location = new System.Drawing.Point(99, 24);
            this.ceroRadioButton.Name = "ceroRadioButton";
            this.ceroRadioButton.Size = new System.Drawing.Size(59, 21);
            this.ceroRadioButton.TabIndex = 1;
            this.ceroRadioButton.TabStop = true;
            this.ceroRadioButton.Text = "Cero";
            this.ceroRadioButton.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ultimoCostoRadioButton);
            this.groupBox1.Controls.Add(this.costoPromedioRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 62);
            this.groupBox1.TabIndex = 15;
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
            // verReporteButton
            // 
            this.verReporteButton.Image = ((System.Drawing.Image)(resources.GetObject("verReporteButton.Image")));
            this.verReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verReporteButton.Location = new System.Drawing.Point(884, 32);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(143, 49);
            this.verReporteButton.TabIndex = 14;
            this.verReporteButton.Text = "Ver Reporte";
            this.verReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.verReporteButton.UseVisualStyleBackColor = true;
            this.verReporteButton.Click += new System.EventHandler(this.verReporteButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.hastaDateTimePicker);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.desdeDateTimePicker);
            this.groupBox2.Controls.Add(this.todasLasFechasCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(282, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 80);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Enabled = false;
            this.hastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDateTimePicker.Location = new System.Drawing.Point(167, 41);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(132, 22);
            this.hastaDateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Enabled = false;
            this.desdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeDateTimePicker.Location = new System.Drawing.Point(167, 13);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(132, 22);
            this.desdeDateTimePicker.TabIndex = 1;
            // 
            // todasLasFechasCheckBox
            // 
            this.todasLasFechasCheckBox.AutoSize = true;
            this.todasLasFechasCheckBox.Checked = true;
            this.todasLasFechasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todasLasFechasCheckBox.Location = new System.Drawing.Point(7, 27);
            this.todasLasFechasCheckBox.Name = "todasLasFechasCheckBox";
            this.todasLasFechasCheckBox.Size = new System.Drawing.Size(70, 21);
            this.todasLasFechasCheckBox.TabIndex = 0;
            this.todasLasFechasCheckBox.Text = "Todas";
            this.todasLasFechasCheckBox.UseVisualStyleBackColor = true;
            this.todasLasFechasCheckBox.CheckedChanged += new System.EventHandler(this.todasLasFechasCheckBox_CheckedChanged);
            // 
            // frmReporteUtilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.verReporteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteUtilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Utilidad";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton positivosRadioButton;
        private System.Windows.Forms.RadioButton ceroRadioButton;
        private System.Windows.Forms.RadioButton todosRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ultimoCostoRadioButton;
        private System.Windows.Forms.RadioButton costoPromedioRadioButton;
        private System.Windows.Forms.Button verReporteButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.CheckBox todasLasFechasCheckBox;
    }
}