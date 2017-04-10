using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(EvaluaFizzBuzz(i));
            }

            Console.ReadLine();
        }

        public static string EvaluaFizzBuzz(int numero)
        {
            double result;
            result = numero / 3.0;
            int resultInt;
            if (int.TryParse(result.ToString(), out resultInt))
            {
                return "Fizz";
            }

            return numero.ToString();
          
        }
    }
}
