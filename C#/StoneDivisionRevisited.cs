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
     * Complete the 'stoneDivision' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. LONG_INTEGER n
     *  2. LONG_INTEGER_ARRAY s
     */

    public static long stoneDivision(long pile,
            long[] predefinedSet,
            int sizeOfPredefinedSet,Dictionary<long, long> memo)
    {
        if (memo.ContainsKey(pile))
            {
                return memo[pile];
            }
            // go over all possible options to find maximum number of moves
            long maximumNumberOfMoves = 0;
            for (int i = 0; i < sizeOfPredefinedSet; i++)
            {
                long divisor = predefinedSet[i];

                if (pile % divisor != 0 || (pile / divisor <= 1))
                {
                    continue;
                }

                // solve a subproblem using recurisve function - a small pile
                long numberOfMoves = stoneDivision(divisor, predefinedSet, sizeOfPredefinedSet,memo);

                // how many piles - count in the factor of piles
                // first divide into small piles, then each small pile will be processed. 
                numberOfMoves = 1 + (pile / divisor) * numberOfMoves;

                // keep the maximum one only
                maximumNumberOfMoves = Math.Max(maximumNumberOfMoves, numberOfMoves);
            }

            memo[pile] = maximumNumberOfMoves;

            return maximumNumberOfMoves;
    }

}

class Solution
{
    public static Dictionary<long, long> memo = new Dictionary<long, long>();
    public static void Main(string[] args)
    {
        ProcessInput();
        
        
    }
    public static void ProcessInput()
        {
            int queries = int.Parse(Console.ReadLine());
            for (int query = 0; query < queries; query++)
            {
                memo.Clear();
                string[] input = Console.ReadLine().Split(' ');
                long n = long.Parse(input[0]);
                int m = int.Parse(input[1]);
                long[] predefinedSet = new long[1003];
                predefinedSet = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                long answer = Result.stoneDivision(n, predefinedSet, m,memo);
                Console.WriteLine(answer);
            }
        }
}
