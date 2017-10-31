namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasAdvertenciaFaltanCampos
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
            this.advertenciaTitulo = new System.Windows.Forms.Label();
            this.volverButton = new System.Windows.Forms.Button();
            this.advertenciaText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // advertenciaTitulo
            // 
            this.advertenciaTitulo.AutoSize = true;
            this.advertenciaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaTitulo.Location = new System.Drawing.Point(142, 26);
            this.advertenciaTitulo.Name = "advertenciaTitulo";
            this.advertenciaTitulo.Size = new System.Drawing.Size(93, 20);
            this.advertenciaTitulo.TabIndex = 5;
            this.advertenciaTitulo.Text = "Advertencia";
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(151, 205);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(75, 23);
            this.volverButton.TabIndex = 4;
            this.volverButton.Text = "Volver atrás";
            this.volverButton.UseVisualStyleBackColor = true;
            // 
            // advertenciaText
            // 
            this.advertenciaText.AutoSize = true;
            this.advertenciaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaText.Location = new System.Drawing.Point(91, 63);
            this.advertenciaText.Name = "advertenciaText";
            this.advertenciaText.Size = new System.Drawing.Size(194, 13);
            this.advertenciaText.TabIndex = 3;
            this.advertenciaText.Text = "Faltan completar los siguientes campos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "<Campos>";
            // 
            // EmpresasAdvertenciaFaltanCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advertenciaTitulo);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.advertenciaText);
            this.Name = "EmpresasAdvertenciaFaltanCampos";
            this.Text = "Advertencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label advertenciaTitulo;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Label advertenciaText;
        private System.Windows.Forms.Label label1;
    }
}