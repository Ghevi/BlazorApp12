using BlazorApp12.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddTransient<TestService>();
//builder.Services.AddScoped<TestService>();
builder.Services.AddSingleton<TestService>();

await builder.Build().RunAsync(); 
