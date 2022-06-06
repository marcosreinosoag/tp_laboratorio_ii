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
    public partial class MenuUsuarios : Form
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            BuscarID frm_buscarId = new BuscarID();
            resultado = frm_buscarId.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                AltaUsuario frm_altaUsuario = new AltaUsuario();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string mensaje;
            mensaje = "Ingrese el id del usuario que desea borrar";
            BuscarID frm_borrarUsuario = new BuscarID(mensaje, "Usuario");
            DialogResult resultado;
            resultado = frm_borrarUsuario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                int indexABorrar;
                indexABorrar = frm_borrarUsuario.IndexEncontrado;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show($"Esta seguro que quiere eliminar el usuario:{Musica.listaUsuarios[indexABorrar].Nombre} {Musica.listaUsuarios[indexABorrar].Apellido}", "Aviso!", buttons);
                if (result == DialogResult.Yes)
                {
                    Musica.EliminarUsuarioPorIndice(indexABorrar);
                    CargarUsuariosALista();
                }
            }
        }
        public void CargarUsuariosALista()
        {
            this.dtg_usuarios.DataSource = null;
            this.dtg_usuarios.DataSource = Musica.listaUsuarios;
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuariosALista();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AltaUsuario frm_altaUsuario = new AltaUsuario();
            DialogResult resultado = frm_altaUsuario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                CargarUsuariosALista();
            }
            else
            {
                MessageBox.Show("Carga cancelada");
            }
        }
    }
}
