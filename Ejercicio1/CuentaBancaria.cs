using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class CuentaBancaria
    {
        public string NumeroCuenta { get; set; }
        public string TitularCuenta { get; set; }
        public decimal Saldo { get; set; }
        public int PinSeguridad { get; set; }
        public CuentaBancaria(string numeroCuenta, string titularCuenta, decimal saldoInicial, int pinSeguridad)
        {
            NumeroCuenta = numeroCuenta;
            TitularCuenta = titularCuenta;
            Saldo = saldoInicial;
            PinSeguridad = pinSeguridad;
        }
        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine("Depósito exitoso: {0:C}", Saldo);
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser mayor que cero.");
            }
        }
        public virtual void Retirar(decimal cantidad, int pin)
        {
            if (cantidad > 0)
            {
                if (pin == PinSeguridad)
                {
                    if (Saldo >= cantidad)
                    {
                        Saldo -= cantidad;
                        Console.WriteLine("Retiro exitoso {0:C}", Saldo);
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente.");
                    }
                }
                else
                {
                    Console.WriteLine("PIN incorrectO.");
                }
            }
            else
            {
                Console.WriteLine("La cantidad a retirar debe ser mayor que cero.");
            }
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo actual: {0:C}", Saldo);
        }
        public void CambiarPin(int pinActual, int nuevoPin)
        {
            if (pinActual == PinSeguridad)
            {
                if (nuevoPin != PinSeguridad)
                {
                    PinSeguridad = nuevoPin;
                    Console.WriteLine("PIN cambiado exitosamente.");
                }
                else
                {
                    Console.WriteLine("El nuevo PIN no puede ser igual al PIN actual.");
                }
            }
            else
            {
                Console.WriteLine("PIN actual incorrecto. No se pudo cambiar el PIN.");
            }
        }

    }
}
