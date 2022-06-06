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
    public partial class AltaUsuario : Form
    {
        int indexAModificar;
        public AltaUsuario()
        {
            InitializeComponent();
            indexAModificar = -1;
        }
        public AltaUsuario(int index) : this()
        {
            this.indexAModificar = index;
        }
        private void CargarCmbConsumicion()
        {
            this.cmb_cargo.Items.Add(ECargo.Administrador);
            this.cmb_cargo.Items.Add(ECargo.Cliente);
        }
        private void VisibilidadBotonesError()
        {
            this.btn_errorId.Visible = false;
            this.btn_errorClave.Visible = false;
            this.btn_errorNombre.Visible = false;
            this.btn_errorApellido.Visible = false;
            this.btn_errorCargo.Visible = false;
            this.btn_errorFechaNac.Visible = false;
            this.btn_errorFechaNac.Visible = false;
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            VisibilidadBotonesError();
            CargarCmbConsumicion();
            if (indexAModificar >= 0)
            {
                VisibilidadBotonesError();
                Usuario usuarioAModificar;
                usuarioAModificar = Musica.listaUsuarios[indexAModificar];
                this.tbx_id.Text = usuarioAModificar.IdDni;
                this.tbx_id.Enabled = false;
                this.tbx_clave.Text = usuarioAModificar.Clave;
                this.tbx_nombre.Text = usuarioAModificar.Nombre;
                this.tbx_apellido.Text = usuarioAModificar.Apellido;
                this.cmb_cargo.SelectedItem = usuarioAModificar.Cargo;
                this.dtm_fechaNac.Value = usuarioAModificar.FechaNac;
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Usuario auxUsuario;
            string id = this.tbx_id.Text.Trim();
            string clave = this.tbx_clave.Text.Trim();
            string nombre = this.tbx_nombre.Text.Trim();
            string apellido = this.tbx_apellido.Text.Trim();
            DateTime fechaDeNacimiento = this.dtm_fechaNac.Value;
            if (ValidarDatos(id, clave, nombre, cmb_cargo.SelectedIndex, apellido, fechaDeNacimiento) == 6)
            {
                ECargo cargo = (ECargo)this.cmb_cargo.SelectedItem;
                auxUsuario = new Usuario(id, clave, nombre, apellido, cargo, fechaDeNacimiento);
                if (auxUsuario != null)
                {
                    if (this.indexAModificar >= 0)
                    {
                        Musica.CargarUsuario(auxUsuario, indexAModificar);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Musica.CargarUsuario(auxUsuario);
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private int ValidarDatos(string id, string clave, string nombre, int cargo, string apellido, DateTime fechaDeNacimiento)
        {
            int retorno = 0;
            if (cargo != 0 && cargo != 1)
            {
                this.btn_errorCargo.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorCargo.Visible = false;
                retorno += 1;
            }
            if (this.indexAModificar == -1)
            {
                if (Validaciones.ValidarStringSoloNumeros(id, 1) == null || Musica.BuscarIdEnListas(id) != -1)
                {
                    retorno -= 1;
                    this.btn_errorId.Visible = true;
                }
                else
                {
                    this.btn_errorId.Visible = false;
                    retorno += 1;
                }
            }
            else
            {
                this.btn_errorId.Visible = false;
                retorno += 1;
            }
            if (string.IsNullOrWhiteSpace(clave) == true)
            {
                this.btn_errorClave.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorClave.Visible = false;
                retorno += 1;
            }
            if (Validaciones.ValidarStringSoloLetras(nombre) == null)
            {
                this.btn_errorNombre.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorNombre.Visible = false;
                retorno += 1;
            }
            if (Validaciones.ValidarStringSoloLetras(apellido) == null)
            {
                this.btn_errorApellido.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorApellido.Visible = false;
                retorno += 1;
            }
            if (DateTime.Now.Year - fechaDeNacimiento.Year < 18)
            {
                this.btn_errorFechaNac.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorFechaNac.Visible = false;
                retorno += 1;
            }

            return retorno;
        }

        private void btn_errorId_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorId, "¡Reingrese el id!");
        }

        private void btn_errorClave_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorClave, "¡Reingrese la clave!");
        }

        private void btn_errorNombre_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorNombre, "¡Reingrese el nombre!");
        }

        private void btn_errorApellido_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorNombre, "¡Reingrese el apellido!");
        }

        private void btn_errorCargo_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorNombre, "¡Seleccione un item!");
        }

        private void btn_errorFechaNac_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorFechaNac, "El Usuario debe ser mayor de edad");
        }
    }
}
