using System.Collections.Generic;
using VaquinhaOnline.Models;

namespace VaquinhaOnline.Repositories
{
    public class DonationRepository : IDonationRepository
    {
        private readonly List<Donation> _donations = new();

        public void Add(Donation donation)
        {
            _donations.Add(donation);
        }

        public IEnumerable<Donation> GetAll()
        {
            return _donations;
        }
    }
}
