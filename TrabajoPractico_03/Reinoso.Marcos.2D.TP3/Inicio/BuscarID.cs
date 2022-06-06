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
    public partial class BuscarID : Form
    {
        string mensaje;
        int indexEncontrado;
        string tipoDeDato;
        public BuscarID()
        {
            InitializeComponent();
        }
        public BuscarID(string mensaje, string tipoDeDato) : this()
        {
            this.mensaje = mensaje;
            this.tipoDeDato = tipoDeDato;
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
            //int numeroId;
            int indexEncontrado;
            switch (tipoDeDato)
            {
                case "Usuario":
                    indexEncontrado = Musica.BuscarIdEnListas(idABuscar);
                    if (indexEncontrado != -1)
                    {
                        this.indexEncontrado = indexEncontrado;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                    break;
                    //case "Instrumento":
                    //    int.TryParse(idABuscar, out numeroId);
                    //    indexEncontrado = Bar.BuscarIdEnListas(numeroId);
                    //    if (indexEncontrado != -1)
                    //    {
                    //        this.indexEncontrado = indexEncontrado;
                    //        this.DialogResult = DialogResult.OK;
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Consumicion no encontrada");
                    //    }
                    //    break;
            }
        }

        private void BuscarID_Load(object sender, EventArgs e)
        {
            this.lbl_mensaje.Text = this.mensaje;
        }
    }
}
