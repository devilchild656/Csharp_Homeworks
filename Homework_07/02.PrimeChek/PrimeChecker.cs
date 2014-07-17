using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeCheckerMethod
{
    static bool PrimeChecker(long input)
    {
        if (input < 2)
        {
            return false;
        }
        else
        {
            int divider = 2;
            double maxDivider = Math.Sqrt(input);

            while (divider <= maxDivider)
            {
                if (input % divider == 0)
                {
                    return false;
                }

                divider++;
            }
        }

        return true;
    }

    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine("\"{0}\" is prime? {1}", number, PrimeChecker(number));
    }
}