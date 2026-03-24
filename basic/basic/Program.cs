using System;

/* namespace HelloWorld
{
    class basic
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");

            //Console.WriteLine(3 + 3);

            //Console.Write("Hello World!");
            //Console.WriteLine("I will print on the same line");


            //Variables
            /*int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);  */



//Constant
/* const int num = 15;
//num = 20;  error
Console.WriteLine(num); */


//string name = "Anuja";
//Console.WriteLine("Hello " + name);


/* float f1 = 32e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);  */


//Type casting
/*  int myInt = 10;
double myDouble = myInt;
Console.WriteLine(myInt);
Console.WriteLine(myDouble);

myDouble = 10.5;
int myInt1 = (int)myDouble;
Console.WriteLine(myInt1);
Console.WriteLine(myDouble);

Console.WriteLine(Convert.ToString(myDouble));
Console.WriteLine(Convert.ToInt32(myDouble));
Console.WriteLine(Convert.ToBoolean(myDouble));   */



//User inputs
/*
Console.Write("Enter username : ");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);

Console.Write("Enter age : ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is : " + age);   */


//Operators
/* int a = 20;
int b = 30;
Console.WriteLine("a : " + a + ", b : " + b);
Console.WriteLine("Addition : " + (a + b));
Console.WriteLine("Subtraction : " + (a - b));
Console.WriteLine("Division : " + (a / b));
Console.WriteLine("Multiplication : " + (a * b));
Console.WriteLine("Increment : " + a++);
Console.WriteLine("Decrement : " + b--); */


//Assignment operators
/* int x = 5;
Console.WriteLine(x += 3);
Console.WriteLine(x -= 3);
Console.WriteLine(x *= 3);
Console.WriteLine(x /= 3);
Console.WriteLine(x %= 3);
Console.WriteLine(x &= 3);
Console.WriteLine(x |= 3);
Console.WriteLine(x ^= 3);
Console.WriteLine(x >>= 3);
Console.WriteLine(x <<= 3);  */


//Comparision operators
/*
int x = 5;
int y = 3;
Console.WriteLine(x == y);
Console.WriteLine(x != y);
Console.WriteLine(x > y);
Console.WriteLine(x < y );
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);  */


//Logical operators
/* int x = 5;
int y = 8;
Console.WriteLine(x < 5 && x < 10);
Console.WriteLine(x < 5 || x < 4);
Console.WriteLine(!(x < 5 && x < 10)); */


//Math
/* Console.WriteLine(Math.Max(5, 10));
Console.WriteLine(Math.Min(5, 10));
Console.WriteLine(Math.Sqrt(64));
Console.WriteLine(Math.Abs(-4.7));
Console.WriteLine(Math.Round(9.99)); */


//String
/* string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

string txt1 = "Hello World";
Console.WriteLine(txt1.ToUpper());   
Console.WriteLine(txt1.ToLower()); */


//Concate
/* string firstName = "John ";
string lastName = "Doe";
string name = string.Concat(firstName, lastName);
Console.WriteLine(name); */


//Interpolation
/* string firstName = "Anujas";
string lastName = "Khandale";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name); */

//Access string
/*  string myString = "Hello";
Console.WriteLine(myString[0]);
Console.WriteLine(myString.IndexOf("e"));

string name = "John Doe";
int charPos = name.IndexOf("D");
string lastName = name.Substring(charPos);
Console.WriteLine(lastName);    */


//Bool
/*  int myAge = 25;
int votingAge = 18;

if (myAge >= votingAge)
{
    Console.WriteLine("Old enough to vote!");
}
else
{
    Console.WriteLine("Not old enough to vote.");
}  */



//if-else
/* int time = 22;
if (time < 10)
{
    Console.WriteLine("Good morning.");
}
else if (time < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}  */

/* int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);  */



//Switch
/* int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
} */



//While loop
/* int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}  */

//Do while loop
/*  int i = 0;
do 
{
  Console.WriteLine(i);
  i++;
}
while (i < 5);  */


//For loop
/* for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
} */


//For each loop
/* string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
Console.WriteLine(i);
}*/



//break
/* for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
} */


//Continue
/* for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
} */


//Arrays
/*
// Create an array of four elements, and add values later
string[] cars = new string[4];

// Create an array of four elements and add values right away 
string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

// Create an array of four elements without specifying the size 
string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };   */

/*
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string i in cars)
{
    Console.WriteLine(i);
}  */

/*
int[] myNumbers = { 5, 1, 8, 9 };
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
    Console.WriteLine(i);
}  */


//Multi-dimensional
/* int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

Console.WriteLine(numbers[0, 2]);



for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.WriteLine(numbers[i, j]);
    }
}  */


namespace ConsoleAppExample
{
    // Step 1: Define a class
    class Student
    {
        // Data members
        public string name;
        public int age;

        // Method to get student details
        public void GetDetails()
        {
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        // Method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Create object of class
            Student s1 = new Student();

            // Step 3: Access class methods
            s1.GetDetails();
            s1.DisplayDetails();

            Console.ReadLine();
        }
    }
}