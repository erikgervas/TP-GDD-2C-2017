using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
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
    public partial class FacturaConfirmado : Form
    {
        private FacturaBuilder factura;

        public FacturaConfirmado(FacturaBuilder facturaBuilder)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.factura = facturaBuilder;
            this.iniciarTitulos();
            this.completarCampos();
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

            foreach (Item unItem in nuevaFactura.items) ItemABM.instanciar().realizarABM(RepositorioItems.instanciar(), unItem);

            this.Close();

            new FacturaOk().Show();
        }

        private void FacturaConfirmado_Load(object sender, EventArgs e)
        {

        }
    }
}
