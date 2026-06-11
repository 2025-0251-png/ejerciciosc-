
Console.WriteLine("INGRESE SU NOMBRE");
string nombre = Console.ReadLine();

Console.WriteLine("ingrese su edad"); 
int edad = int.Parse(Console.ReadLine());

if (edad >= 18)

Console.WriteLine("Usted es mayor de edad, biemvenido sr/a " + nombre);

else
    Console.WriteLine("Usted es menor de edad, lo siento");

