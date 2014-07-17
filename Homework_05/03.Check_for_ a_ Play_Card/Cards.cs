using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Check_for__a__Play_Card
{
    class Cards
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter card");
            string card = Console.ReadLine();
            if (card == "Q" || card == "K" || card == "A" || card == "J" || card == "10" ||
                card == "9" || card == "8" || card == "7" || card == "6" || card == "5" || card == "4" ||
                card == "3" || card == "2")
            {
                Console.WriteLine("Is a card = {0}", true);


            }
            else {
                Console.WriteLine("Is a card = {0}",false);
            }
        }
    }
}
