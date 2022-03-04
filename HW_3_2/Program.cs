// See https://aka.ms/new-console-template for more information

using HW_3;

internal class Program
{
    public static void Main()
    {

        Console.WriteLine("x = " + new RomanNumber(20) + " y = " + new RomanNumber(10));
        Console.WriteLine("x + y = " + (new RomanNumber(20) + new RomanNumber(10)));
        Console.WriteLine("x - y = " + (new RomanNumber(20) - new RomanNumber(10)));
        Console.WriteLine("x * y = " + (new RomanNumber(20) * new RomanNumber(10)));
        Console.WriteLine("x / y = " + (new RomanNumber(20) / new RomanNumber(10)));
        RomanNumber[] romanNumberArray = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            romanNumberArray[i] = new RomanNumber((ushort)(new Random().Next(1, 1000)));
            Console.Write(romanNumberArray[i] + " ");
        }
        Console.WriteLine();

        Array.Sort(romanNumberArray);

        for (int i = 0; i < 10; i++)
        {
            Console.Write(romanNumberArray[i] + " ");
        }
    }
}