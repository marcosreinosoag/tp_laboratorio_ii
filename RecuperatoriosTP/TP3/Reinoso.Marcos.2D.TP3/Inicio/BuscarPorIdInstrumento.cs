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
    public partial class BuscarPorIdInstrumento : Form
    {
        string mensaje;
        int indexEncontrado;
        public BuscarPorIdInstrumento()
        {
            InitializeComponent();
        }
        public BuscarPorIdInstrumento(string mensaje) : this()
        {
            this.mensaje = mensaje;
        }
        public int IndexEncontrado
        {
            get { return indexEncontrado; }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string idABuscar = this.txb_BuscarId.Text;
            int idInstrumento = idABuscar.ConvertirStringAEntero();
            int indexEncontrado;
            indexEncontrado = Musica.BuscarIdEnListas(idInstrumento);
            if (indexEncontrado != -1)
            {
                this.indexEncontrado = indexEncontrado;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Instrumento no encontrado");
            }
        }
        private void BuscarPorIdInstrumento_Load(object sender, EventArgs e)
        {
            this.lbl_mensaje.Text = this.mensaje;
        }
    }
}
