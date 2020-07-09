using System;

namespace ArrangingCoinChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number to test for possible number of staircase: ");
            var number = Console.Read();
            var staircases = ArrangeCoins(number);
            Console.WriteLine($"Number of staircase(s) possible: {staircases}");
        }

        public static int ArrangeCoins(int possibleNumber)
        {
            long left = 0;
            long right = possibleNumber;
            while (left <= right)
            {
                var stairCases = left + (right - left) / 2;
                var current = stairCases * (stairCases + 1) / 2;

                if (current == possibleNumber) return (int)stairCases;

                if (possibleNumber < current)
                {
                    right = stairCases - 1;
                }
                else
                {
                    left = stairCases + 1;
                }
            }

            return (int)right;
        }
    }
}