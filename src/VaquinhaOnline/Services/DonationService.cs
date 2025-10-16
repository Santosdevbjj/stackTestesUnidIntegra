using VaquinhaOnline.Models;
using VaquinhaOnline.Repositories;

namespace VaquinhaOnline.Services
{
    public class DonationService : IDonationService
    {
        private readonly IDonationRepository _repository;

        public DonationService(IDonationRepository repository)
        {
            _repository = repository;
        }

        public void ProcessDonation(Donation donation)
        {
            if (donation == null)
                throw new ArgumentNullException(nameof(donation));

            _repository.Add(donation);
        }
    }
}
