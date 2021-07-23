using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Service.Weather.Client
{
    public class ClientWeather
    {
        private readonly HttpClient _client;
        public ClientWeather(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<Response> GetAsync<Response>(string requestURL)
        {
            try
            {
                var resp = await _client.GetAsync(requestURL);
                var content = await resp.Content.ReadFromJsonAsync<Response>();
                return content;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
