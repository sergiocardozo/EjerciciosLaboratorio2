using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<String>
    {
        protected override bool ValidarArchivo(string ruta, bool validadExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validadExistencia) && Path.GetExtension(ruta) == ".txt")
                    return true;
                else
                    throw new ArchivoIncorrectoException("El archivo no contiene extension txt");
            }
            catch (FileNotFoundException e)
            {

                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }
        }
        public bool Guardar(string ruta, string objeto)
        {
            try
            {
                this.ValidarArchivo(ruta, true);
                using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(ruta)))
                {
                    sw.WriteLine(objeto);
                }
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public bool GuardarComo(string ruta, string objeto)
        {
            try
            {
                this.ValidarArchivo(ruta, false);
                if (!Directory.Exists(Path.GetDirectoryName(ruta)))
                    throw new DirectoryNotFoundException();
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(objeto);
                }
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public string Leer(string ruta)
        {
            try
            {
                this.ValidarArchivo(ruta, true);
                string linea;
                string info = "";
                using (StreamReader str = new StreamReader(ruta))
                {
                    while ((linea = str.ReadLine()) != null)
                    {
                        info += (linea + "\n");
                    }
                }
                return info;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
