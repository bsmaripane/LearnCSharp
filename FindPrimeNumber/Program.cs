using System;

namespace PrimeNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Read a number from the console and store it in the number variable.
            Console.Write("Enter number you want to check:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            //Create an integer variable k for counting remainder of Modulo Operation.
            int divisor = 0;

            //Create a for loop which starts from i (i = 1) to given number(number)
            for (int i = 1; i <= number; i++)
            {
                //Check the modulus of the value of the ‘number’ variable by the value of the ‘i’ variable is equal to 0 or not.
                if (number % i == 0)
                {
                    //If the remainder is 0 then increment k variable by 1.
                    divisor++;
                }
            }

            if (divisor == 2)
            {
                //If k is equal to 2 means, it has two factors one and itself, so it is a prime number.
                //Print a Message in the console
                Console.WriteLine("Entered Number is a Prime Number");
            }
            else
            {
                //If divisor does not equal to 2 means, it is more than two factors, so it is not a prime number.
                //Print a Message in the console
                Console.WriteLine("Entered Number is not a Prime Number");
            }

            // Wait for key press before closing
            Console.ReadKey();
        }

    }
}
