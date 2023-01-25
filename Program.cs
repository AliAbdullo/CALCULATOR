      

        int firstNumber;
        int secondNumber;

        System.Console.Write("Birinchi sonni kiriting: ");
        firstNumber = int.Parse(System.Console.ReadLine());
        System.Console.Write("Ikkinchi sonni kiriting: ");
        secondNumber = int.Parse(System.Console.ReadLine());

        // + - * /
        System.Console.WriteLine($"Added: {firstNumber + secondNumber}"); // Qo'shish
        System.Console.WriteLine($"Substracting: {firstNumber - secondNumber}"); // Ayrish
        System.Console.WriteLine($"Split up: {firstNumber / secondNumber}"); // Bo'lish
        System.Console.WriteLine($"Multiplaying: {firstNumber * secondNumber}"); // Ko'paytirish
                                                                                 // %
        System.Console.WriteLine($"Qoldiq: {firstNumber % secondNumber}"); // Ko'paytirish
  
//   using System; 

// int firstNumber = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(firstNumber ++);
// System.Console.WriteLine(firstNumber);