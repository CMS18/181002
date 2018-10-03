using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedExceptionsHandlers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter Main");

            Console.WriteLine("Call MethodA()");
            MethodA();

            //Console.WriteLine("Call MethodC()");
            //MethodC(0);

            Console.WriteLine($"Exit Main");
        }

        static void MethodA()
        {
            Console.WriteLine($"Enter MethodA");
            try
            {
                Console.WriteLine($"Enter try");
                MethodB();
                Console.WriteLine($"Exit try");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Enter catch");
                Console.WriteLine("Division med noll - skriv in en annan täljare!");
                //throw;
                Console.WriteLine($"Exit catch");
            }
            finally
            {
                Console.WriteLine($"Enter finally");
                Console.WriteLine("Städa - t ex stänga en fil");
                Console.WriteLine($"Exit finally");
            }
            Console.WriteLine($"Exit MethodA");
        }

        static void MethodB()
        {
            Console.WriteLine($"Enter MethodB");
            MethodC(0);
            Console.WriteLine($"Exit MethodB");
        }

        static void MethodC(int x)
        {
            Console.WriteLine($"Enter MethodC");
            MethodD(10, x);
            Console.WriteLine($"Exit MethodC");
        }

        static int MethodD(int a, int b)
        {
            Console.WriteLine($"Enter MethodD");

            // Do stuff
            var result = a / b;

            Console.WriteLine($"Before Return in MethodD");
            return result;          
        }
    }
}
