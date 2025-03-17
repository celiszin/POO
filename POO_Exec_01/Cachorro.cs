using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Exec_01
{
    public class Cachorro : Pet
    {
        public override void emiteSom()
        {
            Console.WriteLine($"{nome} está latindo.. au au au");
        }
    }
}
