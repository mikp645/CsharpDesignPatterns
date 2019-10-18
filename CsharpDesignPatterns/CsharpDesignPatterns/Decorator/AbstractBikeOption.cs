using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Decorator
{
    public abstract class AbstractBikeOption : AbstractBike
    {
        protected internal IBicycle decoratedBike;

        public AbstractBikeOption(IBicycle bicycle)
            : base(bicycle.GetWheel)
        {
        this.decoratedBike = bicycle;
        }
    }
}
