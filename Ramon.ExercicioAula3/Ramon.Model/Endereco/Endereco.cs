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
        public int IDLogradouro { get; set; }
        public TipoEndereco Tipo { get; set; }
        public String Nome { get; set; }
        public int Numero { get; set; }
    }
}

