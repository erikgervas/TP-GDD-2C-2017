using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
using PagoAgil.Aplicacion.View.Empresas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Facturas
{
    public partial class FacturaConfirmado : Form, FormABMAdapter
    {
        private FacturaBuilder factura;
        private bool permitirItems;

        public FacturaConfirmado(FacturaBuilder facturaBuilder)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.factura = facturaBuilder;
            this.iniciarTitulos();
            this.completarCampos();
            FacturaABM.instanciar().mostrar(this);
        }

        private void completarCampos()
        {
            this.numeroFacturaAsignado.Text = this.factura.numero.ToString();
            this.altaAsignada.Text = this.factura.fecha_alta.ToString();
            this.vencimientoAsignado.Text = this.factura.fecha_vencimiento.ToString();
            this.dniAsignado.Text = this.factura.dni_cliente.ToString();
            this.empresaAsignada.Text = this.factura.cuit_empresa;
            this.habilitadoAsignado.Checked = this.factura.estado;
            foreach (Item i in this.factura.items) this.itemDataGrid.Rows.Add(i.nombre, i.cantidad.ToString(), i.monto.ToString());
            this.montoValor.Text = this.factura.items.Sum(i => i.montoTotal()).ToString();
        }

        private void iniciarTitulos()
        {
            this.Text = FacturaABM.instanciar().titulosConfirmado()[0];
            this.tituloLabel.Text = FacturaABM.instanciar().titulosConfirmado()[1];
            this.altaGroup.Text = FacturaABM.instanciar().titulosConfirmado()[2];
            this.completarButton.Text = FacturaABM.instanciar().titulosConfirmado()[3];
        }

        private void seguirModificandoButton_Click(object sender, EventArgs e)
        {
            this.Close();

            new FacturaCompletado(this.factura).Show();
        }

        private void completarButton_Click(object sender, EventArgs e)
        {
            Factura nuevaFactura = this.factura.crear();

            FacturaABM.instanciar().realizarABM(RepositorioFacturas.instanciar(), nuevaFactura);

            if(permitirItems) foreach (Item unItem in nuevaFactura.items) ItemABM.instanciar().realizarABM(RepositorioItems.instanciar(), unItem);

            this.Close();

            new FacturasOk().Show();
        }

        private void FacturaConfirmado_Load(object sender, EventArgs e)
        {

        }

        public void alta()
        {
            permitirItems = true;
        }

        public void baja()
        {
            this.seguirModificandoButton.Visible = false;
            permitirItems = false;
        }

        public void modificacion()
        {
            this.baja();
        }
    }
}
