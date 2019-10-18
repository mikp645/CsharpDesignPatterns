using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Facade
{
    public class BikeFacade
    {
        public void PrepareForSale(IBicycle bicycle)
        {
            Registration reg = new Registration(bicycle);
            reg.AllocateBikeNumber();

            Documentation.PrintBrochure(bicycle);

            bicycle.CleanFrame();
            bicycle.AirTires();
            bicycle.TestRide();
        }
    }
}
