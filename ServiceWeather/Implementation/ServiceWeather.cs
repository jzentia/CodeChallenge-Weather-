using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.Weather.Interface;
using Service.Weather.Client;
using Service.Weather.Model;

namespace Service.Weather.Implementation
{
    public class ServiceWeather : IServiceWeather
    {
        private readonly ClientWeather _client;
        private const string API_KEY = "ab43bf482c7aee120a8e1fd07b10784c";
        public ServiceWeather(ClientWeather client) => _client = client;

        public async Task<ServiceResponse> GetWeatherDetailsByZipCodeAsync(string zipCode)
        {
            var query = new Dictionary<string, string>
            {
                ["access_key"] = API_KEY,
                ["query"] = zipCode,
            };
            
            var response = await _client.GetAsync<WeatherAPIResponse>(QueryHelpers.AddQueryString("/current", query));

            if (response.Current != null)
            {
                bool Weather_Desciprtion = !response.Current.Weather_Descriptions.Any(a => a.ToLower().Contains("rain"));

                return new ServiceResponse
                {
                    Go_OutSide = Weather_Desciprtion,
                    Wear_SunScreen = response.Current.UV_Index > 3,
                    Fly_Kite = response.Current.Wind_Speed > 15 && Weather_Desciprtion
                };
            }
            return null;
        }
    }
}
