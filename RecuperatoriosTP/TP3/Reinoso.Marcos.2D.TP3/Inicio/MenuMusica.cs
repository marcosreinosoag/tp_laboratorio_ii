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
    public partial class MenuMusica : Form
    {
        private ECargo cargo;
        private string nombreCompleto;
        private int indice;
        public MenuMusica()
        {
            InitializeComponent();
        }
        public MenuMusica(string nombreCompleto, ECargo cargo, int indice) : this()
        {
            this.nombreCompleto = nombreCompleto;
            this.cargo = cargo;
            this.indice = indice;
        }
        private void MenuMusica_Load(object sender, EventArgs e)
        {
            PermisosMenu(this.cargo);
            CargarCmbInstrumentos();
            this.lbl_Usuario.Text = "Bienvenido " + nombreCompleto;
        }
        private void CargarCmbInstrumentos()
        {
            this.cmb_instrumentos.DataSource = null;
            this.cmb_instrumentos.Items.Clear();
            this.cmb_instrumentos.Items.Add("Baterias");
            this.cmb_instrumentos.Items.Add("Guitarras");
        }
        private void PermisosMenu(ECargo cargoUsuario)
        {
            if (cargoUsuario == ECargo.Cliente)
            {
                this.btn_instrumentos.Visible = false;
                this.btn_usuarios.Visible = false;
            }
        }
        private void ActualizarLista()
        {
            if (this.cmb_instrumentos.Text == "Baterias")
            {
                this.dtg_stockInstrumento.DataSource = null;
                this.dtg_stockInstrumento.DataSource = Musica.listaBaterias;
            }
            else if (this.cmb_instrumentos.Text == "Guitarras")
            {
                this.dtg_stockInstrumento.DataSource = null;
                this.dtg_stockInstrumento.DataSource = Musica.listaGuitarras;
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Musica.EscribirUsuarios();
            Musica.EscribirInstrumentos();
            Application.Exit();
        }
        private void btn_carrito_Click(object sender, EventArgs e)
        {
            Carrito frm_carrito = new Carrito(this.indice);
            frm_carrito.Show();
        }
        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            MenuUsuarios frm_menuUsuarios = new MenuUsuarios();
            frm_menuUsuarios.Show();
        }
        private void cmb_instrumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_instrumentos.Text == "Baterias")
            {
                this.dtg_stockInstrumento.DataSource = Musica.listaBaterias;
            }
            else if (this.cmb_instrumentos.Text == "Guitarras")
            {
                this.dtg_stockInstrumento.DataSource = Musica.listaGuitarras;
            }
        }
        private void dtg_stockInstrumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cantidad;
            int index = dtg_stockInstrumento.CurrentCell.RowIndex;
            Instrumento nuevaCompra;
            if (this.cmb_instrumentos.SelectedIndex == 0)
            {
                nuevaCompra = Musica.listaBaterias[index];
            }
            else
            {
                nuevaCompra = Musica.listaGuitarras[index];
            }
            IngresoDeCantidad frm_ingresoDeCantidad = new IngresoDeCantidad(index, this.cmb_instrumentos.SelectedIndex);
            DialogResult resultado = frm_ingresoDeCantidad.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Usuario auxUsuario = Musica.listaUsuarios[this.indice];
                List<Instrumento> auxPedidos = auxUsuario.Pedidos;
                cantidad = frm_ingresoDeCantidad.CantidadIngresada;
                if (cantidad > 0)
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        auxPedidos.Add(nuevaCompra);
                    }
                    auxUsuario.Pedidos = auxPedidos;
                }
                else
                {
                    MessageBox.Show("Carga Cancelada");
                }
            }
            ActualizarLista();
        }
        private void btn_instrumentos_Click(object sender, EventArgs e)
        {
            MenuInstrumentos frm_menuInstrumentos = new MenuInstrumentos();
            frm_menuInstrumentos.Show();
        }
    }
}



