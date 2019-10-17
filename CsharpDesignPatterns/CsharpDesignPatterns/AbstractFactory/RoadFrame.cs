using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.AbstractFactory
{
    public class RoadFrame : IBikeFrame
    {
        public string BikeFrameParts
        {
            get { return "Frame parts for the Road Bike."; }
        }
    }
}
