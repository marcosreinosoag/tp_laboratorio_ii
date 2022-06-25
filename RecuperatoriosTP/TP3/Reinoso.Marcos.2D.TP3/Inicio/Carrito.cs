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
    public partial class Carrito : Form
    {
        decimal totalVenta;
        int indexUsuario;
        public Carrito()
        {
            InitializeComponent();
        }
        public Carrito(int index) : this()
        {
            this.indexUsuario = index;
        }
        private void Carrito_Load(object sender, EventArgs e)
        {
            CargarListaPedidosEnLista();
        }
        private void HabilitarPedido()
        {
            if (this.totalVenta == 0)
            {
                this.btn_cerrarPedido.Enabled = false;
            }
            else
            {
                this.btn_cerrarPedido.Enabled = true;
            }
        }
        public void CargarListaPedidosEnLista()
        {
            decimal acumTotal = 0;
            Usuario auxUsuario = Musica.listaUsuarios[indexUsuario];
            List<Instrumento> pedidos = auxUsuario.Pedidos;
            ltbx_pedidos.Items.Clear();
            if (pedidos != null)
            {
                foreach (Instrumento item in pedidos)
                {
                    if (item.GetType() == typeof(Bateria))
                    {
                        Bateria auxBateria = (Bateria)item;
                        ltbx_pedidos.Items.Add("x1 " + auxBateria.Descripcion + " " + " $" + auxBateria.Precio);
                        acumTotal += auxBateria.Precio;
                    }
                    else
                    {
                        Guitarra auxGuitarra = (Guitarra)item;
                        ltbx_pedidos.Items.Add("x1 " + auxGuitarra.Descripcion + " " + " $" + auxGuitarra.Precio);
                        acumTotal += auxGuitarra.Precio;
                    }
                }
                ltbx_pedidos.Items.Add("TOTAL: $" + acumTotal);
                this.totalVenta = acumTotal;
            }
            else
            {
                ltbx_pedidos.Items.Add("No hay pedidos cargados");
            }
            HabilitarPedido();
        }
        private void DevolverStock()
        {
            Usuario auxUsuario = Musica.listaUsuarios[this.indexUsuario];
            List<Instrumento> auxPedidos = auxUsuario.Pedidos;
            List<Instrumento> auxStock = Musica.listatotalInstrumento;
            foreach (Instrumento itemComprado in auxPedidos)
            {
                for (int i = 0; i < auxStock.Count; i++)
                {
                    if (itemComprado.Id== auxStock[i].Id)
                    {
                        auxStock[i].Cantidad += 1;
                    }
                } 
            }
        }
        private void btn_borrarPedidos_Click(object sender, EventArgs e)
        {
            DevolverStock();
            Usuario auxUsuario = Musica.listaUsuarios[this.indexUsuario];
            auxUsuario.Pedidos.Clear();
            CargarListaPedidosEnLista();
        }
        private void btn_cerrarPedido_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            CerrarPedido frm_cerrarPedido = new CerrarPedido(totalVenta);
            resultado = frm_cerrarPedido.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Usuario auxUsuario = Musica.listaUsuarios[this.indexUsuario];
                auxUsuario.Pedidos.Clear();
                MessageBox.Show("EL Pedido finalizo correctamente y puede ser retirado por la sucursal \n !Muchas Gracias!");
                CargarListaPedidosEnLista();
            }
        }
    }
}
