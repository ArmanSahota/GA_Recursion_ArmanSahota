using System;

internal class Program
{
    static void Main(string[] args)
    {
        PrintNumbersFrom1To10(1);
        CountDownAndUp(5);
        int[] numbers = { 12, 45, 7, 23, 9 }; // Adding 5 hardcoded numbers to the array

        Console.WriteLine("Array elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        int sum = CalculateSum(numbers, 0);
        Console.WriteLine($"\nSum of the array elements: {sum}");

        int n = 10; // Change n to the desired Fibonacci sequence length
        Console.WriteLine($"Fibonacci sequence of length {n}:");
        for (int i = 0; i < n; i++)
        {
            int result = Fibonacci(i);
            Console.Write(result + " ");
        }


    }
    //Recursion - Print 1 to 10
    static void PrintNumbersFrom1To10(int currentNumber)
    {
        if (currentNumber <= 10)
        {
            Console.WriteLine(currentNumber);

            int nextNumber = currentNumber + 1;
            PrintNumbersFrom1To10(nextNumber);
        }
    }
    // recursion call stack
    static void CountDownAndUp(int currentNumber)
    {
        
        if (currentNumber >= 1) // base case to make sure its not an infinite loop
        {
            // Console.WriteLine($"Before Recursive Call: {currentNumber}"); // output
            

            CountDownAndUp(currentNumber - 1); // Incremental Step with the Minus 1 and Recursive Call to call back the same function


            Console.WriteLine($"After Recursive Call: {currentNumber}");// now the numbers are going up instead of down

        }
    }
    //Recursion - Working with Arrays
    static int CalculateSum(int[] arr, int index)
    {
        // Base Case: If the index is equal to the array length, return 0 (no elements to add)
        if (index == arr.Length)
        {
            return 0;
        }
        else
        {
            // Recursive Case:
            // Add the current element (at the current index) to the sum of the rest of the elements
            int currentElement = arr[index];
            int restOfTheSum = CalculateSum(arr, index + 1);
            return currentElement + restOfTheSum;
        }
    }
    //Recursive Method - Fibonacci Sequence
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }



}