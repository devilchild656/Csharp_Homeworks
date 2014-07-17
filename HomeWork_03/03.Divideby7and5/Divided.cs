using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Divideby7and5
{
    class Divided
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());
            


            if (a % 5 == 0 && a % 7 == 0)
            {

                Console.WriteLine("Can be divide by 7 and 5 = {0}",true);

            }
            else
            {

                Console.WriteLine("Can be divide by 7 and 5 = {0}",false);

            }
            

        }
    }
}
