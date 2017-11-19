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
            this.volverButton = new System.Windows.Forms.Button();
            this.advertenciaText = new System.Windows.Forms.Label();
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
            this.volverButton.Location = new System.Drawing.Point(151, 114);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(75, 23);
            this.volverButton.TabIndex = 4;
            this.volverButton.Text = "Volver atrás";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // advertenciaText
            // 
            this.advertenciaText.AutoSize = true;
            this.advertenciaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaText.Location = new System.Drawing.Point(73, 63);
            this.advertenciaText.Name = "advertenciaText";
            this.advertenciaText.Size = new System.Drawing.Size(230, 26);
            this.advertenciaText.TabIndex = 3;
            this.advertenciaText.Text = "No se puede dar de baja esta empresa porque\r\ntodavía tiene facturas pendientes de" +
    " rendición.";
            this.advertenciaText.Click += new System.EventHandler(this.advertenciaText_Click);
            // 
            // EmpresasAdvertenciaRendicionesPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.advertenciaTitulo);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.advertenciaText);
            this.Name = "EmpresasAdvertenciaRendicionesPendientes";
            this.Text = "Advertencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label advertenciaTitulo;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Label advertenciaText;
    }
}