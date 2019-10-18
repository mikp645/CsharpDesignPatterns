using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Facade
{
   public class Documentation
    {
        public static void PrintBrochure(IBicycle bicycle)
        {
            Console.WriteLine("Printing Brochure...");
        }
    }
}
