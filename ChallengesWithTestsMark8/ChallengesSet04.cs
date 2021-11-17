using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sumevens = 0;
            int sumodds = 0;
            foreach (int e in numbers)
            {
                if (e % 2 == 0)
                {
                    sumevens += e;
                }
                else
                {
                    sumodds += e;
                }
                
            }

            return sumevens - sumodds;
            
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> myList = new List<int>();
            myList.Add(str1.Length);
            myList.Add(str2.Length);
            myList.Add(str3.Length);
            myList.Add(str4.Length);
            return myList.Min();
            //throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> vs = new List<int>();
            vs.Add(number1);
            vs.Add(number2);
            vs.Add(number3);
            vs.Add(number4);
            return vs.Min();
            

            //throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            //throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int a = sideLength1;
            int b = sideLength2;
            int c = sideLength3;
            if ((a+b) > c && (a + c) > b && (b + c) > a)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            decimal i = 0;
            return decimal.TryParse(input, out i);
            //throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            List<int> nulls = new List<int>();
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nulls.Add(i);
                }
            }
            if (nulls.Count > (objs.Length / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
            
        {
            List<int> totalEvens = new List<int>();

            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Length == 0)
            {
                return 0;
            }
            double sumevens = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumevens += numbers[i];
                    totalEvens.Add(numbers[i]);
                }
             
            }
            if (totalEvens.Count == 0)
            {
                return 0;
            }
            return sumevens / totalEvens.Count;


            //throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int factor = number;
            for (int i = number - 1; i >= 1; i--)
            {
                factor = factor * i;
            }
            return factor;
            //throw new NotImplementedException();
        }
    }
}
