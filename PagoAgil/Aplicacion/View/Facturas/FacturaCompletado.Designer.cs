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
            this.button2 = new System.Windows.Forms.Button();
            this.altaGroup = new System.Windows.Forms.GroupBox();
            this.facturaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.altaLabel = new System.Windows.Forms.Label();
            this.vencimientoLabel = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buscadorCliente = new System.Windows.Forms.Button();
            this.altaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vencimientoTimePicker = new System.Windows.Forms.DateTimePicker();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.itemsBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.montoValor = new System.Windows.Forms.Label();
            this.montoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.itemDataGrid = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.itemTableAdapter = new PagoAgil.DataSet.SQL_BOYS_Data_SetTableAdapters.ItemTableAdapter();
            this.limpiarTodoButton = new System.Windows.Forms.Button();
            this.completarButton = new System.Windows.Forms.Button();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altaGroup.SuspendLayout();
            this.facturaLayout.SuspendLayout();
            this.itemsBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // altaGroup
            // 
            this.altaGroup.Controls.Add(this.facturaLayout);
            this.altaGroup.Controls.Add(this.limpiarButton);
            this.altaGroup.Location = new System.Drawing.Point(89, 76);
            this.altaGroup.Name = "altaGroup";
            this.altaGroup.Size = new System.Drawing.Size(526, 285);
            this.altaGroup.TabIndex = 7;
            this.altaGroup.TabStop = false;
            this.altaGroup.Text = "<Datos>";
            // 
            // facturaLayout
            // 
            this.facturaLayout.ColumnCount = 3;
            this.facturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.facturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.facturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.facturaLayout.Controls.Add(this.empresaLabel, 0, 4);
            this.facturaLayout.Controls.Add(this.numeroLabel, 0, 0);
            this.facturaLayout.Controls.Add(this.dniLabel, 0, 3);
            this.facturaLayout.Controls.Add(this.altaLabel, 0, 1);
            this.facturaLayout.Controls.Add(this.vencimientoLabel, 0, 2);
            this.facturaLayout.Controls.Add(this.numeroTextBox, 1, 0);
            this.facturaLayout.Controls.Add(this.textBox1, 1, 3);
            this.facturaLayout.Controls.Add(this.comboBox1, 1, 4);
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
            // empresaLabel
            // 
            this.empresaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Location = new System.Drawing.Point(3, 173);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(189, 13);
            this.empresaLabel.TabIndex = 4;
            this.empresaLabel.Text = "Nombre de empresa";
            // 
            // numeroLabel
            // 
            this.numeroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(3, 13);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(189, 13);
            this.numeroLabel.TabIndex = 0;
            this.numeroLabel.Text = "Número de factura";
            // 
            // dniLabel
            // 
            this.dniLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(3, 133);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(189, 13);
            this.dniLabel.TabIndex = 3;
            this.dniLabel.Text = "Dni de cliente";
            // 
            // altaLabel
            // 
            this.altaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.altaLabel.AutoSize = true;
            this.altaLabel.Location = new System.Drawing.Point(3, 53);
            this.altaLabel.Name = "altaLabel";
            this.altaLabel.Size = new System.Drawing.Size(189, 13);
            this.altaLabel.TabIndex = 1;
            this.altaLabel.Text = "Fecha de alta";
            // 
            // vencimientoLabel
            // 
            this.vencimientoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.vencimientoLabel.AutoSize = true;
            this.vencimientoLabel.Location = new System.Drawing.Point(3, 93);
            this.vencimientoLabel.Name = "vencimientoLabel";
            this.vencimientoLabel.Size = new System.Drawing.Size(189, 13);
            this.vencimientoLabel.TabIndex = 2;
            this.vencimientoLabel.Text = "Fecha de vencimiento";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroTextBox.Location = new System.Drawing.Point(198, 10);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(189, 20);
            this.numeroTextBox.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(198, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // buscadorCliente
            // 
            this.buscadorCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buscadorCliente.Location = new System.Drawing.Point(402, 128);
            this.buscadorCliente.Name = "buscadorCliente";
            this.buscadorCliente.Size = new System.Drawing.Size(75, 23);
            this.buscadorCliente.TabIndex = 9;
            this.buscadorCliente.Text = "Buscar";
            this.buscadorCliente.UseVisualStyleBackColor = true;
            // 
            // altaTimePicker
            // 
            this.altaTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altaTimePicker.Location = new System.Drawing.Point(198, 50);
            this.altaTimePicker.Name = "altaTimePicker";
            this.altaTimePicker.Size = new System.Drawing.Size(189, 20);
            this.altaTimePicker.TabIndex = 10;
            // 
            // vencimientoTimePicker
            // 
            this.vencimientoTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vencimientoTimePicker.Location = new System.Drawing.Point(198, 90);
            this.vencimientoTimePicker.Name = "vencimientoTimePicker";
            this.vencimientoTimePicker.Size = new System.Drawing.Size(189, 20);
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
            this.itemsBox.Controls.Add(this.button1);
            this.itemsBox.Controls.Add(this.itemDataGrid);
            this.itemsBox.Location = new System.Drawing.Point(89, 379);
            this.itemsBox.Name = "itemsBox";
            this.itemsBox.Size = new System.Drawing.Size(526, 285);
            this.itemsBox.TabIndex = 9;
            this.itemsBox.TabStop = false;
            this.itemsBox.Text = "Items";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.montoValor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.montoLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 195);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 37);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // montoValor
            // 
            this.montoValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.montoValor.AutoSize = true;
            this.montoValor.Location = new System.Drawing.Point(437, 12);
            this.montoValor.Name = "montoValor";
            this.montoValor.Size = new System.Drawing.Size(49, 13);
            this.montoValor.TabIndex = 1;
            this.montoValor.Text = "<Monto>";
            // 
            // montoLabel
            // 
            this.montoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.montoLabel.AutoSize = true;
            this.montoLabel.Location = new System.Drawing.Point(3, 12);
            this.montoLabel.Name = "montoLabel";
            this.montoLabel.Size = new System.Drawing.Size(385, 13);
            this.montoLabel.TabIndex = 0;
            this.montoLabel.Text = "Monto total de factura";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // itemDataGrid
            // 
            this.itemDataGrid.AllowUserToOrderColumns = true;
            this.itemDataGrid.AutoGenerateColumns = false;
            this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.itemDataGrid.DataSource = this.itemBindingSource;
            this.itemDataGrid.Location = new System.Drawing.Point(19, 19);
            this.itemDataGrid.Name = "itemDataGrid";
            this.itemDataGrid.Size = new System.Drawing.Size(489, 165);
            this.itemDataGrid.TabIndex = 0;
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
            this.limpiarTodoButton.Location = new System.Drawing.Point(89, 689);
            this.limpiarTodoButton.Name = "limpiarTodoButton";
            this.limpiarTodoButton.Size = new System.Drawing.Size(150, 25);
            this.limpiarTodoButton.TabIndex = 10;
            this.limpiarTodoButton.Text = "Limpiar todo";
            this.limpiarTodoButton.UseVisualStyleBackColor = true;
            // 
            // completarButton
            // 
            this.completarButton.Location = new System.Drawing.Point(465, 689);
            this.completarButton.Name = "completarButton";
            this.completarButton.Size = new System.Drawing.Size(150, 25);
            this.completarButton.TabIndex = 11;
            this.completarButton.Text = "<Completar>";
            this.completarButton.UseVisualStyleBackColor = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 74;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.FillWeight = 200F;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // FacturaCompletado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 741);
            this.Controls.Add(this.completarButton);
            this.Controls.Add(this.limpiarTodoButton);
            this.Controls.Add(this.itemsBox);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.altaGroup);
            this.Controls.Add(this.button2);
            this.Name = "FacturaCompletado";
            this.Text = "<Completado>";
            this.Load += new System.EventHandler(this.FacturaCompletado_Load);
            this.altaGroup.ResumeLayout(false);
            this.facturaLayout.ResumeLayout(false);
            this.facturaLayout.PerformLayout();
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

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox altaGroup;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label altaLabel;
        private System.Windows.Forms.Label vencimientoLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TableLayoutPanel facturaLayout;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buscadorCliente;
        private System.Windows.Forms.DateTimePicker altaTimePicker;
        private System.Windows.Forms.DateTimePicker vencimientoTimePicker;
        private System.Windows.Forms.GroupBox itemsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView itemDataGrid;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DataSet.SQL_BOYS_Data_SetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label montoLabel;
        private System.Windows.Forms.Label montoValor;
        private System.Windows.Forms.Button limpiarTodoButton;
        private System.Windows.Forms.Button completarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
    }
}