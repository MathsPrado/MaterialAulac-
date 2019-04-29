namespace ConsoleApp3
{
    abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public string Nome { get; set; }

        public abstract double Sacar(double valor);
        
    }
}
