namespace NHibernate.Core.Models
{
    public class Quarto
    {
        public virtual int Id { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Cama { get; set; }
        public virtual bool Ocupado { get; set; }
        public virtual int Numero { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
