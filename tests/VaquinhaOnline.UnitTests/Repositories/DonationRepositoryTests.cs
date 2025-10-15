using Xunit;
using VaquinhaOnline.Repositories;
using VaquinhaOnline.Models;
using System.Collections.Generic;

namespace VaquinhaOnline.UnitTests.Repositories
{
    public class DonationRepositoryTests
    {
        private readonly DonationRepository _repository;

        public DonationRepositoryTests()
        {
            _repository = new DonationRepository(); // Simulação em memória
        }

        [Fact]
        public void Should_Store_Donation()
        {
            var donation = new Donation { Name = "Sergio", Amount = 50 };
            _repository.Add(donation);
            var allDonations = _repository.GetAll();
            Assert.Contains(donation, allDonations);
        }

        [Fact]
        public void Should_Return_Empty_List_When_No_Donations()
        {
            var donations = _repository.GetAll();
            Assert.Empty(donations);
        }
    }
}
