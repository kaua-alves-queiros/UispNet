using System.Net;
using System.Text;
using System.Text.Json;
using UispNet.ViewModels;

namespace UispNet.Services
{
    public partial class UispNetService
    {
        public async Task<List<ClientViewModel>?> GetAllClientsAsync()
        {
            try
            {
                const string route = "clients";
                var response = await _httpClient.GetAsync(route);
                var content = await response.Content.ReadAsStringAsync();
                var clients = JsonSerializer.Deserialize<List<ClientViewModel>>(content);
                
                return clients;
            }
            catch
            {
                return null;
            }
        }

        public async Task<ClientViewModel?> CreateClientAsync(CreateOrUpdateClientViewModel client)
        {
            try
            {
                const string route = "clients";
                var response = await _httpClient.PostAsync(route,
                    new StringContent(JsonSerializer.Serialize(client), Encoding.UTF8, "application/json"));
                var content = await response.Content.ReadAsStringAsync();
                ClientViewModel? createdClient = JsonSerializer.Deserialize<ClientViewModel>(content);

                return createdClient;
            }
            catch
            {
                return null;
            }
        }

        public async Task<ClientViewModel?> UpdateClientAsync(string id, CreateOrUpdateClientViewModel client)
        {
            try
            {
                var route = "clients/" + id;
                var response = await _httpClient.PatchAsync(route,
                    new StringContent(JsonSerializer.Serialize(client), Encoding.UTF8, "application/json"));
                var content = await response.Content.ReadAsStringAsync();
                ClientViewModel? updatedClient = JsonSerializer.Deserialize<ClientViewModel>(content);
                return updatedClient;
            }
            catch
            {
                return null;
            }
        }

        public async Task<HttpStatusCode> DeleteClientAsync(string id)
        {
            try
            {
                var route = "clients/" + id;
                var response = await _httpClient.DeleteAsync(route);
                return response.StatusCode;
            }
            catch
            {
                return HttpStatusCode.BadRequest;
            }

        }
    }
}
