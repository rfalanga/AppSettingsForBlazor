
namespace AppSettingsForBlazor.Services
{
    public interface IAppService
    {
        Task<string> GetAppSettingValueAsync(string key);
    }
}