using AppSettingsForBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace AppSettingsForBlazor.Components.Pages
{
    public partial class Home
    {
        private string _configurationType;

        [Inject]
        private IAppService _appService { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            _configurationType = await _appService.GetAppSettingValueAsync("ServerSide:ConfigurationType");
        }
    }
}
