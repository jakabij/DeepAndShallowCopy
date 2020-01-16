using System;
using System.Collections.Generic;
using System.Text;

namespace ShallowAndDeepCopy
{
    class DataManager
    {
        public int GenerateId(List<int> alreadyGeneratedIds)
        {
            Random random = new Random();
            int generatedId = random.Next(11111111, 99999999);
            while (alreadyGeneratedIds.Contains(generatedId))
            {
                generatedId = random.Next(11111111, 99999999);
            }
            return generatedId;

        }
    }
}
