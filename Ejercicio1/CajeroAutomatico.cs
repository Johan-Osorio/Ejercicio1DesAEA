using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class CajeroAutomatico : CuentaBancaria
    {
        public CajeroAutomatico(string numeroCuenta, string titularCuenta, decimal saldoInicial, int pinSeguridad)
            : base(numeroCuenta, titularCuenta, saldoInicial, pinSeguridad)
        {
        }
        public override void Retirar(decimal cantidad, int pin)
        {
            base.Retirar(cantidad, pin);
        }
    }
}
