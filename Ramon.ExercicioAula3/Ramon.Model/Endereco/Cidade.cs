using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon.Model
{
    public class Cidade
    {
        public int ID { get; set; }
        public UF UF { get; set; }
        public String Nome { get; set; }

        public override string ToString()
        {
            return Nome + " " + UF.ToString();
        }

    }
}
