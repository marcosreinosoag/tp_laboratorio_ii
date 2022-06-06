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
        public MenuMusica()
        {
            InitializeComponent();
        }
        public MenuMusica(string nombreCompleto, ECargo cargo) : this()
        {
            this.nombreCompleto = nombreCompleto;
            this.cargo = cargo;
        }
        private void CargarCmbConsumicion()
        {
            this.cmb_instrumentos.DataSource = null;
            this.cmb_instrumentos.Items.Clear();
            this.cmb_instrumentos.Items.Add("Baterias");
            this.cmb_instrumentos.Items.Add("Guitarras");
            this.cmb_instrumentos.Items.Add("Todos");
        }
        private void PermisosMenu(ECargo cargoUsuario)
        {
            if (cargoUsuario == ECargo.Cliente)
            {
                this.btn_instrumentos.Visible = false;
                this.btn_usuarios.Visible = false;
            }
        }
        private void MenuMusica_Load(object sender, EventArgs e)
        {
            PermisosMenu(this.cargo);
            CargarCmbConsumicion();
            this.lbl_Usuario.Text = "Bienvenido " + nombreCompleto;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_carrito_Click(object sender, EventArgs e)
        {
            Carrito frm_carrito = new Carrito();
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
                this.dtg_stockInstrumento.DataSource = Musica.listaGuistarras;
            }
            else
            {
                this.dtg_stockInstrumento.DataSource = Musica.listatotalInstrumento;
            }
        }

        private void dtg_stockInstrumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
