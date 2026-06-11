using System;

class Program
{
    static void Main()
    {
        decimal saldoDisponible = 5000.00m;
        decimal montoSolicitado;

        Console.WriteLine("Bienvenido al cajero automático.");
        Console.WriteLine("Su saldo disponible es: $" + saldoDisponible);
        Console.WriteLine("Ingrese el monto que desea retirar:");
        int.TryParse(Console.ReadLine(), out int montoSolicitadoInt);

        { if (montoSolicitadoInt <= 0)
            {
                Console.WriteLine("Monto inválido. Por favor, ingrese un monto positivo.");
                return;
            }
            else if (montoSolicitadoInt > saldoDisponible)
            {

                Console.WriteLine("Fondos insuficientes. No puede retirar más de su saldo disponible.");
                return;
            }
            else
            {
                montoSolicitado = montoSolicitadoInt;
                saldoDisponible -= montoSolicitado;
                Console.WriteLine("Retiro exitoso. Su nuevo saldo es: $" + saldoDisponible);
            }
        }
    }
}