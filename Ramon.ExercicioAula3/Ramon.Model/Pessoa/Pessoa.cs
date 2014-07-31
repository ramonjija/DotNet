using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon.Model
{
    public abstract class Pessoa
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }

        public abstract String GetNome();
    }
}
