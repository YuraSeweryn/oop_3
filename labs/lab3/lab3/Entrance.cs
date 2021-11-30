using System.Collections.Generic;

namespace System
{
    internal class Entrance : Composite
    {
        public Entrance(string name)
        : base(name)
        {
            blankspace += "        ";
        }
    }
}