// ========================
//       Information
// ========================

// Direct Link: https://www.hackerrank.com/challenges/30-sorting/problem
// Difficulty: Easy
// Max Score: 30
// Language: C#

// ========================
//         Solution
// ========================
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

       string[] arrayInput = Console.ReadLine().Split(' ');
        int[] numbersArray = Array.ConvertAll(arrayInput, Int32.Parse);
        // Write your code here
        int numberOfSwaps = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - 1; j++) {
                if (numbersArray[j] > numbersArray[j + 1]) {
                    Array.Reverse(numbersArray, j, 2);
                    numberOfSwaps++;
                }
            }

            if (numberOfSwaps == 0) {
                break;
            }
        }
        int firstPosition = numbersArray[0];
        int lastPosition = numbersArray[numbersArray.Length - 1];

        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {firstPosition}");
        Console.WriteLine($"Last Element: {lastPosition}");

    }
}
