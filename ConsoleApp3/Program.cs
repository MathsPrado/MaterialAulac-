using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa(33,12);
            Console.WriteLine(pessoa.Id);
        
            //pessoa.Id = 44;

            Cliente cliente = new Cliente()
            {
                Id = 23,
                Numero = 36
            };
            cliente.Id = 24;

            ContaCorrente contaCorrent1 = new ContaCorrente()
            {
                Nome = "Matheus",
                Numero= 12,
                NumeroContaCorrente= 22,
                Saldo=200
            };
            Console.WriteLine( contaCorrent1.Sacar(100));

            ContaPoupanca contaPoupanca = new ContaPoupanca()
            {
                Nome = "Matheus",
                Numero = 12,
                Saldo = 200
            };
            
            Console.WriteLine(contaPoupanca.Sacar(100));
            Console.ReadKey();
        }

        }
    }

