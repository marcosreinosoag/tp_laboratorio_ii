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
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private void btn_cerrarPedido_Click(object sender, EventArgs e)
        {
            CerrarPedido frm_cerrarPedido = new CerrarPedido(0);
            frm_cerrarPedido.Show();
        }
    }
}
