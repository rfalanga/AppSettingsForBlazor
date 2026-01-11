
namespace AppSettingsForBlazor.Client.Services
{
    public interface IWebAppService
    {
        Task<string> GetAppSettingValueAsync(string key);
    }
}