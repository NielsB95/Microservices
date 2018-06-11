using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Core
{
    public static class CoreSettings
    {
        private static IConfiguration _configuration;

        static CoreSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Settings.json");

            _configuration = builder.Build();
        }

        /// <summary>
        /// Gets the secret which will be used for authentication.
        /// </summary>
        /// <value>The secret.</value>
        public static string Secret
        {
            get
            {
                return _configuration["Authentication:Secret"];
            }
        }

        /// <summary>
        /// This connectionstring will tells us to what database we need to connect.
        /// </summary>
        /// <value>The connection string.</value>
        public static string ConnectionString
        {
            get
            {
                return _configuration["Database:ConnectionString"];
            }
        }
    }
}
