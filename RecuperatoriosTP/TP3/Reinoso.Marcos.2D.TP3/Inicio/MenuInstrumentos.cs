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
    public partial class MenuInstrumentos : Form
    {
        public MenuInstrumentos()
        {
            InitializeComponent();
        }
        private void CargarCmbInstrumento()
        {
            this.cmb_tipoIntrumento.DataSource = null;
            this.cmb_tipoIntrumento.Items.Clear();
            this.cmb_tipoIntrumento.Items.Add("Bateria");
            this.cmb_tipoIntrumento.Items.Add("Guitarra");
            this.cmb_tipoIntrumento.Items.Add("Todos");
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarCmbInstrumento();
        }

        public void ReiniciarInformacion()
        {
            this.cmb_tipoIntrumento.Text = null;
            this.dtg_stock.DataSource = null;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_agregarInstrumento_Click(object sender, EventArgs e)
        {
            AltaInstrumento frm_altaInsrtrumento = new AltaInstrumento();
            DialogResult resultado = frm_altaInsrtrumento.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Consumicion cargada correctamente");
                ReiniciarInformacion();
            }
            else
            {
                MessageBox.Show("Carga cancelada");
            }
        }
        private void btn_modificarInstrumento_Click(object sender, EventArgs e)
        {
            string mensaje;
            mensaje = "Ingrese el id del instrumento que desea modificar";
            BuscarPorIdInstrumento frm_buscarInstrumento = new BuscarPorIdInstrumento(mensaje);
            DialogResult resultado = frm_buscarInstrumento.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                int indexAModificar;
                DialogResult resultadoModificar;
                indexAModificar = frm_buscarInstrumento.IndexEncontrado;
                AltaInstrumento frm_altaInstrumento = new AltaInstrumento(indexAModificar);
                resultadoModificar = frm_altaInstrumento.ShowDialog();
                if (resultadoModificar == DialogResult.OK)
                {
                    MessageBox.Show("Instrumento modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Modificacion de Instrumento cancelada");
                }
            }
        }
        private void btn_eliminarInstrumento_Click(object sender, EventArgs e)
        {
            string mensaje = "Ingrese el id del intrumento que desea borrar";
            BuscarPorIdInstrumento frm_borrarInstrumento = new BuscarPorIdInstrumento(mensaje);
            DialogResult resultado = frm_borrarInstrumento.ShowDialog(); ;
            if (resultado == DialogResult.OK)
            {
                int indexABorrar;
                indexABorrar = frm_borrarInstrumento.IndexEncontrado;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show($"Esta seguro que quiere eliminar el Instrumento ID: {Musica.listatotalInstrumento[indexABorrar].Id}", "Aviso!", buttons);
                if (result == DialogResult.Yes)
                {
                    Musica.EliminarInstrumentoPorIndice(indexABorrar);
                    ReiniciarInformacion();
                }
            }
        }
        private void cmb_tipoIntrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dtg_stock.DataSource = null;
            if (this.cmb_tipoIntrumento.Text == "Guitarra")
            {
                this.dtg_stock.DataSource = Musica.listaGuitarras;
            }
            else if (this.cmb_tipoIntrumento.Text == "Bateria")
            {
                this.dtg_stock.DataSource = Musica.listaBaterias;
            }
            else if (this.cmb_tipoIntrumento.Text == "Todos")
            {
                this.dtg_stock.DataSource = Musica.listatotalInstrumento;
            }
            else
            {
                this.dtg_stock.DataSource = null;
            }
        }

        private void btn_instrumentoMasCaro_Click(object sender, EventArgs e)
        {
            bool primero = true;
            Instrumento auxInstrumento = null;
            foreach (Instrumento item in Musica.listatotalInstrumento)
            {
                if (primero == true || item.Precio > auxInstrumento.Precio)
                {
                    primero = false;
                    auxInstrumento = item;
                }
            }
            MessageBox.Show($"El Instrumento mas costoso es:\n{auxInstrumento.MostrarInformacion()}");
        }

        private void btn_instrumentoMasEconomico_Click(object sender, EventArgs e)
        {
            bool primero = true;
            Instrumento auxInstrumento = null;
            foreach (Instrumento item in Musica.listatotalInstrumento)
            {
                if (primero == true || item.Precio < auxInstrumento.Precio)
                {
                    primero = false;
                    auxInstrumento = item;
                }
            }
            MessageBox.Show($"El Instrumento mas economico es:\n{auxInstrumento.MostrarInformacion()}");
        }
    }
}
