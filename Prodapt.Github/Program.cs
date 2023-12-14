using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prodapt.Github
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var today = DateTime.Now; // To get the present time

            Console.WriteLine(today.ToShortDateString()); //only date will be printed
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(today.ToShortTimeString()); // only time will be printed
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(today.ToLongDateString()); // 10 December 2023
            Console.WriteLine(DateTime.Now.ToLongDateString());

            Console.WriteLine(today.ToLongTimeString()); // 10:03:41 AM
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
