using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernate.Core.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public int QuantidadeDias { get; set; }
        public Quarto Quarto { get; set; }
    }
}
