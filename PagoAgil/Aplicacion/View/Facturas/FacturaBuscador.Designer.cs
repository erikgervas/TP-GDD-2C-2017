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
            this.volverAInicioButton = new System.Windows.Forms.Button();
            this.filtrosPanel = new System.Windows.Forms.GroupBox();
            this.filtrosTabla = new System.Windows.Forms.TableLayoutPanel();
            this.buscarButton = new System.Windows.Forms.Button();
            this.pagadaLabel = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.numeroFactura = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.buscadorCliente = new System.Windows.Forms.Button();
            this.rendidaLabel = new System.Windows.Forms.Label();
            this.pagadaCheckbox = new System.Windows.Forms.CheckBox();
            this.rendidaCheckbox = new System.Windows.Forms.CheckBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.habilitadaTextBox = new System.Windows.Forms.Label();
            this.habilitadaCheckbox = new System.Windows.Forms.CheckBox();
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new PagoAgil.DataSet.SQL_BOYS_Data_SetTableAdapters.FacturaTableAdapter();
            this.numerofacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturamontototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturafechaaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturafechavencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerorendicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadxDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.resultadosBusquedaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).BeginInit();
            this.filtrosPanel.SuspendLayout();
            this.filtrosTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
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
            // 
            // bajaButton
            // 
            this.bajaButton.Location = new System.Drawing.Point(191, 550);
            this.bajaButton.Name = "bajaButton";
            this.bajaButton.Size = new System.Drawing.Size(150, 30);
            this.bajaButton.TabIndex = 22;
            this.bajaButton.Text = "Dar de baja";
            this.bajaButton.UseVisualStyleBackColor = true;
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
            this.empresasDataGrid.AutoGenerateColumns = false;
            this.empresasDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerofacturaDataGridViewTextBoxColumn,
            this.facturamontototalDataGridViewTextBoxColumn,
            this.facturafechaaltaDataGridViewTextBoxColumn,
            this.facturafechavencimientoDataGridViewTextBoxColumn,
            this.dniclienteDataGridViewTextBoxColumn,
            this.idempresaDataGridViewTextBoxColumn,
            this.numerorendicionDataGridViewTextBoxColumn,
            this.habilitadxDataGridViewCheckBoxColumn});
            this.empresasDataGrid.DataSource = this.facturaBindingSource;
            this.empresasDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empresasDataGrid.Location = new System.Drawing.Point(3, 16);
            this.empresasDataGrid.MultiSelect = false;
            this.empresasDataGrid.Name = "empresasDataGrid";
            this.empresasDataGrid.ReadOnly = true;
            this.empresasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empresasDataGrid.Size = new System.Drawing.Size(886, 343);
            this.empresasDataGrid.TabIndex = 0;
            // 
            // volverAInicioButton
            // 
            this.volverAInicioButton.Location = new System.Drawing.Point(12, 12);
            this.volverAInicioButton.Name = "volverAInicioButton";
            this.volverAInicioButton.Size = new System.Drawing.Size(28, 23);
            this.volverAInicioButton.TabIndex = 20;
            this.volverAInicioButton.Text = "<<";
            this.volverAInicioButton.UseVisualStyleBackColor = true;
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
            this.filtrosTabla.Controls.Add(this.habilitadaCheckbox, 5, 1);
            this.filtrosTabla.Controls.Add(this.habilitadaTextBox, 4, 1);
            this.filtrosTabla.Controls.Add(this.clienteTextBox, 5, 0);
            this.filtrosTabla.Controls.Add(this.empresaTextBox, 3, 0);
            this.filtrosTabla.Controls.Add(this.pagadaLabel, 0, 1);
            this.filtrosTabla.Controls.Add(this.numeroFactura, 0, 0);
            this.filtrosTabla.Controls.Add(this.limpiarButton, 7, 0);
            this.filtrosTabla.Controls.Add(this.buscarButton, 7, 1);
            this.filtrosTabla.Controls.Add(this.cuitLabel, 2, 0);
            this.filtrosTabla.Controls.Add(this.clienteLabel, 4, 0);
            this.filtrosTabla.Controls.Add(this.buscadorCliente, 6, 0);
            this.filtrosTabla.Controls.Add(this.rendidaLabel, 2, 1);
            this.filtrosTabla.Controls.Add(this.pagadaCheckbox, 1, 1);
            this.filtrosTabla.Controls.Add(this.rendidaCheckbox, 3, 1);
            this.filtrosTabla.Controls.Add(this.numeroTextBox, 1, 0);
            this.filtrosTabla.Location = new System.Drawing.Point(11, 27);
            this.filtrosTabla.Name = "filtrosTabla";
            this.filtrosTabla.RowCount = 2;
            this.filtrosTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtrosTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtrosTabla.Size = new System.Drawing.Size(875, 59);
            this.filtrosTabla.TabIndex = 4;
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
            // 
            // pagadaLabel
            // 
            this.pagadaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pagadaLabel.AutoSize = true;
            this.pagadaLabel.Location = new System.Drawing.Point(3, 37);
            this.pagadaLabel.Name = "pagadaLabel";
            this.pagadaLabel.Size = new System.Drawing.Size(103, 13);
            this.pagadaLabel.TabIndex = 12;
            this.pagadaLabel.Text = "Pagada";
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
            // cuitLabel
            // 
            this.cuitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(221, 8);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(103, 13);
            this.cuitLabel.TabIndex = 2;
            this.cuitLabel.Text = "Nombre de empresa";
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
            // buscadorCliente
            // 
            this.buscadorCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buscadorCliente.Location = new System.Drawing.Point(658, 3);
            this.buscadorCliente.Name = "buscadorCliente";
            this.buscadorCliente.Size = new System.Drawing.Size(100, 23);
            this.buscadorCliente.TabIndex = 13;
            this.buscadorCliente.Text = "Seleccionar";
            this.buscadorCliente.UseVisualStyleBackColor = true;
            // 
            // rendidaLabel
            // 
            this.rendidaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rendidaLabel.AutoSize = true;
            this.rendidaLabel.Location = new System.Drawing.Point(221, 37);
            this.rendidaLabel.Name = "rendidaLabel";
            this.rendidaLabel.Size = new System.Drawing.Size(103, 13);
            this.rendidaLabel.TabIndex = 14;
            this.rendidaLabel.Text = "Rendida";
            // 
            // pagadaCheckbox
            // 
            this.pagadaCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagadaCheckbox.AutoSize = true;
            this.pagadaCheckbox.Location = new System.Drawing.Point(156, 37);
            this.pagadaCheckbox.Name = "pagadaCheckbox";
            this.pagadaCheckbox.Size = new System.Drawing.Size(15, 14);
            this.pagadaCheckbox.TabIndex = 15;
            this.pagadaCheckbox.UseVisualStyleBackColor = true;
            // 
            // rendidaCheckbox
            // 
            this.rendidaCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rendidaCheckbox.AutoSize = true;
            this.rendidaCheckbox.Location = new System.Drawing.Point(374, 37);
            this.rendidaCheckbox.Name = "rendidaCheckbox";
            this.rendidaCheckbox.Size = new System.Drawing.Size(15, 14);
            this.rendidaCheckbox.TabIndex = 16;
            this.rendidaCheckbox.UseVisualStyleBackColor = true;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeroTextBox.Location = new System.Drawing.Point(113, 4);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroTextBox.TabIndex = 17;
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empresaTextBox.Location = new System.Drawing.Point(331, 4);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.empresaTextBox.TabIndex = 18;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clienteTextBox.Location = new System.Drawing.Point(549, 4);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteTextBox.TabIndex = 19;
            // 
            // habilitadaTextBox
            // 
            this.habilitadaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.habilitadaTextBox.AutoSize = true;
            this.habilitadaTextBox.Location = new System.Drawing.Point(439, 37);
            this.habilitadaTextBox.Name = "habilitadaTextBox";
            this.habilitadaTextBox.Size = new System.Drawing.Size(103, 13);
            this.habilitadaTextBox.TabIndex = 20;
            this.habilitadaTextBox.Text = "Habilitada";
            // 
            // habilitadaCheckbox
            // 
            this.habilitadaCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.habilitadaCheckbox.AutoSize = true;
            this.habilitadaCheckbox.Location = new System.Drawing.Point(592, 37);
            this.habilitadaCheckbox.Name = "habilitadaCheckbox";
            this.habilitadaCheckbox.Size = new System.Drawing.Size(15, 14);
            this.habilitadaCheckbox.TabIndex = 21;
            this.habilitadaCheckbox.UseVisualStyleBackColor = true;
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
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // numerofacturaDataGridViewTextBoxColumn
            // 
            this.numerofacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numerofacturaDataGridViewTextBoxColumn.DataPropertyName = "numero_factura";
            this.numerofacturaDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numerofacturaDataGridViewTextBoxColumn.Name = "numerofacturaDataGridViewTextBoxColumn";
            this.numerofacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturamontototalDataGridViewTextBoxColumn
            // 
            this.facturamontototalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.facturamontototalDataGridViewTextBoxColumn.DataPropertyName = "factura_monto_total";
            this.facturamontototalDataGridViewTextBoxColumn.HeaderText = "Monto total";
            this.facturamontototalDataGridViewTextBoxColumn.Name = "facturamontototalDataGridViewTextBoxColumn";
            this.facturamontototalDataGridViewTextBoxColumn.ReadOnly = true;
            this.facturamontototalDataGridViewTextBoxColumn.Width = 85;
            // 
            // facturafechaaltaDataGridViewTextBoxColumn
            // 
            this.facturafechaaltaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.facturafechaaltaDataGridViewTextBoxColumn.DataPropertyName = "factura_fecha_alta";
            this.facturafechaaltaDataGridViewTextBoxColumn.HeaderText = "Fecha de alta";
            this.facturafechaaltaDataGridViewTextBoxColumn.Name = "facturafechaaltaDataGridViewTextBoxColumn";
            this.facturafechaaltaDataGridViewTextBoxColumn.ReadOnly = true;
            this.facturafechaaltaDataGridViewTextBoxColumn.Width = 97;
            // 
            // facturafechavencimientoDataGridViewTextBoxColumn
            // 
            this.facturafechavencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.facturafechavencimientoDataGridViewTextBoxColumn.DataPropertyName = "factura_fecha_vencimiento";
            this.facturafechavencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de vencimiento";
            this.facturafechavencimientoDataGridViewTextBoxColumn.Name = "facturafechavencimientoDataGridViewTextBoxColumn";
            this.facturafechavencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.facturafechavencimientoDataGridViewTextBoxColumn.Width = 137;
            // 
            // dniclienteDataGridViewTextBoxColumn
            // 
            this.dniclienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dniclienteDataGridViewTextBoxColumn.DataPropertyName = "dni_cliente";
            this.dniclienteDataGridViewTextBoxColumn.HeaderText = "DNI de cliente";
            this.dniclienteDataGridViewTextBoxColumn.Name = "dniclienteDataGridViewTextBoxColumn";
            this.dniclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idempresaDataGridViewTextBoxColumn
            // 
            this.idempresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.HeaderText = "Id de empresa";
            this.idempresaDataGridViewTextBoxColumn.Name = "idempresaDataGridViewTextBoxColumn";
            this.idempresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempresaDataGridViewTextBoxColumn.Width = 99;
            // 
            // numerorendicionDataGridViewTextBoxColumn
            // 
            this.numerorendicionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numerorendicionDataGridViewTextBoxColumn.DataPropertyName = "numero_rendicion";
            this.numerorendicionDataGridViewTextBoxColumn.HeaderText = "Número de rendición";
            this.numerorendicionDataGridViewTextBoxColumn.Name = "numerorendicionDataGridViewTextBoxColumn";
            this.numerorendicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numerorendicionDataGridViewTextBoxColumn.Width = 130;
            // 
            // habilitadxDataGridViewCheckBoxColumn
            // 
            this.habilitadxDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.habilitadxDataGridViewCheckBoxColumn.DataPropertyName = "habilitadx";
            this.habilitadxDataGridViewCheckBoxColumn.HeaderText = "Habilitadx";
            this.habilitadxDataGridViewCheckBoxColumn.Name = "habilitadxDataGridViewCheckBoxColumn";
            this.habilitadxDataGridViewCheckBoxColumn.ReadOnly = true;
            this.habilitadxDataGridViewCheckBoxColumn.Width = 59;
            // 
            // FacturaBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.bajaButton);
            this.Controls.Add(this.resultadosBusquedaPanel);
            this.Controls.Add(this.volverAInicioButton);
            this.Controls.Add(this.filtrosPanel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "FacturaBuscador";
            this.Text = "Consulta de facturas";
            this.Load += new System.EventHandler(this.FacturaBuscador_Load);
            this.resultadosBusquedaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).EndInit();
            this.filtrosPanel.ResumeLayout(false);
            this.filtrosTabla.ResumeLayout(false);
            this.filtrosTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button bajaButton;
        private System.Windows.Forms.GroupBox resultadosBusquedaPanel;
        private System.Windows.Forms.DataGridView empresasDataGrid;
        private System.Windows.Forms.Button volverAInicioButton;
        private System.Windows.Forms.GroupBox filtrosPanel;
        private System.Windows.Forms.TableLayoutPanel filtrosTabla;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label pagadaLabel;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Label numeroFactura;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buscadorCliente;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.Label rendidaLabel;
        private System.Windows.Forms.CheckBox pagadaCheckbox;
        private System.Windows.Forms.CheckBox rendidaCheckbox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.CheckBox habilitadaCheckbox;
        private System.Windows.Forms.Label habilitadaTextBox;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private DataSet.SQL_BOYS_Data_SetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerofacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturamontototalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturafechaaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturafechavencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerorendicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadxDataGridViewCheckBoxColumn;
    }
}