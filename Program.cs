using System;
using lexer;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Lexer ....");
            Lexer _lexer = new Lexer("x = 0");
        }
    }
}
