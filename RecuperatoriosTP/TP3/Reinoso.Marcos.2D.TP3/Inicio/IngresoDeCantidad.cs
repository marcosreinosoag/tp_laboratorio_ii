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
    public partial class IngresoDeCantidad : Form
    {
        int cantidadIngresada;
        int tipoDeConsumicion;
        int indexConsumo;
        public IngresoDeCantidad(int indexConsumo, int tipoDeConsumicion)
        {
            this.indexConsumo = indexConsumo;
            this.tipoDeConsumicion = tipoDeConsumicion;
            InitializeComponent();
        }
        public int CantidadIngresada
        {
            get { return cantidadIngresada; }
        }

        private void IngresoDeCantidad_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int cantidadIngresada;
            if (Validaciones.ValidarStringSoloNumeros(this.txb_cantidadIngresada.Text, 1) != null)
            {

                int.TryParse(this.txb_cantidadIngresada.Text, out cantidadIngresada);
                if (tipoDeConsumicion == 0)
                {
                    Bateria auxBateria = Musica.listaBaterias[indexConsumo];
                    string mensaje = auxBateria.VerificarCantidad(cantidadIngresada);
                    if (mensaje != null)
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        this.cantidadIngresada = cantidadIngresada;
                        int cantidadConsumoStock = auxBateria.Cantidad;
                        auxBateria.Cantidad = cantidadConsumoStock - cantidadIngresada;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    Guitarra auxGuitarra = Musica.listaGuitarras[indexConsumo];
                    string mensaje = auxGuitarra.VerificarCantidad(cantidadIngresada);
                    if (mensaje != null)
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        this.cantidadIngresada = cantidadIngresada;
                        int cantidadConsumoStock = auxGuitarra.Cantidad;
                        auxGuitarra.Cantidad = cantidadConsumoStock - cantidadIngresada;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese solo numeros");
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
