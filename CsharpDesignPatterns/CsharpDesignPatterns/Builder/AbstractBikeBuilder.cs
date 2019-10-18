﻿using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Builder
{
   public abstract class AbstractBikeBuilder
    {
        // property of IBicycle called Bicycle
        public abstract IBicycle Bicycle { get; }

        /*
         * Methods below are virtual which means optionally override in a child
         */
         public virtual void BuildStreetTires() { }
        public virtual void BuildWideTires() { }
        public virtual void BuildHandleBars() { }
    }
}
