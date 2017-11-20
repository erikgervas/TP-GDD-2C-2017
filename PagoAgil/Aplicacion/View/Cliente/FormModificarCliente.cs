using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Cliente
{
    class FormModificarCliente : Form
    {
        private Button guardarButton;
        private Button limpiarButton;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox codigoPostal;
        private TextBox direccionTextBox;
        private TextBox telefonoTextBox;
        private TextBox mailTextBox;
        private TextBox dniTextBox;
        private TextBox apellidoTextBox;
        private Label label9;
        private TextBox nombreTextBox;
        private CheckBox habilitadoCheckBox;
        ClienteDB cliente;

        public FormModificarCliente(ClienteDB c)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.cliente = c;
        }

        private void InitializeComponent()
        {
            this.guardarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.habilitadoCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(481, 472);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(132, 55);
            this.guardarButton.TabIndex = 35;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(98, 472);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(132, 55);
            this.limpiarButton.TabIndex = 34;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Codigo Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, -129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 397);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 26);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // codigoPostal
            // 
            this.codigoPostal.Location = new System.Drawing.Point(264, 344);
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(201, 26);
            this.codigoPostal.TabIndex = 24;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(264, 291);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(201, 26);
            this.direccionTextBox.TabIndex = 23;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(264, 238);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(201, 26);
            this.telefonoTextBox.TabIndex = 22;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(264, 185);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(201, 26);
            this.mailTextBox.TabIndex = 21;
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(264, 28);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.ReadOnly = true;
            this.dniTextBox.Size = new System.Drawing.Size(201, 26);
            this.dniTextBox.TabIndex = 20;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(264, 133);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(201, 26);
            this.apellidoTextBox.TabIndex = 19;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(264, 80);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(201, 26);
            this.nombreTextBox.TabIndex = 18;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Nombre";
            // 
            // habilitadoCheckBox
            // 
            this.habilitadoCheckBox.AutoSize = true;
            this.habilitadoCheckBox.Location = new System.Drawing.Point(312, 438);
            this.habilitadoCheckBox.Name = "habilitadoCheckBox";
            this.habilitadoCheckBox.Size = new System.Drawing.Size(106, 24);
            this.habilitadoCheckBox.TabIndex = 37;
            this.habilitadoCheckBox.Text = "Habilitado";
            this.habilitadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormModificarCliente
            // 
            this.ClientSize = new System.Drawing.Size(715, 574);
            this.Controls.Add(this.habilitadoCheckBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.codigoPostal);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "FormModificarCliente";
            this.Load += new System.EventHandler(this.FormModificarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormModificarCliente_Load(object sender, EventArgs e)
        {
            nombreTextBox.Text = cliente.nombre;
            apellidoTextBox.Text = cliente.apellido;
            dniTextBox.Text = cliente.id.ToString();
            mailTextBox.Text = cliente.mail;
            telefonoTextBox.Text = cliente.telefono.ToString();
            direccionTextBox.Text = cliente.domicilio;
            codigoPostal.Text = cliente.codigoPostal;
            dateTimePicker1.Value = cliente.nacimiento;
            habilitadoCheckBox.Checked = cliente.habilitado;
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            ClienteDB c = new ClienteDB();
            
            c.nombre = nombreTextBox.Text;
            c.apellido = apellidoTextBox.Text;
            c.domicilio = codigoPostal.Text;
            c.habilitado = habilitadoCheckBox.Checked;
            c.mail = mailTextBox.Text;
            c.nacimiento = DateTime.Parse(dateTimePicker1.Text);
            c.telefono = Int32.Parse(telefonoTextBox.Text);
            c.codigoPostal = codigoPostal.Text;

            if ( c.nombre == null || c.apellido == null || c.domicilio == null || c.codigoPostal == null)
            {
                MessageBox.Show("Los campos DNI, Nombre y apellido no pueden estar vacios");
            }
            else
            {
                RepositorioClientes.getInstance().almacenamiento.modificar(c);
            }
        }

        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(telefonoTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo numeros");
                telefonoTextBox.Text = telefonoTextBox.Text.Remove(telefonoTextBox.Text.Length - 1);
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            
            nombreTextBox.Text = null;
            apellidoTextBox.Text = null;
            codigoPostal.Text = null;

            mailTextBox.Text = null;
            dateTimePicker1.Text = null;
            telefonoTextBox.Text = null;
            codigoPostal.Text = null;
        }
    }
}
