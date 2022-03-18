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
            var replaced = str.Replace('_', ' ').Replace('-', ' ');
            // replaced = string.Join("", replaced.Replace('-', ' ').Where(e => !char.IsWhiteSpace(e)));

            var stringBuilder = new StringBuilder();
            
            for(int i = 0; i < replaced.Length; i++)
            {
                if(char.IsWhiteSpace(replaced[i]))
                {
                    stringBuilder.Append(replaced[i + 1].ToString().ToUpper());
                    i++;
                    continue;
                }
                stringBuilder.Append(replaced[i].ToString());
            }
            
            return stringBuilder.ToString().Trim();
        }
    }
}
