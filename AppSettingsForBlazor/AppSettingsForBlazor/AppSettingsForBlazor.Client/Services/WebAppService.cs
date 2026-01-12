using System.Net.Http.Json;

namespace AppSettingsForBlazor.Client.Services
{
    public class WebAppService : IWebAppService
    {
        private readonly HttpClient _httpClient;

        public WebAppService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetAppSettingValueAsync(string key)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<string>($"/api/configuration/{key}");
                return result ?? "Key not found";
            }
            catch
            {
                return "Error retrieving configuration";
            }
        }

    }
}
