using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.AbstractFactory
{
    public class RoadSeat : IBikeSeat
    {
        public string BikeSeatParts
        {
            get { return "Seat parts for the Road Bike"; }
        }
    }
}
