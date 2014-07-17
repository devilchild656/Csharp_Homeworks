using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hello = ("Hello");
            string World = ("World");
            object Helloworld = Hello + " " + World;
            string Hi = (string)Helloworld;

            Console.WriteLine(Hi);
        }
    }
}
