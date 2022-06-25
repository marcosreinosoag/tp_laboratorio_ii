using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum EtipoGuitarra
    {
        Criolla,
        Acustica,
        Electrica,
    }
    public enum EtipoColor
    {
        Negro,
        Blanco,
        Rojo,
        Madera,
    }

    public class Guitarra : Instrumento
    {
        EtipoGuitarra tipo;
        EtipoColor color;
        int cantidadDeMicrofonos;
        bool tieneTremolo;
        public Guitarra()
        {

        }
        public Guitarra(int id, string nombre, int cantidad, decimal precio, EtipoGuitarra tipo, EtipoColor color, int cantidadDeMicrofonos, bool tieneTremolo) : base(id, nombre, cantidad, precio)
        {
            this.tipo = tipo;
            this.color = color;
            this.cantidadDeMicrofonos = cantidadDeMicrofonos;
            this.tieneTremolo = tieneTremolo;
        }
        public int CantidadDeMicrofonos { get => cantidadDeMicrofonos; set => cantidadDeMicrofonos = value; }
        public bool TieneTremolo { get => tieneTremolo; set => tieneTremolo = value; }
        public EtipoGuitarra Tipo { get => tipo; set => tipo = value; }
        public EtipoColor Color { get => color; set => color = value; }
    }
}
