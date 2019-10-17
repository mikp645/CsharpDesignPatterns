using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.AbstractFactory
{
    public class MountainSeat : IBikeSeat
    {
        public string BikeSeatParts
        {
            get { return "Seat parts for the Mountain Bike"; }
        }
    }
}
