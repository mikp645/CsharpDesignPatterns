using CsharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Adapter
{
   public class UltraWheelAdapter : AbstractWheel
    {
        public UltraWheelAdapter(UltraWheel ultraWheel)
            :base(ultraWheel.WheelSize, false) { }
    }
}

