using System;

/*
 * This repository stores completed code exercises from csharpexercises.com and
 * from Exercism.
 */
public class Program
{
    public static void Main()
    {
        Console.Write("Expected behavior of AddAndMultiply() \nAdd the first two integers and multiply its result with the third integer: ");
        Console.WriteLine(AddAndMultiply(3, 5, 9));
        Console.Write("\n");
        Console.Write("Expected behavior of CelsiusToFahrenheit() \nConvert celsius to fahrenheit & return error message if result is below Absolute Zero: ");
        Console.WriteLine(CelsiusToFahrenheit(32));
        Console.Write("\n");
        Console.Write("Expected behavior of ElementaryOperations() \nAdd, subtract, multiply, & divide two numbers, return error message if you try to divide by 0: ");
        Console.WriteLine(ElementaryOperations(5, 12));
    }

    private static int AddAndMultiply(int firstInteger, int secondInteger, int thirdInteger)
    {
        return (firstInteger + secondInteger) * thirdInteger;
    }
    private static string CelsiusToFahrenheit(int celsiusTemperature)
    {
        double calculation = (celsiusTemperature * 1.8) + 32;
        if (calculation > -271.15)
        {
            string resultLine = $"Temperature equals {calculation}°F";
            return resultLine;
        }
        return "Temperature is below absolute zero!";
    }
    private static string ElementaryOperations(double firstInteger, double secondInteger)
    {
        //The variable below uses a ternary operator in order to make a decision based on whether the use gave a 0 as 2nd integer.
        string divideByZeroCheck = (secondInteger == 0) ? "You cannot divide a number by zero!" : $"{firstInteger / secondInteger}";
        //This use of a decimal type is to allow for quotients to be rounded up to the 5th place to avoid long decimal values being rendered.
        decimal quotient = Decimal.Round(Convert.ToDecimal(divideByZeroCheck),5);
        return $"{firstInteger + secondInteger}, {firstInteger - secondInteger}, {firstInteger * secondInteger}, {quotient}";
    }
}