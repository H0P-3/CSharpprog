using System;

namespace GetStartedDebugging
{ 

	internal class program
	{
        static void Main(string[] args)
        {
            Console.Write("Enter your First name:");
            string fname = Console.ReadLine();
            Console.Write("Enter your Last Name:");
            string lname = Console.ReadLine();
            Console.Write("Enter your year of birth:");
            string birth = Convert.ToInt32(Console.ReadLine());

            int age = 2025 - birth;

            Console.WriteLine("Hello" + fname + " " + lname + ". My age is " + birth);

        }

    }
}
