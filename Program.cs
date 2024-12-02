
/*
Write a program to create a function to calculate the sum
of the individual digits of a given number
*/

//convert to string, divide string, convert back
//make numbers absolute because lesssons
//loop to repeat, make sum

namespace Assignment_5._1_Question_2
{
    using System;

    class Program
    {
        public static int numbers(int number)
        {
            //converting type
            string total = Math.Abs(number).ToString(); //absolute numbers

            int[] digits = new int[total.Length];

            //loop
            for (int i = 0; i < total.Length; i++)
            {
                digits[i] = total[i] - '0';
                //add -0 to make math sense
            }
            
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += digit;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number: ");
            Console.WriteLine("");

            //input and output
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                int sum = numbers(input);
                Console.WriteLine("");
                Console.WriteLine($"The sum of the numbers provided with {input} is {sum}");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Doesn't count, please enter a whole number.");
            }
        }
    }

}
