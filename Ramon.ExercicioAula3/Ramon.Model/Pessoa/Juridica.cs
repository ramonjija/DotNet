﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon.Model
{
    public class Juridica : Pessoa
    {
        public String CNPJ { get; set; }
        public String IE { get; set; }
        public String RazaoSocial { get; set; }

        public override string GetNome()
        {
            return this.Nome;
        }
    }
}
