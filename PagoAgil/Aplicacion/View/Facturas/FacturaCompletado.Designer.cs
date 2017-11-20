namespace PagoAgil.Aplicacion.View.Facturas
{
    partial class FacturaCompletado
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
            this.altaGroup = new System.Windows.Forms.GroupBox();
            this.habilitadaCheckBox = new System.Windows.Forms.CheckBox();
            this.facturaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dniClienteTextBox = new System.Windows.Forms.NumericUpDown();
            this.numeroTextBox = new System.Windows.Forms.NumericUpDown();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.altaLabel = new System.Windows.Forms.Label();
            this.vencimientoLabel = new System.Windows.Forms.Label();
            this.empresasNombreComboBox = new System.Windows.Forms.ComboBox();
            this.buscadorCliente = new System.Windows.Forms.Button();
            this.altaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vencimientoTimePicker = new System.Windows.Forms.DateTimePicker();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.itemsBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.montoValor = new System.Windows.Forms.TextBox();
            this.montoLabel = new System.Windows.Forms.Label();
            this.limpiarItemsButton = new System.Windows.Forms.Button();
            this.itemDataGrid = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.itemTableAdapter = new PagoAgil.DataSet.SQL_BOYS_Data_SetTableAdapters.ItemTableAdapter();
            this.limpiarTodoButton = new System.Windows.Forms.Button();
            this.completarButton = new System.Windows.Forms.Button();
            this.altaGroup.SuspendLayout();
            this.facturaLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dniClienteTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextBox)).BeginInit();
            this.itemsBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            this.SuspendLayout();
            // 
            // altaGroup
            // 
            this.altaGroup.Controls.Add(this.habilitadaCheckBox);
            this.altaGroup.Controls.Add(this.facturaLayout);
            this.altaGroup.Controls.Add(this.limpiarButton);
            this.altaGroup.Location = new System.Drawing.Point(89, 76);
            this.altaGroup.Name = "altaGroup";
            this.altaGroup.Size = new System.Drawing.Size(526, 285);
            this.altaGroup.TabIndex = 7;
            this.altaGroup.TabStop = false;
            this.altaGroup.Text = "<Datos>";
            // 
            // habilitadaCheckBox
            // 
            this.habilitadaCheckBox.AutoSize = true;
            this.habilitadaCheckBox.Location = new System.Drawing.Point(435, 249);
            this.habilitadaCheckBox.Name = "habilitadaCheckBox";
            this.habilitadaCheckBox.Size = new System.Drawing.Size(73, 17);
            this.habilitadaCheckBox.TabIndex = 5;
            this.habilitadaCheckBox.Text = "Habilitada";
            this.habilitadaCheckBox.UseVisualStyleBackColor = true;
            // 
            // facturaLayout
            // 
            this.facturaLayout.ColumnCount = 3;
            this.facturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.facturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.facturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.facturaLayout.Controls.Add(this.dniClienteTextBox, 1, 3);
            this.facturaLayout.Controls.Add(this.numeroTextBox, 1, 0);
            this.facturaLayout.Controls.Add(this.empresaLabel, 0, 4);
            this.facturaLayout.Controls.Add(this.numeroLabel, 0, 0);
            this.facturaLayout.Controls.Add(this.dniLabel, 0, 3);
            this.facturaLayout.Controls.Add(this.altaLabel, 0, 1);
            this.facturaLayout.Controls.Add(this.vencimientoLabel, 0, 2);
            this.facturaLayout.Controls.Add(this.empresasNombreComboBox, 1, 4);
            this.facturaLayout.Controls.Add(this.buscadorCliente, 2, 3);
            this.facturaLayout.Controls.Add(this.altaTimePicker, 1, 1);
            this.facturaLayout.Controls.Add(this.vencimientoTimePicker, 1, 2);
            this.facturaLayout.Location = new System.Drawing.Point(19, 29);
            this.facturaLayout.Name = "facturaLayout";
            this.facturaLayout.RowCount = 5;
            this.facturaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.facturaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.facturaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.facturaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.facturaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.facturaLayout.Size = new System.Drawing.Size(489, 200);
            this.facturaLayout.TabIndex = 4;
            // 
            // dniClienteTextBox
            // 
            this.dniClienteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dniClienteTextBox.Location = new System.Drawing.Point(149, 130);
            this.dniClienteTextBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.dniClienteTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dniClienteTextBox.Name = "dniClienteTextBox";
            this.dniClienteTextBox.Size = new System.Drawing.Size(214, 20);
            this.dniClienteTextBox.TabIndex = 12;
            this.dniClienteTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroTextBox.Location = new System.Drawing.Point(149, 10);
            this.numeroTextBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numeroTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(214, 20);
            this.numeroTextBox.TabIndex = 12;
            this.numeroTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // empresaLabel
            // 
            this.empresaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Location = new System.Drawing.Point(3, 173);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(140, 13);
            this.empresaLabel.TabIndex = 4;
            this.empresaLabel.Text = "Cuit de empresa";
            // 
            // numeroLabel
            // 
            this.numeroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(3, 13);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(140, 13);
            this.numeroLabel.TabIndex = 0;
            this.numeroLabel.Text = "Número de factura";
            // 
            // dniLabel
            // 
            this.dniLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(3, 133);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(140, 13);
            this.dniLabel.TabIndex = 3;
            this.dniLabel.Text = "Dni de cliente";
            // 
            // altaLabel
            // 
            this.altaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.altaLabel.AutoSize = true;
            this.altaLabel.Location = new System.Drawing.Point(3, 53);
            this.altaLabel.Name = "altaLabel";
            this.altaLabel.Size = new System.Drawing.Size(140, 13);
            this.altaLabel.TabIndex = 1;
            this.altaLabel.Text = "Fecha de alta";
            // 
            // vencimientoLabel
            // 
            this.vencimientoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.vencimientoLabel.AutoSize = true;
            this.vencimientoLabel.Location = new System.Drawing.Point(3, 93);
            this.vencimientoLabel.Name = "vencimientoLabel";
            this.vencimientoLabel.Size = new System.Drawing.Size(140, 13);
            this.vencimientoLabel.TabIndex = 2;
            this.vencimientoLabel.Text = "Fecha de vencimiento";
            // 
            // empresasNombreComboBox
            // 
            this.empresasNombreComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empresasNombreComboBox.DisplayMember = "nombre";
            this.empresasNombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresasNombreComboBox.FormattingEnabled = true;
            this.empresasNombreComboBox.Location = new System.Drawing.Point(149, 169);
            this.empresasNombreComboBox.Name = "empresasNombreComboBox";
            this.empresasNombreComboBox.Size = new System.Drawing.Size(214, 21);
            this.empresasNombreComboBox.TabIndex = 9;
            this.empresasNombreComboBox.ValueMember = "nombre";
            // 
            // buscadorCliente
            // 
            this.buscadorCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buscadorCliente.Location = new System.Drawing.Point(390, 128);
            this.buscadorCliente.Name = "buscadorCliente";
            this.buscadorCliente.Size = new System.Drawing.Size(75, 23);
            this.buscadorCliente.TabIndex = 9;
            this.buscadorCliente.Text = "Buscar";
            this.buscadorCliente.UseVisualStyleBackColor = true;
            this.buscadorCliente.Click += new System.EventHandler(this.buscadorCliente_Click);
            // 
            // altaTimePicker
            // 
            this.altaTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.altaTimePicker.Enabled = false;
            this.altaTimePicker.Location = new System.Drawing.Point(149, 50);
            this.altaTimePicker.Name = "altaTimePicker";
            this.altaTimePicker.Size = new System.Drawing.Size(214, 20);
            this.altaTimePicker.TabIndex = 10;
            // 
            // vencimientoTimePicker
            // 
            this.vencimientoTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.vencimientoTimePicker.Location = new System.Drawing.Point(149, 90);
            this.vencimientoTimePicker.Name = "vencimientoTimePicker";
            this.vencimientoTimePicker.Size = new System.Drawing.Size(214, 20);
            this.vencimientoTimePicker.TabIndex = 11;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(19, 245);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 3;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(85, 38);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(65, 20);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "<Título>";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // itemsBox
            // 
            this.itemsBox.Controls.Add(this.tableLayoutPanel1);
            this.itemsBox.Controls.Add(this.limpiarItemsButton);
            this.itemsBox.Controls.Add(this.itemDataGrid);
            this.itemsBox.Location = new System.Drawing.Point(89, 367);
            this.itemsBox.Name = "itemsBox";
            this.itemsBox.Size = new System.Drawing.Size(526, 228);
            this.itemsBox.TabIndex = 9;
            this.itemsBox.TabStop = false;
            this.itemsBox.Text = "Items";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.14111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.8589F));
            this.tableLayoutPanel1.Controls.Add(this.montoValor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.montoLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 37);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // montoValor
            // 
            this.montoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.montoValor.Enabled = false;
            this.montoValor.Location = new System.Drawing.Point(389, 8);
            this.montoValor.Name = "montoValor";
            this.montoValor.Size = new System.Drawing.Size(97, 20);
            this.montoValor.TabIndex = 12;
            this.montoValor.Text = "0";
            this.montoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // montoLabel
            // 
            this.montoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.montoLabel.AutoSize = true;
            this.montoLabel.Location = new System.Drawing.Point(3, 12);
            this.montoLabel.Name = "montoLabel";
            this.montoLabel.Size = new System.Drawing.Size(380, 13);
            this.montoLabel.TabIndex = 0;
            this.montoLabel.Text = "Monto total de factura";
            // 
            // limpiarItemsButton
            // 
            this.limpiarItemsButton.Location = new System.Drawing.Point(19, 194);
            this.limpiarItemsButton.Name = "limpiarItemsButton";
            this.limpiarItemsButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarItemsButton.TabIndex = 5;
            this.limpiarItemsButton.Text = "Limpiar";
            this.limpiarItemsButton.UseVisualStyleBackColor = true;
            this.limpiarItemsButton.Click += new System.EventHandler(this.limpiarItemsButton_Click);
            // 
            // itemDataGrid
            // 
            this.itemDataGrid.AllowUserToOrderColumns = true;
            this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cantidad,
            this.monto});
            this.itemDataGrid.Location = new System.Drawing.Point(19, 24);
            this.itemDataGrid.Name = "itemDataGrid";
            this.itemDataGrid.Size = new System.Drawing.Size(489, 115);
            this.itemDataGrid.TabIndex = 0;
            this.itemDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGrid_CellValueChanged);
            this.itemDataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.itemDataGrid_EditingControlShowing);
            this.itemDataGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemDataGrid_KeyPress);
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.sQL_BOYS_Data_Set;
            // 
            // sQL_BOYS_Data_Set
            // 
            this.sQL_BOYS_Data_Set.DataSetName = "SQL_BOYS_Data_Set";
            this.sQL_BOYS_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // limpiarTodoButton
            // 
            this.limpiarTodoButton.Location = new System.Drawing.Point(89, 607);
            this.limpiarTodoButton.Name = "limpiarTodoButton";
            this.limpiarTodoButton.Size = new System.Drawing.Size(150, 25);
            this.limpiarTodoButton.TabIndex = 10;
            this.limpiarTodoButton.Text = "Limpiar todo";
            this.limpiarTodoButton.UseVisualStyleBackColor = true;
            this.limpiarTodoButton.Click += new System.EventHandler(this.limpiarTodoButton_Click);
            // 
            // completarButton
            // 
            this.completarButton.Location = new System.Drawing.Point(465, 607);
            this.completarButton.Name = "completarButton";
            this.completarButton.Size = new System.Drawing.Size(150, 25);
            this.completarButton.TabIndex = 11;
            this.completarButton.Text = "<Completar>";
            this.completarButton.UseVisualStyleBackColor = true;
            this.completarButton.Click += new System.EventHandler(this.completarButton_Click);
            // 
            // FacturaCompletado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 661);
            this.Controls.Add(this.completarButton);
            this.Controls.Add(this.limpiarTodoButton);
            this.Controls.Add(this.itemsBox);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.altaGroup);
            this.Name = "FacturaCompletado";
            this.Text = "<Completado>";
            this.Load += new System.EventHandler(this.FacturaCompletado_Load);
            this.altaGroup.ResumeLayout(false);
            this.altaGroup.PerformLayout();
            this.facturaLayout.ResumeLayout(false);
            this.facturaLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dniClienteTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextBox)).EndInit();
            this.itemsBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox altaGroup;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label altaLabel;
        private System.Windows.Forms.Label vencimientoLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TableLayoutPanel facturaLayout;
        private System.Windows.Forms.Button buscadorCliente;
        private System.Windows.Forms.GroupBox itemsBox;
        private System.Windows.Forms.Button limpiarItemsButton;
        private System.Windows.Forms.DataGridView itemDataGrid;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DataSet.SQL_BOYS_Data_SetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label montoLabel;
        private System.Windows.Forms.Button limpiarTodoButton;
        private System.Windows.Forms.Button completarButton;
        private System.Windows.Forms.CheckBox habilitadaCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        public System.Windows.Forms.ComboBox empresasNombreComboBox;
        public System.Windows.Forms.DateTimePicker altaTimePicker;
        public System.Windows.Forms.DateTimePicker vencimientoTimePicker;
        public System.Windows.Forms.NumericUpDown numeroTextBox;
        public System.Windows.Forms.NumericUpDown dniClienteTextBox;
        private System.Windows.Forms.TextBox montoValor;
    }
}