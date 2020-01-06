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
            var asciiCode = "076097032112097122032110117110099097032102117101032117110097032111112099105195179110";


            Console.WriteLine( string.Format("Ascii code: {0}",asciiCode));

            //Convertir string a array de bytes con expresion lambda
            //1 Hacer split para obtener cada byte en string
            //2 Convertir strig a byte
            //3 Crear array


            //Hacer split cada 3 caracteres
            var splitedMessage = Split(asciiCode, 3);

            //Obtener bytes
            var asciiBytes = splitedMessage.Select(valor => Convert.ToByte(valor)).ToArray();

            //Convertir bytes a string con ascci
            var asciiMessage = Encoding.ASCII.GetString(asciiBytes);

            Console.WriteLine(string.Format("Ascii encoding message: {0}", asciiMessage));


            //Convertir bytes a string con utf8
            var utf8Message = Encoding.UTF8.GetString(asciiBytes);

            Console.WriteLine(string.Format("utf8 encoding message: {0}", utf8Message));

            Console.ReadLine();
        }

        /// <summary>
        /// Divide String en un array, dependiendo del tamaño
        /// </summary>
        /// <param name="str"></param>
        /// <param name="chunkSize"></param>
        /// <returns></returns>
        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
