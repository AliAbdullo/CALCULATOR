using System;

namespace Calculator.Classes
{
    class Security
    {
        public void checkPassword()
        {
            string password = "";
            do
            {
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
            } while (password != "password");
        }
    }
}