using System;
using System.Collections.Generic;

class T1{
    static void Main(string[] args)
    {
        List<int> l1=new List<int>(){12,23,45,67,89};
        foreach (int num in l1)
        {
            Console.WriteLine(num);
        }
}}