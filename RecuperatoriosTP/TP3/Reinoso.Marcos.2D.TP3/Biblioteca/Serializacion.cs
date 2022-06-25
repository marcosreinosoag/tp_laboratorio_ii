using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    public static class Serializacion<T>
    {
        static string rutaBase;
        static Serializacion()
        {
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
        }
        public static void Escribir(T datos, string archivo)
        {
            string rutaCompleta = rutaBase + archivo + ".xml";
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sw, datos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al escribir en el archivo {rutaCompleta}", ex);
            }
        }
        public static T Leer(string nombreArchivo)
        {
            string rutaCompleta = rutaBase + nombreArchivo + ".xml";

            T datos = default;

            try
            {
                if (Directory.Exists(rutaBase))
                {
                    string[] archivosEnRuta = Directory.GetFiles(rutaBase);
                    foreach (string archivoEnRuta in archivosEnRuta)
                    {
                        if (archivoEnRuta.Contains(nombreArchivo))
                        {
                            rutaCompleta = archivoEnRuta;
                            break;
                        }
                    }
                    if (rutaCompleta != null)
                    {
                        using (StreamReader sr = new StreamReader(rutaCompleta))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerializer.Deserialize(sr);
                        }
                    }
                }
                return datos;
            }
            catch (Exception)
            {
                throw new Exception($"Error al leer en el archivo{rutaCompleta}");
            }
        }

    }
}
