using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int i = 2;

            a = Convert.ToInt32(Console.ReadLine());
            while (a % i != 0)
            {
                i++;
            }
            if( a==i)
            {
                Console.WriteLine( "the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }
         
            


        }

    }
}
