using System.Collections.Generic;
using System.Linq;

namespace Nexus.Memory
{
    public partial class MemoryInfo : Memory
    {
        public static List<string> GetListPermission(int userId)
        {
            if (DicUserPermission != null && DicUserPermission.ContainsKey(userId))
            {
                return DicUserPermission[userId].Select(x => x.Name).ToList();
            }
            return  new List<string>();
        }

    }
}


