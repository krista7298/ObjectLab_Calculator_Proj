/*******************************************************************
* Name: Krista Agustin
* Date: 07/12/2026
* Assignment SDC220 Calculator Project Phase #4
*
* Main application class.
* This application performs division and uses exception handling
* to manage invalid numeric input and division by zero.
*/

public class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        bool running = true;

        Console.WriteLine("Krista Agustin - Calculator Project Week 4");
        Console.WriteLine("Welcome to Krista's Calculator!");
        Console.WriteLine("Enter two numbers to divide the first by the second.");
        Console.WriteLine("Invalid entries will display an error and allow you to try again.");

        while (running)
        {
            Console.WriteLine("\n1. Perform division");
            Console.WriteLine("2. Quit");
            Console.Write("Enter your choice: ");

            string? choice = Console.ReadLine();

            if (choice == "2")
            {
                running = false;
                continue;
            }

            if (choice != "1")
            {
                Console.WriteLine("Invalid menu choice. Please enter 1 or 2.");
                continue;
            }

            bool successfulDivision = false;

            while (!successfulDivision)
            {
                try
                {
                    Console.Write("Enter the first number: ");
                    double firstNumber = double.Parse(Console.ReadLine() ?? "");

                    Console.Write("Enter the second number: ");
                    double secondNumber = double.Parse(Console.ReadLine() ?? "");

                    double result = calc.Divide(firstNumber, secondNumber);

                    Console.WriteLine(
                        "{0:F2} / {1:F2} = {2:F2}",
                        firstNumber,
                        secondNumber,
                        result);

                    successfulDivision = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(
                        "Invalid input. Please enter numeric values only.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine(
                        "Cannot divide by zero. Please enter a different second number.");
                }
            }
        }

        Console.WriteLine("\nThank you for using Krista's Calculator!");
    }
}
```
