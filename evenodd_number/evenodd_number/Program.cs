using System;


namespace evenodd_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Your number is even");
                }
                else
                {
                    Console.WriteLine("Your number is odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.ReadLine();


           
        }
    }
}
