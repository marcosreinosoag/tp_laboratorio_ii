using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Tp3
{
    public partial class CerrarPedido : Form
    {
        decimal precioTotal;
        decimal pocentajePorTarjeta;
        decimal precioConTarjeta;
        public CerrarPedido(decimal total)
        {
            InitializeComponent();
            this.precioTotal = total;
            this.pocentajePorTarjeta = 10;
        }
        private void CerrarPedido_Load(object sender, EventArgs e)
        {
            rdb_efectivo.Checked = true;
            this.txb_totalCompra.Text = "$" + precioTotal.ToString();
            this.txb_totalCompra.Enabled = false;
            this.txb_tarjetaDeCredito.Visible = false;
            this.txb_mes.Visible = false;
            this.txb_anio.Visible = false;
            this.txb_codSeguridad.Visible = false;
            this.lbl_barra.Visible = false;
            this.lbl_codSeg.Visible = false;
            this.lbl_fechaVto.Visible = false;
            this.btn_errorNumeroTarjeta.Visible = false;
            this.btn_errorFechaDeVto.Visible = false;
            this.btn_errorCodSeg.Visible = false;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void rdb_tarjetaDeCredito_CheckedChanged(object sender, EventArgs e)
        {
            this.precioConTarjeta = precioTotal * this.pocentajePorTarjeta / 100;
            this.precioConTarjeta += precioTotal;
            this.txb_totalCompra.Text = "$ " + precioConTarjeta.ToString();
            this.txb_tarjetaDeCredito.Visible = true;
            this.txb_codSeguridad.Visible = true;
            this.lbl_barra.Visible = true;
            this.txb_mes.Visible = true;
            this.txb_anio.Visible = true;
            this.lbl_codSeg.Visible = true;
            this.lbl_fechaVto.Visible = true;
        }
        private void rdb_efectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_efectivo.Checked == true)
            {
                this.txb_totalCompra.Text = "$" + precioTotal.ToString();
                this.txb_tarjetaDeCredito.Visible = false;
                this.txb_mes.Visible = false;
                this.txb_anio.Visible = false;
                this.txb_codSeguridad.Visible = false;
                this.lbl_barra.Visible = false;
                this.lbl_codSeg.Visible = false;
                this.lbl_fechaVto.Visible = false;
            }
        }
        private void rdb_tajetaDeDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_tajetaDeDebito.Checked == true)
            {
                this.txb_totalCompra.Text = "$" + precioTotal.ToString();
                this.txb_tarjetaDeCredito.Visible = true;
                this.txb_codSeguridad.Visible = true;
                this.lbl_barra.Visible = true;
                this.txb_mes.Visible = true;
                this.txb_anio.Visible = true;
                this.lbl_codSeg.Visible = true;
                this.lbl_fechaVto.Visible = true;
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (rdb_efectivo.Checked == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (ValidarDatosTarjeta() == 3)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
        private int ValidarDatosTarjeta()
        {
            int retorno = 0;
            if (Validaciones.ValidarStringSoloNumeros(txb_tarjetaDeCredito.Text, 1) != null)
            {
                this.btn_errorNumeroTarjeta.Visible = false;
                retorno += 1;
            }
            else
            {
                this.btn_errorNumeroTarjeta.Visible = true;
            }
            if (Validaciones.ValidarStringSoloNumeros(txb_mes.Text, 1, 12) != null && Validaciones.ValidarStringSoloNumeros(txb_anio.Text, 1) != null)
            {
                btn_errorFechaDeVto.Visible = false;
                retorno += 1;
            }
            else
            {
                btn_errorFechaDeVto.Visible = true;
            }
            if (Validaciones.ValidarStringSoloNumeros(txb_codSeguridad.Text, 1) != null)
            {
                btn_errorCodSeg.Visible = false;
                retorno += 1;
            }
            else
            {
                btn_errorCodSeg.Visible = true;
            }
            return retorno;
        }
        private void btn_errorNumeroTarjeta_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorNumeroTarjeta, "¡numero de tarjeta invalida!");
        }
        private void btn_errorCodSeg_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorFechaDeVto, "¡fecha de vencimiento invalida!");
        }
        private void btn_errorFechaDeVto_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorCodSeg, "¡Codigo de seguridad invalido!");
        }
    }
}
