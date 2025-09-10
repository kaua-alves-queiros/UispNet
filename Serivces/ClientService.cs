using System.Net;
using System.Text;
using System.Text.Json;
using UispNet.ViewModels;

namespace UispNet.Services;

public partial class UispNetService
{
    public async Task<HttpStatusCode> AddClientService(string id, AddServiceToClientViewModel service)
    {
        try
        {
            var route = "clients/" + id + "/services";
            var response = await _httpClient.PostAsync(route,
                new StringContent(JsonSerializer.Serialize(service), Encoding.UTF8, "application/json"));
            return response.StatusCode;
        }
        catch
        {
            return HttpStatusCode.BadRequest;
        }
    }

    public async Task<HttpStatusCode> UpdateService(string id, UpdateServiceViewModel service)
    {
        try
        {
            var route = "clients/services/" + id;
            var response = await _httpClient.PatchAsync(route,
                new StringContent(JsonSerializer.Serialize(service), Encoding.UTF8, "application/json"));
            return response.StatusCode;
        }
        catch
        {
            return HttpStatusCode.BadRequest;
        }
    }

    public async Task<ServiceViewModel?> GetClientService(string id)
    {
        try
        {
            var route = "clients/services?clientId=" + id;
            var response = await _httpClient.GetAsync(route);
            var content = await response.Content.ReadAsStringAsync();
            var serivces = JsonSerializer.Deserialize<List<ServiceViewModel>>(content);
            return serivces?.First();
        }
        catch
        {
            return null;
        }
    }
}