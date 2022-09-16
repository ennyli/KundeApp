using KundeApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KundeApp.DAL
{
    public interface IKundeRepository
    {
        Task<bool> Opprett(Kunde innKunde);
        Task<List<Kunde>> HentAlle();
        Task<bool> Slett(int id);
        Task <Kunde> HentEn(int id);
        Task<bool> Endre(Kunde endreKunde);


    }
}
