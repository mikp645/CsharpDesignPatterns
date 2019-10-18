using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Builder
{
    public abstract class BikeDirector
    {
        public abstract IBicycle Build(AbstractBikeBuilder builder);
    }
}
