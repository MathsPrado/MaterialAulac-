using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public int Numero { get; set; }
        public Pessoa(int id , int numero)
        {
            Id = id;
            Numero = numero;

        }
    }
}
