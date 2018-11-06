using System;

namespace CSharpCalculator
{
    class Program
    {
        public static void Main()
        {
            Calculator c = new Calculator();
            bool shouldStop = false;

            while(!shouldStop)
            {
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Multiply two numbers");
                Console.WriteLine("3. Sum the numbers between two numbers.");
                Console.WriteLine("4. Add number to memory");
                Console.WriteLine("5. Clear memory");
                Console.WriteLine("6. Print calculator contents.");
                Console.WriteLine("7. Quit");

                String inputRaw = "";
                Console.Write("Choose option: ");

                inputRaw = Console.ReadLine();

                int input = Convert.ToInt32(inputRaw);

                switch (input) 
                {
                    case 1:
                        c.SumNumbers();
                        break;
                    case 2:
                        c.MultiplyNumbers();
                        break;
                    case 3:
                        c.SumInBetween(1, 4);
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
            return FirstNumber + SecondNumber;
        }

        public double MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween(int a, int b) 
        {
            // return sum of all number inbetween FirstNumber and SecondNumber
            var sum = 0;
            for (var i = a; i <= b; i++) 
            {
                sum += i;
            }
            return sum;
        }
    }
}
