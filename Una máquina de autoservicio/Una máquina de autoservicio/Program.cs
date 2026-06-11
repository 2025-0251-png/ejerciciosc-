Console.WriteLine("seleccione el tipo de bebida que desea 1: Café, 2: Té, 3: Chocolate, 4: Capuchino");
string bebida = Console.ReadLine();

switch (bebida)
{ 
    case "1":
        Console.WriteLine("Has seleccionado Café - costo 100$");
        break;
    case "2":
        Console.WriteLine("Has seleccionado Té - costo 60$");
        break;
    case "3":
        Console.WriteLine("Has seleccionado Chocolate - costo 75$ ");
        break;
    case "4":
        Console.WriteLine("Has seleccionado Capuchino - costo 120$ ");
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}
