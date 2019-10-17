using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.AbstractFactory
{
    public abstract class AbstractBikeFactory
    {
        public abstract IBikeFrame CreateBikeFrame();
        public abstract IBikeSeat CreateBikeSeat();
    }
}
