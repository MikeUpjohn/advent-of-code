using System;
using System.Configuration;
using System.IO;

namespace AdventOfCode.Challenges.Challenge1 {
    public class Challenge1 {
        public void Run() {
            var input = File.ReadAllText($"{ConfigurationManager.AppSettings["PuzzleDataLocation"]}/Challenge1.txt");
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
