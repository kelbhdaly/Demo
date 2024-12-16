using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Reflection.Metadata;
using System.Numerics;
using System.Diagnostics.Metrics;
using System;

namespace ass3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //        Example(1)  Input: 12 Output: Yes
            //        Example(2) Input: 9 Output: No
            //----------------------
            //Console.WriteLine("Enter The Number");
            //int Num = int.Parse(Console.ReadLine());
            //if (Num % 3 == 0 && Num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion


            #region Q02
            //Write a program that allows the user to insert an integer then print negative if
            // it is negative number otherwise print positive.
            //    Example(1)Input: -5 Output: negative
            //    Example(2)Input: 10 Output: positive
            //----------------------

            //Console.WriteLine("Enter The Number");

            //int Num = int.Parse(Console.ReadLine());
            //string Result = Num switch
            //{
            //    < 0 => "negative",
            //    > 0 => "positive",
            //    _ => "Zero"
            //};
            //Console.WriteLine(Result);

            #endregion


            #region Q03
            //Write a program that takes 3 integers from the user then prints the max element and the min element.
            //    Example(1)
            //    Input: 7,8,5
            //    Output:
            //            max element = 8
            //    min element = 5
            //    Example(2)
            //    Input: 3 6 9
            //    Outputs:
            //            Max element = 9
            //    Min element = 3
            //----------------------
            // Console.WriteLine("Enter The First Number : = ");
            // int FirstNumber = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter The Second Number : = ");
            // int SecondNumber = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter The Third Number : = ");
            // int ThirdNumber = int.Parse(Console.ReadLine());
            // if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
            // {
            //     Console.WriteLine("The Max Number Is : " + FirstNumber);

            // }
            // else if (SecondNumber > FirstNumber && SecondNumber > ThirdNumber)
            // {
            //     Console.WriteLine("The Max Number Is : " + SecondNumber);
            // }

            // else
            // {
            //     Console.WriteLine("The Max Number Is : " + ThirdNumber);
            // }

            // if (FirstNumber < SecondNumber && FirstNumber < ThirdNumber)
            // {
            //     Console.WriteLine("The Min Number Is : " + FirstNumber);
            // }
            //else if (SecondNumber < FirstNumber && SecondNumber < ThirdNumber)
            // {
            //     Console.WriteLine("The Min Number Is : " + SecondNumber);
            // }
            // else
            // {
            //     Console.WriteLine("The Min Number Is : " + ThirdNumber);

            // }
            #endregion

            #region Q04
            //Write a program that allows the user to insert an integer number then check If
            //    a number is even or odd.
            //----------------------
            //Console.WriteLine("Enter The Number");
            //int Num = int.Parse(Console.ReadLine());
            //if (Num % 2 == 0)
            //{
            //    Console.WriteLine("The Number Is Even ");
            //}
            //else
            //{
            //    Console.WriteLine("The Number Is Odd ");

            //}
            #endregion


            #region Q05
            //Write a program that takes character from the user then if it is a vowel 
            // chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //        Example(1)
            //        Input: O
            //        Output: vowel
            //        Example(2)
            //        Input: b
            //        Output: Consonant
            //----------------------
            //Console.WriteLine("Enter The Char To Check Is Vowel or Consonant : ");

            //char Ch = char.Parse(Console.ReadLine());
            //string Result = Ch switch
            //{
            //    'a' or 'e' or 'i' or 'u' => "Vowel",
            //    _ => "Consonant"
            //};
            //Console.WriteLine($"{Result}");


            #endregion


            #region Q06
            //Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //     Example Input: 5 Output: 1, 2, 3, 4, 5

            //Console.WriteLine("Enter The Number ");
            //int Number = int.Parse(Console.ReadLine());
            //for(int i =1; i<=Number; i ++)
            //{
            //    if (i == Number)
            //    {
            //        Console.Write(i);
            //        break;
            //    }
            //    Console.Write(i+ ",");    //:)

            //}

            #endregion


            #region Q07
            //Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.
            //    Example
            //    Input: 5
            //    Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            //-------------------------------------------------

            //Console.WriteLine("Enter The Number ");
            //int Number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{

            //    Console.Write(i * Number + " ");
            //}

            #endregion

            #region Q08
            //Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //        Example:
            //        Input: 15
            //     Output: 2 4 6 8 10 12 14
            //---------------------------------------------

            //Console.WriteLine("Enter The Number ");
            //int Number = int.Parse(Console.ReadLine());

            //for (int i = 1; i < Number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion

            #region Q09
            //Write a program that takes two integers then prints the power.
            //   Example:
            //    Input: 4 3
            //    Output: 64
            //    Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64


            //Console.WriteLine("Enter the number : ");
            //int Number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Number Of Power : ");
            //int NumberOfPower = int.Parse(Console.ReadLine());
            //int Result = 1;

            //for (int i = 0; i < NumberOfPower; i++)
            //{
            //    Result *= Number;
            //}
            //Console.WriteLine(Result);
            #endregion


            #region Q10
            //Write a program to enter marks of five subjects and calculate total, average and percentage.
            //    Example
            //    Input: -Enter Marks of five subjects: 95 76 58 90 89
            //    Output: Total marks = 408
            //            Average Marks = 81
            //            Percentage = 81

            //Console.WriteLine("Enter The Mark Of Subject One");
            //int SubjectOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Mark Of Subject Two");
            //int SubjectTwo = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Mark Of Subject Three");
            //int SubjectThree = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Mark Of Subject Four");
            //int SubjectFour = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Mark Of Subject Five");
            //int SubjectFive = int.Parse(Console.ReadLine());

            //int TotalMark = SubjectOne + SubjectTwo + SubjectThree + SubjectFour + SubjectFive;
            //Console.WriteLine("Total marks = " + TotalMark);

            //Console.WriteLine("Average Marks = " + TotalMark / 5);
            //double Percentage = (double)TotalMark / 5;
            //Console.WriteLine("Percentage = " + Percentage);
            #endregion


            #region Q11
            //Write a program to input the month number and print the number of days in that month.
            //    Example
            //    Input: Month Number: 1
            //    Output: Days in Month: 31
            //Console.WriteLine(" Enter The Month Number : ");
            //int MonthNumber = int.Parse(Console.ReadLine());
            //string DaysInMonth = MonthNumber switch
            //{
            //    1 => " Days in Month: 31",
            //    2 => " Days in Month: 29",
            //    3 => " Days in Month: 31",
            //    4 => " Days in Month: 30",
            //    5 => " Days in Month: 31",
            //    6 => " Days in Month: 30",
            //    7 => " Days in Month: 31",
            //    8 => " Days in Month: 31",
            //    9 => " Days in Month: 30",
            //    10 => " Days in Month: 31",
            //    11 => " Days in Month: 30",
            //    12 => " Days in Month: 31",
            //};
            //Console.WriteLine(DaysInMonth);
            #endregion


            #region Q12
            //Write a program to create a Simple Calculator.
            //Console.WriteLine("Enter The First Number ");
            //int Number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Second Number ");
            //int Number02 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Oprator ");
            //char Oprator =char.Parse( Console.ReadLine());

            //string result = Oprator switch
            //{
            //    '*' => $"The Multi {Number} * {Number02} = {Number * Number02}",
            //    '-' => $"The Sub {Number} - {Number02} = {Number - Number02}",
            //    '+' => $"The Sum {Number} + {Number02} = {Number + Number02}",

            //};
            //Console.WriteLine(result);

            #endregion

            #region Q13
            // Write a program to allow the user to enter a string and print the REVERSE of it.
            //-------------
            //Console.WriteLine("Enter a string:");
            //string S01 = Console.ReadLine();

            
            //string Reversed = "";
            //for (int i = S01.Length - 1; i >= 0; i--)
            //{
            //    Reversed += S01[i];
            //}
            //Console.WriteLine(Reversed);

            #endregion


            #region Q14
            // Write a program to allow the user to enter int and print the REVERSED of it
            //Console.WriteLine("Enter The Integer Number ");
            //int Number = int.Parse(Console.ReadLine());
            //int Reverse = int.Parse(new string(Number.ToString().Reverse().ToArray())); //  :)
            //Console.WriteLine(Reverse);
            #endregion

            #region Q15
            //    Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Test Data: Input starting number of range: 1 Input ending number of range: 50
            //Expected Output :The prime number between 1 and 50 are: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            //------------------------------------

            //Console.WriteLine("Enter The Start Number : ");
            //int Start = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The End Number of range : ");
            //int End = int.Parse(Console.ReadLine());
            //int Range = 1;
            //for (int i = Start; i <= End; ++i)
            //{
            //    if (i <= 1)
            //    {
            //        continue;
            //    }
            //    int j;
            //    for (j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            break;
            //        }

            //    }
            //    if (i > j / 2)
            //    {
            //        Console.Write(i+" ");
            //  }
            //}

            #endregion


            #region Q16
            //Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //    Test Data:
            //                Enter a number to convert: 25
            //    Expected Output :
            //    The Binary of 25 is 11001.

            //------------------------------

            //Console.WriteLine("Enter a number to convert:");
            //int DecimalNumber = int.Parse(Console.ReadLine());

            //string BinaryNumber = "";

            //while (DecimalNumber > 0)
            //{
            //    BinaryNumber = (DecimalNumber % 2) + BinaryNumber;
            //    DecimalNumber = DecimalNumber / 2;

            //}
            //if (BinaryNumber == "")
            //{
            //    BinaryNumber = "0";
            //}
            //Console.WriteLine($"The Binary  is {BinaryNumber}");
            #endregion
        }

    }
}
