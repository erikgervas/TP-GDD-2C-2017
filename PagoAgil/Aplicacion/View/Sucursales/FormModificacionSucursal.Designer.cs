namespace PagoAgil.Aplicacion.View
{
    partial class FormModificacionSucursal
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
            this.buttonConfirmarCambios = new System.Windows.Forms.Button();
            this.numericUpDownCP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmarCambios
            // 
            this.buttonConfirmarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConfirmarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarCambios.Location = new System.Drawing.Point(178, 227);
            this.buttonConfirmarCambios.Name = "buttonConfirmarCambios";
            this.buttonConfirmarCambios.Size = new System.Drawing.Size(221, 31);
            this.buttonConfirmarCambios.TabIndex = 3;
            this.buttonConfirmarCambios.Text = "Confirmar cambios";
            this.buttonConfirmarCambios.UseVisualStyleBackColor = true;
            this.buttonConfirmarCambios.Click += new System.EventHandler(this.buttonConfirmarCambios_Click);
            // 
            // numericUpDownCP
            // 
            this.numericUpDownCP.Enabled = false;
            this.numericUpDownCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCP.Location = new System.Drawing.Point(178, 128);
            this.numericUpDownCP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCP.Name = "numericUpDownCP";
            this.numericUpDownCP.Size = new System.Drawing.Size(356, 24);
            this.numericUpDownCP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dirección";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código postal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Puede modificar los campos que desee exceptuando el código postal ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstado.Location = new System.Drawing.Point(178, 170);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(91, 22);
            this.checkBoxEstado.TabIndex = 14;
            this.checkBoxEstado.Text = "Habilitada";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.CheckedChanged += new System.EventHandler(this.checkBoxEstado_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(175, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "*Solo puede habilitar";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.Location = new System.Drawing.Point(178, 85);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(356, 24);
            this.textBoxDireccion.TabIndex = 16;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(178, 44);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(356, 24);
            this.textBoxNombre.TabIndex = 17;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // FormModificacionSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 270);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCP);
            this.Controls.Add(this.buttonConfirmarCambios);
            this.Name = "FormModificacionSucursal";
            this.Text = "Modificación-Sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmarCambios;
        private System.Windows.Forms.NumericUpDown numericUpDownCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}