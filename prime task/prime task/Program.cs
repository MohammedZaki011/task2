using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_task
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool isprimenum = true;

            Console.WriteLine("pls Enter the frist Number ");
            int n1 = int.Parse(Console.ReadLine());


            Console.WriteLine("pls Enter the second Number ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (int x = n1; x <= n2; x++)
            {
                bool isprime = true;
                int var = x / 2;


                for (int y = 2; y < var; y++)
                {
                    if (x % y == 0)
                    {
                        isprime = false;
                        break;


                    }


                }

                if (isprime) Console.WriteLine(x + "   ");

            }

        }
    }      
}
