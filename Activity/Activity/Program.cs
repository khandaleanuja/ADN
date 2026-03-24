//-----Activity 1-----
/*
using System;

class Program
{
    // Step 1: Declare delegate
    public delegate void MyDelegate();

    // Step 2: Create methods
    public static void Method1()
    {
        Console.WriteLine("Method 1 Executed");
    }

    public static void Method2()
    {
        Console.WriteLine("Method 2 Executed");
    }

    public static void Method3()
    {
        Console.WriteLine("Method 3 Executed");
    }

    static void Main(string[] args)
    {
        // Step 3: Create delegate instance
        MyDelegate del = Method1;

        // Step 4: Add multiple methods
        del += Method2;
        del += Method3;

        //Removing methods
        del -= Method2;
        

        // Step 5: Invoke delegate
        del();   // Calls Method1, Method2, Method3
    }
} */


//-----Activity 2-----
/*
using System;

class Program
{
    // Declare delegate
    public delegate void MyDelegate();

    static void Main(string[] args)
    {
        // Create delegate instance with lambda expressions
        MyDelegate del = () => Console.WriteLine("Lambda Method 1");

        del += () => Console.WriteLine("Lambda Method 2");
        del += () => Console.WriteLine("Lambda Method 3");

        // Invoke delegate
        del();
    }
}  */


//-----Activity 3-----
/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 4 };

        // Sort using lambda expression
        numbers.Sort((a, b) => a.CompareTo(b));

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
} */


//-----Activity 4-----
/*
 Q. Where we use deligates and lambda expressions in companines?
 Ans --> In companies, delegates and lambda expressions are mainly used for event handling, LINQ queries, asynchronous programming, middleware, and 
implementing callback methods.They help write clean, maintainable, and reusable code.
*/


//-----Activity 5-----
//LINQ is a.NET feature that allows querying collections and databases using SQL-like syntax directly in C#.
//It simplifies data manipulation and improves code readability.
//uses --->Filtering database records
// Sorting data
// Searching records
// Grouping data
// Working with APIs
// Reducing complex loops

//There are 2 ways to write LINQ queries:
//1. Query Syntax (SQL-like)
/*
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 5, 8, 3, 10 };

        var result = from n in numbers
                     where n > 5
                     select n;

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
} */

//2. Method Syntax (Most Used in Companies)

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 5, 8, 3, 10 };

        var result = numbers.Where(n => n > 5);

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}





