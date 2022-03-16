using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Core
{
    public class OrderPlease
    {
        public static string Order(string words)
        {
            //var wordsArray = words.Split(' ');
            //var wordsList = new List<string>();

            //for (int i = 0; i < wordsArray.Length; i++)
            //{
            //    foreach(var item in wordsArray)
            //    {
            //        if(item.Contains((i + 1).ToString()))
            //        {
            //            wordsList.Add($"{item} ");
            //        }
            //    }
            //}

            //return string.Join("", wordsList).Trim();

            return string.Join("", words.Split(' ').OrderBy(word => word.FirstOrDefault(ch => char.IsDigit(ch))).Select(word => word + ' ')).Trim();
        }
    }
}
