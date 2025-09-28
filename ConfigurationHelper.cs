using Microsoft.Extensions.Configuration;
using System.IO;

namespace BudgetBook
{
    internal static class ConfigurationHelper
    {
        private static IConfigurationRoot configuration;

        static ConfigurationHelper()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
        }

        public static string GetCsvPath()
        {
            var csvPath = configuration["Export:CsvPath"];
            // ê‚ëŒÉpÉXÇ…ïœä∑ÇµÇƒï‘Ç∑
            return Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), csvPath));
        }
    }
}