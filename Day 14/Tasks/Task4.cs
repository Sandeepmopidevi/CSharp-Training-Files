using System;
using System.Collections.Generic;
using System.Linq;
class Task4
{
    static void Main()
    {
        List<string> studentNm = new List<string> { "sandeep", "lal", "dinesh", "koti", "bob" };
        studentNm.Insert(2, "Prasanth");
        List<string> extraNm = new List<string> { "vijay", "harsha","arora"};
        studentNm.AddRange(extraNm);
        studentNm.Sort();
        studentNm.Reverse();
        foreach (string name in studentNm)
        {
            string revName = new string(name.Reverse().ToArray());
            bool isPalindrome = name.Equals(revName);
            Console.WriteLine(name + " is" + (isPalindrome ? "" : " not") + " a palindrome.");
        }
    }
}