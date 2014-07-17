using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Formatting_Numbers
{
    class Format_numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c ");
            double c = double.Parse(Console.ReadLine());
            string mask = Convert.ToString(a , 16);
            string masktwo = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine(" {0} | {1} | {2:F2} | {3:F3} |",mask,masktwo,b,c );
        }
    }
}
