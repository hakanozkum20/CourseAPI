using Microsoft.Extensions.Configuration;

namespace CourseAPI.Persistence;

static class Configuration
{
    public static string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/CourseAPI.Api"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("MySQLConnectionString");
        }
    }
}