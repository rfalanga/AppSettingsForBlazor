namespace AppSettingsForBlazor.Client.Services
{
    public class WebAppService : IWebAppService
    {
        private readonly ILogger<WebAppService> _logger;
        //private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _configuration;
        // private readonly IOptionsMonitor<AppSettings> _appSettings;  // Example of using IOptionsMonitor for configuration settings, but the blog I'm following doesn't use it.

        public WebAppService(ILogger<WebAppService> logger, IConfiguration configuration)
        {
            _logger = logger;
            //_clientFactory = clientFactory;
            _configuration = configuration;
        }

        public async Task<string> GetAppSettingValueAsync(string key)
        {
            return _configuration[key] ?? "Key not found";
        }

    }
}
