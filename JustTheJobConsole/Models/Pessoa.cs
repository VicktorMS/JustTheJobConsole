﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTheJobConsole.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set;}
        public string Cpf { get; set; }

    }
}
