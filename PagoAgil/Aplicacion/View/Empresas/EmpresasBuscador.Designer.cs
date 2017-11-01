namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasBuscador
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
            this.bajaButton = new System.Windows.Forms.Button();
            this.resultadosBusquedaPanel = new System.Windows.Forms.GroupBox();
            this.empresasDataGrid = new System.Windows.Forms.DataGridView();
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diarendicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadxDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sQLBOYSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.volverAInicioButton = new System.Windows.Forms.Button();
            this.filtrosPanel = new System.Windows.Forms.GroupBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.filtrosTabla = new System.Windows.Forms.TableLayoutPanel();
            this.rubroLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.rubroComboBox = new System.Windows.Forms.ComboBox();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.cuitText = new System.Windows.Forms.TextBox();
            this.eleccionLabel = new System.Windows.Forms.Label();
            this.seleccionarButton = new System.Windows.Forms.Button();
            this.empresaElegidaText = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.modificarButton = new System.Windows.Forms.Button();
            this.resultadosBusquedaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            this.filtrosPanel.SuspendLayout();
            this.filtrosTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // bajaButton
            // 
            this.bajaButton.Location = new System.Drawing.Point(191, 395);
            this.bajaButton.Name = "bajaButton";
            this.bajaButton.Size = new System.Drawing.Size(150, 30);
            this.bajaButton.TabIndex = 16;
            this.bajaButton.Text = "Dar de baja";
            this.bajaButton.UseVisualStyleBackColor = true;
            // 
            // resultadosBusquedaPanel
            // 
            this.resultadosBusquedaPanel.Controls.Add(this.empresasDataGrid);
            this.resultadosBusquedaPanel.Location = new System.Drawing.Point(36, 194);
            this.resultadosBusquedaPanel.Name = "resultadosBusquedaPanel";
            this.resultadosBusquedaPanel.Size = new System.Drawing.Size(757, 186);
            this.resultadosBusquedaPanel.TabIndex = 15;
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
            this.empresasDataGrid.ReadOnly = true;
            this.empresasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empresasDataGrid.Size = new System.Drawing.Size(744, 161);
            this.empresasDataGrid.TabIndex = 0;
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
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            this.cuitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diarendicionDataGridViewTextBoxColumn
            // 
            this.diarendicionDataGridViewTextBoxColumn.DataPropertyName = "dia_rendicion";
            this.diarendicionDataGridViewTextBoxColumn.HeaderText = "Día de rendición";
            this.diarendicionDataGridViewTextBoxColumn.Name = "diarendicionDataGridViewTextBoxColumn";
            this.diarendicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idrubroDataGridViewTextBoxColumn
            // 
            this.idrubroDataGridViewTextBoxColumn.DataPropertyName = "id_rubro";
            this.idrubroDataGridViewTextBoxColumn.HeaderText = "Id de rubro";
            this.idrubroDataGridViewTextBoxColumn.Name = "idrubroDataGridViewTextBoxColumn";
            this.idrubroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // habilitadxDataGridViewCheckBoxColumn
            // 
            this.habilitadxDataGridViewCheckBoxColumn.DataPropertyName = "habilitadx";
            this.habilitadxDataGridViewCheckBoxColumn.HeaderText = "Habilitadx";
            this.habilitadxDataGridViewCheckBoxColumn.Name = "habilitadxDataGridViewCheckBoxColumn";
            this.habilitadxDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sQLBOYSDataSetBindingSource
            // 
            this.sQLBOYSDataSetBindingSource.DataSource = this.sQL_BOYS_Data_Set;
            this.sQLBOYSDataSetBindingSource.Position = 0;
            // 
            // sQL_BOYS_Data_Set
            // 
            this.sQL_BOYS_Data_Set.DataSetName = "SQL_BOYS_Data_Set";
            this.sQL_BOYS_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volverAInicioButton
            // 
            this.volverAInicioButton.Location = new System.Drawing.Point(12, 12);
            this.volverAInicioButton.Name = "volverAInicioButton";
            this.volverAInicioButton.Size = new System.Drawing.Size(28, 23);
            this.volverAInicioButton.TabIndex = 14;
            this.volverAInicioButton.Text = "<<";
            this.volverAInicioButton.UseVisualStyleBackColor = true;
            this.volverAInicioButton.Click += new System.EventHandler(this.volverAInicioButton_Click);
            // 
            // filtrosPanel
            // 
            this.filtrosPanel.Controls.Add(this.buscarButton);
            this.filtrosPanel.Controls.Add(this.limpiarButton);
            this.filtrosPanel.Controls.Add(this.filtrosTabla);
            this.filtrosPanel.Location = new System.Drawing.Point(36, 59);
            this.filtrosPanel.Name = "filtrosPanel";
            this.filtrosPanel.Size = new System.Drawing.Size(757, 127);
            this.filtrosPanel.TabIndex = 13;
            this.filtrosPanel.TabStop = false;
            this.filtrosPanel.Text = "Filtros de búsqueda";
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(675, 98);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(11, 98);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 10;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // filtrosTabla
            // 
            this.filtrosTabla.ColumnCount = 5;
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.16238F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.31123F));
            this.filtrosTabla.Controls.Add(this.rubroLabel, 0, 1);
            this.filtrosTabla.Controls.Add(this.nombreLabel, 0, 0);
            this.filtrosTabla.Controls.Add(this.cuitLabel, 2, 0);
            this.filtrosTabla.Controls.Add(this.rubroComboBox, 1, 1);
            this.filtrosTabla.Controls.Add(this.nombreText, 1, 0);
            this.filtrosTabla.Controls.Add(this.cuitText, 3, 0);
            this.filtrosTabla.Controls.Add(this.eleccionLabel, 2, 1);
            this.filtrosTabla.Controls.Add(this.seleccionarButton, 3, 1);
            this.filtrosTabla.Controls.Add(this.empresaElegidaText, 4, 1);
            this.filtrosTabla.Location = new System.Drawing.Point(11, 27);
            this.filtrosTabla.Name = "filtrosTabla";
            this.filtrosTabla.RowCount = 2;
            this.filtrosTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtrosTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtrosTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filtrosTabla.Size = new System.Drawing.Size(739, 59);
            this.filtrosTabla.TabIndex = 4;
            // 
            // rubroLabel
            // 
            this.rubroLabel.AutoSize = true;
            this.rubroLabel.Location = new System.Drawing.Point(3, 29);
            this.rubroLabel.Name = "rubroLabel";
            this.rubroLabel.Size = new System.Drawing.Size(36, 13);
            this.rubroLabel.TabIndex = 12;
            this.rubroLabel.Text = "Rubro";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(3, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre";
            // 
            // cuitLabel
            // 
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(296, 0);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(32, 13);
            this.cuitLabel.TabIndex = 2;
            this.cuitLabel.Text = "CUIT";
            // 
            // rubroComboBox
            // 
            this.rubroComboBox.FormattingEnabled = true;
            this.rubroComboBox.Location = new System.Drawing.Point(76, 32);
            this.rubroComboBox.Name = "rubroComboBox";
            this.rubroComboBox.Size = new System.Drawing.Size(142, 21);
            this.rubroComboBox.TabIndex = 9;
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(76, 3);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(142, 20);
            this.nombreText.TabIndex = 10;
            // 
            // cuitText
            // 
            this.cuitText.Location = new System.Drawing.Point(369, 3);
            this.cuitText.Name = "cuitText";
            this.cuitText.Size = new System.Drawing.Size(142, 20);
            this.cuitText.TabIndex = 11;
            // 
            // eleccionLabel
            // 
            this.eleccionLabel.AutoSize = true;
            this.eleccionLabel.Location = new System.Drawing.Point(296, 29);
            this.eleccionLabel.Name = "eleccionLabel";
            this.eleccionLabel.Size = new System.Drawing.Size(48, 13);
            this.eleccionLabel.TabIndex = 4;
            this.eleccionLabel.Text = "Elección";
            // 
            // seleccionarButton
            // 
            this.seleccionarButton.Location = new System.Drawing.Point(369, 32);
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.Size = new System.Drawing.Size(142, 23);
            this.seleccionarButton.TabIndex = 13;
            this.seleccionarButton.Text = "Seleccionar";
            this.seleccionarButton.UseVisualStyleBackColor = true;
            // 
            // empresaElegidaText
            // 
            this.empresaElegidaText.BackColor = System.Drawing.SystemColors.Menu;
            this.empresaElegidaText.Location = new System.Drawing.Point(517, 32);
            this.empresaElegidaText.Name = "empresaElegidaText";
            this.empresaElegidaText.ReadOnly = true;
            this.empresaElegidaText.Size = new System.Drawing.Size(219, 20);
            this.empresaElegidaText.TabIndex = 14;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(328, 30);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(173, 20);
            this.tituloLabel.TabIndex = 12;
            this.tituloLabel.Text = "Buscador de empresas";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(487, 395);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(150, 30);
            this.modificarButton.TabIndex = 17;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            // 
            // EmpresasBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 441);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.bajaButton);
            this.Controls.Add(this.resultadosBusquedaPanel);
            this.Controls.Add(this.volverAInicioButton);
            this.Controls.Add(this.filtrosPanel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "EmpresasBuscador";
            this.Text = "Consulta de empresas";
            this.resultadosBusquedaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            this.filtrosPanel.ResumeLayout(false);
            this.filtrosTabla.ResumeLayout(false);
            this.filtrosTabla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bajaButton;
        private System.Windows.Forms.GroupBox resultadosBusquedaPanel;
        private System.Windows.Forms.DataGridView empresasDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diarendicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource sQLBOYSDataSetBindingSource;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.Button volverAInicioButton;
        private System.Windows.Forms.GroupBox filtrosPanel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.TableLayoutPanel filtrosTabla;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.ComboBox rubroComboBox;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.TextBox cuitText;
        private System.Windows.Forms.Label eleccionLabel;
        private System.Windows.Forms.Button seleccionarButton;
        private System.Windows.Forms.TextBox empresaElegidaText;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button modificarButton;
    }
}