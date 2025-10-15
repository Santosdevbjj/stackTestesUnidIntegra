using Xunit;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using VaquinhaOnline;

namespace VaquinhaOnline.IntegrationTests.Controllers
{
    public class DonationControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public DonationControllerTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Get_Donations_Should_Return_OK()
        {
            var response = await _client.GetAsync("/donations");

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            Assert.Contains("Doações", content);
        }

        [Fact]
        public async Task Post_Donation_Should_Redirect()
        {
            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("Name", "Sergio"),
                new KeyValuePair<string, string>("Amount", "100")
            });

            var response = await _client.PostAsync("/donations", formData);

            Assert.Equal(System.Net.HttpStatusCode.Redirect, response.StatusCode);
        }
    }
}
