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
            this.filtrosPanel = new System.Windows.Forms.GroupBox();
            this.filtrosTabla = new System.Windows.Forms.TableLayoutPanel();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.volverAInicioButton = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.eleccionLabel = new System.Windows.Forms.Label();
            this.rubroComboBox = new System.Windows.Forms.ComboBox();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.cuitText = new System.Windows.Forms.TextBox();
            this.rubroLabel = new System.Windows.Forms.Label();
            this.seleccionarButton = new System.Windows.Forms.Button();
            this.resultadosBusquedaPanel = new System.Windows.Forms.GroupBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.empresaElegidaText = new System.Windows.Forms.TextBox();
            this.resultadosGrid = new System.Windows.Forms.DataGridView();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new PagoAgil.GD2C2017DataSetTableAdapters.EmpresaTableAdapter();
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.sQLBOYSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bajaButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.dniclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadxDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filtrosPanel.SuspendLayout();
            this.filtrosTabla.SuspendLayout();
            this.resultadosBusquedaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrosPanel
            // 
            this.filtrosPanel.Controls.Add(this.buscarButton);
            this.filtrosPanel.Controls.Add(this.limpiarButton);
            this.filtrosPanel.Controls.Add(this.filtrosTabla);
            this.filtrosPanel.Location = new System.Drawing.Point(31, 56);
            this.filtrosPanel.Name = "filtrosPanel";
            this.filtrosPanel.Size = new System.Drawing.Size(571, 127);
            this.filtrosPanel.TabIndex = 7;
            this.filtrosPanel.TabStop = false;
            this.filtrosPanel.Text = "Filtros de búsqueda";
            // 
            // filtrosTabla
            // 
            this.filtrosTabla.ColumnCount = 5;
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.filtrosTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
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
            this.filtrosTabla.Size = new System.Drawing.Size(550, 59);
            this.filtrosTabla.TabIndex = 4;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(227, 27);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(173, 20);
            this.tituloLabel.TabIndex = 6;
            this.tituloLabel.Text = "Buscador de empresas";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // volverAInicioButton
            // 
            this.volverAInicioButton.Location = new System.Drawing.Point(12, 12);
            this.volverAInicioButton.Name = "volverAInicioButton";
            this.volverAInicioButton.Size = new System.Drawing.Size(28, 23);
            this.volverAInicioButton.TabIndex = 8;
            this.volverAInicioButton.Text = "<<";
            this.volverAInicioButton.UseVisualStyleBackColor = true;
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
            this.cuitLabel.Location = new System.Drawing.Point(223, 0);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(32, 13);
            this.cuitLabel.TabIndex = 2;
            this.cuitLabel.Text = "CUIT";
            // 
            // eleccionLabel
            // 
            this.eleccionLabel.AutoSize = true;
            this.eleccionLabel.Location = new System.Drawing.Point(223, 29);
            this.eleccionLabel.Name = "eleccionLabel";
            this.eleccionLabel.Size = new System.Drawing.Size(48, 13);
            this.eleccionLabel.TabIndex = 4;
            this.eleccionLabel.Text = "Elección";
            // 
            // rubroComboBox
            // 
            this.rubroComboBox.FormattingEnabled = true;
            this.rubroComboBox.Location = new System.Drawing.Point(58, 32);
            this.rubroComboBox.Name = "rubroComboBox";
            this.rubroComboBox.Size = new System.Drawing.Size(142, 21);
            this.rubroComboBox.TabIndex = 9;
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(58, 3);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(142, 20);
            this.nombreText.TabIndex = 10;
            // 
            // cuitText
            // 
            this.cuitText.Location = new System.Drawing.Point(278, 3);
            this.cuitText.Name = "cuitText";
            this.cuitText.Size = new System.Drawing.Size(142, 20);
            this.cuitText.TabIndex = 11;
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
            // seleccionarButton
            // 
            this.seleccionarButton.Location = new System.Drawing.Point(278, 32);
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.Size = new System.Drawing.Size(142, 23);
            this.seleccionarButton.TabIndex = 13;
            this.seleccionarButton.Text = "Seleccionar";
            this.seleccionarButton.UseVisualStyleBackColor = true;
            // 
            // resultadosBusquedaPanel
            // 
            this.resultadosBusquedaPanel.Controls.Add(this.resultadosGrid);
            this.resultadosBusquedaPanel.Location = new System.Drawing.Point(31, 191);
            this.resultadosBusquedaPanel.Name = "resultadosBusquedaPanel";
            this.resultadosBusquedaPanel.Size = new System.Drawing.Size(571, 186);
            this.resultadosBusquedaPanel.TabIndex = 9;
            this.resultadosBusquedaPanel.TabStop = false;
            this.resultadosBusquedaPanel.Text = "Resultados de búsqueda";
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
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(486, 98);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            // 
            // empresaElegidaText
            // 
            this.empresaElegidaText.BackColor = System.Drawing.SystemColors.Menu;
            this.empresaElegidaText.Location = new System.Drawing.Point(443, 32);
            this.empresaElegidaText.Name = "empresaElegidaText";
            this.empresaElegidaText.ReadOnly = true;
            this.empresaElegidaText.Size = new System.Drawing.Size(104, 20);
            this.empresaElegidaText.TabIndex = 14;
            // 
            // resultadosGrid
            // 
            this.resultadosGrid.AutoGenerateColumns = false;
            this.resultadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniclienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nacimientoDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.codigopostalDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.habilitadxDataGridViewCheckBoxColumn});
            this.resultadosGrid.DataMember = "Cliente";
            this.resultadosGrid.DataSource = this.sQLBOYSDataSetBindingSource;
            this.resultadosGrid.Location = new System.Drawing.Point(11, 25);
            this.resultadosGrid.Name = "resultadosGrid";
            this.resultadosGrid.Size = new System.Drawing.Size(550, 155);
            this.resultadosGrid.TabIndex = 0;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
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
            // bajaButton
            // 
            this.bajaButton.Location = new System.Drawing.Point(141, 392);
            this.bajaButton.Name = "bajaButton";
            this.bajaButton.Size = new System.Drawing.Size(150, 30);
            this.bajaButton.TabIndex = 10;
            this.bajaButton.Text = "Dar de baja";
            this.bajaButton.UseVisualStyleBackColor = true;
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(342, 392);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(150, 30);
            this.modificarButton.TabIndex = 11;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            // 
            // dniclienteDataGridViewTextBoxColumn
            // 
            this.dniclienteDataGridViewTextBoxColumn.DataPropertyName = "dni_cliente";
            this.dniclienteDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dniclienteDataGridViewTextBoxColumn.Name = "dniclienteDataGridViewTextBoxColumn";
            this.dniclienteDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 80;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 80;
            // 
            // nacimientoDataGridViewTextBoxColumn
            // 
            this.nacimientoDataGridViewTextBoxColumn.DataPropertyName = "nacimiento";
            this.nacimientoDataGridViewTextBoxColumn.HeaderText = "Nacimiento";
            this.nacimientoDataGridViewTextBoxColumn.Name = "nacimientoDataGridViewTextBoxColumn";
            this.nacimientoDataGridViewTextBoxColumn.Width = 80;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 80;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.Width = 80;
            // 
            // codigopostalDataGridViewTextBoxColumn
            // 
            this.codigopostalDataGridViewTextBoxColumn.DataPropertyName = "codigo_postal";
            this.codigopostalDataGridViewTextBoxColumn.HeaderText = "Código Postal";
            this.codigopostalDataGridViewTextBoxColumn.Name = "codigopostalDataGridViewTextBoxColumn";
            this.codigopostalDataGridViewTextBoxColumn.Width = 80;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 80;
            // 
            // habilitadxDataGridViewCheckBoxColumn
            // 
            this.habilitadxDataGridViewCheckBoxColumn.DataPropertyName = "habilitadx";
            this.habilitadxDataGridViewCheckBoxColumn.HeaderText = "Habilitadx";
            this.habilitadxDataGridViewCheckBoxColumn.Name = "habilitadxDataGridViewCheckBoxColumn";
            this.habilitadxDataGridViewCheckBoxColumn.Width = 50;
            // 
            // EmpresasBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.bajaButton);
            this.Controls.Add(this.resultadosBusquedaPanel);
            this.Controls.Add(this.volverAInicioButton);
            this.Controls.Add(this.filtrosPanel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "EmpresasBuscador";
            this.Text = "Consulta de empresas";
            this.Load += new System.EventHandler(this.EmpresasBuscador_Load);
            this.filtrosPanel.ResumeLayout(false);
            this.filtrosTabla.ResumeLayout(false);
            this.filtrosTabla.PerformLayout();
            this.resultadosBusquedaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultadosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox filtrosPanel;
        private System.Windows.Forms.TableLayoutPanel filtrosTabla;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button volverAInicioButton;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label eleccionLabel;
        private System.Windows.Forms.ComboBox rubroComboBox;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.TextBox cuitText;
        private System.Windows.Forms.Button seleccionarButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.TextBox empresaElegidaText;
        private System.Windows.Forms.GroupBox resultadosBusquedaPanel;
        private System.Windows.Forms.DataGridView resultadosGrid;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private GD2C2017DataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource sQLBOYSDataSetBindingSource;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button bajaButton;
        private System.Windows.Forms.Button modificarButton;
    }
}