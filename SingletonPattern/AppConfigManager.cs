using DesignPatterns.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    public class AppConfigManager
    {
        public AppSettings appSettingsData;
        public static AppConfigManager Instance => _instance;
        private static readonly AppConfigManager _instance = new();
        private AppConfigManager()
        {
            Console.WriteLine("Loading config... (this should only print ONCE)");
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            appSettingsData = new AppSettings();
            configuration.Bind(appSettingsData);
        }
        
    }
}
