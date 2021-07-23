
using System.Threading.Tasks;
using Service.Weather.Model;

namespace Service.Weather.Interface
{
    public interface  IServiceWeather
    {
        /// <summary>
        /// This Method for getting details by ZipCode
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        Task<ServiceResponse> GetWeatherDetailsByZipCodeAsync(string zipCode);
    }
}
