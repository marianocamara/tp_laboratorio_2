using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "Prueba de archivos";
            bool returno = t.Guardar("Prueba.txt");  
            Console.WriteLine(returno);
            Console.ReadKey();
        }
    }
}
