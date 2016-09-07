using System;
using System.IO;
using lexer;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Lexer ....");

            string input = File.ReadAllText(@"./test/main.ms");
            Lexer _lexer = new Lexer(input);
        }
    }
}
