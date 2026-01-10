using AppSettingsForBlazor.Services;

namespace AppSettingsForBlazor.Components.Pages
{
    public partial class Home
    {
        private string _configurationType;
        private IAppService _appService;

        protected override async Task OnInitializedAsync()
        {
            _configurationType = await _appService.GetAppSettingValueAsync("ServerSide:ConfigurationType");
        }
    }
}
