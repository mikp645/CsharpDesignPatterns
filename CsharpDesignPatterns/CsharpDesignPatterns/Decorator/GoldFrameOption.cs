using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Decorator
{
    public class GoldFrameOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 300.00M; }
        }
        public GoldFrameOption(IBicycle bicycle)
            : base(bicycle) { }
    }
}
