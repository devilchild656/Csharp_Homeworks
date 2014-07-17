using System;


namespace _16.Print_Long_Sequence
{
    class LongSequance
    {
        static void Main()
        {
            int a = 2;
            int b = -(a + 1);

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);

                a = a + 2;
                b = b - 2;


            }
        }
    }
}
