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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_musica_Click(object sender, EventArgs e)
        {
            LoguinMusica frm_musica = new LoguinMusica();
            frm_musica.Show();
        }

        private void btn_transporte_Click(object sender, EventArgs e)
        {
            LoguinTransporte frm_transporte = new LoguinTransporte();
            frm_transporte.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
