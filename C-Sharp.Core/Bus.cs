using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Core
{
    public class Bus
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int total = 0;
           foreach(var item in peopleListInOut)
            {
                total += item[0] - item[1];
            }

            return total;
        }
    }
}
