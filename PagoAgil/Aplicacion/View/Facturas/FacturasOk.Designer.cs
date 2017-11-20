namespace PagoAgil.Aplicacion.View.Facturas
{
    partial class FacturasOk
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
            this.SuspendLayout();
            // 
            // confirmacionText
            // 
            this.confirmacionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmacionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmacionText.Location = new System.Drawing.Point(12, 9);
            this.confirmacionText.Name = "confirmacionText";
            this.confirmacionText.Size = new System.Drawing.Size(360, 143);
            this.confirmacionText.TabIndex = 1;
            this.confirmacionText.Text = "<Mensaje de éxito>";
            this.confirmacionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FacturasOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.confirmacionText);
            this.Name = "FacturasOk";
            this.Text = "<Exito>";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label confirmacionText;
    }
}