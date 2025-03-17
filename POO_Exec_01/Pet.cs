using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Exec_01
{
    public class Pet
    {
        // Atributos 
        public string nome;
        public int idade;
        public string tipo;

        // Métodos
        public void alimentarSe()
        {
            Console.WriteLine($"{nome} está se alimentando");
        }

        public virtual void emiteSom()
        {
            Console.WriteLine($"{nome} está emitindo um som....");
        }
    }
}
