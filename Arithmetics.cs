using System;

namespace Exercises.ArithmeticMethods
{
    public class MathematicOperations
    {
        public static int AddAndMultiply(int firstInteger, int secondInteger, int thirdInteger)
        {
            return (firstInteger + secondInteger) * thirdInteger;
        }
        public static string CelsiusToFahrenheit(int celsiusTemperature)
        {
            double calculation = (celsiusTemperature * 1.8) + 32;
            if (calculation > -271.15)
            {
                string resultLine = $"Temperature equals {calculation}°F";
                return resultLine;
            }
            return "Temperature is below absolute zero!";
        }
        public static string ElementaryOperations(double firstInteger, double secondInteger)
        {
            //The variable below uses a ternary operator in order to make a decision based on whether the use gave a 0 as 2nd integer.
            string divideByZeroCheck = (secondInteger == 0) ? "You cannot divide a number by zero!" : $"{firstInteger / secondInteger}";
            //This use of a decimal type is to allow for quotients to be rounded up to the 5th place to avoid long decimal values being rendered.
            decimal quotient = Decimal.Round(Convert.ToDecimal(divideByZeroCheck), 5);
            return $"{firstInteger + secondInteger}, {firstInteger - secondInteger}, {firstInteger * secondInteger}, {quotient}";
        }
        public static int AddOrDivideBasedOnModulo(int firstInteger, int secondInteger)
        {
            int result = ((firstInteger % 2 == 0 || firstInteger % 3 == 0) && (secondInteger % 2 == 0 || secondInteger % 3 == 0)) ? (firstInteger * secondInteger) : (firstInteger + secondInteger);
            return result;
        }
        public static bool GreaterThanTheThird(int[] a)
        {
            return ((a[0] * a[1]) > a[2] || (a[0] + a[1]) > a[2]);
        }
        public static int[] ArrayOfMultiples(int a, int b)
        {
            int[] result = new int[b];
            for (int i = 0; i < b; i++)
            {
                result[i] = (i + 1) * a;
            }
            return result;
        }
    }
}
