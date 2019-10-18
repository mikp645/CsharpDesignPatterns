using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Facade
{
    public class Registration
    {
        private IBicycle _bicycle;

        public Registration(IBicycle bike)
        {
            this._bicycle = bike;
        }

        public void AllocateBikeNumber()
        {
            Console.WriteLine("Allocating Bike Number");
        }
    }
}
