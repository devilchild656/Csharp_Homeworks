using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sumof5Numbers
{
    class Numbers_with_Space
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers separate with space");
            string number = Console.ReadLine();
            double numbersum = number.Split(' ').Sum(x => double.Parse (x));
            Console.WriteLine("Result is = {0}",numbersum);
        
        
        }
    }
}
