using System.Collections.Generic;
using VaquinhaOnline.Models;

namespace VaquinhaOnline.Repositories
{
    public interface IDonationRepository
    {
        void Add(Donation donation);
        IEnumerable<Donation> GetAll();
    }
}
