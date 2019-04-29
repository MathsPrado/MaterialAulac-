using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ContaPoupanca : Conta
    {
        public override double Sacar(double valor)
        {
            valor = valor * 1.1;
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
            return Saldo;
        }
    }
}
