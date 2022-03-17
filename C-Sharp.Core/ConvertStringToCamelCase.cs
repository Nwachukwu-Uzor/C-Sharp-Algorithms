using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Core
{
    public class ConvertStringToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            var replaced = str.Replace('_', ' ');
            replaced = replaced.Replace('_', ' ');

            var stringBuilder = new StringBuilder();
            
            for(int i = 0; i < replaced.Length; i++)
            {
                if (!char.IsWhiteSpace(replaced[i]))
                {
                    if (i > 0 && char.IsWhiteSpace(replaced[i - 1]))
                    {
                        stringBuilder.Append(replaced[i].ToString().ToUpper());
                    } else
                    {
                        stringBuilder.Append(replaced[i]);
                    }
                }
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
