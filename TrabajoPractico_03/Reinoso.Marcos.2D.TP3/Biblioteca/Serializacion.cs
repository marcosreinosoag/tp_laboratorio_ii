using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class ClaseSerializadorJson<T>
    {
        static string path;
        static ClaseSerializadorJson()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos~Serializacion\";
        }
        public static void Escribir(T datos, string nombre)
        {
            string nombreArchivo = path + @"\SerializadoraJson_" + nombre + ".JSON";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string objetoJson = JsonSerializer.Serialize(datos);
                File.WriteAllText(nombreArchivo, objetoJson);
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {path}", e);
            }
        }
        public static T Leer(string nombre)
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T datosRecuperados = default;
            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivosEnRuta = Directory.GetFiles(path);
                    foreach (string path in archivosEnRuta)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        datosRecuperados = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }
                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {path}", e);
            }
        }
    }
}
