using System.Collections.Generic;

namespace System
{
    internal class Street : Composite
    {
        public Street(string name)
        : base(name)
        {
            blankspace += "    ";
        }
    }
}