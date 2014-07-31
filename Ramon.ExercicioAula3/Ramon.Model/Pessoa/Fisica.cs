using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon.Model
{
    public class Fisica : Pessoa
    {
        public String CPF { get; set; }
        public String RG { get; set; }
        public String Sobrenome { get; set; }
        public int Idade { get; set; }


        public override string GetNome()
        {
            return this.Nome + " " + this.Sobrenome;
        }
    }
}
