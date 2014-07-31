using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon.Model
{
    public class Bairro
    {
        public int ID { get; set; }
        public Cidade Cidade { get; set; }
        public String Nome { get; set; }

        public override string ToString()
        {
            return Nome + Cidade.ToString();
        }
    }
}
