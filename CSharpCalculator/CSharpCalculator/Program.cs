using System;

namespace CSharpCalculator
{
    class Program
    {
        public static void Main()
        {
            Calculator c = new Calculator();
            bool shouldStop = false;
            int navInput = 0;

            while(!shouldStop)
            {
                Console.WriteLine("- - - - - - - -");
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Multiply two numbers");
                Console.WriteLine("3. Sum the numbers between two numbers.");
                Console.WriteLine("4. Add number to memory");
                Console.WriteLine("5. Clear memory");
                Console.WriteLine("6. Print calculator contents.");
                Console.WriteLine("7. Quit");

                Console.Write("Choose option: ");
                navInput = Convert.ToInt32(Console.ReadLine());

                switch (navInput) 
                {
                    case 1:
                        c.SumNumbers();
                        break;
                    case 2:
                        c.MultiplyNumbers();
                        break;
                    case 3:
                        Console.WriteLine("Give first number: ");
                        c.FirstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Give second number: ");
                        c.SecondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(c.SumInBetween(c.FirstNumber, c.SecondNumber));
                        break;
                    case 7:
                        shouldStop = true;
                        break;
                }
            }
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

        public double SumNumbers()
        {
            Console.WriteLine("Sum:");
            return FirstNumber + SecondNumber;
        }

        public double MultiplyNumbers()
        {
            Console.WriteLine("Multiply:");
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween(int a, int b) 
        {
            Console.WriteLine("Sum in between:");
            var sum = 0;
            for (var i = a; i <= b; i++) 
            {
                sum += i;
            }
            return sum;
        }
    }
}
