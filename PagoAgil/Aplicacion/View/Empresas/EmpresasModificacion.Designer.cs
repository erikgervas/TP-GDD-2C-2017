namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasModificacion
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
            this.altaButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.altaGroup = new System.Windows.Forms.GroupBox();
            this.habilitadaCheckBox = new System.Windows.Forms.CheckBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.altaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.direccionText = new System.Windows.Forms.TextBox();
            this.cuitText = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.rubroLabel = new System.Windows.Forms.Label();
            this.diaLabel = new System.Windows.Forms.Label();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.rubroComboBox = new System.Windows.Forms.ComboBox();
            this.diaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.porcentajeText = new System.Windows.Forms.Label();
            this.porcentajeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.altaGroup.SuspendLayout();
            this.altaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // altaButton
            // 
            this.altaButton.Location = new System.Drawing.Point(235, 435);
            this.altaButton.Name = "altaButton";
            this.altaButton.Size = new System.Drawing.Size(149, 30);
            this.altaButton.TabIndex = 14;
            this.altaButton.Text = "Modificar";
            this.altaButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // altaGroup
            // 
            this.altaGroup.Controls.Add(this.habilitadaCheckBox);
            this.altaGroup.Controls.Add(this.limpiarButton);
            this.altaGroup.Controls.Add(this.altaPanel);
            this.altaGroup.Location = new System.Drawing.Point(131, 76);
            this.altaGroup.Name = "altaGroup";
            this.altaGroup.Size = new System.Drawing.Size(357, 341);
            this.altaGroup.TabIndex = 12;
            this.altaGroup.TabStop = false;
            this.altaGroup.Text = "Datos nuevos para la empresa";
            // 
            // habilitadaCheckBox
            // 
            this.habilitadaCheckBox.AutoSize = true;
            this.habilitadaCheckBox.Checked = true;
            this.habilitadaCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.habilitadaCheckBox.Enabled = false;
            this.habilitadaCheckBox.Location = new System.Drawing.Point(30, 307);
            this.habilitadaCheckBox.Name = "habilitadaCheckBox";
            this.habilitadaCheckBox.Size = new System.Drawing.Size(73, 17);
            this.habilitadaCheckBox.TabIndex = 5;
            this.habilitadaCheckBox.Text = "Habilitada";
            this.habilitadaCheckBox.UseVisualStyleBackColor = true;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(251, 303);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 3;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // altaPanel
            // 
            this.altaPanel.ColumnCount = 2;
            this.altaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altaPanel.Controls.Add(this.porcentajeText, 0, 5);
            this.altaPanel.Controls.Add(this.direccionText, 1, 2);
            this.altaPanel.Controls.Add(this.cuitText, 1, 1);
            this.altaPanel.Controls.Add(this.nombreLabel, 0, 0);
            this.altaPanel.Controls.Add(this.cuitLabel, 0, 1);
            this.altaPanel.Controls.Add(this.direccionLabel, 0, 2);
            this.altaPanel.Controls.Add(this.rubroLabel, 0, 3);
            this.altaPanel.Controls.Add(this.diaLabel, 0, 4);
            this.altaPanel.Controls.Add(this.nombreText, 1, 0);
            this.altaPanel.Controls.Add(this.rubroComboBox, 1, 3);
            this.altaPanel.Controls.Add(this.diaNumericUpDown, 1, 4);
            this.altaPanel.Controls.Add(this.porcentajeNumericUpDown, 1, 5);
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
            this.direccionText.Location = new System.Drawing.Point(151, 83);
            this.direccionText.Name = "direccionText";
            this.direccionText.Size = new System.Drawing.Size(142, 20);
            this.direccionText.TabIndex = 7;
            this.direccionText.Text = "<Rubro actual>";
            // 
            // cuitText
            // 
            this.cuitText.Location = new System.Drawing.Point(151, 43);
            this.cuitText.Name = "cuitText";
            this.cuitText.Size = new System.Drawing.Size(142, 20);
            this.cuitText.TabIndex = 6;
            this.cuitText.Text = "<CUIT actual>";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(3, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre";
            // 
            // cuitLabel
            // 
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(3, 40);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(32, 13);
            this.cuitLabel.TabIndex = 1;
            this.cuitLabel.Text = "CUIT";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(3, 80);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(52, 13);
            this.direccionLabel.TabIndex = 2;
            this.direccionLabel.Text = "Dirección";
            // 
            // rubroLabel
            // 
            this.rubroLabel.AutoSize = true;
            this.rubroLabel.Location = new System.Drawing.Point(3, 120);
            this.rubroLabel.Name = "rubroLabel";
            this.rubroLabel.Size = new System.Drawing.Size(36, 13);
            this.rubroLabel.TabIndex = 3;
            this.rubroLabel.Text = "Rubro";
            // 
            // diaLabel
            // 
            this.diaLabel.AutoSize = true;
            this.diaLabel.Location = new System.Drawing.Point(3, 160);
            this.diaLabel.Name = "diaLabel";
            this.diaLabel.Size = new System.Drawing.Size(86, 13);
            this.diaLabel.TabIndex = 4;
            this.diaLabel.Text = "Día de rendición";
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(151, 3);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(142, 20);
            this.nombreText.TabIndex = 5;
            this.nombreText.Text = "<Nombre actual>";
            // 
            // rubroComboBox
            // 
            this.rubroComboBox.FormattingEnabled = true;
            this.rubroComboBox.Location = new System.Drawing.Point(151, 123);
            this.rubroComboBox.Name = "rubroComboBox";
            this.rubroComboBox.Size = new System.Drawing.Size(142, 21);
            this.rubroComboBox.TabIndex = 8;
            this.rubroComboBox.Text = "<Rubro actual>";
            // 
            // diaNumericUpDown
            // 
            this.diaNumericUpDown.Location = new System.Drawing.Point(151, 163);
            this.diaNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.diaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diaNumericUpDown.Name = "diaNumericUpDown";
            this.diaNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.diaNumericUpDown.TabIndex = 9;
            this.diaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(218, 34);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(185, 20);
            this.tituloLabel.TabIndex = 11;
            this.tituloLabel.Text = "Modificación de empresa";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // porcentajeText
            // 
            this.porcentajeText.AutoSize = true;
            this.porcentajeText.Location = new System.Drawing.Point(3, 200);
            this.porcentajeText.Name = "porcentajeText";
            this.porcentajeText.Size = new System.Drawing.Size(117, 13);
            this.porcentajeText.TabIndex = 11;
            this.porcentajeText.Text = "Porcentaje de comisión";
            // 
            // porcentajeNumericUpDown
            // 
            this.porcentajeNumericUpDown.Location = new System.Drawing.Point(151, 203);
            this.porcentajeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porcentajeNumericUpDown.Name = "porcentajeNumericUpDown";
            this.porcentajeNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.porcentajeNumericUpDown.TabIndex = 12;
            this.porcentajeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EmpresasModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.altaButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.altaGroup);
            this.Controls.Add(this.tituloLabel);
            this.Name = "EmpresasModificacion";
            this.Text = "Modificación de empresas";
            this.altaGroup.ResumeLayout(false);
            this.altaGroup.PerformLayout();
            this.altaPanel.ResumeLayout(false);
            this.altaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button altaButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox altaGroup;
        private System.Windows.Forms.CheckBox habilitadaCheckBox;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.TableLayoutPanel altaPanel;
        private System.Windows.Forms.TextBox direccionText;
        private System.Windows.Forms.TextBox cuitText;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.Label diaLabel;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.ComboBox rubroComboBox;
        private System.Windows.Forms.NumericUpDown diaNumericUpDown;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label porcentajeText;
        private System.Windows.Forms.NumericUpDown porcentajeNumericUpDown;
    }
}