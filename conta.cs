using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste.SistemaBanco
{ 
    public class Conta
    {
        public int Agencia {get; set;}
        public int NumeroConta { get; set;}
        public string NomeConta { get; set;}
        public Titular titular {get; set;}
        public decimal Saldo {get; set;}

        public decimal VerSaldo()
        {
            return Saldo;
        }
        public void Depositar(decimal valor)
        {
            Saldo += valor;    
        }
        public void Sacar(decimal valor)
        {
            if(valor <- Saldo)
                Saldo -= valor;
            else
                ConsoleTeste.WriteLine("Saque não pode ser realizado, pois não tem saldo suficiente");
        }
    }
}