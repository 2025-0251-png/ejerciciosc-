using System;

class program
{
    static void Main()
    {

        Console.WriteLine("ingrese un numero");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("el numero es par");
        }
        else
        {
            Console.WriteLine("el numero es impar.");
        }
    }
}
