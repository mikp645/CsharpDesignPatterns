﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.AbstractFactory
{
    public class MountainFrame : IBikeFrame
    {
        public string BikeFrameParts
        {
            get { return "Frame parts for the Mountain Bike"; }
        }
    }
}
