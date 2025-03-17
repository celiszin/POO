using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07_ContaBancaria
{
    public class ContaCorrente : ContaGenerica
    {
        public double Limite { get; set; }

        public override void sacar(double valor)
        {
            if ((valor <= getSaldo() + Limite) && (valor >= 0))
            {
                double auxSaldo = getSaldo();
                auxSaldo -= valor;
                setSaldo(auxSaldo);                
                Console.WriteLine($"Saque realizado com sucesso: R$ {valor}");
            }
            else
                Console.WriteLine($"Valor inválido! O saque não foi realizado.");
        }

        public override void mostrarConta()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine($"Banco: {Banco}\tAgência: {Agencia}\tConta: {Conta}");
            Console.WriteLine($"Saldo: R$ {getSaldo()} + Limite: R$ {Limite} = Disponível: R$ {getSaldo()+Limite}");
            Console.WriteLine("==============================================");
        }
    }
}
