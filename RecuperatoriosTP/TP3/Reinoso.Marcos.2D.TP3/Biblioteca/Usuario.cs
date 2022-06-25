using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    public enum ECargo
    {
        Administrador,
        Cliente,
    }
    public class Usuario : IInformacion
    {
        string idDni;
        string clave;
        string nombre;
        string apellido;
        ECargo cargo;
        DateTime fechaNac;
        List<Instrumento> pedidos;

        public Usuario()
        {

        }
        public Usuario(string idDni, string clave, string nombre, string apellido, ECargo cargo, DateTime fechaNac)
        {
            this.IdDni = idDni;
            this.Clave = clave;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cargo = cargo;
            this.FechaNac = fechaNac;
            this.Pedidos = pedidos = new List<Instrumento>();
        }
        public Usuario(string idDni, string clave, string nombre, string apellido, ECargo cargo, DateTime fechaNac, List<Instrumento> pedidos) : this(idDni, clave, nombre, apellido, cargo, fechaNac)
        {
            this.Pedidos = pedidos;
        }

        public string IdDni { get => idDni; set => idDni = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public ECargo Cargo { get => cargo; set => cargo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public List<Instrumento> Pedidos { get => pedidos; set => pedidos = value; }

        public string MostrarInformacion()
        {
            int edadUsuario = DateTime.Now.Year - this.fechaNac.Year;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.idDni}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Cargo: {this.cargo}");
            sb.AppendLine($"Fehca de nacimiento: {this.fechaNac.ToShortDateString()}");
            sb.AppendLine($"Edad: {edadUsuario}");
            return sb.ToString();  
        }
    }
}
