using System;
using System.Collections.Generic;

namespace MissingNumberApp
{
    // Interface for finding the missing number
    public interface IMissingNumberFinder
    {
        int FindMissingNumber(int[] numbers);
    }

    // Interface for input and output operations
    public interface IConsoleIO
    {
        int[] GetNumbers();
        void DisplayResult(int missingNumber);
    }

    // Implementation of the missing number finder
    public class MissingNumberFinder : IMissingNumberFinder
    {
        public int FindMissingNumber(int[] numbers)
        {
            // find the max number
            int maxNumber = 0;
            foreach (var number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            // calculate the sum from 0 to max number
            int expectedSum = maxNumber * (maxNumber + 1) / 2;
            int actualSum = 0;

            // calculate the sum of all numbers in the array
            foreach (var number in numbers)
            {
                actualSum += number;
            }

            // return the missing number
            return expectedSum - actualSum;
        }
    }

    // Class responsible for input and output operations
    public class ConsoleIO : IConsoleIO
    {
        public int[] GetNumbers()
        {
            Console.WriteLine("Please enter the number list (format like: [9, 6, 4, 2, 3, 5, 7, 0, 1]):");
            string input = Console.ReadLine();

            // remove the square brackets
            input = input.Trim('[', ']');
            string[] parts = input.Split(',');
            List<int> numbers = new List<int>();

            foreach (var part in parts)
            {
                if (int.TryParse(part.Trim(), out int number))
                {
                    numbers.Add(number);
                }
            }

            return numbers.ToArray();
        }

        public void DisplayResult(int missingNumber)
        {
            Console.WriteLine($"The missing number is: {missingNumber}");
        }
    }

    // Main application class
    public class MissingNumberApplication
    {
        private readonly IMissingNumberFinder _missingNumberFinder;
        private readonly IConsoleIO _consoleIO;

        public MissingNumberApplication(IMissingNumberFinder missingNumberFinder, IConsoleIO consoleIO)
        {
            _missingNumberFinder = missingNumberFinder;
            _consoleIO = consoleIO;
        }

        public void Run()
        {
            int[] numbers = _consoleIO.GetNumbers();
            int missingNumber = _missingNumberFinder.FindMissingNumber(numbers);
            _consoleIO.DisplayResult(missingNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMissingNumberFinder missingNumberFinder = new MissingNumberFinder();
            IConsoleIO consoleIO = new ConsoleIO();
            MissingNumberApplication app = new MissingNumberApplication(missingNumberFinder, consoleIO);
            app.Run();
        }
    }
} 