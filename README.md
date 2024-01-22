# GA_Recursion_ArmanSahota


    static void PrintNumbersFrom1To10(int currentNumber)
    {
        if (currentNumber <= 10)
        {
            Console.WriteLine(currentNumber);

            int nextNumber = currentNumber + 1;
            PrintNumbersFrom1To10(nextNumber);
        }
    }

The initial if statments is a base check to make sure its not an infinite loop

Then its the output of printing the number

Then the Incremental Step is adding one to the current number to make it closer to shutting down the if statment

Finally, it is the Recursive Call, calling itself again with the next number until the if statment is complete.



