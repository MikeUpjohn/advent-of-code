using System;
using AdventOfCode.Challenges.Challenge1;

namespace AdventOfCode {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Run a challenge:");
            var challenge = Console.ReadLine();

            if(challenge == "1") {
                new Challenge1a().Run();
            }

            Console.WriteLine(challenge);
            Console.ReadLine();
        }
    }
}
