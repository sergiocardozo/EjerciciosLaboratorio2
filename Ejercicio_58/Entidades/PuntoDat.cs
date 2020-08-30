using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoDat : Archivo,IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido { get; set; }
        protected override bool ValidarArchivo(string ruta, bool validadExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validadExistencia) && Path.GetExtension(ruta) == ".dat")
                    return true;
                else
                    throw new ArchivoIncorrectoException("El archivo no es de la extension .dat");
            }
            catch (FileNotFoundException ex)
            {

                throw new ArchivoIncorrectoException("El archivo no es correcto", ex);
            }
        }
        public bool Guardar(string ruta, PuntoDat objeto)
        {
            try
            {
                this.ValidarArchivo(ruta, true);
                using (FileStream fs = new FileStream(ruta, FileMode.OpenOrCreate))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(fs, objeto);
                }
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            try
            {
                this.ValidarArchivo(ruta, false);
                if (!Directory.Exists(Path.GetDirectoryName(ruta)))
                    throw new DirectoryNotFoundException();
                using (FileStream fs = new FileStream(ruta, FileMode.Create))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(fs, objeto);
                }
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public PuntoDat Leer(string ruta)
        {
            try
            {
                this.ValidarArchivo(ruta, true);
                PuntoDat aux = new PuntoDat();
                using (FileStream fs = new FileStream(ruta, FileMode.Open))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    aux = (PuntoDat)ser.Deserialize(fs);
                }
                return aux;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
