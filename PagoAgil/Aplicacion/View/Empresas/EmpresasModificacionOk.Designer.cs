namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasModificacionOk
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
            this.volverAEmpresasButton = new System.Windows.Forms.Button();
            this.volverAInicioButton = new System.Windows.Forms.Button();
            this.confirmacionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // volverAEmpresasButton
            // 
            this.volverAEmpresasButton.Location = new System.Drawing.Point(243, 88);
            this.volverAEmpresasButton.Name = "volverAEmpresasButton";
            this.volverAEmpresasButton.Size = new System.Drawing.Size(120, 30);
            this.volverAEmpresasButton.TabIndex = 5;
            this.volverAEmpresasButton.Text = "Volver a Empresas";
            this.volverAEmpresasButton.UseVisualStyleBackColor = true;
            // 
            // volverAInicioButton
            // 
            this.volverAInicioButton.Location = new System.Drawing.Point(27, 88);
            this.volverAInicioButton.Name = "volverAInicioButton";
            this.volverAInicioButton.Size = new System.Drawing.Size(120, 30);
            this.volverAInicioButton.TabIndex = 4;
            this.volverAInicioButton.Text = "Volver a inicio";
            this.volverAInicioButton.UseVisualStyleBackColor = true;
            // 
            // confirmacionText
            // 
            this.confirmacionText.AutoSize = true;
            this.confirmacionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmacionText.Location = new System.Drawing.Point(23, 31);
            this.confirmacionText.Name = "confirmacionText";
            this.confirmacionText.Size = new System.Drawing.Size(335, 20);
            this.confirmacionText.TabIndex = 3;
            this.confirmacionText.Text = "Se realizaron las modifiaciones en la empresa.";
            // 
            // EmpresasModificacionOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.volverAEmpresasButton);
            this.Controls.Add(this.volverAInicioButton);
            this.Controls.Add(this.confirmacionText);
            this.Name = "EmpresasModificacionOk";
            this.Text = "Modificación confirmada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverAEmpresasButton;
        private System.Windows.Forms.Button volverAInicioButton;
        private System.Windows.Forms.Label confirmacionText;
    }
}