using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool result = char.IsLetter(c);
            return result;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            
            List<double> mylist = numbers.ToList();
            if (numbers == null || !numbers.Any());
            {
                return 0;
            }

            if (mylist.Count == 0)
            {
                return 0;
            }
            double x = mylist.Max();
            double y = mylist.Min();
            return x + y;

            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        

    

        public int Sum(int[] numbers)
        {   
            if (numbers == null)
            {
                return 0;
            }
          
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;            
            }

            return sum;




        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            List<int> evens = new List<int>();
            int sumevens = 0;
            foreach (int x in numbers)
            {
                if (x % 2 == 0)
                {
                    evens.Add(x);
                }
            }
            foreach (int y in evens)
            {
                sumevens += y;
                
            }
            return sumevens;
        }
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int listSum = 0;

            foreach (int x in numbers)
            {
                listSum += x;
            }

            if (listSum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

          
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //List<long> odds = new List<long>();

            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }

            //for (int i = 1; i < number; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        odds.Add(i);
            //    }
            //}

            //return odds.Count;



        }
    }
}
