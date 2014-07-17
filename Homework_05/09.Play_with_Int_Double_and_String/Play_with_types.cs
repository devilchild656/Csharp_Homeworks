using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Play_with_Int_Double_and_String
{
    class Play_with_types
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
@"Please Choose a type
-->1 int
-->2 double
-->3 string");
            int choose = int.Parse(Console.ReadLine());
            int a = 0;
            double b = 0;
            string c;
            Console.WriteLine();
            switch(choose)
            
            
            {
                case 1: a = int.Parse(Console.ReadLine());
                    { 
                        Console.WriteLine("Number is ---> {0}",a+1);
                
                    };break;
                case 2: b = double.Parse(Console.ReadLine());
                    {
                        Console.WriteLine("Number is ---> {0}", b + 1);

                    }; break;
                case 3: c = Console.ReadLine();
                    {
                        Console.WriteLine("String  is ---> {0}*", c);

                    }break;
                default:
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
                
                        

            }
        }
    }
}
