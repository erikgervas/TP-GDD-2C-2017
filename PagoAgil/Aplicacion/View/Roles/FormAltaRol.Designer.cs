namespace PagoAgil.Aplicacion.View.Roles
{
    partial class FormAltaRol
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.buttonCrearRol = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(44, 51);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(356, 24);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkedListBoxFuncionalidades
            // 
            this.checkedListBoxFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxFuncionalidades.FormattingEnabled = true;
            this.checkedListBoxFuncionalidades.Location = new System.Drawing.Point(44, 125);
            this.checkedListBoxFuncionalidades.Name = "checkedListBoxFuncionalidades";
            this.checkedListBoxFuncionalidades.Size = new System.Drawing.Size(356, 214);
            this.checkedListBoxFuncionalidades.TabIndex = 4;
            this.checkedListBoxFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFuncionalidades_SelectedIndexChanged);
            // 
            // buttonCrearRol
            // 
            this.buttonCrearRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearRol.Location = new System.Drawing.Point(239, 387);
            this.buttonCrearRol.Name = "buttonCrearRol";
            this.buttonCrearRol.Size = new System.Drawing.Size(161, 28);
            this.buttonCrearRol.TabIndex = 8;
            this.buttonCrearRol.Text = "Crear rol";
            this.buttonCrearRol.UseVisualStyleBackColor = true;
            this.buttonCrearRol.Click += new System.EventHandler(this.buttonCrearRol_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(44, 387);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(161, 28);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Elija las funcionalidades";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCrearRol);
            this.Controls.Add(this.checkedListBoxFuncionalidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormAltaRol";
            this.Text = "FormAltaRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxFuncionalidades;
        private System.Windows.Forms.Button buttonCrearRol;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label label2;
    }
}