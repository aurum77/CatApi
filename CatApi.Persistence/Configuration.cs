using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Persistence
{
    public static class Configuration
    {
        public static string PostgreSQLConnectionString
        {
            get
            {
                ConfigurationManager configuration = new();
                configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CatApi.API/"));
                configuration.AddJsonFile("appsettings.json");

                return configuration.GetConnectionString("PostgreSQL")!;
            }
        }
    }
}
