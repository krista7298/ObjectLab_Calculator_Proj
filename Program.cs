/*******************************************************************
* Name: Krista Agustin
* Date: 07/05/2026
* Assignment SDC220 Calculator Project Phase #3
*
* Main application class.
* This application demonstrates calculator memory functions using
* a single stored value and a collection of integer values.
*/

public class Program
{
    static void Main(string[] args)
    {
        Memory memory = new Memory();
        bool running = true;

        Console.WriteLine("Krista Agustin - Calculator Project Week 3");
        Console.WriteLine("Welcome to Krista's Calculator Memory Menu!");
        Console.WriteLine("Use this menu to store, retrieve, clear, and calculate memory values.");

        while (running)
        {
            Console.WriteLine("\nCalculator Memory Menu");
            Console.WriteLine("1. Store single memory value");
            Console.WriteLine("2. Retrieve single memory value");
            Console.WriteLine("3. Clear single memory value");
            Console.WriteLine("4. Replace single memory value");
            Console.WriteLine("5. Add integer to collection");
            Console.WriteLine("6. Display all collection values");
            Console.WriteLine("7. Display collection count");
            Console.WriteLine("8. Remove value from collection");
            Console.WriteLine("9. Get sum of collection");
            Console.WriteLine("10. Get average of collection");
            Console.WriteLine("11. Get difference of first and last values");
            Console.WriteLine("12. Clear collection");
            Console.WriteLine("13. Exit");

            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a number to store in memory: ");
                    double storedValue = Convert.ToDouble(Console.ReadLine());
                    memory.StoreSingleValue(storedValue);
                    Console.WriteLine("Memory value stored.");
                    break;

                case "2":
                    if (memory.HasSingleValue)
                    {
                        Console.WriteLine("Stored memory value: {0:F2}", memory.SingleValue);
                    }
                    else
                    {
                        Console.WriteLine("No single memory value is currently stored.");
                    }
                    break;

                case "3":
                    memory.ClearSingleValue();
                    Console.WriteLine("Single memory value cleared.");
                    break;

                case "4":
                    Console.Write("Enter a new number to replace memory value: ");
                    double replacementValue = Convert.ToDouble(Console.ReadLine());
                    memory.StoreSingleValue(replacementValue);
                    Console.WriteLine("Memory value replaced.");
                    break;

                case "5":
                    Console.Write("Enter an integer to add to the collection: ");
                    int value = Convert.ToInt32(Console.ReadLine());

                    if (memory.AddValue(value))
                    {
                        Console.WriteLine("Value added to collection.");
                    }
                    else
                    {
                        Console.WriteLine("Collection is full. Only 10 values can be stored.");
                    }
                    break;

                case "6":
                    Console.WriteLine("Values stored in collection:");

                    if (memory.GetCount() == 0)
                    {
                        Console.WriteLine("No values are currently stored.");
                    }
                    else
                    {
                        foreach (int item in memory.GetValues())
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

                case "7":
                    Console.WriteLine("Count of values stored: {0}", memory.GetCount());
                    break;

                case "8":
                    Console.Write("Enter the value to remove: ");
                    int removeValue = Convert.ToInt32(Console.ReadLine());

                    if (memory.RemoveValue(removeValue))
                    {
                        Console.WriteLine("Value removed.");
                    }
                    else
                    {
                        Console.WriteLine("Value was not found.");
                    }
                    break;

                case "9":
                    Console.WriteLine("Sum of collection values: {0}", memory.GetSum());
                    break;

                case "10":
                    Console.WriteLine("Average of collection values: {0:F2}", memory.GetAverage());
                    break;

                case "11":
                    Console.WriteLine("Difference of first and last values: {0}", memory.GetDifferenceFirstLast());
                    break;

                case "12":
                    memory.ClearValues();
                    Console.WriteLine("Collection cleared.");
                    break;

                case "13":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please choose a valid menu option.");
                    break;
            }
        }

        Console.WriteLine("\nThank you for using Krista's Calculator!");
    }
}
