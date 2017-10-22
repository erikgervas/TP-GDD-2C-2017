namespace PagoAgil.Aplicacion.View.Empresas
{
    partial class AltaEmpresas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limiparCampos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textNumDiaRendicion = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textCuit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaRubros = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.diaRendicion = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.darAlta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaRendicion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limiparCampos);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(160, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva empresaBuilder";
            // 
            // limiparCampos
            // 
            this.limiparCampos.Location = new System.Drawing.Point(6, 203);
            this.limiparCampos.Name = "limiparCampos";
            this.limiparCampos.Size = new System.Drawing.Size(75, 23);
            this.limiparCampos.TabIndex = 1;
            this.limiparCampos.Text = "Limpiar";
            this.limiparCampos.UseVisualStyleBackColor = true;
            this.limiparCampos.Click += new System.EventHandler(this.limiparCampos_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel1.Controls.Add(this.textNumDiaRendicion, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textDireccion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textCuit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listaRubros, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.diaRendicion, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 163);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textNumDiaRendicion
            // 
            this.textNumDiaRendicion.AutoSize = true;
            this.textNumDiaRendicion.Location = new System.Drawing.Point(3, 128);
            this.textNumDiaRendicion.Name = "textNumDiaRendicion";
            this.textNumDiaRendicion.Size = new System.Drawing.Size(76, 13);
            this.textNumDiaRendicion.TabIndex = 8;
            this.textNumDiaRendicion.Text = "Día Rendición";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(141, 67);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(148, 20);
            this.textDireccion.TabIndex = 6;
            this.textDireccion.TextChanged += new System.EventHandler(this.textDireccion_TextChanged);
            // 
            // textCuit
            // 
            this.textCuit.Location = new System.Drawing.Point(141, 35);
            this.textCuit.Name = "textCuit";
            this.textCuit.Size = new System.Drawing.Size(148, 20);
            this.textCuit.TabIndex = 5;
            this.textCuit.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // listaRubros
            // 
            this.listaRubros.FormattingEnabled = true;
            this.listaRubros.Items.AddRange(new object[] {
            "Jabones",
            "Shampoo"});
            this.listaRubros.Location = new System.Drawing.Point(141, 99);
            this.listaRubros.Name = "listaRubros";
            this.listaRubros.Size = new System.Drawing.Size(148, 17);
            this.listaRubros.TabIndex = 7;
            this.listaRubros.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CUIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rubro";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(141, 3);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(148, 20);
            this.textNombre.TabIndex = 4;
            this.textNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // diaRendicion
            // 
            this.diaRendicion.Location = new System.Drawing.Point(141, 131);
            this.diaRendicion.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.diaRendicion.Name = "diaRendicion";
            this.diaRendicion.Size = new System.Drawing.Size(35, 20);
            this.diaRendicion.TabIndex = 9;
            this.diaRendicion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diaRendicion.ValueChanged += new System.EventHandler(this.diaRendicion_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alta de empresaBuilder";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darAlta
            // 
            this.darAlta.Location = new System.Drawing.Point(245, 345);
            this.darAlta.Name = "darAlta";
            this.darAlta.Size = new System.Drawing.Size(134, 40);
            this.darAlta.TabIndex = 2;
            this.darAlta.Text = "Dar de alta";
            this.darAlta.UseVisualStyleBackColor = true;
            this.darAlta.Click += new System.EventHandler(this.darAlta_Click);
            // 
            // AltaEmpresas
            // 
            this.AccessibleDescription = "En esta ventana puede ingresar una nueva empresaBuilder al sistema";
            this.AccessibleName = "Alta de empresaBuilder";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 437);
            this.Controls.Add(this.darAlta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AltaEmpresas";
            this.Text = "Alta de empresa";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaRendicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button limiparCampos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaRubros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button darAlta;
        private System.Windows.Forms.Label textNumDiaRendicion;
        private System.Windows.Forms.NumericUpDown diaRendicion;
    }
}