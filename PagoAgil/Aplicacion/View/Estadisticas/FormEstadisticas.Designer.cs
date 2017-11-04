namespace PagoAgil.Aplicacion.View.Estadisticas
{
    partial class FormEstadisticas
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
            this.components = new System.ComponentModel.Container();
            this.comboEstadistica = new System.Windows.Forms.ComboBox();
            this.textAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.primerTrimestre = new System.Windows.Forms.RadioButton();
            this.segundoTrimestre = new System.Windows.Forms.RadioButton();
            this.tercerTrimestre = new System.Windows.Forms.RadioButton();
            this.cuartoTrimestre = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sQLBOYSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.groupColumnas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            this.SuspendLayout();
            // 
            // comboEstadistica
            // 
            this.comboEstadistica.BackColor = System.Drawing.SystemColors.Window;
            this.comboEstadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstadistica.FormattingEnabled = true;
            this.comboEstadistica.Location = new System.Drawing.Point(125, 25);
            this.comboEstadistica.Name = "comboEstadistica";
            this.comboEstadistica.Size = new System.Drawing.Size(868, 24);
            this.comboEstadistica.TabIndex = 5;
            this.comboEstadistica.SelectedIndexChanged += new System.EventHandler(this.comboEstadistica_SelectedIndexChanged);
            // 
            // textAnio
            // 
            this.textAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnio.Location = new System.Drawing.Point(125, 208);
            this.textAnio.MaxLength = 4;
            this.textAnio.Name = "textAnio";
            this.textAnio.Size = new System.Drawing.Size(92, 22);
            this.textAnio.TabIndex = 6;
            this.textAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAnio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estadistica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trimestre";
            // 
            // primerTrimestre
            // 
            this.primerTrimestre.AutoSize = true;
            this.primerTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primerTrimestre.Location = new System.Drawing.Point(59, 284);
            this.primerTrimestre.Name = "primerTrimestre";
            this.primerTrimestre.Size = new System.Drawing.Size(127, 20);
            this.primerTrimestre.TabIndex = 10;
            this.primerTrimestre.TabStop = true;
            this.primerTrimestre.Text = "1 (Enero - Marzo)";
            this.primerTrimestre.UseVisualStyleBackColor = true;
            this.primerTrimestre.CheckedChanged += new System.EventHandler(this.primerTrimestre_CheckedChanged);
            // 
            // segundoTrimestre
            // 
            this.segundoTrimestre.AutoSize = true;
            this.segundoTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoTrimestre.Location = new System.Drawing.Point(59, 320);
            this.segundoTrimestre.Name = "segundoTrimestre";
            this.segundoTrimestre.Size = new System.Drawing.Size(113, 20);
            this.segundoTrimestre.TabIndex = 11;
            this.segundoTrimestre.TabStop = true;
            this.segundoTrimestre.Text = "2 (Abril - Junio)";
            this.segundoTrimestre.UseVisualStyleBackColor = true;
            this.segundoTrimestre.CheckedChanged += new System.EventHandler(this.segundoTrimestre_CheckedChanged);
            // 
            // tercerTrimestre
            // 
            this.tercerTrimestre.AutoSize = true;
            this.tercerTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tercerTrimestre.Location = new System.Drawing.Point(59, 356);
            this.tercerTrimestre.Name = "tercerTrimestre";
            this.tercerTrimestre.Size = new System.Drawing.Size(152, 20);
            this.tercerTrimestre.TabIndex = 12;
            this.tercerTrimestre.TabStop = true;
            this.tercerTrimestre.Text = "3 (Julio - Septiembre)";
            this.tercerTrimestre.UseVisualStyleBackColor = true;
            this.tercerTrimestre.CheckedChanged += new System.EventHandler(this.tercerTrimestre_CheckedChanged);
            // 
            // cuartoTrimestre
            // 
            this.cuartoTrimestre.AutoSize = true;
            this.cuartoTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuartoTrimestre.Location = new System.Drawing.Point(59, 392);
            this.cuartoTrimestre.Name = "cuartoTrimestre";
            this.cuartoTrimestre.Size = new System.Drawing.Size(163, 20);
            this.cuartoTrimestre.TabIndex = 13;
            this.cuartoTrimestre.TabStop = true;
            this.cuartoTrimestre.Text = "4 (Octubre - Diciembre)";
            this.cuartoTrimestre.UseVisualStyleBackColor = true;
            this.cuartoTrimestre.CheckedChanged += new System.EventHandler(this.cuartoTrimestre_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.sQLBOYSDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(241, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 207);
            this.dataGridView1.TabIndex = 14;
            // 
            // sQLBOYSDataSetBindingSource
            // 
            this.sQLBOYSDataSetBindingSource.DataSource = this.sQL_BOYS_Data_Set;
            this.sQLBOYSDataSetBindingSource.Position = 0;
            // 
            // sQL_BOYS_Data_Set
            // 
            this.sQL_BOYS_Data_Set.DataSetName = "SQL_BOYS_Data_Set";
            this.sQL_BOYS_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(33, 452);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(960, 30);
            this.buttonCalcular.TabIndex = 15;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // groupColumnas
            // 
            this.groupColumnas.Location = new System.Drawing.Point(33, 71);
            this.groupColumnas.Name = "groupColumnas";
            this.groupColumnas.Size = new System.Drawing.Size(960, 100);
            this.groupColumnas.TabIndex = 16;
            this.groupColumnas.TabStop = false;
            this.groupColumnas.Text = "Columnas a visualizar";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 514);
            this.Controls.Add(this.groupColumnas);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cuartoTrimestre);
            this.Controls.Add(this.tercerTrimestre);
            this.Controls.Add(this.segundoTrimestre);
            this.Controls.Add(this.primerTrimestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAnio);
            this.Controls.Add(this.comboEstadistica);
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEstadistica;
        private System.Windows.Forms.TextBox textAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton primerTrimestre;
        private System.Windows.Forms.RadioButton segundoTrimestre;
        private System.Windows.Forms.RadioButton tercerTrimestre;
        private System.Windows.Forms.RadioButton cuartoTrimestre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sQLBOYSDataSetBindingSource;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.GroupBox groupColumnas;
    }
}