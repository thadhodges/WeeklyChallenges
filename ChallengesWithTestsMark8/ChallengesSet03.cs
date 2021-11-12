using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            
            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];

            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            int x = val.Length;
            return val[x - 1];

            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()

        {
            //List<int> wholeList = new List<int>();
            List<int> odds = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);

                }

                

            }
            foreach (int var in odds)
            {
                return var;            
            }

            //throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
