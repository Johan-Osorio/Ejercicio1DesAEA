// See https://aka.ms/new-console-template for more information
using Ejercicio1;
CajeroAutomatico cuenta = new CajeroAutomatico("310503", "Johan Osorio", 1075, 3118);
while (true)
{
    Console.WriteLine("Bienvenido al Cajero Automático");
    Console.WriteLine("1. Consultar Saldo");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Retirar");
    Console.WriteLine("4. Cambiar PIN");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            cuenta.ConsultarSaldo();
            break;
        case "2":
            Console.Write("Ingrese la cantidad a depositar: ");
            decimal cantidadDeposito = Convert.ToDecimal(Console.ReadLine());
            cuenta.Depositar(cantidadDeposito);
            break;
        case "3":
            Console.Write("Ingrese la cantidad a retirar: ");
            decimal cantidadRetiro = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el PIN de seguridad: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            cuenta.Retirar(cantidadRetiro, pin);
            break;
        case "4":
            Console.Write("Ingrese el PIN actual: ");
            int pinActual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nuevo PIN: ");
            int nuevoPin = Convert.ToInt32(Console.ReadLine());
            cuenta.CambiarPin(pinActual, nuevoPin);
            break;
        case "5":
            Console.WriteLine("Gracias por utilizar el Cajero Automático");
            return;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
    Console.WriteLine();
}

