using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BankAccountData
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            string FirstName = "Ivan";
            string MidName = "Kirolov";
            string Lastname = "Kunchev";
            int Moneyleft = 50;
            long Iban = 0845646546;
            int Card1 = 456465;
            int Card2 = 500055;
            int Card3 = 656565;

            Console.WriteLine("Three Names {0}  {1}  {2}",FirstName,MidName,Lastname);
            Console.WriteLine("Money Left - {0}",Moneyleft);
            Console.WriteLine("Iban - {0}",Iban);
            Console.WriteLine(@"Three cards 
First card -  {0} 
Second Card - {1}
Third Card -  {2}",Card1,Card2,Card3);
 

         }
    }
}
