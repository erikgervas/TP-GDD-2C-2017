namespace PagoAgil.Aplicacion.View.Pago
{
    partial class FormSeleccionFacturas
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
            this.numericUpDownNroF = new System.Windows.Forms.NumericUpDown();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.dataGridViewFacturas = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFechaV = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscarFactura = new System.Windows.Forms.Button();
            this.buttonConfirmarFactura = new System.Windows.Forms.Button();
            this.buttonFinalizarPago = new System.Windows.Forms.Button();
            this.numericUpDownImporteTotal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNroF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImporteTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNroF
            // 
            this.numericUpDownNroF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNroF.Location = new System.Drawing.Point(12, 61);
            this.numericUpDownNroF.Name = "numericUpDownNroF";
            this.numericUpDownNroF.Size = new System.Drawing.Size(341, 24);
            this.numericUpDownNroF.TabIndex = 2;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(389, 61);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(372, 21);
            this.comboBoxEmpresa.TabIndex = 3;
            // 
            // dataGridViewFacturas
            // 
            this.dataGridViewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturas.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewFacturas.Name = "dataGridViewFacturas";
            this.dataGridViewFacturas.Size = new System.Drawing.Size(1121, 111);
            this.dataGridViewFacturas.TabIndex = 4;
            // 
            // dateTimePickerFechaV
            // 
            this.dateTimePickerFechaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaV.Location = new System.Drawing.Point(786, 55);
            this.dateTimePickerFechaV.Name = "dateTimePickerFechaV";
            this.dateTimePickerFechaV.Size = new System.Drawing.Size(347, 24);
            this.dateTimePickerFechaV.TabIndex = 5;
            // 
            // buttonBuscarFactura
            // 
            this.buttonBuscarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFactura.Location = new System.Drawing.Point(389, 91);
            this.buttonBuscarFactura.Name = "buttonBuscarFactura";
            this.buttonBuscarFactura.Size = new System.Drawing.Size(372, 40);
            this.buttonBuscarFactura.TabIndex = 15;
            this.buttonBuscarFactura.Text = "Buscar factura";
            this.buttonBuscarFactura.UseVisualStyleBackColor = true;
            this.buttonBuscarFactura.Click += new System.EventHandler(this.buttonBuscarFactura_Click);
            // 
            // buttonConfirmarFactura
            // 
            this.buttonConfirmarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarFactura.Location = new System.Drawing.Point(184, 343);
            this.buttonConfirmarFactura.Name = "buttonConfirmarFactura";
            this.buttonConfirmarFactura.Size = new System.Drawing.Size(349, 40);
            this.buttonConfirmarFactura.TabIndex = 16;
            this.buttonConfirmarFactura.Text = "Confirmar pago de factura";
            this.buttonConfirmarFactura.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizarPago
            // 
            this.buttonFinalizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizarPago.Location = new System.Drawing.Point(623, 343);
            this.buttonFinalizarPago.Name = "buttonFinalizarPago";
            this.buttonFinalizarPago.Size = new System.Drawing.Size(399, 40);
            this.buttonFinalizarPago.TabIndex = 17;
            this.buttonFinalizarPago.Text = "Finalizar el ingreso de facturas para finalizar el pago";
            this.buttonFinalizarPago.UseVisualStyleBackColor = true;
            // 
            // numericUpDownImporteTotal
            // 
            this.numericUpDownImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownImporteTotal.Location = new System.Drawing.Point(389, 292);
            this.numericUpDownImporteTotal.Name = "numericUpDownImporteTotal";
            this.numericUpDownImporteTotal.Size = new System.Drawing.Size(372, 24);
            this.numericUpDownImporteTotal.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Importe final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Número de factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(905, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha de Vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ingrese la/s facturas a desea abonar";
            // 
            // FormSeleccionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 399);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownImporteTotal);
            this.Controls.Add(this.buttonFinalizarPago);
            this.Controls.Add(this.buttonConfirmarFactura);
            this.Controls.Add(this.buttonBuscarFactura);
            this.Controls.Add(this.dateTimePickerFechaV);
            this.Controls.Add(this.dataGridViewFacturas);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.numericUpDownNroF);
            this.Name = "FormSeleccionFacturas";
            this.Text = "FormSeleccionFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNroF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImporteTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownNroF;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.DataGridView dataGridViewFacturas;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaV;
        private System.Windows.Forms.Button buttonBuscarFactura;
        private System.Windows.Forms.Button buttonConfirmarFactura;
        private System.Windows.Forms.Button buttonFinalizarPago;
        private System.Windows.Forms.NumericUpDown numericUpDownImporteTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}