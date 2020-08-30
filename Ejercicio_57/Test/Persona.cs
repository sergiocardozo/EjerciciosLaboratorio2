using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Test
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool Guardar(Persona p)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            //XmlTextWriter writer = new XmlTextWriter(ruta + "Archivo" + ".xml", Encoding.UTF8);
            //XmlSerializer ser = new XmlSerializer(typeof(Persona));
            //ser.Serialize(writer, p);
            //writer.Close();
            //return true;
            try
            {
                if (!Directory.Exists(ruta))
                    throw new DirectoryNotFoundException();
                using (XmlTextWriter writer = new XmlTextWriter(ruta + "Archivo" + ".xml",Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Persona));
                    ser.Serialize(writer, p);
                }
                return true;                 
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Persona Leer()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "Archivo" + ".xml";
            //
            //reader.Close();
            try
            {
                if (!File.Exists(ruta))
                    throw new FileNotFoundException();
                Persona buffer = new Persona();
                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Persona));
                    buffer = (Persona)ser.Deserialize(reader);
                }
                return buffer;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public override string ToString()
        {
            return this.nombre + " " + this.apellido + "\n";
        }
    }
}
