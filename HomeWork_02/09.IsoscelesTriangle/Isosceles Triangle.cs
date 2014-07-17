using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = (char)169;

            Console.WriteLine("      {0}     ",symbol);
            Console.WriteLine("     {0} {0}",symbol);
            Console.WriteLine("    {0}   {0}",symbol);
            Console.WriteLine("   {0} {0} {0} {0}", symbol);
        }
    }
}
