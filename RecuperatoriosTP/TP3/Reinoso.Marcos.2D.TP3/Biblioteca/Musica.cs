using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Musica
    {
        public static List<Usuario> listaUsuarios;
        public static List<Instrumento> listatotalInstrumento;
        public static List<Guitarra> listaGuitarras;
        public static List<Bateria> listaBaterias;
        static Musica()
        {
            listatotalInstrumento = new List<Instrumento>();
            listaUsuarios = new List<Usuario>();
            LeerIntrumentos();
            LeerUsuarios();
            CargarListaBateria();
            CargarListaGuitarra();
        }
        public static void CargaDeInstrumento(Instrumento instrumento)
        {
            if (instrumento != null)
            {
                Musica.listatotalInstrumento.Add(instrumento);
            }
            CargarListaBateria();
            CargarListaGuitarra();
        }
        public static void CargaDeInstrumento(Instrumento instrumento, int index)
        {
            if (instrumento != null)
            {
                Musica.listatotalInstrumento[index] = instrumento;
            }
            CargarListaBateria();
            CargarListaGuitarra();
        }
        public static void LeerUsuarios()
        {
            List<Usuario> AuxUsuario = Serializacion<List<Usuario>>.Leer("ListaUsuarios");
            if (AuxUsuario != null)
            {
                listaUsuarios = AuxUsuario;
            }
            else
            {
                CargaDeEmpleados();
            }
        }
        public static void CargarListaBateria()
        {
            if (Musica.listatotalInstrumento != null)
            {
                listaBaterias = new List<Bateria>();
                foreach (Instrumento item in Musica.listatotalInstrumento)
                {
                    if (item.GetType() == typeof(Bateria))
                    {
                        listaBaterias.Add((Bateria)item);
                    }
                }
            }
        }
        public static void CargarListaGuitarra()
        {
            if (Musica.listatotalInstrumento != null)
            {
                listaGuitarras = new List<Guitarra>();
                foreach (Instrumento item in Musica.listatotalInstrumento)
                {
                    if (item.GetType() == typeof(Guitarra))
                    {
                        listaGuitarras.Add((Guitarra)item);
                    }
                }
            }
        }
        public static void LeerIntrumentos()
        {
            List<Instrumento> AuxInstrumento = Serializacion<List<Instrumento>>.Leer("ListaInstrumentos");
            if (AuxInstrumento != null)
            {
                listatotalInstrumento = AuxInstrumento;
            }
            else
            {
                CargaDeInstrumentos();
            }
        }
        public static void CargaDeEmpleados()
        {
            Usuario usuario1 = new Usuario("40305323", "12341234", "Roberto", "Suarez", ECargo.Cliente, new DateTime(1998, 03, 23));
            Usuario usuario2 = new Usuario("405454555", "1234", "Fred", "Suarez", ECargo.Administrador, new DateTime(1998, 03, 23));
            Musica.listaUsuarios.Add(usuario1);
            Musica.listaUsuarios.Add(usuario2);
        }
        public static void CargaDeInstrumentos()
        {
            Instrumento guitarraFender = new Guitarra(1, "Guitarra eléctrica Fender Standard Stratocaster de aliso black con diapasón de arce ", 10, 245000, EtipoGuitarra.Electrica, EtipoColor.Negro, 3, true);
            Musica.listatotalInstrumento.Add(guitarraFender);
            Instrumento guitarraGibson = new Guitarra(2, "Guitarra eléctrica Epiphone Inspired by Gibson Les Paul Custom de caoba ebony brillante con diapasón de ébano", 9, 210000, EtipoGuitarra.Electrica, EtipoColor.Negro, 3, false);
            Musica.listatotalInstrumento.Add(guitarraGibson);
            Instrumento guitarra04 = new Guitarra(3, "Guitarra Gibson Memphis Es-339 Studio Wine Red", 10, 628000, EtipoGuitarra.Electrica, EtipoColor.Blanco, 3, false);
            Musica.listatotalInstrumento.Add(guitarra04);
            Instrumento guitarra05 = new Guitarra(4, "Guitarra eléctrica LTD EC Series EC-256 de caoba 2018 black con diapasón de jatoba asado", 9, 210000, EtipoGuitarra.Electrica, EtipoColor.Negro, 3, false);
            Musica.listatotalInstrumento.Add(guitarra05);
            Instrumento guitarra06 = new Guitarra(5, "Guitarra Martin Omc-15me Funda Electroacústica The Working M ", 10, 434000, EtipoGuitarra.Acustica, EtipoColor.Madera, 3, false);
            Musica.listatotalInstrumento.Add(guitarra06);
            Instrumento guitarra07 = new Guitarra(6, "Guitarra Criolla Clasica Gracia M6", 9, 22000, EtipoGuitarra.Criolla, EtipoColor.Madera, 3, false);
            Musica.listatotalInstrumento.Add(guitarra07);
            Instrumento bateria = new Bateria(7, "Bateria Eléctrica Artesia Parches Mesh Doble Zona A50", 10, 220000, true, 2, false);
            Musica.listatotalInstrumento.Add(bateria);
            Instrumento bateria02 = new Bateria(8, "Bateria Acústica Rydeen 5 Cuerpos Bombo 20 Yamaha Rdp0f5fb", 15, 146000, true, 2, false);
            Musica.listatotalInstrumento.Add(bateria02);
            Instrumento bateria03 = new Bateria(10, "Bateria Tama Rhythm Mate Cosmic Indigo Pop Music Floresta!!!", 10, 195000, true, 2, false);
            Musica.listatotalInstrumento.Add(bateria03);
            Bateria bateriaDos = new Bateria(9, "Bateria Pearl Export 5 Cuerpos Bombo 22 Fp21", 10,180000, true, 2, true);
            Musica.listatotalInstrumento.Add(bateriaDos);
        }
        public static void EscribirUsuarios()
        {
            Serializacion<List<Usuario>>.Escribir(listaUsuarios, "ListaUsuarios");
        }
        public static void EscribirInstrumentos()
        {
            Serializacion<List<Instrumento>>.Escribir(listatotalInstrumento, "ListaInstrumentos");
        }
        public static int BuscarIdEnListas(string id)
        {
            int index = -1;
            if (id != null)
            {
                foreach (Usuario item in listaUsuarios)
                {
                    if (item.IdDni == id)
                    {
                        index = listaUsuarios.IndexOf(item);
                        return index;
                    }
                }
            }
            return index;
        } 
        public static int BuscarIdEnListas(int id)
        {
            int index = -1;
            if (id >=0)
            {
                foreach (Instrumento item in listatotalInstrumento)
                {
                    if (item.Id == id)
                    {
                        index = listatotalInstrumento.IndexOf(item);
                        return index;
                    }
                }
            }
            return index;
        }
        public static int BuscarIdEnUsuariosYDevolverIndice(string idABuscar)
        {
            int index = -1;
            if (idABuscar != null)
            {
                foreach (Usuario item in listaUsuarios)
                {
                    if (item.IdDni == idABuscar)
                    {
                        index = listaUsuarios.IndexOf(item);
                        return index;
                    }
                }
            }
            return index;
        }
        public static string DevolverNombreCompeletoUsuario(string id)
        {
            if (id != null)
            {
                foreach (Usuario item in listaUsuarios)
                {
                    if (item.IdDni == id)
                    {
                        return item.Nombre + " " + item.Apellido;
                    }
                }
            }
            return "El id no existe";
        }
        public static bool VerificarUsuarioYClave(string usuario, string clave)
        {
            foreach (Usuario item in listaUsuarios)
            {
                if (item.IdDni == usuario && item.Clave == clave)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool EliminarInstrumentoPorIndice(int indexABorrar)
        {
            bool retorno = false;
            if (indexABorrar > -1)
            {
                listatotalInstrumento.RemoveAt(indexABorrar);
                retorno = true;
            }
            CargarListaBateria();
            CargarListaGuitarra();
            return retorno;
        }
        public static bool EliminarUsuarioPorIndice(int index)
        {
            bool retorno = false;
            if (index > -1)
            {
                listaUsuarios.RemoveAt(index);
                retorno = true;
            }
            return retorno;
        }
        public static ECargo DevolverCargoUsuario(string id)
        {
            ECargo retorno = 0;
            foreach (Usuario item in listaUsuarios)
            {
                if (item.IdDni == id)
                {
                    retorno = item.Cargo;
                }
            }
            return retorno;
        }
        public static bool CargarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                listaUsuarios.Add(usuario);
                return true;
            }
            return false;
        }

        public static bool CargarUsuario(Usuario usuario, int indice)
        {
            if (usuario != null)
            {
                listaUsuarios[indice] = usuario;
                return true;
            }
            return false;
        }
    }
}
