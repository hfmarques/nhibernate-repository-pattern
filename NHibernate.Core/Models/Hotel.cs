using System.Collections.Generic;

namespace NHibernate.Core.Models
{
    public class Hotel
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual IList<Quarto> Quartos { get; set; }
    }
}
