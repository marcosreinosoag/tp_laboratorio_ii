using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Biblioteca
{
    [XmlInclude(typeof(Bateria))]
    [XmlInclude(typeof(Guitarra))]
    public abstract class Instrumento: IInformacion
    {
        static int lastId;

        int id;
        string descripcion;
        int cantidad;
        decimal precio;
        static Instrumento()
        {
            lastId = 1;
        }
        public Instrumento()
        {

        }
        public Instrumento(int id, string nombre, int cantidad, decimal precio)
        {
            lastId = id;
            this.id = id;
            lastId++;
            this.descripcion = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }

        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Descripcion: {this.descripcion}");
            sb.AppendLine($"Cantidad: {this.cantidad}");
            sb.AppendLine($"Precio: {this.Precio}");
            return sb.ToString();
        }
        public string VerificarCantidad(int cantidad)
        {
            string retorno = null;
            if (this.Cantidad < cantidad)
            {
                return "La cantidad ingresada supera a la que hay en stock";
            }
            return retorno;
        }
        public static int GenerarId()
        {
            return lastId;
        }
    }
}
