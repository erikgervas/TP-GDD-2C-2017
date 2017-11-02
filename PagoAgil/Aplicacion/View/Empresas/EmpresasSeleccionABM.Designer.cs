namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasSeleccionABM
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.seleccionABMPanel = new System.Windows.Forms.GroupBox();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.consultarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.seleccionABMPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AccessibleName = "";
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(100, 23);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(81, 20);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Empresas";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // seleccionABMPanel
            // 
            this.seleccionABMPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.seleccionABMPanel.Controls.Add(this.ingresarButton);
            this.seleccionABMPanel.Controls.Add(this.consultarButton);
            this.seleccionABMPanel.Location = new System.Drawing.Point(49, 67);
            this.seleccionABMPanel.Name = "seleccionABMPanel";
            this.seleccionABMPanel.Size = new System.Drawing.Size(183, 144);
            this.seleccionABMPanel.TabIndex = 1;
            this.seleccionABMPanel.TabStop = false;
            this.seleccionABMPanel.Text = "Seleccione acción";
            // 
            // ingresarButton
            // 
            this.ingresarButton.Location = new System.Drawing.Point(32, 40);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(120, 30);
            this.ingresarButton.TabIndex = 3;
            this.ingresarButton.Text = "Dar de alta";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.ingresarButton_Click);
            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(32, 92);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(120, 30);
            this.consultarButton.TabIndex = 2;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpresasSeleccionABM
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seleccionABMPanel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "EmpresasSeleccionABM";
            this.Text = "Empresas";
            this.seleccionABMPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.GroupBox seleccionABMPanel;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button button1;
    }
}