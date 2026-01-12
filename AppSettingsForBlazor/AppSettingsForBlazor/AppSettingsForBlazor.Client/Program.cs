using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection; // Add this using directive
using AppSettingsForBlazor.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register HTTP Client Factory
//builder.Services.AddHttpClient();

// Register IWebAppService for the WebAssembly client
builder.Services.AddScoped<IWebAppService, WebAppService>();

await builder.Build().RunAsync();
