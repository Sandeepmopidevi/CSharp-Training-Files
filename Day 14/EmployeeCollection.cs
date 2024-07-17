using System;
using System.Linq;
using System.Collections.Generic;

class T12
{
    static void Main(string[] args)
    {
        var s1 = new List<Employee>()
        {
            new Employee() { id = 123, name = "xyz" },
            new Employee() { id = 564, name = "pqr" }
        };

        var s2 = from y in s1
                 where y.name == "xyz"
                 select y;

        foreach (var x in s2)
        {
            Console.WriteLine("ID: "+x.id+", Name: "+x.name);
        }
    }
}
public class Employee
{
    public int id { get; set; }
    public string name { get; set; }
}