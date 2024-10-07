using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        try
        {
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            int result = Divide(num1, num2);
            Console.WriteLine($"Result: {num1} / {num2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number entered is too large or too small for an integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }
}
