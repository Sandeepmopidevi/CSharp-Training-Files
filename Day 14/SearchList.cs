    using System;
    using System.Collections.Generic;
    
    class C2
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("hello");
            list.Add("xyz");
    
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
    
            int index = list.BinarySearch("pqr");
            Console.WriteLine(index);
        }
    }