using System;

namespace _17.Play_with_the_Debugger
{
    class Program
    {
        static void Main()
        {
            int a = 1;

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(a);
                a = a + 1;
            }
        }
    }
}
