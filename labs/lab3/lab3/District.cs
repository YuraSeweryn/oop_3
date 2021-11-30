using System.Collections.Generic;

namespace System
{
    class District : Composite
    {
        public District(string name)
        : base(name)
        {
            blankspace += "  ";
        }
    }
}
