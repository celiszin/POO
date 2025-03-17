using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07_ContaBancaria
{
    public class ContaGenerica
    {
        // Propriedades da classe
        public int Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        private double Saldo;

        // Métodos da classe
        public void depositar(double valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;     //Saldo = Saldo + valor;
                Console.WriteLine($"Depósito realizado com sucesso: R$ {valor}");
            }
            else
                Console.WriteLine($"Valor inválido! O depósito não foi realizado.");                
        }

        public virtual void sacar(double valor)
        {
            if ((valor <= Saldo) && (valor >= 0))
            {
                Saldo -= valor;     //Saldo = Saldo - valor;
                Console.WriteLine($"Saque realizado com sucesso: R$ {valor}");
            }
            else
                Console.WriteLine($"Valor inválido! O saque não foi realizado.");
        }

        public virtual void mostrarConta()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine($"Banco: {Banco}\tAgência: {Agencia}\tConta: {Conta}");
            Console.WriteLine($"Saldo: R$ {Saldo}");
            Console.WriteLine("==============================================");
        }

        public double getSaldo()
        {
            return Saldo;
        }

        public void setSaldo(double valor)
        {
            Saldo = valor;
        }

    }
}
