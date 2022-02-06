using System;
using Exercises.ArithmeticMethods;

/*
 * This repository stores completed code exercises from csharpexercises.com and
 * from Exercism.
 */
namespace Exercises
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Expected behavior of AddAndMultiply() \nAdd the first two integers and multiply its result with the third integer: ");
            Console.WriteLine($"\nIf given 3, 5, & 9 = {MathematicOperations.AddAndMultiply(3, 5, 9)}");
            Console.Write("\n");
            Console.Write("Expected behavior of CelsiusToFahrenheit() \nConvert celsius to fahrenheit & return error message if result is below Absolute Zero: ");
            Console.WriteLine($"\nIf given 32 = {MathematicOperations.CelsiusToFahrenheit(32)}");
            Console.Write("\n");
            Console.Write("Expected behavior of ElementaryOperations() \nAdd, subtract, multiply, & divide two numbers, return error message if you try to divide by 0: ");
            Console.WriteLine($"\nIf given 5 & 12 = {MathematicOperations.ElementaryOperations(5, 12)}");
            Console.Write("\n");
            Console.Write("Expected behavior of AddOrDivideBasedOnModulo() \nIf the 1st & 2nd inputs are divisible by 2 or 3, their product are printed - otherwise their sum: ");
            Console.WriteLine($"\nIf given 7 & 12 = {MathematicOperations.AddOrDivideBasedOnModulo(7, 12)}");
            Console.Write("\n");
            Console.Write("Expected behavior of IsThisAllUppercaseLetters() \nIf the 3-letter string contains all Uppercase letters, return true: ");
            Console.WriteLine($"\nIf given 'ZT!' = {IsThisAllUppercaseLetters("ZT!")}");
            Console.Write("\n");
            Console.Write("Expected behavior of GreaterThanTheThird() \nIf the sum or product of first two numbers are greater than the third number, return true: ");
            Console.WriteLine($"\nIf given [2, 7, 13] = {MathematicOperations.GreaterThanTheThird(new int[] { 2, 7, 13 })}");
            Console.Write("\n");
            Console.Write("Expected behavior of ArrayOfMultiples() \n1st input is the number whose multiples will be listed & the 2nd input determines how many multiples will be listed: ");
            Console.WriteLine($"\nIf given 12 & 10 = {string.Join(",", MathematicOperations.ArrayOfMultiples(12, 10))}");
        }
        private static bool IsThisAllUppercaseLetters(string a)
        {
            return (char.IsUpper(a[0]) && char.IsUpper(a[1]) && char.IsUpper(a[2]));
        }
    }
}