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
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(int[][] arr)
    {
        int maxSum = int.MinValue;
        int rows = arr.Length - 2;
        for(int j = 0; j < rows; j++){
            int columns = arr[j].Length - 2;            
            for(int k = 0; k < columns; k++){
                int sum = arr[j][k] + arr[j][k+1] + arr[j][k+2]
                                    + arr[j+1][k+1]
                    + arr[j+2][k] + arr[j+2][k+1] + arr[j+2][k+2];
                
                if(maxSum < sum){
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];
        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
