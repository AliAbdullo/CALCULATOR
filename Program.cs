using System;
using Calculator.Classes;
using CALCULATOR.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Security security = new Security();
        Calculatr calculatr = new Calculatr();

        security.checkPassword();
        calculatr.GetInput();
        
        string message =
                !(calculatr.IsFirstNumberPositive())
                        ? "1st number is not positive!"
                        : "1st number is not negative!";
        Console.WriteLine(message);

        calculatr.CompareInputs();
        
        string resolt = calculatr.Calculate();

        Console.WriteLine(resolt);
        calculatr.PrintEvenNumbers();  
        calculatr.PrintMultiplicationTable();   
    }
}