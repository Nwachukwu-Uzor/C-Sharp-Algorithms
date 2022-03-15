using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Core
{
    public class FriendOFoe
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(name => name.Length == 4);
        }
    }
}
