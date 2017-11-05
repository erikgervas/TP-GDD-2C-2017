namespace PagoAgil.Aplicacion.View.Devolucion
{
    partial class FormDevolucion
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNumeroFactura = new System.Windows.Forms.TextBox();
            this.textMotivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDevolverFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de factura";
            // 
            // textNumeroFactura
            // 
            this.textNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroFactura.Location = new System.Drawing.Point(71, 76);
            this.textNumeroFactura.Name = "textNumeroFactura";
            this.textNumeroFactura.Size = new System.Drawing.Size(200, 22);
            this.textNumeroFactura.TabIndex = 1;
            this.textNumeroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeroFactura_KeyPress);
            // 
            // textMotivo
            // 
            this.textMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMotivo.Location = new System.Drawing.Point(71, 134);
            this.textMotivo.Name = "textMotivo";
            this.textMotivo.Size = new System.Drawing.Size(200, 22);
            this.textMotivo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivo";
            // 
            // buttonDevolverFactura
            // 
            this.buttonDevolverFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolverFactura.Location = new System.Drawing.Point(83, 191);
            this.buttonDevolverFactura.Name = "buttonDevolverFactura";
            this.buttonDevolverFactura.Size = new System.Drawing.Size(173, 31);
            this.buttonDevolverFactura.TabIndex = 4;
            this.buttonDevolverFactura.Text = "Devolver";
            this.buttonDevolverFactura.UseVisualStyleBackColor = true;
            this.buttonDevolverFactura.Click += new System.EventHandler(this.buttonDevolverFactura_Click);
            // 
            // FormDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 290);
            this.Controls.Add(this.buttonDevolverFactura);
            this.Controls.Add(this.textMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNumeroFactura);
            this.Controls.Add(this.label1);
            this.Name = "FormDevolucion";
            this.Text = "FormDevolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumeroFactura;
        private System.Windows.Forms.TextBox textMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDevolverFactura;

    }
}