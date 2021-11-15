using System;

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
                sumodds -= e;
            }

            return sumevens - sumodds;
            
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
            
        {
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
                sumevens += numbers[i];
               
            }
            return sumevens / numbers.Length;
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
