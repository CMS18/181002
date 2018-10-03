using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static int GoBoom(int a, int b)
        {
            var result = a / b;
            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(GoBoom(100, 0));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Något gick fel!");
                throw;
            }


            var x = int.Parse("XYZ");

            var success = int.TryParse("XYZ", out int value);
            if (success) // success == true
            {
                // Använd value till något
            }
            else
            {
                // Egen felhantering - t ex fråga igen.
            }

            int age = CalculteAgeInDays(new DateTime(2019, 10, 3));
            Console.WriteLine("Age in days: " + age);

            DoStuff();
        }

        private static int CalculteAgeInDays(DateTime birthDate)
        {
            if (birthDate > DateTime.Now)
                throw new ArgumentOutOfRangeException( nameof(birthDate), "Can not be a date in the future");
            return (DateTime.Now - birthDate).Days;
        }

        private static bool TryCalculteAgeInDays(DateTime birthDate, out int age)
        {
            var success = (birthDate < DateTime.Now);
            age = (DateTime.Now - birthDate).Days;
            return success;
        }

        private static void DoStuff()
        {
            throw new NotImplementedException();
        }
    }
}
