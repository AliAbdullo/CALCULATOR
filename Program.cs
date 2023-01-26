        // int firstNumber;
        // int secondNumber;

        // System.Console.Write("Birinchi sonni kiriting: ");
        // firstNumber = int.Parse(System.Console.ReadLine());
        // System.Console.Write("Ikkinchi sonni kiriting: ");
        // secondNumber = int.Parse(System.Console.ReadLine());

        // // + - * /
        // System.Console.WriteLine($"Added: {firstNumber + secondNumber}"); // Qo'shish
        // System.Console.WriteLine($"Substracting: {firstNumber - secondNumber}"); // Ayrish
        // System.Console.WriteLine($"Split up: {firstNumber / secondNumber}"); // Bo'lish
        // System.Console.WriteLine($"Multiplaying: {firstNumber * secondNumber}"); // Ko'paytirish
        //                                                                          // %
        // System.Console.WriteLine($"Qoldiq: {firstNumber % secondNumber}"); // Ko'paytirish
  
//   using System; 

// int firstNumber = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(firstNumber ++);
// System.Console.WriteLine(firstNumber);

using System;

System.Console.WriteLine("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"1st number is greater then 2nd number: {firstNumber > secondNumber}");
System.Console.WriteLine($"1st number is greater then or equal to 2nd number: {firstNumber >= secondNumber}");
System.Console.WriteLine($"1st number is less then 2nd number: {firstNumber < secondNumber}");
System.Console.WriteLine($"1st number is less then or equal to 2nd number: {firstNumber <= secondNumber}");
System.Console.WriteLine($"Numbers are equal: {firstNumber == secondNumber}");
System.Console.WriteLine($"Numbers are not equal: {firstNumber != secondNumber}");