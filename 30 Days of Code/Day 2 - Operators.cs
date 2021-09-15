  
// ========================
//       Information
// ========================

// Direct Link: https://www.hackerrank.com/challenges/30-operators/problem
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

class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static double solve(double meal_cost, int tip_percent, int tax_percent)
    {
        var tip = tip_percent * meal_cost / 100;
        var tax = tax_percent * meal_cost / 100;
        var total_cost = Math.Round(tip + tax + meal_cost);
        return total_cost;
    }
    

}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine(Result.solve(meal_cost, tip_percent, tax_percent));
    }
}