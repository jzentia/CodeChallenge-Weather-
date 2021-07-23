using System.Threading.Tasks;
using Service.Weather.Client;
using Service.Weather.Interface;
using Service.Weather.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace CodeChallenge
{
    class Program
    {
        public static async Task Main(string[] args) =>
           await ConfigureServices(args).
                 GetService<App>().
                 RunAsync();

        /// <summary>
        /// Method on accessing the apihttp://api.weatherstack.com/
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static ServiceProvider ConfigureServices(string[] args)
        {
            var service = new ServiceCollection();

            service.AddHttpClient<ClientWeather>(a => a.BaseAddress = new System.Uri("http://api.weatherstack.com/"));
            service.AddTransient<IServiceWeather, ServiceWeather>();
            service.AddTransient<App>();
            
            return service.BuildServiceProvider();
        }
    }
}
