using System;

namespace CodeWars
{
    public class Kata
    {
// Question:
//Description:
//Write a function that accepts an array of 10 integers(between 0 and 9), that returns a string of those numbers in the form of a phone number.

//Example:
//Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
//The returned format must be correct in order to complete this challenge.
//Don't forget the space after the closing parentheses

        public static string CreatePhoneNumber_Mine(int[] digits) 
        { 
            return $"({digits[0]}{digits[1]}{digits[2]}) {digits[3]}{digits[4]}{digits[5]}-{digits[6]}{digits[7]}{digits[8]}{digits[9]}";
        }

        public static string CreatePhoneNumber_Other(int[] digits)
        {
            return Int32.Parse(string.Concat(digits)).ToString("(000) 000-0000");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] myDigits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine($"Mine: {Kata.CreatePhoneNumber_Mine(myDigits)}");
            Console.WriteLine($"Other: {Kata.CreatePhoneNumber_Other(myDigits)}");
        }
    }
}
