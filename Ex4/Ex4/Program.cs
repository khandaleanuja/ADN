using System;

class Program
{
    // Delegate declaration
    delegate void MyDelegate(string name);

    // Method
    static void SayHello(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void Main()
    {
        // Delegate object
        MyDelegate d = SayHello;

        // Calling delegate
        d("Anuja");
    }
}
