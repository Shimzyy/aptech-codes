using System;
using System.Collections;
using System.Collections.Generic;
class Student:IEnumerable
{
    LinkedList<string> objList = new LinkedList<string>();
    public void StudentDetails()
    {
        objList.AddFirst("");
    }
}





namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
