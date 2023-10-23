using FinTrack.Models.Clients;
using FinTrack.Services.Interfaces;

namespace FinTrack.Services
{
    public class BasicClientService : IBasicClientService
	{
        private readonly HttpClient _httpClient;

        public BasicClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IList<BasicClient> BasicClients { get; set; } = new List<BasicClient>();

        public BasicClient BasicClientSelected { get; set; } = new BasicClient();

        public async Task GetBasicClientsAsync()
        {
            if (BasicClients.Count == 0)
            {
                var response = await _httpClient.GetFromJsonAsync<IList<BasicClient>>("/api/BasicClient");
                if (response != null)
                {
                    BasicClients = response;
                }
            }
        }

        public async Task GetSingleBasicClientAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<BasicClient>($"/api/BasicClient/{id}");
            if (response != null)
            {
                BasicClientSelected = response;
            }
        }

        public async Task<int> PostBasicClientAsync(BasicClient profile)
        {
            var response = await _httpClient.PostAsJsonAsync($"/api/BasicClient", profile);
            if (response.IsSuccessStatusCode)
            {
                return 0;
            }
            return 1;
        }
    }
}

