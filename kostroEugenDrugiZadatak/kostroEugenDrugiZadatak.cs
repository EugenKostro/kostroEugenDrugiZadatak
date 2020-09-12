using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenDrugiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuta, sekunda, brojSekundi;

            Console.WriteLine("Upišite broj sekundi: ");
            sekunda = Convert.ToInt32();

            minuta = sekunda / 60;
            brojSekundi = sekunda % 60;

            Console.WriteLine("minuta/e: ", minuta);
            Console.WriteLine("sekundi/e: ", brojSekundi);

            Console.ReadKey();
        }
    }
}
