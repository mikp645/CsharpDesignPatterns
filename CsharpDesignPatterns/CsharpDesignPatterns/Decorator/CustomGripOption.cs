using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Decorator
{
    public class CustomGripOption :  AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 20.00m; }
        }
        public CustomGripOption(IBicycle bicycle)
            :base(bicycle) { }
    }
}
