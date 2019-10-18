﻿using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Decorator
{
    public class LeatherSeatOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 40.00m; }
        }

        public LeatherSeatOption(IBicycle bicycle)
            : base(bicycle) { }
    }
}
