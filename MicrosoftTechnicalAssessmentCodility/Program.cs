using MicrosoftTechnicalAssessmentCodility.Ex01;
using MicrosoftTechnicalAssessmentCodility.Ex02;
using MicrosoftTechnicalAssessmentCodility.Ex03;
using System;

namespace MicrosoftTechnicalAssessmentCodility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("==============================");
                    Console.WriteLine("1 - Number Sum Exercise");
                    Console.WriteLine("2 - Similar Cars Exercise");
                    Console.WriteLine("3 - Similar letters Remove Exercise");
                    Console.Write("> ");
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("\n\n> Please inform the test number");
                            Console.Write("\n> ");
                            int number = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine("\n\nResult is: " + ExerciseOneResult.Solution(number));

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Write("\n\n> Please inform how many cars have");
                            Console.Write("\n> ");
                            int carsCount = int.Parse(Console.ReadLine());
                            
                            string[] cars = new string[carsCount];
                            for(int i = 0; i < carsCount; i++)
                            {
                                Console.Write("\n Please inform code of car {0}: ", i + 1);
                                cars[i] = Console.ReadLine();
                            }

                            Console.WriteLine("\n\nResult is: " + string.Join(", ", ExerciseTwoResult.Solution(cars)));

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Write("\n\n> Please inform the text");
                            Console.Write("\n> ");
                            string text = Console.ReadLine();

                            Console.WriteLine("\n\nResult is: " + ExerciseThreeResult.Solution(text));

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("\nOption not found!");
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch { }
            }
            
        }
    }
}
