using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernate.Core.Models
{
    public class Cliente : Pessoa
    {
        public int QuantidadeOcupacoes { get; set; }
        public List<Reserva> Reservas { get; set; }
    }
}
