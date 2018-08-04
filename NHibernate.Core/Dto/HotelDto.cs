using System.Collections.Generic;

namespace NHibernate.Core.Dto
{
    public class HotelDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public EnderecoDto Endereco { get; set; }
        public List<QuartoDto> Quartos { get; set; }
    }
}
