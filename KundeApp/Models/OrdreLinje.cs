namespace KundeApp.Models
{
    public class OrdreLinje
    {
        public int Id { get; set; }
        public int Antall { get; set; }
        public string Name { get; set; }

        public virtual Vare Vare { get; set; }
        public virtual Ordre Ordre { get; set; }
    }
}
