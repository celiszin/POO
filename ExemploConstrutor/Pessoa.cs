using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutor
{
    internal class Pessoa
    {
        // Propriedades (atributos) da classe
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Métodos (comportamentos / ações) da classe
        public Pessoa(string pNome, int pIdade)
        {
            Nome = pNome;
            Idade = pIdade;
        }

        public Pessoa(string pNome)
        {
            Nome = pNome;
        }

        public Pessoa() { }

        public void apresentarSe()
        {
            string f1 = $"Olá, meu nome é {Nome}";
            string f2 = "";

            if (Idade > 0)
                f2 = $" e eu tenho {Idade} anos.";
            else
                f2 = " e a minha idade não é da sua conta.";

            Console.WriteLine(f1 + f2);
        }
    }
}
