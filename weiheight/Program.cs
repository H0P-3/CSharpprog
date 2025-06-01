using System;


namespace weiheight
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            
            Console.WriteLine($"Total Number with height greater than 170 and weight greater 55 is {count}");
            Console.ReadLine();
            
        }
    }
}
