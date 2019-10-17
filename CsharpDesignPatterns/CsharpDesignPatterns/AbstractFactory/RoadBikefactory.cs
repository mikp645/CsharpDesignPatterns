using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.AbstractFactory
{
   public class RoadBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreateBikeFrame()
        {
            return new RoadFrame();
        }

        public override IBikeSeat CreateBikeSeat()
        {
            return new RoadSeat();
        }
    }
}
