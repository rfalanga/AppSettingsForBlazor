using AppSettingsForBlazor.Client.Services;
using Microsoft.AspNetCore.Components;

namespace AppSettingsForBlazor.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private string _configurationType = string.Empty;

        [Inject]
        private IAppService AppService { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            _configurationType = await AppService.GetAppSettingValueAsync("ServerSide:ConfigurationType");
        }

        private void IncrementCount()
        {
            currentCount++;
            Console.WriteLine($"Count incremented to: {currentCount}"); // I don't know if this was even necessary
        }
    }
}
