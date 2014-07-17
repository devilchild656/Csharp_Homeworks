using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintCompanyInformation
{
    class Company
    {
        static void Main(string[] args)
        {
            Console.WriteLine( " Enter Company name");
            string nameC = Console.ReadLine();
            Console.WriteLine("Enter Adress of company");
            string adress = Console.ReadLine();
            Console.WriteLine("Enter phone of company ");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fax");
            short fax = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter Website of company ");
            string website = Console.ReadLine();
            Console.WriteLine("Enter Manager  name ");
            string mangername = Console.ReadLine();
            Console.WriteLine("Age of Manager");
            short age = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter manager phone number");
            int phonem = int.Parse(Console.ReadLine());

            Console.WriteLine(@"
Name of company - {0}
Adress  - {1}
Phone  - {2}
Fax  - {3}
Website - {4}
Manager name - {5}
Age of Manager - {6}
Phone of Manger - {7}",nameC,adress,phone,fax,website,mangername,age,phonem);


        }
    }
}
