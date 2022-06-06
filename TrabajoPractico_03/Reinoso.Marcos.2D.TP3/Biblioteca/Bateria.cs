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
        int cantidadTom;
        int cantidadPlatillos;
        bool doblePedal;

        public Bateria(int id, string nombre, string marca, int cantidad, decimal precio, bool esElectronica, int cantidadTom, int cantidadPlatillos, bool doblePedal) : base(id, nombre, marca, cantidad, precio)
        {
            this.EsElectronica = esElectronica;
            this.CantidadTom = cantidadTom;
            this.CantidadPlatillos = cantidadPlatillos;
            this.DoblePedal = doblePedal;

        }
        public bool EsElectronica { get => esElectronica; set => esElectronica = value; }
        public int CantidadTom { get => cantidadTom; set => cantidadTom = value; }
        public int CantidadPlatillos { get => cantidadPlatillos; set => cantidadPlatillos = value; }
        public bool DoblePedal { get => doblePedal; set => doblePedal = value; }
    }
}
