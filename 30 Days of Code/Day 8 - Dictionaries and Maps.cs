  
// ========================
//       Information
// ========================

// Direct Link: https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
// Difficulty: Easy
// Max Score: 30
// Language: C#

// ========================
//         Solution
// ========================
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Int32.Parse(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        for(int i=0;i<n;i++){
            string[] line = Console.ReadLine().Split(' ');
            phoneBook[line[0]]= line[1];
        }
        string name;
        while ((name = Console.ReadLine()) !=null){
            if(phoneBook.ContainsKey(name)){
                Console.WriteLine(name + "="+ phoneBook[name]);
            }else{
                Console.WriteLine("Not found");
            }
        }
    }
}


