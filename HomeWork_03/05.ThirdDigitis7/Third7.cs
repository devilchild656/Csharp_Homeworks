using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitis7
{
    class Third7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Nummber");
            int number = int.Parse(Console.ReadLine());
            if (((number / 100) % 10) == 7)
            {
                Console.WriteLine(true);


            }
            else
            {
                Console.WriteLine(false);
            }
            
        }
    }
}
