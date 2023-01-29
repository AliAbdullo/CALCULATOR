using System;
namespace CALCULATOR
{
        class Program
        {
                static void Main()
                {
                        
                        string password = "";
                        do
                        {
                                System.Console.WriteLine("Enter password: ");
                                password = Console.ReadLine();
                        }while(password != "password");

                        int counter = 1;
                        while(counter <= 6)
                        {
                                if(counter % 2 == 0)
                                {
                                        System.Console.WriteLine(counter);
                                }
                                counter++ ;
                        }

                        System.Console.WriteLine("Type 1st number: ");
                        int firstNumber = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Enter Operation (+,-,*,/,%): ");
                        string operation = Console.ReadLine();
                        System.Console.WriteLine("Type 2nd number: ");
                        int secondNumber = Convert.ToInt32(Console.ReadLine());
                        // Swich expretion
                        string resolt = operation switch
                        {
                                "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
                                "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
                                "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
                                "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
                                "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
                                _   => "Operation not found!"
                        };
                        System.Console.WriteLine(resolt);
                        //Loops
                        for(int iterator = 1; iterator <= 10; iterator ++)
                        {
                                for(int inerIterator = 1; inerIterator <= 10; inerIterator ++)
                                {
                                        System.Console.WriteLine($"{iterator} x {inerIterator} = {iterator * inerIterator}");
                                }

                                System.Console.WriteLine();
                        }

                        // Ternary operator
                        string message =
                                !(firstNumber >= 0)
                                        ?"1st number is not positive!"
                                        :"1st number is not negative!";
                        // logical operator &&, ||, !
                        System.Console.WriteLine(message);

                        if(firstNumber > secondNumber)
                        {
                                System.Console.WriteLine("1st number is greater then 2nd number!");
                        }
                        else if(firstNumber == secondNumber)
                        {
                                System.Console.WriteLine("1st number is equal than 2nd number!");
                        }
                        else 
                        {
                                System.Console.WriteLine("1st number is less then 2nd number! ");
                        }
                }
        }
}