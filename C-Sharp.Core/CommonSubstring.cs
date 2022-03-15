using System.Collections.Generic;

namespace C_Sharp.Core
{
    public class CommonSubstring
	{
		public static bool SubstringTest(string str1, string str2)
		{
			var value1 = str1.Length >= str2.Length ? str1 : str2;
			var value2 = value1 == str1 ? str2 : str1;

			var arr1 = GetSubstrings(value1);
			return CompareSubstrings(arr1, value2);
		}

		public static List<string> GetSubstrings(string input)
		{
			var inputArray = new List<string>();

			for (int i = 0; i < input.Length; i++)
			{
				for (int j = 2; j <= input.Length - i; j++)
				{
					inputArray.Add(input.Substring(i, j).ToLower());
				}
			}

			return inputArray;
		}

		public static bool CompareSubstrings(List<string> input1, string input2)
		{
			foreach (var item in input1)
			{
				if (input2.ToLower().Contains(item))
				{
					return true;
				}
			}

			return false;
		}
	}
}
