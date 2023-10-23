using FinTrack.Models.Clients;

namespace FinTrack.Services.Interfaces
{
	public interface IBasicClientService
	{
        BasicClient BasicClientSelected { get; }
        IList<BasicClient> BasicClients { get; }
        Task GetBasicClientsAsync();
        Task GetSingleBasicClientAsync(int id);
        Task<int> PostBasicClientAsync(BasicClient profile);
    }
}

