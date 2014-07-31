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
        public Bairro Bairro { get; set; }
        public TipoLogradouro Tipo { get; set; }
        public String Nome { get; set; }
        public int Numero { get; set; }

        public override string ToString()
        {
            return Tipo +" "+ Nome +" nº "+ Numero + Bairro.ToString();
        }
    }
}
