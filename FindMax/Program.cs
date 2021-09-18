using System;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find MAximum number between Three!");
            MaxNumbers maxNumbers = new MaxNumbers();
            maxNumbers.MaxInt();
            maxNumbers.Show();
            maxNumbers.Swaps();
        }
    }
}
