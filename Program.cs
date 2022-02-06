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
            Console.Write("\n");
            Console.Write("Expected behavior of IsThereANeighbor() \nA 3-letter string inputted checks if the 1st or 3rd letter in the string is a neighbor of the 2nd letter in the alphabet: ");
            Console.WriteLine($"\nIf given 'GWX' = {IsThereANeighbor("GWX")}");
            Console.Write("\n");
            Console.Write("Expected behavior of ReverseCase() \nWill reverse the case of every letter in a string inputted while ignoring whitespaces: ");
            Console.WriteLine($"If given 'ARUU said the dwarf' = {ReverseCase("ARUU said the Dwarf")}");
        }
        private static bool IsThisAllUppercaseLetters(string a)
        {
            return (char.IsUpper(a[0]) && char.IsUpper(a[1]) && char.IsUpper(a[2]));
        }
        private static bool IsThereANeighbor(string a)
        {
            return ((((int)a[1] + 1) == ((int)a[0])) || (((int)a[1] - 1) == ((int)a[0])) || (((int)a[1] + 1) == ((int)a[2])) || (((int)a[1] - 1) == ((int)a[2])));
        }
        private static string ReverseCase(string a)
        {
            char[] deconstructedString = a.ToCharArray();
            for (int i = 0; i < deconstructedString.Length; i++)
            {
                char letter = (char)deconstructedString[i];
                if (Char.IsWhiteSpace(letter))
                {
                    deconstructedString[i] = (char)32;
                }
                else
                {
                    char letterSwappedCase = (Char.IsUpper(letter)) ? Char.ToLower(letter) : Char.ToUpper(letter);
                    deconstructedString[i] = letterSwappedCase;
                }
            }
            string assembledStringWithReverseCases = string.Join("", deconstructedString);
            return assembledStringWithReverseCases;
        }
    }
}