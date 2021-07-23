
using System.Collections.Generic;

namespace Service.Weather.Model
{
    public class CurrentWeather
    {
        /// <summary>
        /// Getting the data of weather description
        /// </summary>
        public List<string> Weather_Descriptions { get; set; }
        /// <summary>
        /// Getting the data of wind speed
        /// </summary>
        public double Wind_Speed { get; set; }
        /// <summary>
        /// Getting the Ultraviolet index
        /// </summary>
        public double UV_Index { get; set; }

    }
}
