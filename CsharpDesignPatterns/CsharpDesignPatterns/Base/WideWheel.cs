using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Base
{
   public class WideWheel : AbstractWheel
{
    public WideWheel(int size)
        : base(size, true) { }
}
}
