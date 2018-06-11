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
        /// Gets the secret which will be used for authentication. No access modifier, because
        /// this key needs to stay within this library.
        /// </summary>
        /// <value>The secret.</value>
        static string Secret
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
