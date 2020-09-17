using System;
/*
 * Name: Lisa Duong
 * Class: ISM4300.001
 * Assignment: Tech Project #2b
 * Comments: Conditional Statements
 * Date: 9/17/20
 */

namespace Duong_Techproj2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            Console.WriteLine("Please enter an integer value.");
            //asking user to input an integer to get a letter grade
            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                if(grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("Your letter grade will be: A");
                    Console.WriteLine("Press any key to exit the program.");
                    //grades between 90-100 will output grade A
                }
                else if (grade >= 80 && grade <= 89)
                {
                    Console.WriteLine("Your letter grade will be: B");
                    Console.WriteLine("Press any key to exit the program.");
                    //grades between 80-89 will output grade B
                }
                else if (grade >= 70 && grade <= 79)
                {
                    Console.WriteLine("Your letter grade will be: C");
                    Console.WriteLine("Press any key to exit the program.");
                    //grades between 70-79 will output grade C
                }
                else if (grade >= 60 && grade <= 69)
                {
                    Console.WriteLine("Your letter grade will be: D");
                    Console.WriteLine("Press any key to exit the program.");
                    //grades between 60-69 will output grade D
                }
                else if (grade >= 0 && grade <= 59)
                {
                    Console.WriteLine("Your letter grade will be: F");
                    Console.WriteLine("Press any key to exit the program.");
                    //grades between 0-59 will output grade F
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please enter an integer value within 0-100.");
                    Console.WriteLine("Press any key to exit the program.");
                    //any integer not between 0-100 will output this
                }
            }
            catch
            {
                Console.WriteLine("Incorrect input. Please enter an integer value.");
                Console.WriteLine("Press any key to exit the program.");
                //If user inputs non-integer number then this is outputted
            }
        }
    }
}
