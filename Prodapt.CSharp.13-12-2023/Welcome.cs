using System;
using Prodapt.CSharp.ToCreate.dll_File;

namespace Prodapt.CSharp._13_12_2023_
{
    internal class Welcome
    {
        static void Main(string[] args)
        {
            Login l = new Login();
            var result = l.Validation("jeeva", "22");
            Console.WriteLine(result);
        }


    }
}
