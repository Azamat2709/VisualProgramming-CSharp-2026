using System;
using System.Collections;

    class Program
    {
        static void Main(string[] args)
        {
List<object>list = new List<object>(); // I changed the <int> to <object>, so it can takes any type of value
list.Add(10);
list.Add("Hello");
Console.WriteLine(list[0]);
Console.WriteLine(list[1]);
        }
    }
