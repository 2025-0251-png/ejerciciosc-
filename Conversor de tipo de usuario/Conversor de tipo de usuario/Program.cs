Console.WriteLine("ingrese letra clave (A,E,U,L)");
string letra = Console.ReadLine();

switch (letra)

{
    case "A":
        Console.WriteLine("usted accede como Administrador tiene acceso a todo");
        break;
    case "E":
        Console.WriteLine("usted accede como Editor puede editar los proyectos");
        break;
    case "U":
        Console.WriteLine("usted accede como Autor puede redactar sus proyectos");
        break;
    case "L":
        Console.WriteLine("usted accede como Lector solo puede leer los proyectos");
        break;
    default:
        Console.WriteLine("usted accede como invitado");
        break;
    }
