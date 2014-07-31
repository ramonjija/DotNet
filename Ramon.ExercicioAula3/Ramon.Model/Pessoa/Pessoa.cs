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
        public int IDTelefone { get; set; } //Publica ou privada?
        public int IDEndereco { get; set; }
    }
}
