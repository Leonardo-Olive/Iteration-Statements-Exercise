using System.ComponentModel;

namespace IterationStatements
{
    public class Program
    {


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Run();
            Console.ReadLine();
        }

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            Console.WriteLine("Hello there! We will show your number from 1000 to -1000.");
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            Console.WriteLine("Now we will show you increments of 3.");
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual()


        {
            Console.WriteLine("Please enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("The numbers are equal.");
                return true;
            }

            Console.WriteLine("The numbers are not equal.");
            return false;
        }
        //Write a method to check whether a given number is even or odd
        public static void Odd()
        {
            Console.WriteLine("Now, lets see if a number is even or odd. Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.ReadLine();


            if (num % 2 == 0)
            {
                Console.WriteLine("Your number is even!");
            }
            else
                Console.WriteLine("Your number is odd!");
        }

        // Write a method to check whether a given number is positive or negative

        public static void Check()
        {
            Console.WriteLine("Please enter a number");
            var number = int.Parse(Console.ReadLine());


            if (number >= 0)
            {
                Console.WriteLine("Your number is positive");
            }
            else
                Console.WriteLine("Your number is negative");
            Console.ReadLine();

            //Write a method to read the age of a candidate and determine whether they can vote.

        }
        public static void Vote()
        {
            Console.WriteLine("Lets see if you can vote. Please enter your age:");

            var age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You can vote!");

            }
            else
                Console.WriteLine("I love your excitement, but you are not old enough.");
            Console.ReadLine();

        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void Range()
        {


            Console.WriteLine("Let`s guess the number range:");


            var input = int.Parse(Console.ReadLine());

            if (input > 10)
            {
                Console.WriteLine("Your number is not in the range.");
            }
            else
                Console.WriteLine($"{input} is in the range.");

        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void Multi()
        {
            Console.WriteLine("Now, lets think of a number to multiply from 1 to 12.");
            var multNumb = int.Parse(Console.ReadLine());

            

            Console.WriteLine($"Here are the results: {multNumb*1},{multNumb*2}, {multNumb*3}, {multNumb * 4}, {multNumb * 5}, {multNumb * 6}, {multNumb * 7}, {multNumb * 8}, {multNumb * 9},{multNumb * 10}, {multNumb * 11}, {multNumb * 12}");
        }

        public static void Run()
        {
            PrintThousand();
            Threes();
            IsEqual();
            Odd();
            Check();
            Vote();
            Range();
            Multi();
            Console.WriteLine("I hope you liked our little game. We will see you next time!");

        }



    }
}