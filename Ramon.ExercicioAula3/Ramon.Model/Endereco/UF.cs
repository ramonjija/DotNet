﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon.Model
{
    public class UF
    {
        public int ID { get; set; }
        public String Sigla { get; set; }

        public override string ToString()
        {
            return this.Sigla;
        }

    }
}
