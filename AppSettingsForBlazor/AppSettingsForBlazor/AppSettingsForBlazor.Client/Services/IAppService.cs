namespace AppSettingsForBlazor.Client.Services
{
    public interface IAppService
    {
        Task<string> GetAppSettingValueAsync(string key);
    }
}