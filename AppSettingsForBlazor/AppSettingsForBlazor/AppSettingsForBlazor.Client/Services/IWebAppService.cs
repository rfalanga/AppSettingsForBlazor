
namespace AppSettingsForBlazor.Services
{
    public interface IWebAppService
    {
        Task<string> GetAppSettingValueAsync(string key);
    }
}