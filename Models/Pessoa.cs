using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        
        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }
}