using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.QuotesinStrings
{
    class QuotesinString
    {
        static void Main(string[] args)
        {
            string firsttest = "The \"use\" of quotations causes difficulties.";
            string secondtest =@"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(firsttest);
            Console.WriteLine(secondtest);

        }
    }
}
