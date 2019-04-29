using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
     class ContaCorrente : Conta
    {
        public int NumeroContaCorrente { get; set; }

        public override double Sacar(double valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
            return Saldo;
        }
    }
}
