using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{

    public static class GuardarString
    {
        /// <summary>
        /// Extension de String
        /// Guarda un archivo en la ruta especificada como parametro
        /// </summary>
        /// <param name="t"></param>
        /// <param name="archivo">ruta y nombre del archivo</param>
        /// <returns></returns>
        public static bool Guardar(this String t, string archivo)
        {
            try
            {
                using (StreamWriter file = new System.IO.StreamWriter(archivo, true))
                {
                    file.WriteLine(t);
                    file.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
