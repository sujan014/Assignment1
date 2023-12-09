// See https://aka.ms/new-console-template for more information
using Assignment1;

Console.WriteLine("**************************************");
Console.WriteLine("********** Calculator Demo ***********");
Console.WriteLine("******* By: Sujan Raj Shrestha *******");
Console.WriteLine("**************************************");
Console.WriteLine();

string continue_calculate = "n";
do
{
    int value1 = Input.getInput("Enter Value1:");
    int value2 = Input.getInput("Enter Value2:");
    Console.WriteLine($"Value1: {value1}");
    Console.WriteLine($"Value2: {value2}");

    Console.WriteLine();
    Console.WriteLine("Add     : 1");
    Console.WriteLine("Subtract: 2");
    Console.WriteLine("Multiply: 3");

    int operation = Input.getInput("Enter Operation:");

    Calculator calculator = new Calculator();
    int result = 0;
    if (operation == 1)
    {
        result = calculator.Add(value1, value2);
        Console.WriteLine($"Result: {result}");
    }
    else if (operation == 2)
    {
        result = calculator.Subtract(value1, value2);
        Console.WriteLine($"Result: {result}");
    }
    else if (operation == 3)
    {
        result = calculator.Multiply(value1, value2);
        Console.WriteLine($"Result: {result}");
    }
    else
    {
        Console.WriteLine("Invalid operation.");
    }
    Console.WriteLine();
    Console.WriteLine("Calculate again ? (y/n)");
    continue_calculate = Console.ReadLine();
} while (continue_calculate == "Y" || continue_calculate == "y");


static class Input
{
    public static Int32 getInput(string name)
    {
        while (true)
        {
            try
            {
                Console.WriteLine($"{name}");
                var v1 = Console.ReadLine();
                int a = int.Parse(v1);
                return a;
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}



