namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasBaja
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.preguntaText = new System.Windows.Forms.Label();
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
            this.altaGroup.SuspendLayout();
            this.altaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // seguirModificandoButton
            // 
            this.seguirModificandoButton.Location = new System.Drawing.Point(131, 435);
            this.seguirModificandoButton.Name = "seguirModificandoButton";
            this.seguirModificandoButton.Size = new System.Drawing.Size(150, 30);
            this.seguirModificandoButton.TabIndex = 19;
            this.seguirModificandoButton.Text = "Sí";
            this.seguirModificandoButton.UseVisualStyleBackColor = true;
            // 
            // altaButton
            // 
            this.altaButton.Location = new System.Drawing.Point(339, 435);
            this.altaButton.Name = "altaButton";
            this.altaButton.Size = new System.Drawing.Size(150, 30);
            this.altaButton.TabIndex = 18;
            this.altaButton.Text = "No";
            this.altaButton.UseVisualStyleBackColor = true;
            // 
            // altaGroup
            // 
            this.altaGroup.Controls.Add(this.altaPanel);
            this.altaGroup.Location = new System.Drawing.Point(131, 76);
            this.altaGroup.Name = "altaGroup";
            this.altaGroup.Size = new System.Drawing.Size(358, 300);
            this.altaGroup.TabIndex = 17;
            this.altaGroup.TabStop = false;
            this.altaGroup.Text = "Datos de la empresa a eliminar";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(246, 34);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(129, 20);
            this.tituloLabel.TabIndex = 16;
            this.tituloLabel.Text = "Baja de empresa";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // preguntaText
            // 
            this.preguntaText.AutoSize = true;
            this.preguntaText.Location = new System.Drawing.Point(207, 405);
            this.preguntaText.Name = "preguntaText";
            this.preguntaText.Size = new System.Drawing.Size(207, 13);
            this.preguntaText.TabIndex = 21;
            this.preguntaText.Text = "¿Seguro quiere dar de baja esta empresa?";
            // 
            // altaPanel
            // 
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
            this.altaPanel.TabIndex = 3;
            // 
            // porcentajeText
            // 
            this.porcentajeText.AutoSize = true;
            this.porcentajeText.Location = new System.Drawing.Point(3, 200);
            this.porcentajeText.Name = "porcentajeText";
            this.porcentajeText.Size = new System.Drawing.Size(117, 13);
            this.porcentajeText.TabIndex = 12;
            this.porcentajeText.Text = "Porcentaje de comisión";
            // 
            // porcentajeAsignadoText
            // 
            this.porcentajeAsignadoText.AutoSize = true;
            this.porcentajeAsignadoText.Location = new System.Drawing.Point(151, 200);
            this.porcentajeAsignadoText.Name = "porcentajeAsignadoText";
            this.porcentajeAsignadoText.Size = new System.Drawing.Size(70, 13);
            this.porcentajeAsignadoText.TabIndex = 11;
            this.porcentajeAsignadoText.Text = "<Porcentaje>";
            // 
            // diaAsignadoLabel
            // 
            this.diaAsignadoLabel.AutoSize = true;
            this.diaAsignadoLabel.Location = new System.Drawing.Point(151, 160);
            this.diaAsignadoLabel.Name = "diaAsignadoLabel";
            this.diaAsignadoLabel.Size = new System.Drawing.Size(37, 13);
            this.diaAsignadoLabel.TabIndex = 9;
            this.diaAsignadoLabel.Text = "<Día>";
            // 
            // rubroAsignadoLabel
            // 
            this.rubroAsignadoLabel.AutoSize = true;
            this.rubroAsignadoLabel.Location = new System.Drawing.Point(151, 120);
            this.rubroAsignadoLabel.Name = "rubroAsignadoLabel";
            this.rubroAsignadoLabel.Size = new System.Drawing.Size(48, 13);
            this.rubroAsignadoLabel.TabIndex = 8;
            this.rubroAsignadoLabel.Text = "<Rubro>";
            // 
            // direccionAsignadaLabel
            // 
            this.direccionAsignadaLabel.AutoSize = true;
            this.direccionAsignadaLabel.Location = new System.Drawing.Point(151, 80);
            this.direccionAsignadaLabel.Name = "direccionAsignadaLabel";
            this.direccionAsignadaLabel.Size = new System.Drawing.Size(64, 13);
            this.direccionAsignadaLabel.TabIndex = 7;
            this.direccionAsignadaLabel.Text = "<Dirección>";
            // 
            // cuitAsignadoLabel
            // 
            this.cuitAsignadoLabel.AutoSize = true;
            this.cuitAsignadoLabel.Location = new System.Drawing.Point(151, 40);
            this.cuitAsignadoLabel.Name = "cuitAsignadoLabel";
            this.cuitAsignadoLabel.Size = new System.Drawing.Size(44, 13);
            this.cuitAsignadoLabel.TabIndex = 6;
            this.cuitAsignadoLabel.Text = "<CUIT>";
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
            // nombreAsignadoLabel
            // 
            this.nombreAsignadoLabel.AutoSize = true;
            this.nombreAsignadoLabel.Location = new System.Drawing.Point(151, 0);
            this.nombreAsignadoLabel.Name = "nombreAsignadoLabel";
            this.nombreAsignadoLabel.Size = new System.Drawing.Size(56, 13);
            this.nombreAsignadoLabel.TabIndex = 5;
            this.nombreAsignadoLabel.Text = "<Nombre>";
            // 
            // EmpresasBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.preguntaText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.seguirModificandoButton);
            this.Controls.Add(this.altaButton);
            this.Controls.Add(this.altaGroup);
            this.Controls.Add(this.tituloLabel);
            this.Name = "EmpresasBaja";
            this.Text = "Baja de empresa";
            this.altaGroup.ResumeLayout(false);
            this.altaPanel.ResumeLayout(false);
            this.altaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seguirModificandoButton;
        private System.Windows.Forms.Button altaButton;
        private System.Windows.Forms.GroupBox altaGroup;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label preguntaText;
        private System.Windows.Forms.TableLayoutPanel altaPanel;
        private System.Windows.Forms.Label porcentajeText;
        private System.Windows.Forms.Label porcentajeAsignadoText;
        public System.Windows.Forms.Label diaAsignadoLabel;
        public System.Windows.Forms.Label rubroAsignadoLabel;
        public System.Windows.Forms.Label direccionAsignadaLabel;
        public System.Windows.Forms.Label cuitAsignadoLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.Label diaLabel;
        public System.Windows.Forms.Label nombreAsignadoLabel;
    }
}