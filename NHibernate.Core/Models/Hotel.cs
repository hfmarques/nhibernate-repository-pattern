using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernate.Core.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Pessoa> Pessoas { get; set; }
        public List<Telefone> Telefones { get; set; }
        public Endereco Endereco { get; set; }
        public List<Quarto> Quartos { get; set; }
    }
}
