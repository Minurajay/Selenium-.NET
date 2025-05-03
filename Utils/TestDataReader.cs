using Microsoft.Extensions.Configuration;
using System.IO;

namespace TestProject1.Utilities
{
    public static class TestDataReader
    {
        private static readonly IConfigurationRoot Configuration;

        static TestDataReader()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        // Fix possible null return by returning a default value if the key is not found
        public static string Get(string key)
        {
            return Configuration[key] ?? string.Empty; // Return an empty string if the key is not found
        }
    }
}
