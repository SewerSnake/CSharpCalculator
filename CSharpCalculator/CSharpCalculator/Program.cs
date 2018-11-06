using System;

namespace CSharpCalculator
{
    class Program
    {
        public static void Main()
        {
            // Calculator c = new Calculator();

            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Multiply two numbers");
            Console.WriteLine("3. Sum the numbers between two numbers.");
            Console.WriteLine("4. Add number to memory");
            Console.WriteLine("5. Clear memory");
            Console.WriteLine("6. Print calculator contents.");
            Console.WriteLine("7. Quit");
        }
    }

    public class Calculator 
    {
        // properties
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int NumberInMemory { get; set; }

        // constructor - nollställer properties
        public Calculator() 
        {
            this.FirstNumber = 0;
            this.SecondNumber = 0;
            this.NumberInMemory = 0;
        }

        public override string ToString() 
        {
            return $"First number: {FirstNumber} \nSecond number: {SecondNumber} \nNumber in memory: {NumberInMemory}";
        }

        void SumNumbers()
        {
            // return FirstNumber + SecondNumber;
        }

        void MultiplyNumbers()
        {
            // return FirstNumber * SecondNumber;
        }
    }
}
