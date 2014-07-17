using System;


namespace _15.Age_after_10_Years
{
    class AgeAfter10years
    {
        static void Main()
        {
            Console.WriteLine("Enter your BirthDay:");
            Console.WriteLine("mm.dd.yyyy");
            DateTime DateOfBirth;
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            var now = float.Parse(DateTime.Now.ToString("yyyy.MMdd"));
            var dob = float.Parse(DateOfBirth.ToString("yyyy.MMdd"));
            var age = (int)(now - dob);
            Console.WriteLine("You are now  = {0}", age);
            Console.WriteLine("You will be after 10 year   = {0}", age + 10);

        }
    }
}
