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
    }

    private static int AddAndMultiply(int firstInteger, int secondInteger, int thirdInteger)
    {
        return (firstInteger + secondInteger) * thirdInteger;
    }
}