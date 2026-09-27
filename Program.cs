using DesignPatterns.SingletonPattern;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfiguration configuration = builder.Build();

var config1 = AppConfigManager.Instance;
var config2 = AppConfigManager.Instance;

Console.WriteLine(config1.appSettingsData.ConnectionStrings.LocalDB);
Console.WriteLine(config2.appSettingsData.ConnectionStrings.LocalDB);
Console.WriteLine($"Same instance? {ReferenceEquals(config1, config2)}");