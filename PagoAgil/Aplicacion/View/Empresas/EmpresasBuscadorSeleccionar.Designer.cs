namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasBuscadorSeleccionar
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
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.bajaButton = new System.Windows.Forms.Button();
            this.resultadosBusquedaPanel = new System.Windows.Forms.GroupBox();
            this.empresasDataGrid = new System.Windows.Forms.DataGridView();
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diarendicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajecomisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadxDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new PagoAgil.DataSet.SQL_BOYS_Data_SetTableAdapters.EmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            this.resultadosBusquedaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sQL_BOYS_Data_Set
            // 
            this.sQL_BOYS_Data_Set.DataSetName = "SQL_BOYS_Data_Set";
            this.sQL_BOYS_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(389, 30);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(206, 20);
            this.tituloLabel.TabIndex = 17;
            this.tituloLabel.Text = "Seleccionador de empresas";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bajaButton
            // 
            this.bajaButton.Location = new System.Drawing.Point(417, 410);
            this.bajaButton.Name = "bajaButton";
            this.bajaButton.Size = new System.Drawing.Size(150, 30);
            this.bajaButton.TabIndex = 18;
            this.bajaButton.Text = "Seleccionar";
            this.bajaButton.UseVisualStyleBackColor = true;
            // 
            // resultadosBusquedaPanel
            // 
            this.resultadosBusquedaPanel.Controls.Add(this.empresasDataGrid);
            this.resultadosBusquedaPanel.Location = new System.Drawing.Point(34, 62);
            this.resultadosBusquedaPanel.Name = "resultadosBusquedaPanel";
            this.resultadosBusquedaPanel.Size = new System.Drawing.Size(926, 329);
            this.resultadosBusquedaPanel.TabIndex = 16;
            this.resultadosBusquedaPanel.TabStop = false;
            this.resultadosBusquedaPanel.Text = "Resultados de búsqueda";
            // 
            // empresasDataGrid
            // 
            this.empresasDataGrid.AutoGenerateColumns = false;
            this.empresasDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempresaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.diarendicionDataGridViewTextBoxColumn,
            this.porcentajecomisionDataGridViewTextBoxColumn,
            this.idrubroDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.habilitadxDataGridViewCheckBoxColumn});
            this.empresasDataGrid.DataSource = this.empresaBindingSource;
            this.empresasDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empresasDataGrid.Location = new System.Drawing.Point(3, 16);
            this.empresasDataGrid.MultiSelect = false;
            this.empresasDataGrid.Name = "empresasDataGrid";
            this.empresasDataGrid.ReadOnly = true;
            this.empresasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empresasDataGrid.Size = new System.Drawing.Size(920, 310);
            this.empresasDataGrid.TabIndex = 1;
            // 
            // idempresaDataGridViewTextBoxColumn
            // 
            this.idempresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idempresaDataGridViewTextBoxColumn.Name = "idempresaDataGridViewTextBoxColumn";
            this.idempresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempresaDataGridViewTextBoxColumn.Width = 41;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            this.cuitDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuitDataGridViewTextBoxColumn.Width = 57;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            this.domicilioDataGridViewTextBoxColumn.Width = 74;
            // 
            // diarendicionDataGridViewTextBoxColumn
            // 
            this.diarendicionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.diarendicionDataGridViewTextBoxColumn.DataPropertyName = "dia_rendicion";
            this.diarendicionDataGridViewTextBoxColumn.HeaderText = "Día de rendición";
            this.diarendicionDataGridViewTextBoxColumn.Name = "diarendicionDataGridViewTextBoxColumn";
            this.diarendicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.diarendicionDataGridViewTextBoxColumn.Width = 111;
            // 
            // porcentajecomisionDataGridViewTextBoxColumn
            // 
            this.porcentajecomisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.porcentajecomisionDataGridViewTextBoxColumn.DataPropertyName = "porcentaje_comision";
            this.porcentajecomisionDataGridViewTextBoxColumn.HeaderText = "Porcentaje de comisión";
            this.porcentajecomisionDataGridViewTextBoxColumn.Name = "porcentajecomisionDataGridViewTextBoxColumn";
            this.porcentajecomisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.porcentajecomisionDataGridViewTextBoxColumn.Width = 142;
            // 
            // idrubroDataGridViewTextBoxColumn
            // 
            this.idrubroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idrubroDataGridViewTextBoxColumn.DataPropertyName = "id_rubro";
            this.idrubroDataGridViewTextBoxColumn.HeaderText = "Id de rubro";
            this.idrubroDataGridViewTextBoxColumn.Name = "idrubroDataGridViewTextBoxColumn";
            this.idrubroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idrubroDataGridViewTextBoxColumn.Width = 83;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
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
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.sQL_BOYS_Data_Set;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // EmpresasBuscadorSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.bajaButton);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.resultadosBusquedaPanel);
            this.Name = "EmpresasBuscadorSeleccionar";
            this.Text = "Seleccionador de empresas";
            this.Load += new System.EventHandler(this.EmpresasBuscadorSeleccionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            this.resultadosBusquedaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button bajaButton;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.GroupBox resultadosBusquedaPanel;
        private System.Windows.Forms.DataGridView empresasDataGrid;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DataSet.SQL_BOYS_Data_SetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diarendicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajecomisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadxDataGridViewCheckBoxColumn;
    }
}