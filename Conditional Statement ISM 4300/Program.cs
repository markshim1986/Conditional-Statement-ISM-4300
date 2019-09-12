// Autor: Mark Shim
// Date: 9/9/2019
// Comment: This is a C# console running a conditional statement of students grades
using System;

namespace Conditional_Statement_ISM_4300
{
    class Program
    {

        static void Main(string[] args)

        // Ask the user for input
        {
            Console.Write("What grade do you expect to earn in ISM4300? ");

            // Use a try catch block to validate user input.
            // If the user input incorrect data, they will 
            // recieve an error message

            try
            {
                // This variable will gather the user input

                int grade = int.Parse(Console.ReadLine());

                if ((98 <= grade) && (grade <= 100))
                {
                    Console.WriteLine("Your grade in the class will be an A+");
                    // This line informs the student of their grade
                }
                else if ((92 <= grade) && (grade <= 97))
                {
                    Console.WriteLine("Your grade in the class will be an A-");
                    // This line informs the student of their grade
                }
                else if ((90 <= grade) && (grade <= 91))
                {
                    Console.WriteLine("Your grade in the class will be an A");
                }
                else if ((88 <= grade) && (grade <= 89))
                {
                    Console.WriteLine("Your grade in the class will be a B+");
                    // This line informs the student of their grade
                }
                else if ((82 <= grade) && (grade <= 87))
                {
                    Console.WriteLine("Your grade in the class will be a B");
                    // This line informs the student of their grade
                }
                else if ((80 <= grade) && (grade <= 81))
                {
                    Console.WriteLine("Your grade in the class will be a B-");
                    // This line informs the student of their grade
                }
                else if ((78 <= grade) && (grade <= 79))
                {
                    Console.WriteLine("Your grade in the class will be a C+");
                    // This line informs the student of their grade
                }
                else if ((72 <= grade) && (grade <= 77))
                {
                    Console.WriteLine("Your grade in the class will be a C");
                }// This line informs the student of their grade

                else if ((70 <= grade) && (grade <= 71))
                {
                    Console.WriteLine("Your grade in the class will be a C-");
                }// This line informs the student of their grade

                else if ((68 <= grade) && (grade <= 69))
                {
                    Console.WriteLine("Your grade in the class will be a D+");
                }// This line informs the student of their grade

                else if ((62 <= grade) && (grade <= 67))
                {
                    Console.WriteLine("Your grade in the class will be a D");
                }// This line informs the student of their grade

                else if ((60 <= grade) && (grade <= 61))
                {
                    Console.WriteLine("Your grade in the class will be a D-");
                }// This line informs the student of their grade

                else 
                {
                    Console.WriteLine("Your grade in the class will be a F");
                    Console.ReadKey(true);
                }// This line informs the student of their grade
                
            }
            catch
            {
               
            }
        }
    }
}
            

   
