using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Etipo
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
        Etipo tipo;
        EtipoColor color;
        int cantidadDeMicrofonos;
        bool tieneTremolo;

        public Guitarra(int id, string nombre, string marca, int cantidad, decimal precio, Etipo tipo, EtipoColor color, int cantidadDeMicrofonos, bool tieneTremolo) : base(id, nombre, marca, cantidad, precio)
        {
            this.Tipo = tipo;
            this.Color = color;
            this.CantidadDeMicrofonos = cantidadDeMicrofonos;
            this.TieneTremolo = tieneTremolo;
        }

        public int CantidadDeMicrofonos { get => cantidadDeMicrofonos; set => cantidadDeMicrofonos = value; }
        public bool TieneTremolo { get => tieneTremolo; set => tieneTremolo = value; }
        internal Etipo Tipo { get => tipo; set => tipo = value; }
        internal EtipoColor Color { get => color; set => color = value; }
    }
}
