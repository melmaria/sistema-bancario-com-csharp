using Console.SistemaBanco;
using System;

namespace ConsoleTeste
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conta = new conta();
            conta.NomeConta = "Conta Teste";
            conta.NomeConta = 1000;
            conta.Agencia = 001;

            conta.Titular = new Titular()
            {
                CPF = "52542506875",
                RG = "2584156",
                Endereço = "Rua caxias",
                Nome = "Joao"
            };
            
            Console.WriteLine($"O saldo atual é:, {conta.VerSaldo}"());
           
            conta.Depositar(150);
            
            Console.WriteLine($"O saldo atual, após o deposito é:,  {conta.VerSaldo()}");
            
            conta.Sacar(900);
            
            Console.WriteLine($"O saldo atual, após o saque é, {conta.VerSaldo()}");
            
            conta.Sacar(2000);

            ConsoleTeste.ReadKey();

        }
    }
}