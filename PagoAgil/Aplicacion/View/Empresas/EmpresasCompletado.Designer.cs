namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasCompletado
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.altaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.direccionText = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.rubroLabel = new System.Windows.Forms.Label();
            this.diaLabel = new System.Windows.Forms.Label();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.rubroComboBox = new System.Windows.Forms.ComboBox();
            this.diaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.porcentajeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.porcentajeText = new System.Windows.Forms.Label();
            this.cuitText = new System.Windows.Forms.MaskedTextBox();
            this.altaGroup = new System.Windows.Forms.GroupBox();
            this.habilitadaCheckBox = new System.Windows.Forms.CheckBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.altaButton = new System.Windows.Forms.Button();
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.sQLBOYSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeNumericUpDown)).BeginInit();
            this.altaGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(127, 38);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(65, 20);
            this.tituloLabel.TabIndex = 1;
            this.tituloLabel.Text = "<Título>";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // altaPanel
            // 
            this.altaPanel.ColumnCount = 2;
            this.altaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altaPanel.Controls.Add(this.direccionText, 1, 2);
            this.altaPanel.Controls.Add(this.nombreLabel, 0, 0);
            this.altaPanel.Controls.Add(this.cuitLabel, 0, 1);
            this.altaPanel.Controls.Add(this.direccionLabel, 0, 2);
            this.altaPanel.Controls.Add(this.rubroLabel, 0, 3);
            this.altaPanel.Controls.Add(this.diaLabel, 0, 4);
            this.altaPanel.Controls.Add(this.nombreText, 1, 0);
            this.altaPanel.Controls.Add(this.rubroComboBox, 1, 3);
            this.altaPanel.Controls.Add(this.diaNumericUpDown, 1, 4);
            this.altaPanel.Controls.Add(this.porcentajeNumericUpDown, 1, 5);
            this.altaPanel.Controls.Add(this.porcentajeText, 0, 5);
            this.altaPanel.Controls.Add(this.cuitText, 1, 1);
            this.altaPanel.Location = new System.Drawing.Point(30, 30);
            this.altaPanel.Name = "altaPanel";
            this.altaPanel.RowCount = 6;
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.altaPanel.Size = new System.Drawing.Size(296, 243);
            this.altaPanel.TabIndex = 2;
            // 
            // direccionText
            // 
            this.direccionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionText.Location = new System.Drawing.Point(151, 90);
            this.direccionText.Name = "direccionText";
            this.direccionText.Size = new System.Drawing.Size(142, 20);
            this.direccionText.TabIndex = 7;
            // 
            // nombreLabel
            // 
            this.nombreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(3, 13);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(142, 13);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre";
            // 
            // cuitLabel
            // 
            this.cuitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(3, 53);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(142, 13);
            this.cuitLabel.TabIndex = 1;
            this.cuitLabel.Text = "CUIT";
            // 
            // direccionLabel
            // 
            this.direccionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(3, 93);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(142, 13);
            this.direccionLabel.TabIndex = 2;
            this.direccionLabel.Text = "Dirección";
            // 
            // rubroLabel
            // 
            this.rubroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rubroLabel.AutoSize = true;
            this.rubroLabel.Location = new System.Drawing.Point(3, 133);
            this.rubroLabel.Name = "rubroLabel";
            this.rubroLabel.Size = new System.Drawing.Size(142, 13);
            this.rubroLabel.TabIndex = 3;
            this.rubroLabel.Text = "Rubro";
            // 
            // diaLabel
            // 
            this.diaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diaLabel.AutoSize = true;
            this.diaLabel.Location = new System.Drawing.Point(3, 173);
            this.diaLabel.Name = "diaLabel";
            this.diaLabel.Size = new System.Drawing.Size(142, 13);
            this.diaLabel.TabIndex = 4;
            this.diaLabel.Text = "Día de rendición";
            // 
            // nombreText
            // 
            this.nombreText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreText.Location = new System.Drawing.Point(151, 10);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(142, 20);
            this.nombreText.TabIndex = 5;
            // 
            // rubroComboBox
            // 
            this.rubroComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rubroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rubroComboBox.FormattingEnabled = true;
            this.rubroComboBox.Location = new System.Drawing.Point(151, 129);
            this.rubroComboBox.MaxDropDownItems = 10;
            this.rubroComboBox.Name = "rubroComboBox";
            this.rubroComboBox.Size = new System.Drawing.Size(142, 21);
            this.rubroComboBox.TabIndex = 8;
            // 
            // diaNumericUpDown
            // 
            this.diaNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.diaNumericUpDown.Location = new System.Drawing.Point(151, 170);
            this.diaNumericUpDown.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.diaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diaNumericUpDown.Name = "diaNumericUpDown";
            this.diaNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.diaNumericUpDown.TabIndex = 9;
            this.diaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // porcentajeNumericUpDown
            // 
            this.porcentajeNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.porcentajeNumericUpDown.Location = new System.Drawing.Point(151, 211);
            this.porcentajeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porcentajeNumericUpDown.Name = "porcentajeNumericUpDown";
            this.porcentajeNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.porcentajeNumericUpDown.TabIndex = 11;
            this.porcentajeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // porcentajeText
            // 
            this.porcentajeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.porcentajeText.AutoSize = true;
            this.porcentajeText.Location = new System.Drawing.Point(3, 215);
            this.porcentajeText.Name = "porcentajeText";
            this.porcentajeText.Size = new System.Drawing.Size(142, 13);
            this.porcentajeText.TabIndex = 10;
            this.porcentajeText.Text = "Porcentaje de comisión";
            // 
            // cuitText
            // 
            this.cuitText.Location = new System.Drawing.Point(151, 43);
            this.cuitText.Mask = "9-99999999-9";
            this.cuitText.Name = "cuitText";
            this.cuitText.Size = new System.Drawing.Size(142, 20);
            this.cuitText.TabIndex = 12;
            this.cuitText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cuitText_KeyPress);
            // 
            // altaGroup
            // 
            this.altaGroup.Controls.Add(this.habilitadaCheckBox);
            this.altaGroup.Controls.Add(this.limpiarButton);
            this.altaGroup.Controls.Add(this.altaPanel);
            this.altaGroup.Location = new System.Drawing.Point(131, 76);
            this.altaGroup.Name = "altaGroup";
            this.altaGroup.Size = new System.Drawing.Size(358, 339);
            this.altaGroup.TabIndex = 3;
            this.altaGroup.TabStop = false;
            this.altaGroup.Text = "<Datos>";
            // 
            // habilitadaCheckBox
            // 
            this.habilitadaCheckBox.AutoSize = true;
            this.habilitadaCheckBox.Checked = true;
            this.habilitadaCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.habilitadaCheckBox.Location = new System.Drawing.Point(30, 307);
            this.habilitadaCheckBox.Name = "habilitadaCheckBox";
            this.habilitadaCheckBox.Size = new System.Drawing.Size(73, 17);
            this.habilitadaCheckBox.TabIndex = 4;
            this.habilitadaCheckBox.Text = "Habilitada";
            this.habilitadaCheckBox.UseVisualStyleBackColor = true;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(251, 302);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 3;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // altaButton
            // 
            this.altaButton.Location = new System.Drawing.Point(235, 435);
            this.altaButton.Name = "altaButton";
            this.altaButton.Size = new System.Drawing.Size(150, 30);
            this.altaButton.TabIndex = 6;
            this.altaButton.Text = "<ABM>";
            this.altaButton.UseVisualStyleBackColor = true;
            this.altaButton.Click += new System.EventHandler(this.altaButton_Click);
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
            // EmpresasCompletado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.altaButton);
            this.Controls.Add(this.altaGroup);
            this.Controls.Add(this.tituloLabel);
            this.Name = "EmpresasCompletado";
            this.Text = "<Completado>";
            this.altaPanel.ResumeLayout(false);
            this.altaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeNumericUpDown)).EndInit();
            this.altaGroup.ResumeLayout(false);
            this.altaGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TableLayoutPanel altaPanel;
        private System.Windows.Forms.TextBox direccionText;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.Label diaLabel;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.NumericUpDown diaNumericUpDown;
        private System.Windows.Forms.GroupBox altaGroup;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button altaButton;
        private System.Windows.Forms.NumericUpDown porcentajeNumericUpDown;
        private System.Windows.Forms.Label porcentajeText;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.BindingSource sQLBOYSDataSetBindingSource;
        public System.Windows.Forms.CheckBox habilitadaCheckBox;
        private System.Windows.Forms.MaskedTextBox cuitText;
        public System.Windows.Forms.ComboBox rubroComboBox;
    }
}