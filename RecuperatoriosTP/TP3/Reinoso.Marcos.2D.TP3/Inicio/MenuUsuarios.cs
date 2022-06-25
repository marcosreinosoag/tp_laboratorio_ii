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
        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuariosALista();
        }
        public void CargarUsuariosALista()
        {
            this.dtg_usuarios.DataSource = null;
            this.dtg_usuarios.DataSource = Musica.listaUsuarios;
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
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string mensaje = "Ingrese el id del usuario que desea modificar";
            BuscarIdUsuario frm_buscarIdUsuario = new BuscarIdUsuario(mensaje);
            DialogResult resultado;
            resultado = frm_buscarIdUsuario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                int indexAModificar;
                indexAModificar = frm_buscarIdUsuario.IndexEncontrado;
                AltaUsuario frm_altaUsuario = new AltaUsuario(indexAModificar);
                DialogResult resultadoModificacion;
                resultadoModificacion = frm_altaUsuario.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    MessageBox.Show("El usuario fue modificado correctamente");
                    CargarUsuariosALista();
                }
                else
                {
                    MessageBox.Show("Modificacion cancelada");
                }
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "Ingrese el id del usuario que desea borrar";
            BuscarIdUsuario frm_borrarUsuario = new BuscarIdUsuario(mensaje);
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
        private void btn_usuarioConMayorEdad_Click(object sender, EventArgs e)
        {
            bool primero = true;
            Usuario auxUsuario = null;
            foreach (Usuario item in Musica.listaUsuarios)
            {
                if (primero == true || item.FechaNac < auxUsuario.FechaNac)
                {
                    primero = false;
                    auxUsuario = item;
                }
            }
            MessageBox.Show($"El usuario con mayor edad es:\n{auxUsuario.MostrarInformacion()}");
        }
        private void btn_usuarioConMenorEdad_Click(object sender, EventArgs e)
        {
            bool primero = true;
            Usuario auxUsuario = null;
            foreach (Usuario item in Musica.listaUsuarios)
            {
                if (primero == true || item.FechaNac > auxUsuario.FechaNac)
                {
                    primero = false;
                    auxUsuario = item;
                }
            }
            MessageBox.Show($"El usuario con menor edad es:\n{auxUsuario.MostrarInformacion()}");
        }
    }
}
