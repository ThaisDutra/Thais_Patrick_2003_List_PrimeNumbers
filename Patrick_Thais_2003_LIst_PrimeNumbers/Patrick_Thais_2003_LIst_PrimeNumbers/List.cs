using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick_Thais_2003_LIst_PrimeNumbers
{
    class List
    {
            static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int a = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 2; j <= a; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;

                        break;
                    }


                }

                if (isPrime)
                {
                    Console.WriteLine("Primo:    " + i);
                }

                isPrime = true;
            }

            Console.ReadLine();
        }
    }
}
