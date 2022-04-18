using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Realiza la limpieza de los campos cuando se presiona el boton Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Convierte todos los campos por defecto.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "0";
        }
        /// <summary>
        /// Realiza la operacion matematica entre dos numero cuando se presiona el boton Operar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string numeroString = this.txtNumero1.Text;
            string numeroDosString = this.txtNumero2.Text;
            string operacion = this.cmbOperador.Text;

            if (!string.IsNullOrEmpty(numeroDosString) && !string.IsNullOrEmpty(numeroDosString) && double.TryParse(numeroString, out resultado) && double.TryParse(numeroDosString, out resultado))
            {

                resultado = Operar(numeroString, numeroDosString, operacion);
                if (resultado != double.MinValue)
                {
                    if (operacion == "")
                    {
                        operacion = "+";
                    }
                    this.lblResultado.Text = resultado.ToString();
                    this.lstOperaciones.Items.Add(numeroString + " " + operacion + " " + numeroDosString + " = " + resultado);
                }
                else
                {
                    string mensaje = "¡ERROR!";
                    MessageBox.Show("No puede dividir un numero por 0", mensaje);
                }
            }
            else
            {
                MessageBox.Show("Numeros ingresados invalidos");
            }
        }
        /// <summary>
        /// Valida que los datos ingresados sean correctos y realiza la operacion matematica . 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            char operacion;

            Operando numeroUno = new Operando(numero1);
            Operando numeroDos = new Operando(numero2);
            
            char.TryParse(operador, out operacion);

            resultado = Calculadora.Operar(numeroUno, numeroDos, operacion);

            return resultado;
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Realiza la conversion de un numero decimal a binario cuando se presiona el boton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            string resultadoBinario;
            resultadoBinario = resultado.DecimalBinario(this.lblResultado.Text);
            if (resultadoBinario != "Valor invalido")
            {
                this.lstOperaciones.Items.Add("Decimal: " + lblResultado.Text + " " + "Binario: " + resultado.DecimalBinario(this.lblResultado.Text));
                this.lblResultado.Text = resultadoBinario;
            }
            else
            {
                string mensaje = "¡ERROR!";
                MessageBox.Show("¡Valor Invalido!", mensaje);
            }
        }
        /// <summary>
        /// ealiza la conversion de un numero binario a decimal cuando se presiona el boton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            string resultadoDecimal;
            resultadoDecimal = resultado.BinarioDecimal(this.lblResultado.Text);
            if (resultadoDecimal != "Valor invalido")
            {
                this.lstOperaciones.Items.Add("Binario: " + lblResultado.Text + " " + "Decimal: " + resultado.BinarioDecimal(this.lblResultado.Text));
                this.lblResultado.Text = resultadoDecimal;
            }
            else
            {
                string mensaje = "¡ERROR!";
                MessageBox.Show("¡Valor Invalido!", mensaje);
            }
        }

        /// <summary>
        /// Consulta si el usuario quiere cerrar el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
