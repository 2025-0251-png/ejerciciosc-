Console.WriteLine("ingrese temperatura");
int temperatura = int.Parse(Console.ReadLine());

if (temperatura <= 15)
{
    Console.WriteLine("esta haciendo frio");
}
if (temperatura >= 15 && temperatura <= 28) 
{
    Console.WriteLine("el clima esta templado");
}
if (temperatura >= 28)
{
    Console.WriteLine("esta haciendo calor");
}