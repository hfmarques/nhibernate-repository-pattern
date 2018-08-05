namespace NHibernate.Core.Dto
{
    public class QuartoDto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Cama { get; set; }
        public bool Ocupado { get; set; }
        public int Numero { get; set; }
        public HotelDto Hotel { get; set; }
    }
}
