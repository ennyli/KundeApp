using System.Collections.Generic;

namespace KundeApp.Models
{
    public class Ordre
    {
        public int Id { get; set; }
        public string Dato { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual List<OrdreLinje> OrdreLinjer { get; set; }
    }
}
