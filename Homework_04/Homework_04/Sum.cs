using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04
{
    class Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c ");
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;
            Console.WriteLine("{0}+{1}+{2} = {3}",a,b,c,sum);
        }
    }
}
