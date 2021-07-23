using System.Threading.Tasks;
using Service.Weather.Interface;

namespace CodeChallenge
{
    class App
    {
        private readonly IServiceWeather _service;
        public App(IServiceWeather service)
        {
            _service = service;
        }

        public async Task RunAsync()
        {
            string zipCode = Result.InputZipCode();

            var response = await _service.GetWeatherDetailsByZipCodeAsync(zipCode);

            Result.GenerateResult(response);
        }
    }
}
