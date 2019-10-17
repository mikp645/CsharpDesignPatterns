using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.AbstractFactory
{
   public  class MountainBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreateBikeFrame()
        {
            return new MountainFrame();
        }

        public override IBikeSeat CreateBikeSeat()
        {
            return new MountainSeat();
        }

    }
}
