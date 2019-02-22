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
            int a, b;
            int sum = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;
            Double avg= sum / 2.0;
            Console.Write("print sum: ");
            Console.WriteLine(sum);
            Console.WriteLine(avg);


        }

    }
}
