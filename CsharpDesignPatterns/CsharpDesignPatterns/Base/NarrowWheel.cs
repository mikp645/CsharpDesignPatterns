using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDesignPatterns.Base
{
    public class NarrowWheel : AbstractWheel
{
    public NarrowWheel(int size)
        : base(size, false) { }
}
}
