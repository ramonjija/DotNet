using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon.Model
{
    public class Logradouro
    {
        //TODO: definir enum de logradouro
        public int ID { get; set; }
        public int IDBairro { get; set; }
        public TipoLogradouro Tipo { get; set; }
        public String Nome { get; set; }
    }
}
