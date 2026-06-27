/*******************************************************************
* Name: Krista Agustin
* Date: 06/26/2026
* Assignment SDC220 Calculator Project Phase #2
*
* Main application class.
* This application displays a menu-driven calculator that performs
* addition, subtraction, multiplication, and division.
*/

public class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        bool running = true;

        Console.WriteLine("Krista Agustin - Project Week 2 Calculator");
        Console.WriteLine("Welcome to Krista's Calculator!");
        Console.WriteLine("Select an option from the menu. Results display to 2 decimal places.");

        while (running)
        {
            Console.WriteLine("\nCalculator Menu");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();

            if (choice == "5")
            {
                running = false;
                break;
            }

            if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, 3, 4, or 5.");
                continue;
            }

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    Console.WriteLine("{0:F2} + {1:F2} = {2:F2}", num1, num2, calc.Add(num1, num2));
                    break;

                case "2":
                    Console.WriteLine("{0:F2} - {1:F2} = {2:F2}", num1, num2, calc.Subtract(num1, num2));
                    break;

                case "3":
                    Console.WriteLine("{0:F2} * {1:F2} = {2:F2}", num1, num2, calc.Multiply(num1, num2));
                    break;

                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine("{0:F2} / {1:F2} = {2:F2}", num1, num2, calc.Divide(num1, num2));
                    }
                    break;
            }
        }

        Console.WriteLine("\nThank you for using Krista's Calculator!");
    }
}

