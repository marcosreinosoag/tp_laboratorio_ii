using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CerrarPedido_Load(object sender, EventArgs e)
        {
            rdb_efectivo.Checked = true;
            this.txb_totalCarrito.Text = "$" + precioTotal.ToString();
            this.txb_totalCarrito.Enabled = false;
            this.txb_tarjetaDeCredito.Visible = false;
            this.txb_mes.Visible = false;
            this.txb_anio.Visible = false;
            this.txb_codSeguridad.Visible = false;
            this.lbl_barra.Visible = false;
            this.lbl_codSeg.Visible = false;
            this.lbl_fechaVto.Visible = false;
            this.txb_direccion.Visible = false;
            this.txb_codPostal.Visible = false;
            this.txb_descripcion.Visible = false;
        }

        private void rdb_local_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_envioDomicilio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
