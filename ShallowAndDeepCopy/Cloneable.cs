using System;
using System.Collections.Generic;
using System.Text;

namespace ShallowAndDeepCopy
{
    interface Cloneable
    {
        public Recipe Clone(Recipe toClone, List<int> alreadyGeneratedIds);
    }
}
