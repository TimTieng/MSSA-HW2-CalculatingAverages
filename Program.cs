//Class:    ERAU ISTA220 Programming Fundamentals - C#
//Student:  Tim Tieng
//Instructor:   Christine E. Lee, Instructor
//Project Start Date: 08JUL2020
//Project End Date: 18JUL2020

/******************************************************************************

This project contains the code to conduct mathematical operations: Finding the
sum and averages with specific conditions. Concepts Utilized: Arrays, String-INT
conversions, storing User Input into Arrays, If-Statements, For-Loops, Comparison
and Logical operators

Revisions: 1. Line 117 - explicitly casted INT to convert INT to Decimal (12JUL)
           2. Chaged comparison operators in in IntermediateDifficulty() and AdvancedDifficulty() (12JUL)
           3. Changed Average calucations data types from INT to FLOAT (13JUL)

Revision Date: 13JUL2020

Revised By: Tim Tieng

******************************************************************************/
using System;
using System.Collections.Generic;

namespace CSharpHomework2_CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Practical Use - Menu Console Application tries to limit over crowding on console window
             that makes the program more user friendly. 
            */
            Console.Clear(); //This clears the console menu

            bool displayMenu = true;//True value is used to display the option menu
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
            MainMenu();
        }
        private static bool MainMenu() //bool is part of the method declaration because we defined a boolean value in the Main Method to reference.
        {
            Console.WriteLine("Hi Christine! Here is my Math Homework - Calculating Averages Program!");
            Console.WriteLine("1). Option 1: Basic Difficulty 1 - Calculate the Sum of an array!");
            Console.WriteLine("2). Option 2: Basic Difficulty 2 - Calcuate the average of an array!");
            Console.WriteLine("3). Option 3: Intermediate Difficulty - Average specific numbers of scores provided by you and assign a letter grade!");
            Console.WriteLine("4). Option 4: Advanced Difficulty - Average non-specific number of scores!");
            Console.WriteLine("5). Option 5: EXIT Program");
            string result = Console.ReadLine();

            if (result == "1")
            {
                SumOfNum();
                return true;
            }
            else if (result == "2")
            {
                ArrayAverage();
                return true;
            }
            else if (result == "3")
            {
                IntermediateDiff();
                return true;
            }
            else if (result == "4")
            {
                AdvancedDifficulty();
                return true;
            }
            else if (result == "5")
            {
                Console.Clear();
                return false;//The false value is the trigger for the program to break out of the loop
            }
            else
            {
                return true;
            }
        }
        private static void SumOfNum()
        {
            Console.Clear();
            Console.WriteLine("This program asks for you to input 10 values between 0-100 and return the sum of those values");
            
            int i;//value that user will input to be stored in the array
            int[] array= new int [10];//declaring and creating an empty array with a max limit of 10 values

            for (i = 0; i < 10; i++) //Automate task. starting point for counter, limit for counter, counter will increase. Will repeat task until <10
            {
                Console.Write("Please enter 10 values that range between 0-100: ");
                array[i] = Convert.ToInt32(Console.ReadLine());//Convert string input to INT
                if (array[i] > 100)
                {
                    Console.WriteLine("Invalid response");
                    --i; //This ensures the input is not added into the array RECVIED ASSISTANCE VIA INTERNET
                }
            }
            Console.WriteLine($"This is your array: " +
                    $"[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}, {array[8]}, {array[9]}]");
            //INTENTIONAL LINE BREAK
            int sumOfArray = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6] + array[7] + array[8] + array[9];
            Console.WriteLine($"The sum of your values is {sumOfArray}");
            Console.ReadLine();
        }
        private static void ArrayAverage()//Using same code structure from SumOfArray Method
        {
            Console.Clear();
            Console.WriteLine("This program ask for you to chose 10 values between 0-100 and returns the average of those values");

            int i;
            int[] array = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.Write("Please enter 10 values that range between 0-100: ");
                array[i] = (int)Convert.ToDecimal(Console.ReadLine());
                if (array[i] > 100)
                {
                    Console.WriteLine("Invalid response");
                    --i;
                }
            }
            Console.WriteLine($"This is your array: " +
                    $"[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}, {array[8]}, {array[9]}]");
            //INTENTIONAL LINE BREAK
            float sumOfArray = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6] + array[7] + array[8] + array[9];
            Console.WriteLine($"The sum of your values is {sumOfArray}");
            float averageOfArray = sumOfArray / 10;
            Console.WriteLine($"The average of your array is {averageOfArray}");
            Console.ReadLine();
        }
        private static void IntermediateDiff()//Using similar code structure from ArrayAverage Method
        {
            Console.Clear();
            Console.WriteLine("This program will provide an average value and assign a letter grade by asking you how many tests you graded and their respective scores!");
            Console.WriteLine("Please enter the amount of tests you have graded: ");
            int testQuantity = Convert.ToInt32(Console.ReadLine());
            if (testQuantity < 0 || testQuantity >100)
            {
                Console.WriteLine("Invalid input. Please ensure your value is between 0-100");
            }
            //INTENTIONAL LINE BREAK
            int i;
            int[] array = new int[testQuantity]; //Ensure the value for 'i' matches testQuantity so the proper amount of values is stored in the array
            for (i = 0; i < testQuantity; i++) //testQuantity = limit of the array
            {
                Console.Write("Please enter the grade values for your graded tests: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] > 100)
                {
                    Console.WriteLine("Invalid response");
                    --i;
                }
            }
            Console.WriteLine("These are the grades you put into the system: ");//Print all grades from the array. FOREACH needed since its an array
            foreach (var item in array)
            {
                Console.Write($" [{item}] ");
            }
            //INTENTIONAL LINE BREAK
            float sum = 0;
            for (i = 0; i < testQuantity; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"The total sum of your test grades is {sum}");
            float averageOfArray = sum / testQuantity;
            Console.WriteLine($"The average of your tests is {averageOfArray}");
            //declare and set grade values - use logical and conditional operators in IF statements
            char aGradeValue= 'A';
            char bGradeValue = 'B';
            char cGradeValue = 'C';
            char dGradeValue = 'D';
            char failingGradeValue = 'F';
            if (averageOfArray >= 91 && averageOfArray <= 100)//Set range for grade values using && to represent AND
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{aGradeValue}'.");
                Console.ReadLine();
            }
            else if (averageOfArray >= 85 && averageOfArray <= 90)
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{bGradeValue}'.");
                Console.ReadLine();
            }
            else if (averageOfArray >= 75 && averageOfArray <= 84)
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{cGradeValue}'.");
                Console.ReadLine();
            }
            else if (averageOfArray >= 65 && averageOfArray <= 74)
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{dGradeValue}'.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{failingGradeValue}'.");
                Console.ReadLine();
            }
        }
        private static void AdvancedDifficulty()
        {
            Console.Clear();
            Console.WriteLine("This program accepts grade value input, averages the grade values, and assigns a letter grade!");
            //INTENTIONAL LINE BREAK
            int i;
            
            //int[] array = new int[] { };
            int[] array = new int[20];//20 grade limit for now.Figure out how to set an empty array WITHOUT the "divide by zero error"
            int arrayLength = array.Length;
            for (i = 0; i < arrayLength; i++)
            {
                Console.Write("Please enter the grade values for your graded tests: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] > 100)
                {
                    Console.WriteLine("Invalid response! Plese enter a grade between 0-100");
                    --i;
                }
            }
            Console.WriteLine("These are the grades you put into the system: ");//Print all grades from the array. FOREACH needed
            foreach (var item in array)
            {
                Console.Write($" [{item}] ");
            }
            //INTENTIONAL LINE BREAK
            float sum = 0;
            for (i = 0; i < arrayLength; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"The total sum of your test grades is {sum}");
            float averageOfArray = sum / arrayLength;
            Console.WriteLine($"The average of your tests is {averageOfArray}");
            //declare and set grade values - use logical and conditional operators in IF statements
            char aGradeValue = 'A';
            char bGradeValue = 'B';
            char cGradeValue = 'C';
            char dGradeValue = 'D';
            char failingGradeValue = 'F';
            if (averageOfArray >= 91 && averageOfArray <= 100)//Set range for grade values using && to represent AND
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{aGradeValue}'.");
                Console.ReadLine();
            }
            else if (averageOfArray >= 85 && averageOfArray <= 90)
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{bGradeValue}'.");
                Console.ReadLine();
            }
            else if (averageOfArray >= 75 && averageOfArray <= 84)
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{cGradeValue}'.");
                Console.ReadLine();
            }
            else if (averageOfArray >= 65 && averageOfArray <= 74)
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{dGradeValue}'.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"The test score average is {averageOfArray} that equates to a letter grade of '{failingGradeValue}'.");
                Console.ReadLine();
            }
        }
    }
}
/* 1. Recieved assitance with "Menu Console". I utilized the concepts taught in Bob Tabor's C# for abosolute beginners, "WhileIteration" Lesson
      to create a Main Menu feature of my program. I completed this youtube course and repeated several of his projects prior to the
      course start https://www.youtube.com/watch?v=sQurwqK0JNE

   2. On 08JUL2020, I had an informal conversation with Tyler Kain (student) on key concepts used for his coding assignment to help guide my method
      code blocks. From this conversation, I realized I need to ensure I include an If statement to validate user response if a value is outside
      the range of 0-100.

   3. I used a code referenced in StackOverflow to know  the code to ensure an invalid response is not added into the array. The forum
      recommended I use a decrement operator on the value I set as the array value.
      https://stackoverflow.com/questions/19581089/c-sharp-checking-users-input-before-placing-it-into-an-array

   4. I referenced the concepts outlined on CompleteCsharptutorial website to know how to store user input into an array.
      https://www.completecsharptutorial.com/basic/storing-values.php

    5.I referenced the code in this website and changed it to fit my existing code. I used this website mainly to learn how to add the values in the
      using a foreach format https://www.w3resource.com/csharp-exercises/array/csharp-array-exercise-3.php
*/
