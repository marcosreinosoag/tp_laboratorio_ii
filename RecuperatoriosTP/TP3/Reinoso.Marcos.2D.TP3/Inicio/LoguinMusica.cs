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
    public partial class LoguinMusica : Form
    {
        public LoguinMusica()
        {
            InitializeComponent();
        }
        private void LoguinMusica_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Musica.EscribirUsuarios();
        }
        private void LimpiarCampos()
        {
            this.txb_usuario.Clear();
            this.txb_clave.Clear();
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string id;
            string claveIngresada;
            string nombreCompleto;
            ECargo cargoUsuario;
            id = this.txb_usuario.Text;
            claveIngresada = this.txb_clave.Text;
            if (Musica.VerificarUsuarioYClave(id, claveIngresada) == true)
            {
                nombreCompleto = Musica.DevolverNombreCompeletoUsuario(id);
                cargoUsuario = Musica.DevolverCargoUsuario(id);
                int indexUsuario = Musica.BuscarIdEnUsuariosYDevolverIndice(id);
                MenuMusica frm_menuMusica = new MenuMusica(nombreCompleto, cargoUsuario, indexUsuario);
                frm_menuMusica.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario ingresado es inconrrecto");
            }
        }
        private void btn_ingresoAdmin_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            if (Musica.listaUsuarios != null)
            {
                foreach (Usuario item in Musica.listaUsuarios)
                {
                    if (item != null)
                    {
                        if (item.Cargo == ECargo.Administrador)
                        {
                            this.txb_usuario.Text = item.IdDni;
                            this.txb_clave.Text = item.Clave;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay administradores cargados");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay usuarios cargados.");
            }
        }

        private void btn_ingresoCliente_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            foreach (Usuario item in Musica.listaUsuarios)
            {
                if (item != null)
                {
                    if (item.Cargo == ECargo.Cliente)
                    {
                        this.txb_usuario.Text = item.IdDni;
                        this.txb_clave.Text = item.Clave;
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("No hay empleados cargados");
                }
            }
        }
        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            AltaUsuario frm_altaUsuario = new AltaUsuario(-2);
            DialogResult resultado = frm_altaUsuario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Usted se ha sido Registrado correctamente");
            }
            else
            {
                MessageBox.Show("Registro Cancelado");
            }
        }
    }
}