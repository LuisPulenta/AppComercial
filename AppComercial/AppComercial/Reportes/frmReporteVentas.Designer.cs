
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 678);
            this.panel1.TabIndex = 1;
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
            this.verReporteButton.Location = new System.Drawing.Point(570, 8);
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
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 761);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Ventas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button verReporteButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}