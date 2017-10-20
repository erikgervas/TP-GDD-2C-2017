using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View
{
    class FormABMCliente : Form
    {
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn codigoPostal;
        private DataGridViewTextBoxColumn fechaDeNaciomiento;
        private DataGridViewButtonColumn modificar;
        private DataGridViewButtonColumn eliminar;
        private Button limpiarButton;
        private Button buscarButton;
        private ComboBox CondicionComboBox;
        private TextBox condicionTextBox;
        private Label label1;
        private Label label2;
        private Button nuevoClienteButton;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeNaciomiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.CondicionComboBox = new System.Windows.Forms.ComboBox();
            this.condicionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nuevoClienteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.dni,
            this.mail,
            this.telefono,
            this.direccion,
            this.codigoPostal,
            this.fechaDeNaciomiento,
            this.modificar,
            this.eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // dni
            // 
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            // 
            // mail
            // 
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // codigoPostal
            // 
            this.codigoPostal.HeaderText = "Codigo Postal";
            this.codigoPostal.Name = "codigoPostal";
            // 
            // fechaDeNaciomiento
            // 
            this.fechaDeNaciomiento.HeaderText = "Fecha de nacimiento";
            this.fechaDeNaciomiento.Name = "fechaDeNaciomiento";
            // 
            // modificar
            // 
            this.modificar.HeaderText = "MODIFICAR";
            this.modificar.Name = "modificar";
            this.modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "ELIMINAR";
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(321, 296);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(199, 42);
            this.limpiarButton.TabIndex = 1;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(555, 296);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(199, 42);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            // 
            // CondicionComboBox
            // 
            this.CondicionComboBox.FormattingEnabled = true;
            this.CondicionComboBox.Location = new System.Drawing.Point(429, 162);
            this.CondicionComboBox.Name = "CondicionComboBox";
            this.CondicionComboBox.Size = new System.Drawing.Size(216, 28);
            this.CondicionComboBox.TabIndex = 3;
            // 
            // condicionTextBox
            // 
            this.condicionTextBox.Location = new System.Drawing.Point(452, 238);
            this.condicionTextBox.Name = "condicionTextBox";
            this.condicionTextBox.Size = new System.Drawing.Size(170, 26);
            this.condicionTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Condicion de filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor de filtro";
            // 
            // nuevoClienteButton
            // 
            this.nuevoClienteButton.Location = new System.Drawing.Point(895, 12);
            this.nuevoClienteButton.Name = "nuevoClienteButton";
            this.nuevoClienteButton.Size = new System.Drawing.Size(199, 69);
            this.nuevoClienteButton.TabIndex = 7;
            this.nuevoClienteButton.Text = "NUEVO CLIENTE";
            this.nuevoClienteButton.UseVisualStyleBackColor = true;
            this.nuevoClienteButton.Click += new System.EventHandler(this.nuevoClienteButton_Click);
            // 
            // FormABMCliente
            // 
            this.ClientSize = new System.Drawing.Size(1106, 696);
            this.Controls.Add(this.nuevoClienteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.condicionTextBox);
            this.Controls.Add(this.CondicionComboBox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormABMCliente";
            this.Load += new System.EventHandler(this.FormABMCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void nuevoClienteButton_Click(object sender, EventArgs e)
        {
            Form altaClinte = new FormAltaCliente();
            altaClinte.Show();

        }

        private void FormABMCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
