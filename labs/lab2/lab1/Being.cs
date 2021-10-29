using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public abstract class Being
    {
        public abstract string Name { get; set; }

        public abstract string Introduce();
    }
}
