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
        Console.WriteLine($"\nIf given 3, 5, & 9 = {AddAndMultiply(3, 5, 9)}");
        Console.Write("\n");
        Console.Write("Expected behavior of CelsiusToFahrenheit() \nConvert celsius to fahrenheit & return error message if result is below Absolute Zero: ");
        Console.WriteLine($"\nIf given 32 = {CelsiusToFahrenheit(32)}");
        Console.Write("\n");
        Console.Write("Expected behavior of ElementaryOperations() \nAdd, subtract, multiply, & divide two numbers, return error message if you try to divide by 0: ");
        Console.WriteLine($"\nIf given 5 & 12 = {ElementaryOperations(5, 12)}");
        Console.Write("\n");
        Console.Write("Expected behavior of AddOrDivideBasedOnModulo() \nIf the 1st & 2nd inputs are divisible by 2 or 3, their product are printed - otherwise their sum: ");
        Console.WriteLine($"\nIf given 7 & 12 = { AddOrDivideBasedOnModulo(7, 12)}");
        Console.Write("\n");
        Console.Write("Expected behavior of IsThisAllUppercaseLetters() \nIf the 3-letter string contains all Uppercase letters, return true: ");
        Console.WriteLine($"\nIf given 'ZT!' = {IsThisAllUppercaseLetters("ZT!")}");
        Console.Write("\n");
        Console.Write("Expected behavior of GreaterThanTheThird() \nIf the sum or product of first two numbers are greater than the third number, return true: ");
        Console.WriteLine($"\nIf given [2, 7, 13] = {GreaterThanTheThird(new int[] {2, 7, 13})}");
        Console.Write("\n");
        Console.Write("Expected behavior of ArrayOfMultiples() \n1st input is the number whose multiples will be listed & the 2nd input determines how many multiples will be listed: ");
        Console.WriteLine($"\nIf given 12 & 10 = {string.Join(",", ArrayOfMultiples(12,10))}");
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
    private static int AddOrDivideBasedOnModulo(int firstInteger, int secondInteger)
    {
        int result = ((firstInteger % 2 == 0 || firstInteger % 3 == 0) && (secondInteger % 2 == 0 || secondInteger % 3 == 0)) ? (firstInteger * secondInteger) : (firstInteger + secondInteger);
        return result;
    }
    private static bool IsThisAllUppercaseLetters(string a)
    {
        return (char.IsUpper(a[0]) && char.IsUpper(a[1]) && char.IsUpper(a[2]));
    }
    public static bool GreaterThanTheThird(int[] a)
    {
        return ((a[0] * a[1]) > a[2] || (a[0] + a[1]) > a[2]);
    }
    public static int[] ArrayOfMultiples(int a, int b)
    {
        int[] result = new int[b];
        for(int i = 0; i < b; i++)
        {
            result[i] = (i + 1) * a;
        }
        return result;
    }
}