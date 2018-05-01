using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernate.Core.Models
{
    public class Quarto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Cama { get; set; }
        public bool Ocupado { get; set; }
        public int Numero { get; set; }
    }
}
