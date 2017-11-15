namespace PagoAgil.Aplicacion.View.Facturas
{
    partial class FacturaConfirmado
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
            this.facturaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.numeroFacturaAsignado = new System.Windows.Forms.Label();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.altaLabel = new System.Windows.Forms.Label();
            this.vencimientoLabel = new System.Windows.Forms.Label();
            this.altaAsignada = new System.Windows.Forms.Label();
            this.vencimientoAsignado = new System.Windows.Forms.Label();
            this.dniAsignado = new System.Windows.Forms.Label();
            this.empresaAsignada = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.altaGroup = new System.Windows.Forms.GroupBox();
            this.habilitadoAsignado = new System.Windows.Forms.CheckBox();
            this.montoValor = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.montoLabel = new System.Windows.Forms.Label();
            this.itemsBox = new System.Windows.Forms.GroupBox();
            this.itemDataGrid = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.seguirModificandoButton = new System.Windows.Forms.Button();
            this.completarButton = new System.Windows.Forms.Button();
            this.itemTableAdapter = new PagoAgil.DataSet.SQL_BOYS_Data_SetTableAdapters.ItemTableAdapter();
            this.facturaLayout.SuspendLayout();
            this.altaGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.itemsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            this.SuspendLayout();
            // 
            // facturaLayout
            // 
            this.facturaLayout.ColumnCount = 3;
            this.facturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.facturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.facturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.facturaLayout.Controls.Add(this.numeroFacturaAsignado, 1, 0);
            this.facturaLayout.Controls.Add(this.empresaLabel, 0, 4);
            this.facturaLayout.Controls.Add(this.numeroLabel, 0, 0);
            this.facturaLayout.Controls.Add(this.dniLabel, 0, 3);
            this.facturaLayout.Controls.Add(this.altaLabel, 0, 1);
            this.facturaLayout.Controls.Add(this.vencimientoLabel, 0, 2);
            this.facturaLayout.Controls.Add(this.altaAsignada, 1, 1);
            this.facturaLayout.Controls.Add(this.vencimientoAsignado, 1, 2);
            this.facturaLayout.Controls.Add(this.dniAsignado, 1, 3);
            this.facturaLayout.Controls.Add(this.empresaAsignada, 1, 4);
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
            // numeroFacturaAsignado
            // 
            this.numeroFacturaAsignado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroFacturaAsignado.AutoSize = true;
            this.numeroFacturaAsignado.Location = new System.Drawing.Point(198, 13);
            this.numeroFacturaAsignado.Name = "numeroFacturaAsignado";
            this.numeroFacturaAsignado.Size = new System.Drawing.Size(189, 13);
            this.numeroFacturaAsignado.TabIndex = 5;
            this.numeroFacturaAsignado.Text = "<Número de factura>";
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
            // altaAsignada
            // 
            this.altaAsignada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.altaAsignada.AutoSize = true;
            this.altaAsignada.Location = new System.Drawing.Point(198, 53);
            this.altaAsignada.Name = "altaAsignada";
            this.altaAsignada.Size = new System.Drawing.Size(189, 13);
            this.altaAsignada.TabIndex = 6;
            this.altaAsignada.Text = "<Fecha de alta>";
            // 
            // vencimientoAsignado
            // 
            this.vencimientoAsignado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.vencimientoAsignado.AutoSize = true;
            this.vencimientoAsignado.Location = new System.Drawing.Point(198, 93);
            this.vencimientoAsignado.Name = "vencimientoAsignado";
            this.vencimientoAsignado.Size = new System.Drawing.Size(189, 13);
            this.vencimientoAsignado.TabIndex = 7;
            this.vencimientoAsignado.Text = "<Fecha de vencimiento>";
            // 
            // dniAsignado
            // 
            this.dniAsignado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dniAsignado.AutoSize = true;
            this.dniAsignado.Location = new System.Drawing.Point(198, 133);
            this.dniAsignado.Name = "dniAsignado";
            this.dniAsignado.Size = new System.Drawing.Size(189, 13);
            this.dniAsignado.TabIndex = 8;
            this.dniAsignado.Text = "<Dni de cliente>";
            // 
            // empresaAsignada
            // 
            this.empresaAsignada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empresaAsignada.AutoSize = true;
            this.empresaAsignada.Location = new System.Drawing.Point(198, 173);
            this.empresaAsignada.Name = "empresaAsignada";
            this.empresaAsignada.Size = new System.Drawing.Size(189, 13);
            this.empresaAsignada.TabIndex = 9;
            this.empresaAsignada.Text = "<Nombre de empresa>";
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
            this.tituloLabel.TabIndex = 14;
            this.tituloLabel.Text = "<Título>";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // altaGroup
            // 
            this.altaGroup.Controls.Add(this.habilitadoAsignado);
            this.altaGroup.Controls.Add(this.facturaLayout);
            this.altaGroup.Location = new System.Drawing.Point(89, 76);
            this.altaGroup.Name = "altaGroup";
            this.altaGroup.Size = new System.Drawing.Size(526, 267);
            this.altaGroup.TabIndex = 13;
            this.altaGroup.TabStop = false;
            this.altaGroup.Text = "<Datos>";
            // 
            // habilitadoAsignado
            // 
            this.habilitadoAsignado.AutoSize = true;
            this.habilitadoAsignado.Enabled = false;
            this.habilitadoAsignado.Location = new System.Drawing.Point(435, 240);
            this.habilitadoAsignado.Name = "habilitadoAsignado";
            this.habilitadoAsignado.Size = new System.Drawing.Size(73, 17);
            this.habilitadoAsignado.TabIndex = 5;
            this.habilitadoAsignado.Text = "Habilitada";
            this.habilitadoAsignado.UseVisualStyleBackColor = true;
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
            // itemsBox
            // 
            this.itemsBox.Controls.Add(this.tableLayoutPanel1);
            this.itemsBox.Controls.Add(this.itemDataGrid);
            this.itemsBox.Location = new System.Drawing.Point(89, 349);
            this.itemsBox.Name = "itemsBox";
            this.itemsBox.Size = new System.Drawing.Size(526, 247);
            this.itemsBox.TabIndex = 15;
            this.itemsBox.TabStop = false;
            this.itemsBox.Text = "Items";
            // 
            // itemDataGrid
            // 
            this.itemDataGrid.AllowUserToAddRows = false;
            this.itemDataGrid.AllowUserToDeleteRows = false;
            this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cantidad,
            this.monto});
            this.itemDataGrid.Location = new System.Drawing.Point(19, 19);
            this.itemDataGrid.Name = "itemDataGrid";
            this.itemDataGrid.ReadOnly = true;
            this.itemDataGrid.Size = new System.Drawing.Size(489, 165);
            this.itemDataGrid.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
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
            // seguirModificandoButton
            // 
            this.seguirModificandoButton.Location = new System.Drawing.Point(89, 615);
            this.seguirModificandoButton.Name = "seguirModificandoButton";
            this.seguirModificandoButton.Size = new System.Drawing.Size(150, 25);
            this.seguirModificandoButton.TabIndex = 16;
            this.seguirModificandoButton.Text = "Seguir Modificando";
            this.seguirModificandoButton.UseVisualStyleBackColor = true;
            this.seguirModificandoButton.Click += new System.EventHandler(this.seguirModificandoButton_Click);
            // 
            // completarButton
            // 
            this.completarButton.Location = new System.Drawing.Point(465, 615);
            this.completarButton.Name = "completarButton";
            this.completarButton.Size = new System.Drawing.Size(150, 25);
            this.completarButton.TabIndex = 17;
            this.completarButton.Text = "<Confirmar>";
            this.completarButton.UseVisualStyleBackColor = true;
            this.completarButton.Click += new System.EventHandler(this.completarButton_Click);
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaConfirmado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 661);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.altaGroup);
            this.Controls.Add(this.itemsBox);
            this.Controls.Add(this.seguirModificandoButton);
            this.Controls.Add(this.completarButton);
            this.Name = "FacturaConfirmado";
            this.Text = "<Confirmado>";
            this.Load += new System.EventHandler(this.FacturaConfirmado_Load);
            this.facturaLayout.ResumeLayout(false);
            this.facturaLayout.PerformLayout();
            this.altaGroup.ResumeLayout(false);
            this.altaGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.itemsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel facturaLayout;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label altaLabel;
        private System.Windows.Forms.Label vencimientoLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.GroupBox altaGroup;
        private System.Windows.Forms.Label montoValor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label montoLabel;
        private System.Windows.Forms.GroupBox itemsBox;
        private System.Windows.Forms.DataGridView itemDataGrid;
        private System.Windows.Forms.Button seguirModificandoButton;
        private System.Windows.Forms.Button completarButton;
        private System.Windows.Forms.Label numeroFacturaAsignado;
        private System.Windows.Forms.Label altaAsignada;
        private System.Windows.Forms.Label vencimientoAsignado;
        private System.Windows.Forms.Label dniAsignado;
        private System.Windows.Forms.Label empresaAsignada;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DataSet.SQL_BOYS_Data_SetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.CheckBox habilitadoAsignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;

    }
}