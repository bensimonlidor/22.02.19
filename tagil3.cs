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
            int sum = 0;
            a = Convert.ToInt32(Console.ReadLine());
            while ( a>0)
            {
                sum = sum + a;

             a= Convert.ToInt32(Console.ReadLine());  
            }
            Console.WriteLine( sum);


        }

    }
}
