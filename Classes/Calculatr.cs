using System;

namespace CALCULATOR.Classes
{
    public class Calculatr
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }   
        public string Operation { get; set; }

        public void GetInput()
        {
            Console.WriteLine("Type 1st number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operation (+,-,*,/,%): ");
            Operation = Console.ReadLine();
            Console.WriteLine("Type 2nd number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }
        public bool IsFirstNumberPositive()
        {
            return FirstNumber >= 0;
        }
        public void CompareInputs()
        {
                if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("1st number is greater then 2nd number!");
            }
            else if (FirstNumber == SecondNumber)
            {
                Console.WriteLine("1st number is equal than 2nd number!");
            }
            else
            {
                Console.WriteLine("1st number is less then 2nd number! ");
            }
        }
        public string Calculate()
        {
                return Operation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}",
                _ => "Operation not found!"
            };
        }

        public void PrintEvenNumbers()
        {   
            Console.WriteLine("Printing even numbers till first input... ");
            int counter = 1;
            while (counter <= FirstNumber)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
        }
        public void PrintMultiplicationTable()
        {
            for (int iterator = 1; iterator <= 10; iterator++)
            {
                for (int inerIterator = 1; inerIterator <= 10; inerIterator++)
                {
                    Console.WriteLine($"{iterator} x {inerIterator} = {iterator * inerIterator}");
                }

                Console.WriteLine();
            }
        }
    }
}