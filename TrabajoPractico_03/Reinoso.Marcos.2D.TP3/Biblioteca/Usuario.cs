using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum ECargo
    {
        Administrador,
        Cliente,
    }
    public class Usuario
    {
        string idDni;
        string clave;
        string nombre;
        string apellido;
        ECargo cargo;
        DateTime fechaNac;
        List<Instrumento> pedidos;
        public Usuario(string idDni, string clave, string nombre, string apellido, ECargo cargo, DateTime fechaNac)
        {
            pedidos = new List<Instrumento>();
            this.IdDni = idDni;
            this.Clave = clave;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cargo = cargo;
            this.FechaNac = fechaNac;
        }
        public string IdDni { get => idDni; set => idDni = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public ECargo Cargo { get => cargo; set => cargo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    }
}
