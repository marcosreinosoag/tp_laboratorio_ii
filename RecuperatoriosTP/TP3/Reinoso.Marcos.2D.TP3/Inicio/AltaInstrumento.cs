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
    public partial class AltaInstrumento : Form
    {
        int indexAModificar;
        int idInstrumentoAModificar;
        bool doblePedal;
        bool tieneTremolo;
        bool esElectronica;
        public AltaInstrumento()
        {
            InitializeComponent();
            this.indexAModificar = -1;
        }
        public AltaInstrumento(int indexAModificar) : this()
        {
            this.indexAModificar = indexAModificar;
        }
        private void CargarCmbInstrumento()
        {
            this.cmb_tipoInstrumento.Items.Add("Guitarra");
            this.cmb_tipoInstrumento.Items.Add("Bateria");
        }
        private void CargarCmbTipoGuitarra()
        {
            this.cmb_guitarraTipoGuitarra.Items.Add(EtipoGuitarra.Acustica);
            this.cmb_guitarraTipoGuitarra.Items.Add(EtipoGuitarra.Criolla);
            this.cmb_guitarraTipoGuitarra.Items.Add(EtipoGuitarra.Electrica);
        }
        private void CargarCmbTipoColor()
        {
            this.cmb_guitarraTipoColor.Items.Add(EtipoColor.Blanco);
            this.cmb_guitarraTipoColor.Items.Add(EtipoColor.Madera);
            this.cmb_guitarraTipoColor.Items.Add(EtipoColor.Negro);
            this.cmb_guitarraTipoColor.Items.Add(EtipoColor.Rojo);
        }
        private void VisibilidadBotonesError()
        {
            this.btn_errorDescripcion.Visible = false;
            this.btn_errorItemTipoColorGuitarra.Visible = false;
            this.btn_errorCantidadInstrumento.Visible = false;
            this.btn_errorTipoDeGuitarra.Visible = false;
            this.btn_errorPrecioInstrumento.Visible = false;
            this.btn_errorGuitarraCantidadMicrofonos.Visible = false;
            this.btn_errorCantidadPlatillos.Visible = false;
        }
        private void AltaConsumicion_Load(object sender, EventArgs e)
        {
            CargarCmbInstrumento();
            CargarCmbTipoGuitarra();
            CargarCmbTipoColor();
            VisibilidadBotonesError();

            this.cmb_tipoInstrumento.SelectedIndex = 0;
            VisibilidadBotonesError();
            if (indexAModificar >= 0)
            {
                Instrumento auxInstrumento = Musica.listatotalInstrumento[indexAModificar];
                this.cmb_tipoInstrumento.Enabled = false;
                idInstrumentoAModificar = auxInstrumento.Id;

                if (auxInstrumento.GetType() == typeof(Bateria))
                {
                    this.cmb_tipoInstrumento.SelectedIndex = 1;
                    this.cmb_tipoInstrumento.Enabled = false;
                    Bateria bateriaAModificar = (Bateria)auxInstrumento;
                    this.txb_descripcionInstrumento.Text = bateriaAModificar.Descripcion;
                    this.txb_numeroCantidad.Text = bateriaAModificar.Cantidad.ToString();
                    this.txb_precio.Text = bateriaAModificar.Precio.ToString();
                    this.txb_bateriaCantidadPlatillos.Text = bateriaAModificar.CantidadPlatillos.ToString();
                    this.chbx_doblePedal.Checked = bateriaAModificar.DoblePedal;
                    this.chbx_esElectronica.Checked = bateriaAModificar.EsElectronica;
                }
                else
                {
                    this.cmb_tipoInstrumento.SelectedIndex = 1;
                    this.cmb_tipoInstrumento.Enabled = false;
                    Guitarra guitarraAModificar = (Guitarra)auxInstrumento;
                    this.txb_descripcionInstrumento.Text = guitarraAModificar.Descripcion;
                    this.txb_numeroCantidad.Text = guitarraAModificar.Cantidad.ToString();
                    this.txb_precio.Text = guitarraAModificar.Precio.ToString();
                    this.txb_cantidadMicrofonos.Text = guitarraAModificar.CantidadDeMicrofonos.ToString();
                    this.cmb_guitarraTipoGuitarra.SelectedItem = guitarraAModificar.Tipo;
                    this.cmb_guitarraTipoColor.SelectedItem = guitarraAModificar.Color;
                    this.chbx_tieneTremolo.Checked = guitarraAModificar.TieneTremolo;
                }
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string descripcionInstrumento = this.txb_descripcionInstrumento.Text;
            decimal precio;

            if (this.cmb_tipoInstrumento.SelectedIndex == 1)
            {
                Bateria auxBateria;
                bool doblePedal = this.doblePedal;
                bool esElectronica = this.esElectronica;
                if (ValidarDatosInstrumento(descripcionInstrumento, this.txb_numeroCantidad.Text, this.txb_precio.Text) == 3 & ValidarDatosBateria(this.txb_bateriaCantidadPlatillos.Text) == 1)
                {
                    int cantidad = this.txb_numeroCantidad.Text.ConvertirStringAEntero();
                    precio= this.txb_precio.Text.ConvertirStringADecimal();
                    int cantidadPlatillos = this.txb_bateriaCantidadPlatillos.Text.ConvertirStringAEntero();
                    if (this.indexAModificar >= 0)
                    {
                        auxBateria = new Bateria(this.idInstrumentoAModificar, descripcionInstrumento, cantidad, precio, this.esElectronica, cantidadPlatillos, this.doblePedal);
                        Musica.CargaDeInstrumento(auxBateria, indexAModificar);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        auxBateria = new Bateria(Instrumento.GenerarId(), descripcionInstrumento, cantidad, precio, this.esElectronica, cantidadPlatillos, this.doblePedal);
                        Musica.CargaDeInstrumento(auxBateria);
                        this.DialogResult = DialogResult.OK;
                    }

                }
            }
            else
            {
                Guitarra auxGuitarra;
                bool tieneTremolo = this.tieneTremolo;
                if (ValidarDatosInstrumento(descripcionInstrumento, this.txb_numeroCantidad.Text, this.txb_precio.Text) == 3 & ValidarDatosGuitarra(this.cmb_guitarraTipoGuitarra.SelectedIndex, this.cmb_guitarraTipoColor.SelectedIndex, this.txb_cantidadMicrofonos.Text) == 3)
                {
                    int cantidad = this.txb_numeroCantidad.Text.ConvertirStringAEntero();
                    EtipoGuitarra tipoDeGuitarra = (EtipoGuitarra)this.cmb_guitarraTipoGuitarra.SelectedItem;
                    EtipoColor tipoDeColor = (EtipoColor)this.cmb_guitarraTipoColor.SelectedItem;
                    int cantidadMicrofonos = txb_numeroCantidad.Text.ConvertirStringAEntero();
                    precio = this.txb_precio.Text.ConvertirStringADecimal();
                    if (this.indexAModificar >= 0)
                    {
                        auxGuitarra = new Guitarra(this.idInstrumentoAModificar, descripcionInstrumento, cantidad, precio, tipoDeGuitarra, tipoDeColor, cantidadMicrofonos, tieneTremolo);
                        Musica.CargaDeInstrumento(auxGuitarra, indexAModificar);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        auxGuitarra = new Guitarra(Instrumento.GenerarId(), descripcionInstrumento, cantidad, precio, tipoDeGuitarra, tipoDeColor, cantidadMicrofonos, tieneTremolo);
                        Musica.CargaDeInstrumento(auxGuitarra);
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmb_consumicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_tipoInstrumento.Text == "Bateria")
            {
                VisibilidadBotonesError();
                this.txb_bateriaCantidadPlatillos.Visible = true;
                this.chbx_doblePedal.Visible = true;
                this.chbx_esElectronica.Visible = true;

                this.chbx_tieneTremolo.Visible = false;
                this.txb_cantidadMicrofonos.Visible = false;
                this.cmb_guitarraTipoColor.Visible = false;
                this.cmb_guitarraTipoGuitarra.Visible = false;
            }
            else if (this.cmb_tipoInstrumento.Text == "Guitarra")
            {
                VisibilidadBotonesError();
                this.chbx_tieneTremolo.Visible = true;
                this.txb_cantidadMicrofonos.Visible = true;
                this.cmb_guitarraTipoColor.Visible = true;
                this.cmb_guitarraTipoGuitarra.Visible = true;

                this.txb_bateriaCantidadPlatillos.Visible = false;
                this.chbx_doblePedal.Visible = false;
                this.chbx_esElectronica.Visible = false;
            }
        }
        private int ValidarDatosInstrumento(string descripcion, string cantidad, string precio)
        {
            int retorno = 0;
            if (Validaciones.ValidarString(descripcion) == null)
            {
                retorno -= 1;
                this.btn_errorDescripcion.Visible = true;
            }
            else
            {
                this.btn_errorDescripcion.Visible = false;
                retorno += 1;
            }
            if (Validaciones.ValidarStringSoloNumeros(cantidad, 1) == null)
            {
                this.btn_errorCantidadInstrumento.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorCantidadInstrumento.Visible = false;
                retorno += 1;
            }
            if (Validaciones.ValidarStringSoloNumeros(precio, 1) == null)
            {
                this.btn_errorPrecioInstrumento.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorPrecioInstrumento.Visible = false;
                retorno += 1;
            }
            return retorno;
        }
        private int ValidarDatosGuitarra(int tipoDeGuitarra, int tipoDeColor, string cantidadPatillos)
        {
            int retorno = 0;
            if (tipoDeGuitarra != 0 && tipoDeGuitarra != 1 && tipoDeGuitarra != 2)
            {
                this.btn_errorTipoDeGuitarra.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorTipoDeGuitarra.Visible = false;
                retorno += 1;
            }
            if (tipoDeColor != 0 && tipoDeColor != 1 && tipoDeGuitarra != 2 && tipoDeGuitarra != 3)
            {
                this.btn_errorItemTipoColorGuitarra.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorItemTipoColorGuitarra.Visible = false;
                retorno += 1;
            }
            if (Validaciones.ValidarStringSoloNumeros(cantidadPatillos, 0) == null)
            {
                this.btn_errorGuitarraCantidadMicrofonos.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorGuitarraCantidadMicrofonos.Visible = false;
                retorno += 1;
            }
            return retorno;
        }
        private int ValidarDatosBateria(string cantidadPlatillos)
        {
            int retorno = 0;
            if (Validaciones.ValidarStringSoloNumeros(cantidadPlatillos, 0) == null)
            {
                this.btn_errorCantidadPlatillos.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorCantidadPlatillos.Visible = false;
                retorno += 1;
            }
            return retorno;
        }
        private void chbx_esElectronica_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbx_esElectronica.Checked == true)
            {
                this.esElectronica = true;
            }
            else
            {
                this.esElectronica = false;
            }
        }
        private void chbx_tieneTremolo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbx_tieneTremolo.Checked == true)
            {
                this.tieneTremolo = true;
            }
            else
            {
                this.tieneTremolo = false;
            }
        }

        private void chbx_doblePedal_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbx_doblePedal.Checked == true)
            {
                this.doblePedal = true;
            }
            else
            {
                this.doblePedal = false;
            }
        }

        private void btn_errorDescripcion_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorDescripcion, "¡Reingrese el descripcion!");
        }

        private void btn_errorCantidadInstrumento_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorCantidadInstrumento, "¡Reingrese la cantidad!");
        }

        private void btn_errorPrecioInstrumento_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorPrecioInstrumento, "¡Reingrese el precio!");
        }

        private void btn_guitarraErrorCantidadMicrofonos_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorGuitarraCantidadMicrofonos, "¡Reingrese la cantidad de microfonos!");
        }

        private void btn_errorCantidadPlatillos_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorCantidadPlatillos, "¡Reingrese la cantidad de platillos!");
        }

        private void btn_errorTipoDeGuitarra_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorTipoDeGuitarra, "¡Error!Seleccione un item");
        }
        private void btn_errorItemTipoColorGuitarra_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorItemTipoColorGuitarra, "¡Error!Seleccione un item");
        }
    }
}
