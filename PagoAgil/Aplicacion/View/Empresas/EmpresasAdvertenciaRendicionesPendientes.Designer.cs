namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class EmpresasAdvertenciaRendicionesPendientes
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
            this.advertenciaText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // advertenciaTitulo
            // 
            this.advertenciaTitulo.AutoSize = true;
            this.advertenciaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaTitulo.Location = new System.Drawing.Point(146, 26);
            this.advertenciaTitulo.Name = "advertenciaTitulo";
            this.advertenciaTitulo.Size = new System.Drawing.Size(93, 20);
            this.advertenciaTitulo.TabIndex = 5;
            this.advertenciaTitulo.Text = "Advertencia";
            // 
            // advertenciaText
            // 
            this.advertenciaText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.advertenciaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaText.Location = new System.Drawing.Point(12, 9);
            this.advertenciaText.Name = "advertenciaText";
            this.advertenciaText.Size = new System.Drawing.Size(360, 143);
            this.advertenciaText.TabIndex = 3;
            this.advertenciaText.Text = "<Texto>";
            this.advertenciaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmpresasAdvertenciaRendicionesPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.advertenciaTitulo);
            this.Controls.Add(this.advertenciaText);
            this.Name = "EmpresasAdvertenciaRendicionesPendientes";
            this.Text = "Advertencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label advertenciaTitulo;
        private System.Windows.Forms.Label advertenciaText;
    }
}