using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            

            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }

            }

            return false;

     

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count() == 0 )
            {
                return false;
            }

            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public char GetFirstLetterOfString(string val)
        {
            var First = val[0];
            return First;
        }

        public char GetLastLetterOfString(string val)
        {
           var Last = val[val.Length-1];
           return Last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if ( divisor == 0)
            {
                return 0;
            }

            var answer = dividend / divisor;
            return answer;

        }

        public int LastMinusFirst(int[] nums)
        {
            var Lastnum = nums[nums.Length - 1];
            var Firstnum = nums[0];
            var result = Lastnum - Firstnum;
            return result;
        }

        public int[] GetOddsBelow100()
        {
            var List = new List<int>();

            for(int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    List.Add(i);
                }
            }
            return List.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
