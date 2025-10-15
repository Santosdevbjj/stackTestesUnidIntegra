using Xunit;
using Moq;
using VaquinhaOnline.Services;
using VaquinhaOnline.Repositories;
using VaquinhaOnline.Models;

namespace VaquinhaOnline.UnitTests.Services
{
    public class DonationServiceTests
    {
        private readonly DonationService _service;
        private readonly Mock<IDonationRepository> _repositoryMock;

        public DonationServiceTests()
        {
            _repositoryMock = new Mock<IDonationRepository>();
            _service = new DonationService(_repositoryMock.Object);
        }

        [Fact]
        public void Should_Add_Donation_When_Valid()
        {
            var donation = new Donation { Name = "Sergio", Amount = 100 };
            _service.ProcessDonation(donation);
            _repositoryMock.Verify(r => r.Add(donation), Times.Once);
        }

        [Fact]
        public void Should_Throw_Exception_When_Donation_Is_Null()
        {
            Assert.Throws<ArgumentNullException>(() => _service.ProcessDonation(null));
        }
    }
}
