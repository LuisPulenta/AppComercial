
namespace AppComercial
{
    partial class frmProductos
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
            System.Windows.Forms.Label iDProductoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iDDepartamentoLabel;
            System.Windows.Forms.Label iDIVALabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label iDMedidaLabel;
            System.Windows.Forms.Label medidaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppComercial = new AppComercial.DSAppComercial();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearchItem = new System.Windows.Forms.ToolStripButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.iDDepartamentoComboBox = new System.Windows.Forms.ComboBox();
            this.iDIVAComboBox = new System.Windows.Forms.ComboBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.imagenTextBox = new System.Windows.Forms.TextBox();
            this.iDMedidaComboBox = new System.Windows.Forms.ComboBox();
            this.medidaTextBox = new System.Windows.Forms.TextBox();
            this.barraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.gbxBarras = new System.Windows.Forms.GroupBox();
            this.btnEliminarBarra = new System.Windows.Forms.Button();
            this.btnAgregarBarra = new System.Windows.Forms.Button();
            this.barrasDataGridView = new System.Windows.Forms.DataGridView();
            this.barraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxBodegas = new System.Windows.Forms.GroupBox();
            this.btnAgregarBodega = new System.Windows.Forms.Button();
            this.bodegasDataGridView = new System.Windows.Forms.DataGridView();
            this.IDBodega = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppComercialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasReposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new AppComercial.DSAppComercialTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new AppComercial.DSAppComercialTableAdapters.TableAdapterManager();
            this.barraTableAdapter = new AppComercial.DSAppComercialTableAdapters.BarraTableAdapter();
            this.bodegaProductoTableAdapter = new AppComercial.DSAppComercialTableAdapters.BodegaProductoTableAdapter();
            this.bodegaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new AppComercial.DSAppComercialTableAdapters.DepartamentoTableAdapter();
            this.iVATableAdapter = new AppComercial.DSAppComercialTableAdapters.IVATableAdapter();
            this.medidaTableAdapter = new AppComercial.DSAppComercialTableAdapters.MedidaTableAdapter();
            this.bodegaTableAdapter = new AppComercial.DSAppComercialTableAdapters.BodegaTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iDBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasReposicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorPrint = new System.Windows.Forms.ToolStripButton();
            iDProductoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            iDDepartamentoLabel = new System.Windows.Forms.Label();
            iDIVALabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            iDMedidaLabel = new System.Windows.Forms.Label();
            medidaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.gbxBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barrasDataGridView)).BeginInit();
            this.gbxBodegas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDProductoLabel
            // 
            iDProductoLabel.AutoSize = true;
            iDProductoLabel.Location = new System.Drawing.Point(20, 43);
            iDProductoLabel.Name = "iDProductoLabel";
            iDProductoLabel.Size = new System.Drawing.Size(82, 17);
            iDProductoLabel.TabIndex = 1;
            iDProductoLabel.Text = "IDProducto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(241, 43);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripción:";
            // 
            // iDDepartamentoLabel
            // 
            iDDepartamentoLabel.AutoSize = true;
            iDDepartamentoLabel.Location = new System.Drawing.Point(724, 43);
            iDDepartamentoLabel.Name = "iDDepartamentoLabel";
            iDDepartamentoLabel.Size = new System.Drawing.Size(102, 17);
            iDDepartamentoLabel.TabIndex = 5;
            iDDepartamentoLabel.Text = "Departamento:";
            // 
            // iDIVALabel
            // 
            iDIVALabel.AutoSize = true;
            iDIVALabel.Location = new System.Drawing.Point(294, 71);
            iDIVALabel.Name = "iDIVALabel";
            iDIVALabel.Size = new System.Drawing.Size(33, 17);
            iDIVALabel.TabIndex = 9;
            iDIVALabel.Text = "IVA:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(50, 71);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(52, 17);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "Precio:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(53, 99);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 17);
            notasLabel.TabIndex = 14;
            notasLabel.Text = "Notas:";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(488, 71);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(58, 17);
            imagenLabel.TabIndex = 11;
            imagenLabel.Text = "Imagen:";
            // 
            // iDMedidaLabel
            // 
            iDMedidaLabel.AutoSize = true;
            iDMedidaLabel.Location = new System.Drawing.Point(475, 102);
            iDMedidaLabel.Name = "iDMedidaLabel";
            iDMedidaLabel.Size = new System.Drawing.Size(57, 17);
            iDMedidaLabel.TabIndex = 16;
            iDMedidaLabel.Text = "Unidad:";
            // 
            // medidaLabel
            // 
            medidaLabel.AutoSize = true;
            medidaLabel.Location = new System.Drawing.Point(791, 102);
            medidaLabel.Name = "medidaLabel";
            medidaLabel.Size = new System.Drawing.Size(58, 17);
            medidaLabel.TabIndex = 18;
            medidaLabel.Text = "Medida:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = null;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = null;
            this.productoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCancelItem,
            this.bindingNavigatorSearchItem,
            this.bindingNavigatorPrint});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(1298, 31);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSAppComercial;
            this.productoBindingSource.PositionChanged += new System.EventHandler(this.productoBindingSource_PositionChanged);
            // 
            // dSAppComercial
            // 
            this.dSAppComercial.DataSetName = "DSAppComercial";
            this.dSAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditItem.Image")));
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorEditItem.Text = "toolStripButton1";
            this.bindingNavigatorEditItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bindingNavigatorEditItem.ToolTipText = "Edita el Registro actual";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.ToolTipText = "Agregar nuevo Registro";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.ToolTipText = "Eliminar el Registro actual";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorSaveItem.Text = "Guardar datos";
            this.bindingNavigatorSaveItem.ToolTipText = "Guardar cambios";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCancelItem
            // 
            this.bindingNavigatorCancelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancelItem.Enabled = false;
            this.bindingNavigatorCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancelItem.Image")));
            this.bindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelItem.Name = "bindingNavigatorCancelItem";
            this.bindingNavigatorCancelItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorCancelItem.Text = "toolStripButton2";
            this.bindingNavigatorCancelItem.ToolTipText = "Cancelar cambios en  el Registro actual";
            this.bindingNavigatorCancelItem.Click += new System.EventHandler(this.bindingNavigatorCancelItem_Click);
            // 
            // bindingNavigatorSearchItem
            // 
            this.bindingNavigatorSearchItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSearchItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSearchItem.Image")));
            this.bindingNavigatorSearchItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearchItem.Name = "bindingNavigatorSearchItem";
            this.bindingNavigatorSearchItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorSearchItem.Text = "toolStripButton3";
            this.bindingNavigatorSearchItem.ToolTipText = "Buscar un Registro";
            this.bindingNavigatorSearchItem.Click += new System.EventHandler(this.bindingNavigatorSearchItem_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvDatos.DataSource = this.productoBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDatos.Location = new System.Drawing.Point(0, 378);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1298, 270);
            this.dgvDatos.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Producto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDDepartamento";
            this.dataGridViewTextBoxColumn3.DataSource = this.departamentoBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDDepartamento";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.dSAppComercial;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDIVA";
            this.dataGridViewTextBoxColumn4.DataSource = this.iVABindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IDIVA";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSAppComercial;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IDMedida";
            this.dataGridViewTextBoxColumn8.DataSource = this.medidaBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "IDMedida";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataMember = "Medida";
            this.medidaBindingSource.DataSource = this.dSAppComercial;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn9.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // iDProductoTextBox
            // 
            this.iDProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IDProducto", true));
            this.iDProductoTextBox.Location = new System.Drawing.Point(108, 40);
            this.iDProductoTextBox.Name = "iDProductoTextBox";
            this.iDProductoTextBox.ReadOnly = true;
            this.iDProductoTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDProductoTextBox.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(333, 40);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(363, 22);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // iDDepartamentoComboBox
            // 
            this.iDDepartamentoComboBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDDepartamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDDepartamento", true));
            this.iDDepartamentoComboBox.DataSource = this.departamentoBindingSource;
            this.iDDepartamentoComboBox.DisplayMember = "Descripcion";
            this.iDDepartamentoComboBox.Enabled = false;
            this.iDDepartamentoComboBox.FormattingEnabled = true;
            this.iDDepartamentoComboBox.Location = new System.Drawing.Point(832, 40);
            this.iDDepartamentoComboBox.Name = "iDDepartamentoComboBox";
            this.iDDepartamentoComboBox.Size = new System.Drawing.Size(179, 24);
            this.iDDepartamentoComboBox.TabIndex = 6;
            this.iDDepartamentoComboBox.ValueMember = "IDDepartamento";
            // 
            // iDIVAComboBox
            // 
            this.iDIVAComboBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDIVAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDIVA", true));
            this.iDIVAComboBox.DataSource = this.iVABindingSource;
            this.iDIVAComboBox.DisplayMember = "Descripcion";
            this.iDIVAComboBox.Enabled = false;
            this.iDIVAComboBox.FormattingEnabled = true;
            this.iDIVAComboBox.Location = new System.Drawing.Point(333, 68);
            this.iDIVAComboBox.Name = "iDIVAComboBox";
            this.iDIVAComboBox.Size = new System.Drawing.Size(121, 24);
            this.iDIVAComboBox.TabIndex = 10;
            this.iDIVAComboBox.ValueMember = "IDIVA";
            // 
            // precioTextBox
            // 
            this.precioTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(108, 68);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(100, 22);
            this.precioTextBox.TabIndex = 8;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(108, 96);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ReadOnly = true;
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(346, 65);
            this.notasTextBox.TabIndex = 15;
            // 
            // imagenTextBox
            // 
            this.imagenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Imagen", true));
            this.imagenTextBox.Location = new System.Drawing.Point(552, 68);
            this.imagenTextBox.Name = "imagenTextBox";
            this.imagenTextBox.ReadOnly = true;
            this.imagenTextBox.Size = new System.Drawing.Size(397, 22);
            this.imagenTextBox.TabIndex = 12;
            // 
            // iDMedidaComboBox
            // 
            this.iDMedidaComboBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDMedidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDMedida", true));
            this.iDMedidaComboBox.DataSource = this.medidaBindingSource;
            this.iDMedidaComboBox.DisplayMember = "Descripcion";
            this.iDMedidaComboBox.Enabled = false;
            this.iDMedidaComboBox.FormattingEnabled = true;
            this.iDMedidaComboBox.Location = new System.Drawing.Point(552, 99);
            this.iDMedidaComboBox.Name = "iDMedidaComboBox";
            this.iDMedidaComboBox.Size = new System.Drawing.Size(204, 24);
            this.iDMedidaComboBox.TabIndex = 17;
            this.iDMedidaComboBox.ValueMember = "IDMedida";
            // 
            // medidaTextBox
            // 
            this.medidaTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.medidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Medida", true));
            this.medidaTextBox.Location = new System.Drawing.Point(855, 99);
            this.medidaTextBox.Name = "medidaTextBox";
            this.medidaTextBox.ReadOnly = true;
            this.medidaTextBox.Size = new System.Drawing.Size(94, 22);
            this.medidaTextBox.TabIndex = 19;
            // 
            // barraBindingSource
            // 
            this.barraBindingSource.DataMember = "FK_Barra_Producto";
            this.barraBindingSource.DataSource = this.productoBindingSource;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Enabled = false;
            this.btnBuscarImagen.Location = new System.Drawing.Point(955, 68);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(56, 28);
            this.btnBuscarImagen.TabIndex = 13;
            this.btnBuscarImagen.Text = "...";
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagen.Location = new System.Drawing.Point(1017, 40);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(277, 249);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 21;
            this.pbxImagen.TabStop = false;
            // 
            // gbxBarras
            // 
            this.gbxBarras.Controls.Add(this.btnEliminarBarra);
            this.gbxBarras.Controls.Add(this.btnAgregarBarra);
            this.gbxBarras.Controls.Add(this.barrasDataGridView);
            this.gbxBarras.Location = new System.Drawing.Point(4, 167);
            this.gbxBarras.Name = "gbxBarras";
            this.gbxBarras.Size = new System.Drawing.Size(204, 205);
            this.gbxBarras.TabIndex = 20;
            this.gbxBarras.TabStop = false;
            this.gbxBarras.Text = "Códigos de Barras";
            // 
            // btnEliminarBarra
            // 
            this.btnEliminarBarra.Enabled = false;
            this.btnEliminarBarra.Location = new System.Drawing.Point(96, 20);
            this.btnEliminarBarra.Name = "btnEliminarBarra";
            this.btnEliminarBarra.Size = new System.Drawing.Size(75, 31);
            this.btnEliminarBarra.TabIndex = 1;
            this.btnEliminarBarra.Text = "Eliminar";
            this.btnEliminarBarra.UseVisualStyleBackColor = true;
            this.btnEliminarBarra.Click += new System.EventHandler(this.btnEliminarBarra_Click);
            // 
            // btnAgregarBarra
            // 
            this.btnAgregarBarra.Enabled = false;
            this.btnAgregarBarra.Location = new System.Drawing.Point(6, 21);
            this.btnAgregarBarra.Name = "btnAgregarBarra";
            this.btnAgregarBarra.Size = new System.Drawing.Size(75, 31);
            this.btnAgregarBarra.TabIndex = 0;
            this.btnAgregarBarra.Text = "Agregar";
            this.btnAgregarBarra.UseVisualStyleBackColor = true;
            this.btnAgregarBarra.Click += new System.EventHandler(this.btnAgregarBarra_Click);
            // 
            // barrasDataGridView
            // 
            this.barrasDataGridView.AllowUserToAddRows = false;
            this.barrasDataGridView.AllowUserToDeleteRows = false;
            this.barrasDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.barrasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.barrasDataGridView.AutoGenerateColumns = false;
            this.barrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barrasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barraDataGridViewTextBoxColumn});
            this.barrasDataGridView.DataSource = this.barraBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.barrasDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.barrasDataGridView.Location = new System.Drawing.Point(6, 57);
            this.barrasDataGridView.Name = "barrasDataGridView";
            this.barrasDataGridView.ReadOnly = true;
            this.barrasDataGridView.RowHeadersWidth = 51;
            this.barrasDataGridView.RowTemplate.Height = 24;
            this.barrasDataGridView.Size = new System.Drawing.Size(190, 143);
            this.barrasDataGridView.TabIndex = 2;
            // 
            // barraDataGridViewTextBoxColumn
            // 
            this.barraDataGridViewTextBoxColumn.DataPropertyName = "Barra";
            this.barraDataGridViewTextBoxColumn.HeaderText = "Barra";
            this.barraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barraDataGridViewTextBoxColumn.Name = "barraDataGridViewTextBoxColumn";
            this.barraDataGridViewTextBoxColumn.ReadOnly = true;
            this.barraDataGridViewTextBoxColumn.Width = 125;
            // 
            // gbxBodegas
            // 
            this.gbxBodegas.Controls.Add(this.btnAgregarBodega);
            this.gbxBodegas.Controls.Add(this.bodegasDataGridView);
            this.gbxBodegas.Location = new System.Drawing.Point(214, 167);
            this.gbxBodegas.Name = "gbxBodegas";
            this.gbxBodegas.Size = new System.Drawing.Size(797, 205);
            this.gbxBodegas.TabIndex = 21;
            this.gbxBodegas.TabStop = false;
            this.gbxBodegas.Text = "Parámetros de Bodega";
            // 
            // btnAgregarBodega
            // 
            this.btnAgregarBodega.Enabled = false;
            this.btnAgregarBodega.Location = new System.Drawing.Point(636, 21);
            this.btnAgregarBodega.Name = "btnAgregarBodega";
            this.btnAgregarBodega.Size = new System.Drawing.Size(155, 31);
            this.btnAgregarBodega.TabIndex = 0;
            this.btnAgregarBodega.Text = "Agregar / Modificar";
            this.btnAgregarBodega.UseVisualStyleBackColor = true;
            this.btnAgregarBodega.Click += new System.EventHandler(this.btnAgregarBodega_Click);
            // 
            // bodegasDataGridView
            // 
            this.bodegasDataGridView.AllowUserToAddRows = false;
            this.bodegasDataGridView.AllowUserToDeleteRows = false;
            this.bodegasDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.bodegasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bodegasDataGridView.AutoGenerateColumns = false;
            this.bodegasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bodegasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBodega,
            this.Stock,
            this.Minimo,
            this.Maximo,
            this.DiasReposicion,
            this.CantidadMinima,
            this.iDBodegaDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.minimoDataGridViewTextBoxColumn,
            this.maximoDataGridViewTextBoxColumn,
            this.diasReposicionDataGridViewTextBoxColumn,
            this.cantidadMinimaDataGridViewTextBoxColumn});
            this.bodegasDataGridView.DataSource = this.bodegaProductoBindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bodegasDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.bodegasDataGridView.Location = new System.Drawing.Point(6, 57);
            this.bodegasDataGridView.Name = "bodegasDataGridView";
            this.bodegasDataGridView.ReadOnly = true;
            this.bodegasDataGridView.RowHeadersWidth = 51;
            this.bodegasDataGridView.RowTemplate.Height = 24;
            this.bodegasDataGridView.Size = new System.Drawing.Size(785, 143);
            this.bodegasDataGridView.TabIndex = 1;
            // 
            // IDBodega
            // 
            this.IDBodega.DataPropertyName = "IDBodega";
            this.IDBodega.DataSource = this.bodegaBindingSource;
            this.IDBodega.DisplayMember = "Descripcion";
            this.IDBodega.HeaderText = "Bodega";
            this.IDBodega.MinimumWidth = 6;
            this.IDBodega.Name = "IDBodega";
            this.IDBodega.ReadOnly = true;
            this.IDBodega.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDBodega.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IDBodega.ValueMember = "IDBodega";
            this.IDBodega.Width = 125;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSAppComercialBindingSource;
            // 
            // dSAppComercialBindingSource
            // 
            this.dSAppComercialBindingSource.DataSource = this.dSAppComercial;
            this.dSAppComercialBindingSource.Position = 0;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            this.Stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // Minimo
            // 
            this.Minimo.DataPropertyName = "Minimo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            this.Minimo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Minimo.HeaderText = "Mínimo";
            this.Minimo.MinimumWidth = 6;
            this.Minimo.Name = "Minimo";
            this.Minimo.ReadOnly = true;
            this.Minimo.Width = 125;
            // 
            // Maximo
            // 
            this.Maximo.DataPropertyName = "Maximo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            this.Maximo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Maximo.HeaderText = "Máximo";
            this.Maximo.MinimumWidth = 6;
            this.Maximo.Name = "Maximo";
            this.Maximo.ReadOnly = true;
            this.Maximo.Width = 125;
            // 
            // DiasReposicion
            // 
            this.DiasReposicion.DataPropertyName = "DiasReposicion";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N0";
            this.DiasReposicion.DefaultCellStyle = dataGridViewCellStyle5;
            this.DiasReposicion.HeaderText = "Días Repos.";
            this.DiasReposicion.MinimumWidth = 6;
            this.DiasReposicion.Name = "DiasReposicion";
            this.DiasReposicion.ReadOnly = true;
            this.DiasReposicion.Width = 125;
            // 
            // CantidadMinima
            // 
            this.CantidadMinima.DataPropertyName = "CantidadMinima";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            this.CantidadMinima.DefaultCellStyle = dataGridViewCellStyle6;
            this.CantidadMinima.HeaderText = "Cant. Mín.";
            this.CantidadMinima.MinimumWidth = 6;
            this.CantidadMinima.Name = "CantidadMinima";
            this.CantidadMinima.ReadOnly = true;
            this.CantidadMinima.Width = 125;
            // 
            // bodegaProductoBindingSource1
            // 
            this.bodegaProductoBindingSource1.DataMember = "BodegaProducto";
            this.bodegaProductoBindingSource1.DataSource = this.dSAppComercial;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarraTableAdapter = this.barraTableAdapter;
            this.tableAdapterManager.BodegaProductoTableAdapter = this.bodegaProductoTableAdapter;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ConceptoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.KardexTableAdapter = null;
            this.tableAdapterManager.MedidaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppComercial.DSAppComercialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // barraTableAdapter
            // 
            this.barraTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaProductoTableAdapter
            // 
            this.bodegaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaProductoBindingSource
            // 
            this.bodegaProductoBindingSource.DataMember = "BodegaProducto";
            this.bodegaProductoBindingSource.DataSource = this.dSAppComercial;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // medidaTableAdapter
            // 
            this.medidaTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // iDBodegaDataGridViewTextBoxColumn
            // 
            this.iDBodegaDataGridViewTextBoxColumn.DataPropertyName = "IDBodega";
            this.iDBodegaDataGridViewTextBoxColumn.HeaderText = "IDBodega";
            this.iDBodegaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBodegaDataGridViewTextBoxColumn.Name = "iDBodegaDataGridViewTextBoxColumn";
            this.iDBodegaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBodegaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // minimoDataGridViewTextBoxColumn
            // 
            this.minimoDataGridViewTextBoxColumn.DataPropertyName = "Minimo";
            this.minimoDataGridViewTextBoxColumn.HeaderText = "Minimo";
            this.minimoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minimoDataGridViewTextBoxColumn.Name = "minimoDataGridViewTextBoxColumn";
            this.minimoDataGridViewTextBoxColumn.ReadOnly = true;
            this.minimoDataGridViewTextBoxColumn.Width = 125;
            // 
            // maximoDataGridViewTextBoxColumn
            // 
            this.maximoDataGridViewTextBoxColumn.DataPropertyName = "Maximo";
            this.maximoDataGridViewTextBoxColumn.HeaderText = "Maximo";
            this.maximoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maximoDataGridViewTextBoxColumn.Name = "maximoDataGridViewTextBoxColumn";
            this.maximoDataGridViewTextBoxColumn.ReadOnly = true;
            this.maximoDataGridViewTextBoxColumn.Width = 125;
            // 
            // diasReposicionDataGridViewTextBoxColumn
            // 
            this.diasReposicionDataGridViewTextBoxColumn.DataPropertyName = "DiasReposicion";
            this.diasReposicionDataGridViewTextBoxColumn.HeaderText = "DiasReposicion";
            this.diasReposicionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diasReposicionDataGridViewTextBoxColumn.Name = "diasReposicionDataGridViewTextBoxColumn";
            this.diasReposicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.diasReposicionDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadMinimaDataGridViewTextBoxColumn
            // 
            this.cantidadMinimaDataGridViewTextBoxColumn.DataPropertyName = "CantidadMinima";
            this.cantidadMinimaDataGridViewTextBoxColumn.HeaderText = "CantidadMinima";
            this.cantidadMinimaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadMinimaDataGridViewTextBoxColumn.Name = "cantidadMinimaDataGridViewTextBoxColumn";
            this.cantidadMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadMinimaDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingNavigatorPrint
            // 
            this.bindingNavigatorPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPrint.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPrint.Image")));
            this.bindingNavigatorPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorPrint.Name = "bindingNavigatorPrint";
            this.bindingNavigatorPrint.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorPrint.Text = "toolStripButton1";
            this.bindingNavigatorPrint.ToolTipText = "Listado de Productos";
            this.bindingNavigatorPrint.Click += new System.EventHandler(this.bindingNavigatorPrint_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1298, 649);
            this.Controls.Add(this.gbxBodegas);
            this.Controls.Add(this.gbxBarras);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(medidaLabel);
            this.Controls.Add(this.medidaTextBox);
            this.Controls.Add(iDMedidaLabel);
            this.Controls.Add(this.iDMedidaComboBox);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(this.imagenTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(iDIVALabel);
            this.Controls.Add(this.iDIVAComboBox);
            this.Controls.Add(iDDepartamentoLabel);
            this.Controls.Add(this.iDDepartamentoComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(iDProductoLabel);
            this.Controls.Add(this.iDProductoTextBox);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.productoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.gbxBarras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barrasDataGridView)).EndInit();
            this.gbxBodegas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bodegasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppComercialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DSAppComercial dSAppComercial;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DSAppComercialTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DSAppComercialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox medidaTextBox;
        private System.Windows.Forms.ComboBox iDMedidaComboBox;
        private System.Windows.Forms.TextBox imagenTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ComboBox iDIVAComboBox;
        private System.Windows.Forms.ComboBox iDDepartamentoComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox iDProductoTextBox;
        private System.Windows.Forms.DataGridView dgvDatos;
        private DSAppComercialTableAdapters.BarraTableAdapter barraTableAdapter;
        private System.Windows.Forms.BindingSource barraBindingSource;
        private System.Windows.Forms.GroupBox gbxBodegas;
        private System.Windows.Forms.Button btnAgregarBodega;
        private System.Windows.Forms.DataGridView bodegasDataGridView;
        private System.Windows.Forms.GroupBox gbxBarras;
        private System.Windows.Forms.Button btnEliminarBarra;
        private System.Windows.Forms.Button btnAgregarBarra;
        private System.Windows.Forms.DataGridView barrasDataGridView;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnBuscarImagen;
        private DSAppComercialTableAdapters.BodegaProductoTableAdapter bodegaProductoTableAdapter;
        private System.Windows.Forms.BindingSource bodegaProductoBindingSource;
        private System.Windows.Forms.BindingSource bodegaProductoBindingSource1;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DSAppComercialTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSAppComercialTableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private DSAppComercialTableAdapters.MedidaTableAdapter medidaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn barraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dSAppComercialBindingSource;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSAppComercialTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearchItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasReposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasReposicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMinimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPrint;
    }
}