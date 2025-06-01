using System; //Import system
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GetStartedDebugging //Container for classes. You can have a
                              //namespace within a namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter your First name:");
            string fname = Console.ReadLine();
            Console.Write("Enter your Last Name:");
            string lname = Console.ReadLine();
            Console.Write("Enter your year of birth:");
            int birth = Convert.ToInt32(Console.ReadLine());

            int age = DateTime.Now.Year - birth;

            Console.WriteLine("Hello" + fname + " " + lname + ". My age is " + age);

            Console.WriteLine("Enter the Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            

            if (number % 2 == 0)
            {
                Console.WriteLine("$Your number is even");
            }
            else
            {
                Console.WriteLine("$Your number is odd");
            }
            */
            //string name = ("Hope");
            //double accountbal = 1000000000;
            //Int64 accountno = 0235939011;
            //Int32 age = 12;
            // Console.WriteLine($"My name is {name}, My age is {age}, n/ And I have  {accountbal}, In my account no: {accountno}");
            //Console.WriteLine("Welcome");
            // Console.ReadLine();

            //int myNum = 15;
            //myNum = 20;
            //Console.WriteLine(myNum);

            //int myNum2 = 5;
            //double myDoubleNum = 5.99D;
            //char myLetter = 'D';
            //bool myBool = true;
            //string myText = "Hello";

            /*int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine(a);
            Console.WriteLine(b);


            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = array1;
            array2[0] = 100;
            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[0]);
            Console.WriteLine(b);

            int num = 42;
            object boxed = num;
            int unboxed = (int)boxed;



            //Console.WriteLine(boxed);
            //int myInt = 9;
            //double myDouble = myInt;
            //Console.WriteLine(myInt);
            //Console.WriteLine(myDouble);

            double myDouble = 9.78;
            int myInt = (int)myDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool)); */



            //Console.Write("Enter the Number: ");
            //string input = Console.ReadLine();
            //int number = Convert.ToInt32(Console.ReadLine());
            //Int32.Parse(number);
            /*if (int.TryParse(input, out int number))
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
            Console.ReadLine();*/


            //int count = 0;
            /*
            int[] height = new int[10];
            int[] weight = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter your height" + (i + 1));
                height[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter your Weight" + (i + 1));
                weight[i] = int.Parse(Console.ReadLine());

            }
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                if (height[i] > 170 && weight[i] > 55)
                {
                    count++;
                }
               
            }
            Console.WriteLine("Total Number with height greater than 170 and weight greater 55," (count));
            Console.ReadLine();*/


            /*string firstword = ("This is the first word");
            string secondword = ("And this is the second word");
            Console.WriteLine(string.Concat(firstword, secondword));

            int len = firstword.Length;
            Console.WriteLine(len);
            //Console.WriteLine(string (firstword.Length));
            Console.WriteLine(secondword.ToUpper());
            Console.WriteLine(firstword.ToLower());
            Console.WriteLine(secondword.IndexOf("secondword"));
            Console.WriteLine(secondword.Trim());
            Console.WriteLine(string.Equals("w", "c"));
            Console.WriteLine(secondword.Clone());
            Console.WriteLine(secondword.StartsWith("t"));
            Console.ReadLine();*/

            {
                try{
                    int result = 4 / 0;
                    Console.WriteLine(result.ToString);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally { }
            }
            {
                int result = 4 / 0;
                Console.WriteLine(result.ToString);
            }
            //int userInput = 2;
            //bool isEven = userInput % 2 == 0;
            //Console.WriteLine(int.Parse(Console.ReadLine()) % 2 == 0 ? "even" : "odd");
        }
        

    }
}
