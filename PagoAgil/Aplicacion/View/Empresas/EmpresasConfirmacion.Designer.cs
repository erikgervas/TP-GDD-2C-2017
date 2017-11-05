namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasConfirmacion
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
            this.seguirModificandoButton = new System.Windows.Forms.Button();
            this.altaButton = new System.Windows.Forms.Button();
            this.altaGroup = new System.Windows.Forms.GroupBox();
            this.habilitadaCheckBox = new System.Windows.Forms.CheckBox();
            this.altaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.porcentajeText = new System.Windows.Forms.Label();
            this.porcentajeAsignadoText = new System.Windows.Forms.Label();
            this.diaAsignadoLabel = new System.Windows.Forms.Label();
            this.rubroAsignadoLabel = new System.Windows.Forms.Label();
            this.direccionAsignadaLabel = new System.Windows.Forms.Label();
            this.cuitAsignadoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.rubroLabel = new System.Windows.Forms.Label();
            this.diaLabel = new System.Windows.Forms.Label();
            this.nombreAsignadoLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.altaGroup.SuspendLayout();
            this.altaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // seguirModificandoButton
            // 
            this.seguirModificandoButton.Location = new System.Drawing.Point(131, 435);
            this.seguirModificandoButton.Name = "seguirModificandoButton";
            this.seguirModificandoButton.Size = new System.Drawing.Size(150, 30);
            this.seguirModificandoButton.TabIndex = 11;
            this.seguirModificandoButton.Text = "Seguir modificando";
            this.seguirModificandoButton.UseVisualStyleBackColor = true;
            this.seguirModificandoButton.Click += new System.EventHandler(this.seguirModificandoButton_Click);
            // 
            // altaButton
            // 
            this.altaButton.Location = new System.Drawing.Point(339, 435);
            this.altaButton.Name = "altaButton";
            this.altaButton.Size = new System.Drawing.Size(150, 30);
            this.altaButton.TabIndex = 10;
            this.altaButton.Text = "Confirmar";
            this.altaButton.UseVisualStyleBackColor = true;
            this.altaButton.Click += new System.EventHandler(this.altaButton_Click);
            // 
            // altaGroup
            // 
            this.altaGroup.Controls.Add(this.habilitadaCheckBox);
            this.altaGroup.Controls.Add(this.altaPanel);
            this.altaGroup.Location = new System.Drawing.Point(131, 76);
            this.altaGroup.Name = "altaGroup";
            this.altaGroup.Size = new System.Drawing.Size(358, 341);
            this.altaGroup.TabIndex = 9;
            this.altaGroup.TabStop = false;
            this.altaGroup.Text = "<Datos>";
            // 
            // habilitadaCheckBox
            // 
            this.habilitadaCheckBox.AutoCheck = false;
            this.habilitadaCheckBox.AutoSize = true;
            this.habilitadaCheckBox.Checked = true;
            this.habilitadaCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.habilitadaCheckBox.Enabled = false;
            this.habilitadaCheckBox.Location = new System.Drawing.Point(30, 307);
            this.habilitadaCheckBox.Name = "habilitadaCheckBox";
            this.habilitadaCheckBox.Size = new System.Drawing.Size(73, 17);
            this.habilitadaCheckBox.TabIndex = 12;
            this.habilitadaCheckBox.Text = "Habilitada";
            this.habilitadaCheckBox.UseVisualStyleBackColor = true;
            // 
            // altaPanel
            // 
            this.altaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.altaPanel.ColumnCount = 2;
            this.altaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altaPanel.Controls.Add(this.porcentajeText, 0, 5);
            this.altaPanel.Controls.Add(this.porcentajeAsignadoText, 0, 5);
            this.altaPanel.Controls.Add(this.diaAsignadoLabel, 1, 4);
            this.altaPanel.Controls.Add(this.rubroAsignadoLabel, 1, 3);
            this.altaPanel.Controls.Add(this.direccionAsignadaLabel, 1, 2);
            this.altaPanel.Controls.Add(this.cuitAsignadoLabel, 1, 1);
            this.altaPanel.Controls.Add(this.nombreLabel, 0, 0);
            this.altaPanel.Controls.Add(this.cuitLabel, 0, 1);
            this.altaPanel.Controls.Add(this.direccionLabel, 0, 2);
            this.altaPanel.Controls.Add(this.rubroLabel, 0, 3);
            this.altaPanel.Controls.Add(this.diaLabel, 0, 4);
            this.altaPanel.Controls.Add(this.nombreAsignadoLabel, 1, 0);
            this.altaPanel.Location = new System.Drawing.Point(30, 30);
            this.altaPanel.Name = "altaPanel";
            this.altaPanel.RowCount = 6;
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.altaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.altaPanel.Size = new System.Drawing.Size(296, 243);
            this.altaPanel.TabIndex = 2;
            // 
            // porcentajeText
            // 
            this.porcentajeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.porcentajeText.AutoSize = true;
            this.porcentajeText.Location = new System.Drawing.Point(3, 215);
            this.porcentajeText.Name = "porcentajeText";
            this.porcentajeText.Size = new System.Drawing.Size(142, 13);
            this.porcentajeText.TabIndex = 12;
            this.porcentajeText.Text = "Porcentaje de comisión";
            // 
            // porcentajeAsignadoText
            // 
            this.porcentajeAsignadoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.porcentajeAsignadoText.AutoSize = true;
            this.porcentajeAsignadoText.Location = new System.Drawing.Point(151, 215);
            this.porcentajeAsignadoText.Name = "porcentajeAsignadoText";
            this.porcentajeAsignadoText.Size = new System.Drawing.Size(142, 13);
            this.porcentajeAsignadoText.TabIndex = 11;
            this.porcentajeAsignadoText.Text = "<Porcentaje>";
            // 
            // diaAsignadoLabel
            // 
            this.diaAsignadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diaAsignadoLabel.AutoSize = true;
            this.diaAsignadoLabel.Location = new System.Drawing.Point(151, 173);
            this.diaAsignadoLabel.Name = "diaAsignadoLabel";
            this.diaAsignadoLabel.Size = new System.Drawing.Size(142, 13);
            this.diaAsignadoLabel.TabIndex = 9;
            this.diaAsignadoLabel.Text = "<Día>";
            // 
            // rubroAsignadoLabel
            // 
            this.rubroAsignadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rubroAsignadoLabel.AutoSize = true;
            this.rubroAsignadoLabel.Location = new System.Drawing.Point(151, 133);
            this.rubroAsignadoLabel.Name = "rubroAsignadoLabel";
            this.rubroAsignadoLabel.Size = new System.Drawing.Size(142, 13);
            this.rubroAsignadoLabel.TabIndex = 8;
            this.rubroAsignadoLabel.Text = "<Rubro>";
            // 
            // direccionAsignadaLabel
            // 
            this.direccionAsignadaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionAsignadaLabel.AutoSize = true;
            this.direccionAsignadaLabel.Location = new System.Drawing.Point(151, 93);
            this.direccionAsignadaLabel.Name = "direccionAsignadaLabel";
            this.direccionAsignadaLabel.Size = new System.Drawing.Size(142, 13);
            this.direccionAsignadaLabel.TabIndex = 7;
            this.direccionAsignadaLabel.Text = "<Dirección>";
            // 
            // cuitAsignadoLabel
            // 
            this.cuitAsignadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuitAsignadoLabel.AutoSize = true;
            this.cuitAsignadoLabel.Location = new System.Drawing.Point(151, 53);
            this.cuitAsignadoLabel.Name = "cuitAsignadoLabel";
            this.cuitAsignadoLabel.Size = new System.Drawing.Size(142, 13);
            this.cuitAsignadoLabel.TabIndex = 6;
            this.cuitAsignadoLabel.Text = "<CUIT>";
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
            // nombreAsignadoLabel
            // 
            this.nombreAsignadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreAsignadoLabel.AutoSize = true;
            this.nombreAsignadoLabel.Location = new System.Drawing.Point(151, 13);
            this.nombreAsignadoLabel.Name = "nombreAsignadoLabel";
            this.nombreAsignadoLabel.Size = new System.Drawing.Size(142, 13);
            this.nombreAsignadoLabel.TabIndex = 5;
            this.nombreAsignadoLabel.Text = "<Nombre>";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(127, 38);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(112, 20);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "<Título nuevo>";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmpresasConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.seguirModificandoButton);
            this.Controls.Add(this.altaButton);
            this.Controls.Add(this.altaGroup);
            this.Controls.Add(this.tituloLabel);
            this.Name = "EmpresasConfirmacion";
            this.Text = "<Confirmación>";
            this.altaGroup.ResumeLayout(false);
            this.altaGroup.PerformLayout();
            this.altaPanel.ResumeLayout(false);
            this.altaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button altaButton;
        private System.Windows.Forms.GroupBox altaGroup;
        private System.Windows.Forms.TableLayoutPanel altaPanel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.Label diaLabel;
        private System.Windows.Forms.Label tituloLabel;
        public System.Windows.Forms.Label diaAsignadoLabel;
        public System.Windows.Forms.Label rubroAsignadoLabel;
        public System.Windows.Forms.Label direccionAsignadaLabel;
        public System.Windows.Forms.Label cuitAsignadoLabel;
        public System.Windows.Forms.Label nombreAsignadoLabel;
        private System.Windows.Forms.Label porcentajeAsignadoText;
        private System.Windows.Forms.Label porcentajeText;
        public System.Windows.Forms.Button seguirModificandoButton;
        public System.Windows.Forms.CheckBox habilitadaCheckBox;
    }
}