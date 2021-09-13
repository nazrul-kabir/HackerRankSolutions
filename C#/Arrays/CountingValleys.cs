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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int n, string s) {
        
        int elevation = 0;
        int valleyCount = 0;
        bool aboveSeaLevel = true;        
        // O(n)        
        foreach(char c in s)
        {
            if(c == 'D')
                elevation--;
            else
                elevation++;
            
            if(elevation < 0 && aboveSeaLevel == true)
            {
                valleyCount++;
                aboveSeaLevel = false;
            }
            else if(elevation >= 0 && aboveSeaLevel == false)
            {
                aboveSeaLevel = true;
            }    
        }
        
        return valleyCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}