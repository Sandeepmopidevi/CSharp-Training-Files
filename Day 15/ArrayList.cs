using System;
using System.Collections;
using System.Collections.Generic;

class C1{
    public static void Main(string[] args){
        var arr1=new ArrayList();
        var arr2=new ArrayList(){1,"sandeep",null};
        ArrayList l1=new ArrayList();

        foreach(var item in arr2)
        {
            Console.WriteLine(item);
        }
    }
}