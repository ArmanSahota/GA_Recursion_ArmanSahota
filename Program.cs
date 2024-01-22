using System;

internal class Program
{
    static void Main(string[] args)
    {
        PrintNumbersFrom1To10(1);
    }
    static void PrintNumbersFrom1To10(int currentNumber)
    {
        if (currentNumber <= 10)
        {
            Console.WriteLine(currentNumber);

            int nextNumber = currentNumber + 1;
            PrintNumbersFrom1To10(nextNumber);
        }
    }
}