using System;

namespace PejwakBaran
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine();
                Console.WriteLine("*******************Menu***********************");
                Console.WriteLine("Please choose a number:");
                Console.WriteLine("1- Validate a string");
                Console.WriteLine("2- Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        string input;
                        // Get string from user
                        Console.WriteLine("Please enter your string:");
                        input = Console.ReadLine();

                        // Check if input is empty
                        if (String.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Input string is empty or whitespace");
                        }
                        else
                        {
                            // Check string
                            bool result = Solution.IsValid(input);

                            if (result)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Input string is valid.");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Input string is not valid.");
                            }
                        }

                        break;

                    case "2":
                        runProgram = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
                
        }
    }
}
