// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Drawing;
using Pastel;

// Console.WriteLine("Hello, Owais!".Pastel(Color.Aqua));


// A method can use memebers of class but function cannot use members of class

//Calculator class
public class Calculator
{
    public static int number1;
    public static int number2;

    public static int Add()

    {
        return number1 + number2;
    }
 public static void DisplayNumbers()
     {
       for (int a = 0; a <= 20; a++)
        {
            Console.WriteLine(a);         }
    }
    static void Main(string[] args)
    {
        number1 = 34;
        number2 = 45;
        int result = Add();
        DisplayNumbers();
    
        Console.WriteLine("The result is " + result);
    }

}

// For loop

// public class NumberDisplay()
// {

//     public static void DisplayNumbers()
//     {
//         for (int a = 0; a <= 20; a++)
//         {
//             Console.WriteLine(a);
//         }
//     }
//     static void Main(string[] args)
//     {
//         DisplayNumbers();
//     }

// }


