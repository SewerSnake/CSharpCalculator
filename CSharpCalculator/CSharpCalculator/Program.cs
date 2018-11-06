using System;

namespace CSharpCalculator
{
    class Program
    {
        public static void Main()
        {
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
        public double FirstNumber 
        {
            // Korta ner dessa till { get; set; } ?
            get { return FirstNumber; }
            set { FirstNumber = value; }
        }
        public double SecondNumber
        {
            get { return SecondNumber; }
            set { SecondNumber = value; }
        }
        public int NumberInMemory {
            get { return NumberInMemory; }
            set { NumberInMemory = value; }
        }

        // constructor - nollställer properties
        public Calculator() 
        {
            this.FirstNumber = 0;
            this.SecondNumber = 0;
            this.NumberInMemory = 0;
        }

        public override string ToString() 
        {
            return "First number: {FirstNumber} \n Second number: {SecondNumber} \n Number in memory: {NumberInMemory}";
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
