namespace UispNet.Services;

public partial class UispNetService
{
    private HttpClient _httpClient = new HttpClient();
    
    public void Setup(string host, string appKey)
    {
        _httpClient.BaseAddress = new Uri(host);
        _httpClient.DefaultRequestHeaders.Add("X-Auth-App-Key", appKey);
    }
}