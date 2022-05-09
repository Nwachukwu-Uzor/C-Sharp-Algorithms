using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Core
{
    public class CarMileage
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            if (
                 (awesomePhrases.Contains(number) || IsPalindrome(number) ||
                 CheckIfDigitFollowedByAllZeros(number) || IsDecrementingSequence(number)
                 || IsIncrementingSequence(number))
                 && number > 99
            )
            {
                return 2;
            } else if (
                (IsPalindrome(number + 1) || IsPalindrome(number + 2)
                || CheckIfDigitFollowedByAllZeros(number + 1) || CheckIfDigitFollowedByAllZeros(number + 2)
                || IsIncrementingSequence(number + 1) || IsIncrementingSequence(number + 2)
                || IsDecrementingSequence(number + 1) || IsDecrementingSequence(number + 2)
                || awesomePhrases.Contains(number + 1) || awesomePhrases.Contains(number + 2))
                && number > 99
            )
            {
                return 1;
            }
            return 0;
        }

        public static bool IsPalindrome(int number)
        {
            return number.ToString() ==  string.Join("", number.ToString().Reverse());
        }


        public static bool CheckIfDigitFollowedByAllZeros(int number)
        {
            var numbArray = number.ToString().Select(num => Convert.ToInt32(num)).ToList();

            return numbArray.Count(num => num == 48) == numbArray.Count - 1;
        }

        public static bool IsDecrementingSequence(int number)
        {
            var numbArray = number.ToString().Select(num => Convert.ToInt32(num) - 48);
            return numbArray.Zip(numbArray.Skip(1), (a, b) => (a - 1) == b).All(x => x);
        }

        public static bool IsIncrementingSequence(int number)
        {
            var numbArray = number.ToString().Select(num => Convert.ToInt32(num) - 48).ToList();
            if(numbArray[numbArray.Count - 1] == 0)
            {
                numbArray.RemoveAt(numbArray.Count - 1);
            }

            return numbArray.Zip(numbArray.Skip(1), (a, b) => (a + 1) == b).All(x => x);
        }
    }
}
