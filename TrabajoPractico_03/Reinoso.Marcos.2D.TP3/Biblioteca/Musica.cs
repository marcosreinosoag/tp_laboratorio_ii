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
        public static List<Guitarra> listaGuistarras;
        public static List<Bateria> listaBaterias;

        static Musica()
        {
            listaUsuarios = new List<Usuario>();
            LeerUsuarios();
        }
        public static void LeerUsuarios()
        {
            listaUsuarios = ClaseSerializadorJson<List<Usuario>>.Leer("ListaUsuarios");
        }
        public static void EscribirUsuarios()
        {
            ClaseSerializadorJson<List<Usuario>>.Escribir(listaUsuarios, "ListaUsuarios");
        }
        public static void EscribirInstrumentos()
        {
            ClaseSerializadorJson<List<Usuario>>.Escribir(listaUsuarios, "ListaUsuarios");
        }
        public static void LeerIntrumentos()
        {
            listaUsuarios = ClaseSerializadorJson<List<Usuario>>.Leer("ListaUsuarios");
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
        //public static int BuscarIdEnListas(int idABuscar)
        //{
        //    int index = -1;
        //    if (idABuscar > 0)
        //    {
        //        foreach (Consumo item in totalConsumo)
        //        {
        //            if (item.Id == idABuscar)
        //            {
        //                index = totalConsumo.IndexOf(item);
        //                return index;
        //            }
        //        }
        //    }
        //    return index;
        //}
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
