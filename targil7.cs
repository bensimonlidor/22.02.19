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
            int i = 1;

            a=Convert.ToInt32(Console.ReadLine());
            b =Convert.ToInt32(Console.ReadLine());
            while (i <= b)
            {
                sum = sum + a;
                i++;
            }
            Console.WriteLine( sum);
        
      
        }

    }
}
