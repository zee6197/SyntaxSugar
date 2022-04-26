using System;

namespace SyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var TheAnswer = 4;
            var TheResponse = (TheAnswer < 9) ? $"{TheAnswer} is less than nine" : $"{TheAnswer} is greater than nine";
            Console.WriteLine(TheResponse);
        }
    }
}
