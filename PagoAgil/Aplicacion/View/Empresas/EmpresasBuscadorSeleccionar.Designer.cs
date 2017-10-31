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
            this.resultadosBusquedaPanel = new System.Windows.Forms.GroupBox();
            this.empresasDataGrid = new System.Windows.Forms.DataGridView();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.bajaButton = new System.Windows.Forms.Button();
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.sQLBOYSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diarendicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadxDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.volverAInicioButton = new System.Windows.Forms.Button();
            this.resultadosBusquedaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // resultadosBusquedaPanel
            // 
            this.resultadosBusquedaPanel.Controls.Add(this.empresasDataGrid);
            this.resultadosBusquedaPanel.Location = new System.Drawing.Point(34, 62);
            this.resultadosBusquedaPanel.Name = "resultadosBusquedaPanel";
            this.resultadosBusquedaPanel.Size = new System.Drawing.Size(757, 186);
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
            this.idrubroDataGridViewTextBoxColumn,
            this.habilitadxDataGridViewCheckBoxColumn});
            this.empresasDataGrid.DataMember = "Empresa";
            this.empresasDataGrid.DataSource = this.sQLBOYSDataSetBindingSource;
            this.empresasDataGrid.Location = new System.Drawing.Point(6, 19);
            this.empresasDataGrid.MultiSelect = false;
            this.empresasDataGrid.Name = "empresasDataGrid";
            this.empresasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empresasDataGrid.Size = new System.Drawing.Size(744, 161);
            this.empresasDataGrid.TabIndex = 0;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(309, 30);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(206, 20);
            this.tituloLabel.TabIndex = 17;
            this.tituloLabel.Text = "Seleccionador de empresas";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bajaButton
            // 
            this.bajaButton.Location = new System.Drawing.Point(337, 269);
            this.bajaButton.Name = "bajaButton";
            this.bajaButton.Size = new System.Drawing.Size(150, 30);
            this.bajaButton.TabIndex = 18;
            this.bajaButton.Text = "Seleccionar";
            this.bajaButton.UseVisualStyleBackColor = true;
            // 
            // sQL_BOYS_Data_Set
            // 
            this.sQL_BOYS_Data_Set.DataSetName = "SQL_BOYS_Data_Set";
            this.sQL_BOYS_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sQLBOYSDataSetBindingSource
            // 
            this.sQLBOYSDataSetBindingSource.DataSource = this.sQL_BOYS_Data_Set;
            this.sQLBOYSDataSetBindingSource.Position = 0;
            // 
            // idempresaDataGridViewTextBoxColumn
            // 
            this.idempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idempresaDataGridViewTextBoxColumn.Name = "idempresaDataGridViewTextBoxColumn";
            this.idempresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            // 
            // diarendicionDataGridViewTextBoxColumn
            // 
            this.diarendicionDataGridViewTextBoxColumn.DataPropertyName = "dia_rendicion";
            this.diarendicionDataGridViewTextBoxColumn.HeaderText = "Día de rendición";
            this.diarendicionDataGridViewTextBoxColumn.Name = "diarendicionDataGridViewTextBoxColumn";
            // 
            // idrubroDataGridViewTextBoxColumn
            // 
            this.idrubroDataGridViewTextBoxColumn.DataPropertyName = "id_rubro";
            this.idrubroDataGridViewTextBoxColumn.HeaderText = "Id de Rubro";
            this.idrubroDataGridViewTextBoxColumn.Name = "idrubroDataGridViewTextBoxColumn";
            // 
            // habilitadxDataGridViewCheckBoxColumn
            // 
            this.habilitadxDataGridViewCheckBoxColumn.DataPropertyName = "habilitadx";
            this.habilitadxDataGridViewCheckBoxColumn.HeaderText = "Habilitadx";
            this.habilitadxDataGridViewCheckBoxColumn.Name = "habilitadxDataGridViewCheckBoxColumn";
            // 
            // volverAInicioButton
            // 
            this.volverAInicioButton.Location = new System.Drawing.Point(12, 12);
            this.volverAInicioButton.Name = "volverAInicioButton";
            this.volverAInicioButton.Size = new System.Drawing.Size(28, 23);
            this.volverAInicioButton.TabIndex = 19;
            this.volverAInicioButton.Text = "<<";
            this.volverAInicioButton.UseVisualStyleBackColor = true;
            // 
            // EmpresasBuscadorSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 311);
            this.Controls.Add(this.volverAInicioButton);
            this.Controls.Add(this.bajaButton);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.resultadosBusquedaPanel);
            this.Name = "EmpresasBuscadorSeleccionar";
            this.Text = "Seleccionador de empresas";
            this.resultadosBusquedaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox resultadosBusquedaPanel;
        private System.Windows.Forms.DataGridView empresasDataGrid;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button bajaButton;
        private System.Windows.Forms.BindingSource sQLBOYSDataSetBindingSource;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diarendicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button volverAInicioButton;
    }
}