using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon.Model
{
    public class Endereco
    {
        public int ID { get; set; }
        public Logradouro Logradouro { get; set; }
        public TipoEndereco Tipo { get; set; }

        public override string ToString()
        {
            return Tipo + " " + Logradouro.ToString();
        }
    }
}

