  
// ========================
//       Information
// ========================

// Direct Link: https://www.hackerrank.com/challenges/30-review-loop/problem
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
        int counter = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= counter; i++) {
            string myString = Console.ReadLine();

            for (int j = 0; j < myString.Length; j++) {
                if (j % 2 == 0) {
                    Console.Write(myString[j]);
                }
            }

            Console.Write(" ");

            for (int j = 0; j < myString.Length; j++) {
                if (j % 2 == 1) {
                    Console.Write(myString[j]);
                }
            }
            Console.WriteLine();
        }
    }
}

