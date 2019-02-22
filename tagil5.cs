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
            int secert;
            int guess;

            secert = (new Random()).Next(101) + 1;
            guess = Convert.ToInt32(Console.ReadLine());
            while (secert != guess)
            {
              if(  guess< secert)

                {
                    Console.WriteLine( "too small");
                }
              else
                {
                    Console.WriteLine("too big");
                }

               guess= Convert.ToInt32(Console.ReadLine());
            }
      
            
                Console.WriteLine("bingo");
            
         
            


        }

    }
}
