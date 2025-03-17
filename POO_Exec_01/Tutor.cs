using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Exec_01
{
    public class Tutor
    {
        public string nome;
        private double creditos;

        public void setCreditos(double creditos)
        {
            if (creditos >= 0)
                this.creditos = creditos;
        }

        public double getCreditos()
        {
            return this.creditos;
        }
    }
}
