using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bateria : Instrumento
    {
        bool esElectronica;
        int cantidadPlatillos;
        bool doblePedal;
        public Bateria()
        {

        }
        public Bateria(int id, string nombre, int cantidad, decimal precio, bool esElectronica, int cantidadPlatillos, bool doblePedal) : base(id, nombre, cantidad, precio)
        {
            this.esElectronica = esElectronica;
            this.cantidadPlatillos = cantidadPlatillos;
            this.doblePedal = doblePedal;
        }
        public bool EsElectronica { get => esElectronica; set => esElectronica = value; }
        public int CantidadPlatillos { get => cantidadPlatillos; set => cantidadPlatillos = value; }
        public bool DoblePedal { get => doblePedal; set => doblePedal = value; }
    }
}
