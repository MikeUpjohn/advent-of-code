using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace AdventOfCode.Challenges.Challenge1 {
    public class Challenge1a {
        public void Run() {
            var input = File.ReadAllText($"{ConfigurationManager.AppSettings["PuzzleDataLocation"]}/Challenge1.txt");
            IList<int> numbers = input.Split('\n').Select(s=>int.Parse(s)).ToList();

            bool isFound = false;
            int sumToFind = 2020;
            int result = 0;

            for (var i = 0; i < numbers.Count() && !isFound; i++) {
                var currentNumber = numbers[i];
                if(numbers.Contains(sumToFind - currentNumber)) {
                    result = currentNumber * (sumToFind - currentNumber);
                    isFound = true;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
