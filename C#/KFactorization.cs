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
     * Complete the 'kFactorization' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY A
     */

    public static String kFactorization(int[] arr, int result, int step, String output, String[] strs)
    {
        if (strs[0] != null && strs[0].Length < output.Length)
        {
            return null;
        }
        if (result == 1)
        {
            strs[0] = output;
            return output;
        }
        String outp = null;
        for (var i = 0; i < arr.Length; i++)
        {
            if (result % arr[i] == 0)
            {
                var temp = Result.kFactorization(arr, (int)(result / arr[i]), step + 1, (int)(result / arr[i]) + " " + output, strs);
                if (temp == null)
                {
                    continue;
                }
                else if (outp == null)
                {
                    outp = temp;
                }
                else
                {
                    outp = outp.Length < temp.Length ? outp : temp;
                }
            }
        }
        return (outp == null) ? null : outp;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstMultipleInput[0]);
        int k = Convert.ToInt32(firstMultipleInput[1]);
        int[] arr = new int[k];
        for (var i = 0; i < k; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        var outp = Result.kFactorization(arr, n, 0, "" + n.ToString(), new String[1]);
        textWriter.WriteLine(string.Join(", ", int.Parse(outp) == 0 ? -1 : int.Parse(outp)));
        
        textWriter.Flush();
        textWriter.Close();
    }
}
