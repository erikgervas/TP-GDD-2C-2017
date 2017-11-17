namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasOk
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
            this.confirmacionText = new System.Windows.Forms.Label();
            this.volverAInicioButton = new System.Windows.Forms.Button();
            this.volverAEmpresasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmacionText
            // 
            this.confirmacionText.AutoSize = true;
            this.confirmacionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmacionText.Location = new System.Drawing.Point(27, 29);
            this.confirmacionText.Name = "confirmacionText";
            this.confirmacionText.Size = new System.Drawing.Size(146, 20);
            this.confirmacionText.TabIndex = 0;
            this.confirmacionText.Text = "<Mensaje de éxito>";
            this.confirmacionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volverAInicioButton
            // 
            this.volverAInicioButton.Location = new System.Drawing.Point(27, 88);
            this.volverAInicioButton.Name = "volverAInicioButton";
            this.volverAInicioButton.Size = new System.Drawing.Size(120, 30);
            this.volverAInicioButton.TabIndex = 1;
            this.volverAInicioButton.Text = "Volver a inicio";
            this.volverAInicioButton.UseVisualStyleBackColor = true;
            this.volverAInicioButton.Click += new System.EventHandler(this.volverAInicioButton_Click);
            // 
            // volverAEmpresasButton
            // 
            this.volverAEmpresasButton.Location = new System.Drawing.Point(243, 88);
            this.volverAEmpresasButton.Name = "volverAEmpresasButton";
            this.volverAEmpresasButton.Size = new System.Drawing.Size(120, 30);
            this.volverAEmpresasButton.TabIndex = 2;
            this.volverAEmpresasButton.Text = "Volver a Empresas";
            this.volverAEmpresasButton.UseVisualStyleBackColor = true;
            this.volverAEmpresasButton.Click += new System.EventHandler(this.volverAEmpresasButton_Click);
            // 
            // EmpresasOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.volverAEmpresasButton);
            this.Controls.Add(this.volverAInicioButton);
            this.Controls.Add(this.confirmacionText);
            this.Name = "EmpresasOk";
            this.Text = "<Éxito>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmacionText;
        private System.Windows.Forms.Button volverAInicioButton;
        private System.Windows.Forms.Button volverAEmpresasButton;
    }
}