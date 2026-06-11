Console.WriteLine("seleccione el tipo de opercion que desea realizar (suma, resta, multiplicacion,division):");
string operacion = Console.ReadLine().ToLower();



switch (operacion)
{
    case "suma" :
        Console.WriteLine("ingrese el primer numero");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"el resultado de la suma es: {num1 + num2}");
        break;
    case "resta":
        Console.WriteLine("ingrese el primer numero");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero");
        int num4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"el resultado de la resta es: {num3 - num4}");
        break;
    case "multiplicacion":
        Console.WriteLine("ingrese el primer numero");
        int num5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero");
        int num6 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"el resultado de la multiplicacion es: {num5 * num6}");
        break;
    case "division":
        Console.WriteLine("ingrese el primer numero");
        int num7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero");
        int num8 = Convert.ToInt32(Console.ReadLine());
        if (num8 != 0)
            Console.WriteLine($"el resultado de la division es: {num7 / num8}");
        else
            Console.WriteLine("no se puede dividir entre cero");
        break;
    default:
        Console.WriteLine("operacion no valida");
        break;
}
