using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            if (startNumber == 0)
            {
                return n;
            }

            List<int> firstList = new List<int>();
            int maxLoop = startNumber * n;
            int[] numbersDivisiblebyN = new int[0];

            for (int i = 0; i < maxLoop; i++)
            {
                if (i > startNumber && i % n == 0)
                {
                    firstList.Add(i);
                }
            }
            firstList.ToArray();
            return firstList[0];
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0 && i != numbers.Length)
                {
                    sum += numbers[i + 1];
                }
                
            }
            return sum;
            //throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            int badWords = 0;
            int goodWords = 0;

            List<string> wordsList = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "" || words[i] == " " || words[i] == "  ")
                {
                    badWords += 1;
                }
                else
                {
                    wordsList.Add(words[i].Trim());
                    goodWords += 1;
                }
            }
            if (goodWords == 0)
            {
                return "";
            }
            else
            {
                return String.Join(" ", wordsList) + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }
            if (everyFourth.ToArray() == null)
            {
                return everyFourth.ToArray();
            }
            return everyFourth.ToArray();
            //throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
