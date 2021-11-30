using System.Collections.Generic;

namespace System
{
    internal class Building : Composite
    {
        public Building(string name)
        : base(name)
        {
            blankspace += "      ";
        }
    }
}