namespace PagoAgil.Aplicacion.View.Facturas
{
    partial class FacturaBuscador
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
            this.modificarButton = new System.Windows.Forms.Button();
            this.bajaButton = new System.Windows.Forms.Button();
            this.resultadosBusquedaPanel = new System.Windows.Forms.GroupBox();
            this.empresasDataGrid = new System.Windows.Forms.DataGridView();
            this.numerofacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturamontototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturafechaaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturafechavencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerorendicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.facturaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtrosPanel = new System.Windows.Forms.GroupBox();
            this.filtrosTabla = new System.Windows.Forms.TableLayoutPanel();
            this.habilitadaCheckbox = new System.Windows.Forms.CheckBox();
            this.numeroFactura = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.buscadorCliente = new System.Windows.Forms.Button();
            this.pagadaCheckbox = new System.Windows.Forms.CheckBox();
            this.rendidaCheckbox = new System.Windows.Forms.CheckBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.facturaTableAdapter = new PagoAgil.DataSet.SQL_BOYS_Data_SetTableAdapters.FacturaTableAdapter();
            this.facturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.numeroNumericUpDown = new System.Windows.Forms.TextBox();
            this.dniNumericUpDown = new System.Windows.Forms.TextBox();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.resultadosBusquedaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            this.filtrosPanel.SuspendLayout();
            this.filtrosTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(632, 550);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(150, 30);
            this.modificarButton.TabIndex = 23;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // bajaButton
            // 
            this.bajaButton.Location = new System.Drawing.Point(191, 550);
            this.bajaButton.Name = "bajaButton";
            this.bajaButton.Size = new System.Drawing.Size(150, 30);
            this.bajaButton.TabIndex = 22;
            this.bajaButton.Text = "Dar de baja";
            this.bajaButton.UseVisualStyleBackColor = true;
            this.bajaButton.Click += new System.EventHandler(this.bajaButton_Click);
            // 
            // resultadosBusquedaPanel
            // 
            this.resultadosBusquedaPanel.Controls.Add(this.empresasDataGrid);
            this.resultadosBusquedaPanel.Location = new System.Drawing.Point(46, 182);
            this.resultadosBusquedaPanel.Name = "resultadosBusquedaPanel";
            this.resultadosBusquedaPanel.Size = new System.Drawing.Size(892, 362);
            this.resultadosBusquedaPanel.TabIndex = 21;
            this.resultadosBusquedaPanel.TabStop = false;
            this.resultadosBusquedaPanel.Text = "Resultados de búsqueda";
            // 
            // empresasDataGrid
            // 
            this.empresasDataGrid.AllowUserToDeleteRows = false;
            this.empresasDataGrid.AutoGenerateColumns = false;
            this.empresasDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerofacturaDataGridViewTextBoxColumn,
            this.facturamontototalDataGridViewTextBoxColumn,
            this.facturafechaaltaDataGridViewTextBoxColumn,
            this.facturafechavencimientoDataGridViewTextBoxColumn,
            this.dniclienteDataGridViewTextBoxColumn,
            this.idempresaDataGridViewTextBoxColumn,
            this.numerorendicionDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1});
            this.empresasDataGrid.DataSource = this.facturaBindingSource2;
            this.empresasDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empresasDataGrid.Location = new System.Drawing.Point(3, 16);
            this.empresasDataGrid.MultiSelect = false;
            this.empresasDataGrid.Name = "empresasDataGrid";
            this.empresasDataGrid.ReadOnly = true;
            this.empresasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empresasDataGrid.Size = new System.Drawing.Size(886, 343);
            this.empresasDataGrid.TabIndex = 0;
            this.empresasDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empresasDataGrid_CellContentClick);
            // 
            // numerofacturaDataGridViewTextBoxColumn
            // 
            this.numerofacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numerofacturaDataGridViewTextBoxColumn.DataPropertyName = "numero_factura";
            this.numerofacturaDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numerofacturaDataGridViewTextBoxColumn.Name = "numerofacturaDataGridViewTextBoxColumn";
            this.numerofacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturamontototalDataGridViewTextBoxColumn
            // 
            this.facturamontototalDataGridViewTextBoxColumn.DataPropertyName = "factura_monto_total";
            this.facturamontototalDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.facturamontototalDataGridViewTextBoxColumn.Name = "facturamontototalDataGridViewTextBoxColumn";
            this.facturamontototalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturafechaaltaDataGridViewTextBoxColumn
            // 
            this.facturafechaaltaDataGridViewTextBoxColumn.DataPropertyName = "factura_fecha_alta";
            this.facturafechaaltaDataGridViewTextBoxColumn.HeaderText = "Fecha de Alta";
            this.facturafechaaltaDataGridViewTextBoxColumn.Name = "facturafechaaltaDataGridViewTextBoxColumn";
            this.facturafechaaltaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturafechavencimientoDataGridViewTextBoxColumn
            // 
            this.facturafechavencimientoDataGridViewTextBoxColumn.DataPropertyName = "factura_fecha_vencimiento";
            this.facturafechavencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de vencimiento";
            this.facturafechavencimientoDataGridViewTextBoxColumn.Name = "facturafechavencimientoDataGridViewTextBoxColumn";
            this.facturafechavencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniclienteDataGridViewTextBoxColumn
            // 
            this.dniclienteDataGridViewTextBoxColumn.DataPropertyName = "dni_cliente";
            this.dniclienteDataGridViewTextBoxColumn.HeaderText = "Dni de cliente";
            this.dniclienteDataGridViewTextBoxColumn.Name = "dniclienteDataGridViewTextBoxColumn";
            this.dniclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idempresaDataGridViewTextBoxColumn
            // 
            this.idempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.HeaderText = "Id de empresa";
            this.idempresaDataGridViewTextBoxColumn.Name = "idempresaDataGridViewTextBoxColumn";
            this.idempresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerorendicionDataGridViewTextBoxColumn
            // 
            this.numerorendicionDataGridViewTextBoxColumn.DataPropertyName = "numero_rendicion";
            this.numerorendicionDataGridViewTextBoxColumn.HeaderText = "Rendición";
            this.numerorendicionDataGridViewTextBoxColumn.Name = "numerorendicionDataGridViewTextBoxColumn";
            this.numerorendicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "habilitadx";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Habilitadx";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // facturaBindingSource2
            // 
            this.facturaBindingSource2.DataMember = "Factura";
            this.facturaBindingSource2.DataSource = this.sQL_BOYS_Data_Set;
            // 
            // sQL_BOYS_Data_Set
            // 
            this.sQL_BOYS_Data_Set.DataSetName = "SQL_BOYS_Data_Set";
            this.sQL_BOYS_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.sQL_BOYS_Data_Set;
            // 
            // filtrosPanel
            // 
            this.filtrosPanel.Controls.Add(this.filtrosTabla);
            this.filtrosPanel.Location = new System.Drawing.Point(46, 59);
            this.filtrosPanel.Name = "filtrosPanel";
            this.filtrosPanel.Size = new System.Drawing.Size(892, 103);
            this.filtrosPanel.TabIndex = 19;
            this.filtrosPanel.TabStop = false;
            this.filtrosPanel.Text = "Filtros de búsqueda";
            // 
            // filtrosTabla
            // 
            this.filtrosTabla.ColumnCount = 8;
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filtrosTabla.Controls.Add(this.estadoLabel, 0, 1);
            this.filtrosTabla.Controls.Add(this.dniNumericUpDown, 5, 0);
            this.filtrosTabla.Controls.Add(this.numeroNumericUpDown, 1, 0);
            this.filtrosTabla.Controls.Add(this.numeroFactura, 0, 0);
            this.filtrosTabla.Controls.Add(this.limpiarButton, 7, 0);
            this.filtrosTabla.Controls.Add(this.buscarButton, 7, 1);
            this.filtrosTabla.Controls.Add(this.cuitLabel, 2, 0);
            this.filtrosTabla.Controls.Add(this.clienteLabel, 4, 0);
            this.filtrosTabla.Controls.Add(this.buscadorCliente, 6, 0);
            this.filtrosTabla.Controls.Add(this.pagadaCheckbox, 1, 1);
            this.filtrosTabla.Controls.Add(this.empresaComboBox, 3, 0);
            this.filtrosTabla.Controls.Add(this.habilitadaCheckbox, 5, 1);
            this.filtrosTabla.Controls.Add(this.rendidaCheckbox, 3, 1);
            this.filtrosTabla.Location = new System.Drawing.Point(11, 27);
            this.filtrosTabla.Name = "filtrosTabla";
            this.filtrosTabla.RowCount = 2;
            this.filtrosTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtrosTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtrosTabla.Size = new System.Drawing.Size(875, 59);
            this.filtrosTabla.TabIndex = 4;
            // 
            // habilitadaCheckbox
            // 
            this.habilitadaCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.habilitadaCheckbox.AutoSize = true;
            this.habilitadaCheckbox.Location = new System.Drawing.Point(548, 35);
            this.habilitadaCheckbox.Name = "habilitadaCheckbox";
            this.habilitadaCheckbox.Size = new System.Drawing.Size(72, 17);
            this.habilitadaCheckbox.TabIndex = 21;
            this.habilitadaCheckbox.Text = "Habilitadx";
            this.habilitadaCheckbox.UseVisualStyleBackColor = true;
            // 
            // numeroFactura
            // 
            this.numeroFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroFactura.AutoSize = true;
            this.numeroFactura.Location = new System.Drawing.Point(3, 8);
            this.numeroFactura.Name = "numeroFactura";
            this.numeroFactura.Size = new System.Drawing.Size(103, 13);
            this.numeroFactura.TabIndex = 1;
            this.numeroFactura.Text = "Número";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.limpiarButton.Location = new System.Drawing.Point(769, 3);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(100, 23);
            this.limpiarButton.TabIndex = 10;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buscarButton.Location = new System.Drawing.Point(769, 32);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(100, 24);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // cuitLabel
            // 
            this.cuitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(221, 8);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(103, 13);
            this.cuitLabel.TabIndex = 2;
            this.cuitLabel.Text = "Cuit de empresa";
            // 
            // clienteLabel
            // 
            this.clienteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(439, 8);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(103, 13);
            this.clienteLabel.TabIndex = 4;
            this.clienteLabel.Text = "DNI de cliente";
            // 
            // buscadorCliente
            // 
            this.buscadorCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buscadorCliente.Location = new System.Drawing.Point(658, 3);
            this.buscadorCliente.Name = "buscadorCliente";
            this.buscadorCliente.Size = new System.Drawing.Size(100, 23);
            this.buscadorCliente.TabIndex = 13;
            this.buscadorCliente.Text = "Seleccionar";
            this.buscadorCliente.UseVisualStyleBackColor = true;
            this.buscadorCliente.Click += new System.EventHandler(this.buscadorCliente_Click);
            // 
            // pagadaCheckbox
            // 
            this.pagadaCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pagadaCheckbox.AutoSize = true;
            this.pagadaCheckbox.Location = new System.Drawing.Point(112, 35);
            this.pagadaCheckbox.Name = "pagadaCheckbox";
            this.pagadaCheckbox.Size = new System.Drawing.Size(63, 17);
            this.pagadaCheckbox.TabIndex = 15;
            this.pagadaCheckbox.Text = "Pagada";
            this.pagadaCheckbox.UseVisualStyleBackColor = true;
            // 
            // rendidaCheckbox
            // 
            this.rendidaCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rendidaCheckbox.AutoSize = true;
            this.rendidaCheckbox.Location = new System.Drawing.Point(330, 35);
            this.rendidaCheckbox.Name = "rendidaCheckbox";
            this.rendidaCheckbox.Size = new System.Drawing.Size(66, 17);
            this.rendidaCheckbox.TabIndex = 16;
            this.rendidaCheckbox.Text = "Rendida";
            this.rendidaCheckbox.UseVisualStyleBackColor = true;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(406, 30);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(161, 20);
            this.tituloLabel.TabIndex = 18;
            this.tituloLabel.Text = "Buscador de facturas";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // facturaBindingSource1
            // 
            this.facturaBindingSource1.DataMember = "Factura";
            this.facturaBindingSource1.DataSource = this.sQL_BOYS_Data_Set;
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(330, 4);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(103, 21);
            this.empresaComboBox.TabIndex = 25;
            // 
            // numeroNumericUpDown
            // 
            this.numeroNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroNumericUpDown.Location = new System.Drawing.Point(112, 4);
            this.numeroNumericUpDown.Name = "numeroNumericUpDown";
            this.numeroNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.numeroNumericUpDown.TabIndex = 24;
            // 
            // dniNumericUpDown
            // 
            this.dniNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dniNumericUpDown.Location = new System.Drawing.Point(548, 4);
            this.dniNumericUpDown.Name = "dniNumericUpDown";
            this.dniNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.dniNumericUpDown.TabIndex = 26;
            // 
            // estadoLabel
            // 
            this.estadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(3, 37);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(103, 13);
            this.estadoLabel.TabIndex = 27;
            this.estadoLabel.Text = "Estado de factura";
            // 
            // FacturaBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.bajaButton);
            this.Controls.Add(this.resultadosBusquedaPanel);
            this.Controls.Add(this.filtrosPanel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "FacturaBuscador";
            this.Text = "Consulta de facturas";
            this.Load += new System.EventHandler(this.FacturaBuscador_Load);
            this.resultadosBusquedaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            this.filtrosPanel.ResumeLayout(false);
            this.filtrosTabla.ResumeLayout(false);
            this.filtrosTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button bajaButton;
        private System.Windows.Forms.GroupBox resultadosBusquedaPanel;
        private System.Windows.Forms.DataGridView empresasDataGrid;
        private System.Windows.Forms.GroupBox filtrosPanel;
        private System.Windows.Forms.TableLayoutPanel filtrosTabla;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Label numeroFactura;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buscadorCliente;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private DataSet.SQL_BOYS_Data_SetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerofacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturamontototalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturafechaaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturafechavencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerorendicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource facturaBindingSource2;
        private System.Windows.Forms.BindingSource facturaBindingSource1;
        public System.Windows.Forms.ComboBox empresaComboBox;
        public System.Windows.Forms.CheckBox pagadaCheckbox;
        public System.Windows.Forms.CheckBox rendidaCheckbox;
        public System.Windows.Forms.CheckBox habilitadaCheckbox;
        public System.Windows.Forms.TextBox dniNumericUpDown;
        public System.Windows.Forms.TextBox numeroNumericUpDown;
        private System.Windows.Forms.Label estadoLabel;
    }
}