using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiDecoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Example();
        }


        private static void Example()
        {
            //Mensaje ASCII = La paz nunca fue una opción
            var asciiCode = "076 097 032 112 097 122 032 110 117 110 099 097 032 102 117 101 032 117 110 097 032 111 112 099 105 195 179 110";

            Console.WriteLine( string.Format("Ascii code: {0}",asciiCode));

            //Convertir string a array de bytes con expresion lambda
            //1 Hacer split para obtener cada byte en string
            //2 Convertir strig a byte
            //3 Crear array
            var asciiBytes = asciiCode.Split(' ').Select(valor => Convert.ToByte(valor)).ToArray();

            //Convertir bytes a string con ascci
            var asciiMessage = Encoding.ASCII.GetString(asciiBytes);

            Console.WriteLine(string.Format("Ascii encoding message: {0}", asciiMessage));


            //Convertir bytes a string con utf8
            var utf8Message = Encoding.UTF8.GetString(asciiBytes);

            Console.WriteLine(string.Format("utf8 encoding message: {0}", utf8Message));

            Console.ReadLine();
        }
    }
}
