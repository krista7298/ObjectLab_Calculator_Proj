// See https://aka.ms/new-console-template for more information
/*******************************************************************
* Name: Krista Agustin
* Date: 06/17/2026
* Assignment SDC220 Calculator Project - Phase 1
*
* Main application class.
* This application demonstrates basic calculator functionality
* including integer addition and floating-point subtraction.
*******************************************************************/

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("====================================");
        Console.WriteLine("Krista Agustin - Week 1 Calculator Project");
        Console.WriteLine("====================================\n");

        Console.WriteLine("Welcome to Krista's Calculator!");
        Console.WriteLine("This calculator can:");
        Console.WriteLine("- Add two integer values");
        Console.WriteLine("- Subtract two decimal values");
        Console.WriteLine();

        // Integer Addition
        Console.Write("Enter the first integer: ");
        int intVal1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int intVal2 = Convert.ToInt32(Console.ReadLine());

        int intResult = intVal1 + intVal2;

        Console.WriteLine("\nResult:");
        Console.WriteLine("{0} + {1} = {2}", intVal1, intVal2, intResult);

        Console.WriteLine();

        // Floating Point Subtraction
        Console.Write("Enter the first decimal value: ");
        double dblVal1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second decimal value: ");
        double dblVal2 = Convert.ToDouble(Console.ReadLine());

        double dblResult = dblVal2 - dblVal1;

        Console.WriteLine("\nResult:");
        Console.WriteLine("{0:F2} - {1:F2} = {2:F2}",
            dblVal2, dblVal1, dblResult);

        Console.WriteLine();
        Console.WriteLine("Thank you for using Krista's Calculator!");
    }
}
