using System;

namespace Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            do
            {

                Console.WriteLine("Enter a number between 1 and 100: ");
                int UserInput = int.Parse(Console.ReadLine());


                if (UserInput % 2 == 0 && UserInput > 2 && UserInput < 25 )
                {

                    // Need to get output to dispplay with input
                    Console.WriteLine($"Output: {UserInput} and even");
                    Console.WriteLine($"Even and less than 25");

                }
                else
                {
                    // Need to get output to dispplay with input
                    Console.WriteLine($"Output: {UserInput} and odd");
                }
                Console.WriteLine("Would you like to continue (y/n)?");
                userInput = Console.ReadLine();


            } while (userInput != "n");
              Console.WriteLine("Bye!");
        
        }
    }
}
