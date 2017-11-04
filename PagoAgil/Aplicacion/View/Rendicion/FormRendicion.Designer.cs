namespace PagoAgil.Aplicacion.View.Rendicion
{
    partial class FormRendicion
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
            this.dataGridRendicion = new System.Windows.Forms.DataGridView();
            this.sQLBOYSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_BOYS_Data_Set = new PagoAgil.DataSet.SQL_BOYS_Data_Set();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRendir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRendicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRendicion
            // 
            this.dataGridRendicion.AllowUserToAddRows = false;
            this.dataGridRendicion.AllowUserToDeleteRows = false;
            this.dataGridRendicion.AllowUserToOrderColumns = true;
            this.dataGridRendicion.AutoGenerateColumns = false;
            this.dataGridRendicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRendicion.DataSource = this.sQLBOYSDataSetBindingSource;
            this.dataGridRendicion.Location = new System.Drawing.Point(24, 50);
            this.dataGridRendicion.Name = "dataGridRendicion";
            this.dataGridRendicion.ReadOnly = true;
            this.dataGridRendicion.Size = new System.Drawing.Size(680, 302);
            this.dataGridRendicion.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la/s empresa/s que quiera rendir";
            // 
            // buttonRendir
            // 
            this.buttonRendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRendir.Location = new System.Drawing.Point(24, 367);
            this.buttonRendir.Name = "buttonRendir";
            this.buttonRendir.Size = new System.Drawing.Size(680, 30);
            this.buttonRendir.TabIndex = 16;
            this.buttonRendir.Text = "Rendir";
            this.buttonRendir.UseVisualStyleBackColor = true;
            this.buttonRendir.Click += new System.EventHandler(this.buttonRendir_Click);
            // 
            // FormRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 414);
            this.Controls.Add(this.buttonRendir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRendicion);
            this.Name = "FormRendicion";
            this.Text = "FormRendicion";
            this.Load += new System.EventHandler(this.FormRendicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRendicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBOYSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_BOYS_Data_Set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRendicion;
        private System.Windows.Forms.BindingSource sQLBOYSDataSetBindingSource;
        private DataSet.SQL_BOYS_Data_Set sQL_BOYS_Data_Set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRendir;
    }
}