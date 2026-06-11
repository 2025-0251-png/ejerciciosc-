Console.WriteLine("escriba el mes que necesite");
string mes = Console.ReadLine();

switch (mes)
{
    case "diciembre":
    case "enero":
    case "febrero":
        Console.WriteLine("estamos en invierno");
        break;
    case "marzo":
    case "abril":
    case "mayo":
        Console.WriteLine("estamos en primavera");
        break;
    case "junio":
    case "julio":
    case "agosto":
        Console.WriteLine("estamos en verano");
        break;
    case "septiembre":
    case "octubre":
    case "noviembre":
        Console.WriteLine("estamos en otoño");
        break;
    default:
        Console.WriteLine("mes no valido");
        break;
}