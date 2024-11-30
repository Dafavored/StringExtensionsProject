using System;
using StringExtensionsNamespace;

namespace StringExtensionsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        bool result = input.StartsWithUpper();
        Console.WriteLine(result
            ? "The string starts with an uppercase letter."
            : "The string does not start with an uppercase letter.");
        }
    }
}
