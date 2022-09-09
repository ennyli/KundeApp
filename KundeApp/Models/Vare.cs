using System.Collections.Generic;

namespace KundeApp.Models
{
    public class Vare
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }

        public virtual List<OrdreLinje> OrdreLinjer { get; set; }
    }
}
