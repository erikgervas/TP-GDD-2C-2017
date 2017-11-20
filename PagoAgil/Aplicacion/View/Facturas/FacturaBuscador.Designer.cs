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
            this.resultadosBusquedaPanel = new System.Windows.Forms.GroupBox();
            this.empresasDataGrid = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendiciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewFacturaBuscadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.filtrosPanel = new System.Windows.Forms.GroupBox();
            this.filtrosTabla = new System.Windows.Forms.TableLayoutPanel();
            this.numeroFactura = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.numeroNumericUpDown = new System.Windows.Forms.TextBox();
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.dniNumericUpDown = new System.Windows.Forms.TextBox();
            this.buscadorCliente = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.viewFacturaBuscadorTableAdapter = new PagoAgil.DataSet.SQL_BOYS_Data_SetTableAdapters.viewFacturaBuscadorTableAdapter();
            this.resultadosBusquedaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFacturaBuscadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            this.filtrosPanel.SuspendLayout();
            this.filtrosTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // modificarButton
            // 
            this.modificarButton.Enabled = false;
            this.modificarButton.Location = new System.Drawing.Point(417, 556);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(150, 30);
            this.modificarButton.TabIndex = 23;
            this.modificarButton.Text = "Expectante";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
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
            this.numeroDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.altaDataGridViewTextBoxColumn,
            this.vencimientoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.Cuit_Empresa,
            this.pagoDataGridViewTextBoxColumn,
            this.rendiciónDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1});
            this.empresasDataGrid.DataSource = this.viewFacturaBuscadorBindingSource;
            this.empresasDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empresasDataGrid.Location = new System.Drawing.Point(3, 16);
            this.empresasDataGrid.MultiSelect = false;
            this.empresasDataGrid.Name = "empresasDataGrid";
            this.empresasDataGrid.ReadOnly = true;
            this.empresasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empresasDataGrid.Size = new System.Drawing.Size(886, 343);
            this.empresasDataGrid.TabIndex = 0;
            this.empresasDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empresasDataGrid_CellClick);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // altaDataGridViewTextBoxColumn
            // 
            this.altaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.altaDataGridViewTextBoxColumn.DataPropertyName = "Alta";
            this.altaDataGridViewTextBoxColumn.HeaderText = "Alta";
            this.altaDataGridViewTextBoxColumn.Name = "altaDataGridViewTextBoxColumn";
            this.altaDataGridViewTextBoxColumn.ReadOnly = true;
            this.altaDataGridViewTextBoxColumn.Width = 50;
            // 
            // vencimientoDataGridViewTextBoxColumn
            // 
            this.vencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vencimientoDataGridViewTextBoxColumn.DataPropertyName = "Vencimiento";
            this.vencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            this.vencimientoDataGridViewTextBoxColumn.Name = "vencimientoDataGridViewTextBoxColumn";
            this.vencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vencimientoDataGridViewTextBoxColumn.Width = 90;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 64;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaDataGridViewTextBoxColumn.Width = 73;
            // 
            // Cuit_Empresa
            // 
            this.Cuit_Empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cuit_Empresa.DataPropertyName = "Cuit_Empresa";
            this.Cuit_Empresa.HeaderText = "Cuit";
            this.Cuit_Empresa.Name = "Cuit_Empresa";
            this.Cuit_Empresa.ReadOnly = true;
            this.Cuit_Empresa.Width = 50;
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "Pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "Pago";
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            this.pagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagoDataGridViewTextBoxColumn.Width = 57;
            // 
            // rendiciónDataGridViewTextBoxColumn
            // 
            this.rendiciónDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rendiciónDataGridViewTextBoxColumn.DataPropertyName = "Rendición";
            this.rendiciónDataGridViewTextBoxColumn.HeaderText = "Rendición";
            this.rendiciónDataGridViewTextBoxColumn.Name = "rendiciónDataGridViewTextBoxColumn";
            this.rendiciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.rendiciónDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Habilitadx";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Habilitadx";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 59;
            // 
            // viewFacturaBuscadorBindingSource
            // 
            this.viewFacturaBuscadorBindingSource.DataMember = "viewFacturaBuscador";
            this.viewFacturaBuscadorBindingSource.DataSource = this.sQL_BOYS_Data_Set;
            // 
            // sQL_BOYS_Data_Set
            // 
            this.sQL_BOYS_Data_Set.DataSetName = "SQL_BOYS_Data_Set";
            this.sQL_BOYS_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.filtrosTabla.ColumnCount = 7;
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93103F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93104F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93104F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93104F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93104F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93104F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.41379F));
            this.filtrosTabla.Controls.Add(this.numeroFactura, 0, 0);
            this.filtrosTabla.Controls.Add(this.clienteLabel, 4, 0);
            this.filtrosTabla.Controls.Add(this.cuitLabel, 2, 0);
            this.filtrosTabla.Controls.Add(this.numeroNumericUpDown, 1, 0);
            this.filtrosTabla.Controls.Add(this.empresaComboBox, 3, 0);
            this.filtrosTabla.Controls.Add(this.dniNumericUpDown, 5, 0);
            this.filtrosTabla.Controls.Add(this.limpiarButton, 6, 1);
            this.filtrosTabla.Controls.Add(this.buscarButton, 6, 0);
            this.filtrosTabla.Controls.Add(this.buscadorCliente, 5, 1);
            this.filtrosTabla.Location = new System.Drawing.Point(11, 27);
            this.filtrosTabla.Name = "filtrosTabla";
            this.filtrosTabla.RowCount = 2;
            this.filtrosTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtrosTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtrosTabla.Size = new System.Drawing.Size(875, 59);
            this.filtrosTabla.TabIndex = 4;
            // 
            // numeroFactura
            // 
            this.numeroFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroFactura.AutoSize = true;
            this.numeroFactura.Location = new System.Drawing.Point(3, 8);
            this.numeroFactura.Name = "numeroFactura";
            this.numeroFactura.Size = new System.Drawing.Size(107, 13);
            this.numeroFactura.TabIndex = 1;
            this.numeroFactura.Text = "Número";
            // 
            // clienteLabel
            // 
            this.clienteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(455, 8);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(107, 13);
            this.clienteLabel.TabIndex = 4;
            this.clienteLabel.Text = "DNI de cliente";
            // 
            // cuitLabel
            // 
            this.cuitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(229, 8);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(107, 13);
            this.cuitLabel.TabIndex = 2;
            this.cuitLabel.Text = "Cuit de empresa";
            // 
            // numeroNumericUpDown
            // 
            this.numeroNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numeroNumericUpDown.Location = new System.Drawing.Point(116, 4);
            this.numeroNumericUpDown.Name = "numeroNumericUpDown";
            this.numeroNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.numeroNumericUpDown.TabIndex = 24;
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(342, 4);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(103, 21);
            this.empresaComboBox.TabIndex = 25;
            // 
            // dniNumericUpDown
            // 
            this.dniNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dniNumericUpDown.Location = new System.Drawing.Point(568, 4);
            this.dniNumericUpDown.Name = "dniNumericUpDown";
            this.dniNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.dniNumericUpDown.TabIndex = 26;
            // 
            // buscadorCliente
            // 
            this.buscadorCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buscadorCliente.Location = new System.Drawing.Point(568, 32);
            this.buscadorCliente.Name = "buscadorCliente";
            this.buscadorCliente.Size = new System.Drawing.Size(103, 23);
            this.buscadorCliente.TabIndex = 13;
            this.buscadorCliente.Text = "Seleccionar";
            this.buscadorCliente.UseVisualStyleBackColor = true;
            this.buscadorCliente.Click += new System.EventHandler(this.buscadorCliente_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.limpiarButton.Location = new System.Drawing.Point(772, 32);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(100, 23);
            this.limpiarButton.TabIndex = 10;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buscarButton.Location = new System.Drawing.Point(772, 3);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(100, 23);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
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
            // viewFacturaBuscadorTableAdapter
            // 
            this.viewFacturaBuscadorTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.resultadosBusquedaPanel);
            this.Controls.Add(this.filtrosPanel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "FacturaBuscador";
            this.Text = "Consulta de facturas";
            this.Load += new System.EventHandler(this.FacturaBuscador_Load);
            this.resultadosBusquedaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFacturaBuscadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            this.filtrosPanel.ResumeLayout(false);
            this.filtrosTabla.ResumeLayout(false);
            this.filtrosTabla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.GroupBox resultadosBusquedaPanel;
        private System.Windows.Forms.GroupBox filtrosPanel;
        private System.Windows.Forms.TableLayoutPanel filtrosTabla;
        private System.Windows.Forms.Label numeroFactura;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadxDataGridViewCheckBoxColumn;
        public System.Windows.Forms.ComboBox empresaComboBox;
        public System.Windows.Forms.TextBox dniNumericUpDown;
        public System.Windows.Forms.TextBox numeroNumericUpDown;
        private System.Windows.Forms.DataGridView empresasDataGrid;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button buscarButton;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.BindingSource viewFacturaBuscadorBindingSource;
        private DataSet.SQL_BOYS_Data_SetTableAdapters.viewFacturaBuscadorTableAdapter viewFacturaBuscadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendiciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button buscadorCliente;
    }
}