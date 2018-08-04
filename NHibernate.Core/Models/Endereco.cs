namespace NHibernate.Core.Models
{
    public class Endereco
    {
        public virtual int Id { get; set; }
        public virtual int Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Uf { get; set; }
        public virtual string Rua { get; set; }
    }
}
