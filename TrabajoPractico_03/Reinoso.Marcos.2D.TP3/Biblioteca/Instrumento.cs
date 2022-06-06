using System;
using System.IO;

namespace Biblioteca
{
    public abstract class Instrumento
    {
        private int id;
        private string nombre;
        private string marca;
        private int cantidad;
        private decimal precio;
        protected Instrumento(int id, string nombre, string marca, int cantidad, decimal precio)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Marca = marca;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        protected int Id { get => id; set => id = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Marca { get => marca; set => marca = value; }
        protected int Cantidad { get => cantidad; set => cantidad = value; }
        protected decimal Precio { get => precio; set => precio = value; }

    }
}
