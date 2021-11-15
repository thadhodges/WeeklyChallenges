using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }
            foreach (bool x in vals)
            {
                if (x == false)
                {
                    return true;
                }

                return false;
            }
            return false;
            //throw new NotImplementedException();

            ////How do you make a boolean return False and True with Capitalized first letter
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val) => val[0];//throw new NotImplementedException();

        public char GetLastLetterOfString(string val)
        {
            int x = val.Length;
            return val[x - 1];

            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal answer = dividend / divisor;
            return answer;
            
            
            
            
            //throw new NotImplementedException();
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

            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
