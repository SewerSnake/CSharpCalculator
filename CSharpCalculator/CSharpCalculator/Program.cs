using System;
using System.ComponentModel.Design;

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

                navInput = c.Menu();

                switch (navInput) 
                {
                    case 1:
                        c.GetUserInput();
                        Console.WriteLine($"The sum is: {c.SumNumbers()}");
                        break;
                    case 2:
                        c.GetUserInput();
                        Console.WriteLine($"The product is: {c.MultiplyNumbers()}");
                        break;
                    case 3:
                        c.GetUserInput();
                        Console.WriteLine($"The sum of all numbers inbetween is: {c.SumInBetween(c.FirstNumber, c.SecondNumber)}");
                        break;
                    case 4:
                        Console.Write("Give a number to add to memory: ");
                        c.NumberInMemory = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"in mem: {c.NumberInMemory}");
                        break;
                    case 5:
                        c.NumberInMemory = 0;
                        Console.WriteLine("Number in memory cleared.");
                        break;
                    case 6:
                        Console.WriteLine($"The number in memory is: {c.NumberInMemory}");
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        shouldStop = true;
                        Console.WriteLine("Goodbye!");
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

        public int Menu()
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
            return Convert.ToInt32(Console.ReadLine());
        }


        public void GetUserInput()
        {
            Console.Write("Give first number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give second number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
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
            var sum = 0;
            for (var i = a; i <= b; i++) 
            {
                sum += i;
            }
            return sum;
        }
    }
}
