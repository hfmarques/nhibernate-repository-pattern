using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernate.Core.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public Hotel Hotel { get; set; }
        public List<Telefone> Telefones { get; set; }
        public Endereco Endereco { get; set; }
    }
}
