using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //if (vals == null)
            //{
            //    return false;
            //}

            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }

            return false;
            //foreach (bool x in vals)
            //{
            //    if (x == false)
            //    {
            //        return true;
            //    }

            //    return false;
            //}
            //return false;
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sumodds = 0;
            foreach (var item in numbers)
            {
                if (item % 2 != 0)
                {
                    sumodds += item;
                }
            }
            if (sumodds % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //for (int i = 0; i < password.Length; i++)
            //{
            //    if (password[i] == char.ToUpper());
            //}
            
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
            if (divisor == 0)
            {
                return 0;
            }

            decimal answer = dividend / divisor;
            return answer;





        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()

        {
            List<int> answer = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    answer.Add(i);
                }
            }
            int[] vs = answer.ToArray();
            return vs;
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();

                

                //throw new NotImplementedException();
            }
        }
    }
}
